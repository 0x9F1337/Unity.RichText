using Unity.RichText.TextFlags.Interfaces;
using Unity.RichText.TextFlags.Parameters.Validators;

namespace Unity.RichText.TextFlags.ParamTexts
{
    internal class MarginText : ITextItem
    {
        public string? Param { get; } = string.Empty;

        public MarginText( object param )
        {
            var value = param?.ToString();

            EmValidator.Validate( value );

            this.Param = value;
        }

        public string CloseTag()
            => "</margin>";

        public string OpenTag()
            => $"<margin={this.Param}>";
    }
}
