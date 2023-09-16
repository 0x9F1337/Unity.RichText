using Unity.RichText.TextFlags.Interfaces;
using Unity.RichText.TextFlags.Parameters.Validators;

namespace Unity.RichText.TextFlags.ParamTexts
{
    internal class LineHeightText : ITextItem
    {
        public string? Param { get; } = string.Empty;

        public LineHeightText( object param )
        {
            var value = param?.ToString();

            PercentValidator.Validate( value );

            this.Param = value;
        }

        public string CloseTag()
            => "</line-height>";

        public string OpenTag()
            => $"<line-height={this.Param}>";
    }
}
