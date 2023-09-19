using Unity.RichText.TextFlags.Interfaces;
using Unity.RichText.TextFlags.Parameters.Validators;

namespace Unity.RichText.TextFlags.ParamTexts
{
    [TextItemIdentifier( UnityRichTextFlag.Size )]
    internal class SizeText : ITextItem, IParam
    {
        public string? Param { get; private set; } = string.Empty;

        public string CloseTag()
            => "</size>";

        public string OpenTag()
            => $"<size={this.Param}>";

        public void SetParam( string? value )
        {
            PercentValidator.Validate( value );

            this.Param = value;
        }
    }
}
