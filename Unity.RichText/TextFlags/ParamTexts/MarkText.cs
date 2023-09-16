using Unity.RichText.TextFlags.Interfaces;
using Unity.RichText.TextFlags.Parameters.Validators;

namespace Unity.RichText.TextFlags.ParamTexts
{
    internal class MarkText : ITextItem
    {
        public string? Param { get; } = string.Empty;

        public MarkText( object param )
        {
            var value = param?.ToString();

            ColorValidator.Validate( value );

            this.Param = value;
        }

        public string CloseTag()
            => "</mark>";

        public string OpenTag()
            => $"<mark={this.Param}>";
    }
}
