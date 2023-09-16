using Unity.RichText.TextFlags.Interfaces;
using Unity.RichText.TextFlags.Parameters.Validators;

namespace Unity.RichText.TextFlags.ParamTexts
{
    internal class FontWeightText : ITextItem
    {
        public string? Param { get; } = string.Empty;

        public FontWeightText( object param )
        {
            var value = param?.ToString();

            IntegerValidator.Validate( value );

            this.Param = value;
        }

        public string CloseTag()
            => "</font-weight>";

        public string OpenTag()
            => $"<font-weight=\"{this.Param}\">";
    }
}
