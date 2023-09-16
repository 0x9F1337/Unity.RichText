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
                    try
                    {
                        var text = InitializeText( modifier, param );

                        if ( text == null )
                            continue;

                        if ( open )
                            sb.Append( text.OpenTag() );
                        else
                            sb.Append( text.CloseTag() );
                    }
                    catch ( Exception ex )
                    {
                        Console.WriteLine( $"[{DateTime.Now}] Parameter \"{param?.ToString() ?? "[UNKNOWN]"}\" with modifiers \"{modifiers.ToString()}\" caused an error and will be ignored: ", ex.Message );
                    }
                }
            }
        }

        private static ITextItem InitializeText( UnityRichTextFlag flag, object? param )
        {
            return flag switch
            {
                UnityRichTextFlag.Bold => new BoldText(),
                UnityRichTextFlag.Italic => new ItalicText(),
                UnityRichTextFlag.Href => new HRefText( param ),
                UnityRichTextFlag.Align => new AlignText( param ),
                UnityRichTextFlag.AllCaps => new AllCapsText(),
                UnityRichTextFlag.Alpha => new AlphaText( param ),
                UnityRichTextFlag.CSpace => new CSpaceText( param ),
                UnityRichTextFlag.Font => new FontText( param ),
                UnityRichTextFlag.FontWeight => new FontWeightText( param ),
                UnityRichTextFlag.Gradient => new GradientText( param ),
                UnityRichTextFlag.Indent => new IndentText( param ),
                UnityRichTextFlag.LineHeight => new LineHeightText( param ),
                UnityRichTextFlag.LineIndent => new LineIndentText( param ),
                UnityRichTextFlag.Lowercase => new LowerCaseText(),
                UnityRichTextFlag.Margin => new MarginText( param ),
                UnityRichTextFlag.Mark => new MarkText( param ),
                UnityRichTextFlag.MSpace => new MSpaceText( param ),
                UnityRichTextFlag.Nobr => new NoBreakText(),
                UnityRichTextFlag.NoParse => new NoParseText(),
                UnityRichTextFlag.Pos => new PosText( param ),
                UnityRichTextFlag.Rotate => new RotateText( param ),
                UnityRichTextFlag.Crossed => new CrossedText(),
                UnityRichTextFlag.Size => new SizeText( param ),
                UnityRichTextFlag.SmallCaps => new SmallCapsText(),
                UnityRichTextFlag.Space => new SpaceText( param ),
                UnityRichTextFlag.Sprite => new SpriteText( param ),
                UnityRichTextFlag.Strikethrough => new StrikeThroughText(),
                UnityRichTextFlag.Style => new StyleText( param ),
                UnityRichTextFlag.Subscript => new SubscriptText(),
                UnityRichTextFlag.Superscript => new SuperscriptText(),
                UnityRichTextFlag.Underline => new UnderlineText(),
                UnityRichTextFlag.VOffset => new VOffsetText( param ),
                UnityRichTextFlag.Width => new WidthText( param ),
                _ => null,
            };
        }
    }
}