using Unity.RichText.TextFlags.Interfaces;
using Unity.RichText.TextFlags.Parameters.Validators;

namespace Unity.RichText.TextFlags.ParamTexts
{
    internal class GradientText : ITextItem
    {
        public string? Param { get; } = string.Empty;

        public GradientText( object param )
        {
            var value = param?.ToString();

            StringValidator.Validate( value );

            this.Param = value;
        }

        public string CloseTag()
            => "</gradient>";

        public string OpenTag()
            => $"<gradient=\"{this.Param}\">";
    }
}
