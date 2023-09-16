using System.Drawing;
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
        private static readonly UnityRichTextFlag[] CachedFlags;

        static UnityRichText()
        {
            CachedFlags = Enum.GetValues<UnityRichTextFlag>();
        }

        public static string ToUnityRichText( this string value )
        {
            return value;
        }

        public static string Nested( string value, UnityRichTextFlag modifiers, object? param = null )
        {
            // TODO cache
            StringBuilder sb = new StringBuilder();

            AddTexts( sb, modifiers, param, true );

            sb.Append( value );

            AddTexts( sb, modifiers, param, false );

            return sb.ToString();
        }

        public static string Nested( params (string value, UnityRichTextFlag flag)[] args )
        {
            (string v, UnityRichTextFlag f, object? p)[] array = new (string v, UnityRichTextFlag f, object? p)[ args.Length ];

            int i = 0;
            foreach ( var arg in args )
                array[ i++ ] = (arg.value, arg.flag, null);

            return Nested( array );
        }

        public static string Nested( params (string value, UnityRichTextFlag flag, object? param)[] args )
        {
            StringBuilder sb = new StringBuilder();

            foreach ( var arg in args )
            {
                var modifier = arg.flag;

                AddTexts( sb, modifier, arg.param, true );

                sb.Append( arg.value );

                AddTexts( sb, modifier, arg.param, false );
            }

            return sb.ToString();
        }

        private static void AddTexts( StringBuilder sb, UnityRichTextFlag modifiers, object? param, bool open )
        {
            foreach ( var modifier in ( open ) ? CachedFlags : CachedFlags.Reverse() )
            {
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

        private static ITextItem InitializeText( UnityRichTextFlag flag, object? param )
        {
            switch ( flag )
            {
                case UnityRichTextFlag.Bold:
                    return new BoldText();

                case UnityRichTextFlag.Italic:
                    return new ItalicText();

                case UnityRichTextFlag.Href:
                    return new HRefText( param );

                default:
                    return null;
            }
        }
    }
}