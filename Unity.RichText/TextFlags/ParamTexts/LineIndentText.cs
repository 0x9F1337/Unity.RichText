using Unity.RichText.TextFlags.Interfaces;
using Unity.RichText.TextFlags.Parameters.Validators;

namespace Unity.RichText.TextFlags.ParamTexts
{
    internal class LineIndentText : ITextItem
    {
        public string? Param { get; } = string.Empty;

        public LineIndentText( object param )
        {
            var value = param?.ToString();

            PercentValidator.Validate( value );

            this.Param = value;
        }

        public string CloseTag()
            => "</LineIndent>";

        public string OpenTag()
            => $"<LineIndent={this.Param}>";
    }
}
