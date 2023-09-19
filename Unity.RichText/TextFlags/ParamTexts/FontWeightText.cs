using Unity.RichText.TextFlags.Interfaces;
using Unity.RichText.TextFlags.Parameters.Validators;

namespace Unity.RichText.TextFlags.ParamTexts
{
    [TextItemIdentifier( UnityRichTextFlag.FontWeight )]
    internal class FontWeightText : ITextItem, IParam
    {
        public string? Param { get; private set; } = string.Empty;

        public string CloseTag()
            => "</font-weight>";

        public string OpenTag()
            => $"<font-weight=\"{this.Param}\">";

        public void SetParam( string? value )
        {
            IntegerValidator.Validate( value );

            this.Param = value;
        }
    }
}
