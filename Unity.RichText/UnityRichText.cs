using System.Drawing;
using System.Dynamic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using Unity.RichText.TextFlags;
using Unity.RichText.TextFlags.Interfaces;
using Unity.RichText.TextFlags.ParamTexts;
using Unity.RichText.TextFlags.Texts;

namespace Unity.RichText
{
    public static class UnityRichText
    {
        private static readonly Dictionary<UnityRichTextFlag, object> CachedTextItems;
        private static readonly UnityRichTextFlag[] CachedFlags;

        static UnityRichText()
        {
            CachedFlags = Enum.GetValues<UnityRichTextFlag>();
            CachedTextItems = new();

            var types = Assembly.GetExecutingAssembly()
                    .GetTypes()
                    .Where( t => t.GetInterface( nameof( ITextItem ) ) != null )
                    .ToList();

            CachedTextItems.Add( UnityRichTextFlag.None, null );

            foreach ( var type in types )
            {
                var instance = Activator.CreateInstance( type );
                var flag = GetFlagFromType( type );

                CachedTextItems.Add( flag, instance );
            }
        }

        public static string ToUnityNestedRichText( this string value, UnityRichTextFlag modifiers, string? param = null )
        {
            return Nested( value, modifiers, param );
        }

        public static string Nested( string value, UnityRichTextFlag modifiers, string? param = null )
        {
            StringBuilder sb = new StringBuilder();

            try
            {
                AddTags( sb, modifiers, param, true );

                sb.Append( value );

                AddTags( sb, modifiers, param, false );
            }
            catch ( Exception ex )
            {
                Console.WriteLine( $"[{DateTime.Now}] Parameter \"{param?.ToString() ?? "[UNKNOWN]"}\" with modifiers \"{modifiers.ToString()}\" caused an error and will be ignored: " + ex.ToString() );
            }

            return sb.ToString();
        }

        public static string Nested( params (string value, UnityRichTextFlag flag)[] args )
        {
            (string v, UnityRichTextFlag f, string? p)[] array = new (string v, UnityRichTextFlag f, string? p)[ args.Length ];

            int i = 0;
            foreach ( var arg in args )
                array[ i++ ] = (arg.value, arg.flag, null);

            return Nested( array );
        }

        public static string Nested( params (string value, UnityRichTextFlag flag, string? param)[] args )
        {
            StringBuilder sb = new StringBuilder();

            foreach ( var arg in args )
                sb.Append( Nested( arg.value, arg.flag, arg.param ) );

            return sb.ToString();
        }

        private static void AddTags( StringBuilder sb, UnityRichTextFlag modifiers, string? param, bool open )
        {
            foreach ( var modifier in ( open ) ? CachedFlags : CachedFlags.Reverse() )
            {
                if ( modifier == UnityRichTextFlag.None )
                    continue;

                if ( modifiers.HasFlag( modifier ) )
                {
                    var text = InitializeText( modifier, param );

                    if ( text == null )
                        continue;

                    if ( open )
                        sb.Append( text.OpenTag() );
                    else
                        sb.Append( text.CloseTag() );
                }
            }
        }

        private static ITextItem? InitializeText( UnityRichTextFlag flag, string? param )
        {
            var instance = CachedTextItems[ flag ];

            if ( instance == null )
                return null;

            if ( instance is IParam instanceWithParam )
                instanceWithParam.SetParam( param );

            return ( ITextItem )instance;
        }

        private static UnityRichTextFlag GetFlagFromType( Type type )
            => type.GetCustomAttribute<TextItemIdentifier>().FlagType;
    }
}