using Unity.RichText.TextFlags.Interfaces;
using Unity.RichText.TextFlags.Parameters.Validators;

namespace Unity.RichText.TextFlags.ParamTexts
{
    internal class WidthText : ITextItem
    {
        public string? Param { get; } = string.Empty;

        public WidthText( object param )
        {
            var value = param?.ToString();

            PercentValidator.Validate( value );

            this.Param = value;
        }

        public string CloseTag()
            => "</width>";

        public string OpenTag()
            => $"<width={this.Param}>";
    }
}
