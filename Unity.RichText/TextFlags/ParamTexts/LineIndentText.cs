using Unity.RichText.TextFlags.Interfaces;
using Unity.RichText.TextFlags.Parameters.Validators;

namespace Unity.RichText.TextFlags.ParamTexts
{
    [TextItemIdentifier( UnityRichTextFlag.LineIndent )]
    internal class LineIndentText : ITextItem, IParam
    {
        public string? Param { get; private set; } = string.Empty;

        public string CloseTag()
            => "</line-indent>";

        public string OpenTag()
            => $"<line-indent={this.Param}>";

        public void SetParam( string? value )
        {
            PercentValidator.Validate( value );

            this.Param = value;
        }
    }
}
