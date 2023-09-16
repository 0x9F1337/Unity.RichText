using Unity.RichText.TextFlags.Interfaces;
using Unity.RichText.TextFlags.Parameters.Validators;

namespace Unity.RichText.TextFlags.ParamTexts
{
    internal class PosText : ITextItem
    {
        public string? Param { get; } = string.Empty;

        public PosText( object param )
        {
            var value = param?.ToString();

            PercentValidator.Validate( value );

            this.Param = value;
        }

        public string CloseTag()
            => "</pos>";

        public string OpenTag()
            => $"<pos={this.Param}>";
    }
}
