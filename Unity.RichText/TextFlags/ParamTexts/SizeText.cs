using Unity.RichText.TextFlags.Interfaces;
using Unity.RichText.TextFlags.Parameters.Validators;

namespace Unity.RichText.TextFlags.ParamTexts
{
    internal class SizeText : ITextItem
    {
        public string? Param { get; } = string.Empty;

        public SizeText( object param )
        {
            var value = param?.ToString();

            PercentValidator.Validate( value );

            this.Param = value;
        }

        public string CloseTag()
            => "</size>";

        public string OpenTag()
            => $"<size={this.Param}>";
    }
}
