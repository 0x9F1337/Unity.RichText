using Unity.RichText.TextFlags.Interfaces;
using Unity.RichText.TextFlags.Parameters.Validators;

namespace Unity.RichText.TextFlags.ParamTexts
{
    [TextItemIdentifier( UnityRichTextFlag.Gradient )]
    internal class GradientText : ITextItem, IParam
    {
        public string? Param { get; private set; } = string.Empty;

        public string CloseTag()
            => "</gradient>";

        public string OpenTag()
            => $"<gradient=\"{this.Param}\">";

        public void SetParam( string? value )
        {
            StringValidator.Validate( value );

            this.Param = value;
        }
    }
}
