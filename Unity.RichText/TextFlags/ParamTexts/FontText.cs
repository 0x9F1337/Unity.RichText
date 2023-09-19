using Unity.RichText.TextFlags.Interfaces;
using Unity.RichText.TextFlags.Parameters.Validators;

namespace Unity.RichText.TextFlags.ParamTexts
{
    [TextItemIdentifier( UnityRichTextFlag.Font )]
    internal class FontText : ITextItem, IParam
    {
        public string? Param { get; private set; } = string.Empty;

        public string CloseTag()
            => "</font>";

        public string OpenTag()
            => $"<font=\"{this.Param}\">";

        public void SetParam( string? value )
        {
            StringValidator.Validate( value );

            this.Param = value;
        }
    }
}
