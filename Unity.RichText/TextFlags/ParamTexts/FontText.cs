using Unity.RichText.TextFlags.Interfaces;
using Unity.RichText.TextFlags.Parameters.Validators;

namespace Unity.RichText.TextFlags.ParamTexts
{
    internal class FontText : ITextItem
    {
        public string? Param { get; } = string.Empty;

        public FontText( object param )
        {
            var value = param?.ToString();

            StringValidator.Validate( value );

            this.Param = value;
        }

        public string CloseTag()
            => "</font>";

        public string OpenTag()
            => $"<font=\"{this.Param}\">";
    }
}
