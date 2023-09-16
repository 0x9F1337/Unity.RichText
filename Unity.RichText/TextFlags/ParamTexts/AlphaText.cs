using Unity.RichText.TextFlags.Interfaces;
using Unity.RichText.TextFlags.Parameters.Validators;

namespace Unity.RichText.TextFlags.ParamTexts
{
    internal class AlphaText : ITextItem
    {
        public string? Param { get; } = string.Empty;

        public AlphaText( object param )
        {
            var value = param?.ToString();

            ByteValidator.Validate( value );

            this.Param = value;
        }

        public string CloseTag()
            => "</alpha>";

        public string OpenTag()
            => $"<alpha={this.Param}>";
    }
}
