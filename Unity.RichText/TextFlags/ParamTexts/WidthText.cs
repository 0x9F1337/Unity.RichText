using Unity.RichText.TextFlags.Interfaces;
using Unity.RichText.TextFlags.Parameters.Validators;

namespace Unity.RichText.TextFlags.ParamTexts
{
    [TextItemIdentifier( UnityRichTextFlag.Width )]
    internal class WidthText : ITextItem, IParam
    {
        public string? Param { get; private set; } = string.Empty;

        public string CloseTag()
            => "</width>";

        public string OpenTag()
            => $"<width={this.Param}>";

        public void SetParam( string? value )
        {
            PercentValidator.Validate( value );

            this.Param = value;
        }
    }
}
