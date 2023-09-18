using Unity.RichText.TextFlags.Interfaces;
using Unity.RichText.TextFlags.Parameters.Validators;

namespace Unity.RichText.TextFlags.ParamTexts
{
    [TextItemIdentifier( UnityRichTextFlag.Rotate )]
    internal class RotateText : ITextItem, IParam
    {
        public string? Param { get; private set; } = string.Empty;

        public string CloseTag()
            => "</rotate>";

        public string OpenTag()
            => $"<rotate=\"{this.Param}\">";

        public void SetParam( object param )
        {
            var value = param?.ToString();

            IntegerValidator.Validate( value );

            this.Param = value;
        }
    }
}
