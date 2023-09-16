using Unity.RichText.TextFlags.Interfaces;
using Unity.RichText.TextFlags.Parameters.Validators;

namespace Unity.RichText.TextFlags.ParamTexts
{
    internal class IndentText : ITextItem
    {
        public string? Param { get; } = string.Empty;

        public IndentText( object param )
        {
            var value = param?.ToString();

            PercentValidator.Validate( value );

            this.Param = value;
        }

        public string CloseTag()
            => "</indent>";

        public string OpenTag()
            => $"<indent={this.Param}>";
    }
}
