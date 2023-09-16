using Unity.RichText.TextFlags.Interfaces;
using Unity.RichText.TextFlags.Parameters.Validators;

namespace Unity.RichText.TextFlags.ParamTexts
{
    internal class MSpaceText : ITextItem
    {
        public string? Param { get; } = string.Empty;

        public MSpaceText( object param )
        {
            var value = param?.ToString();

            EmValidator.Validate( value );

            this.Param = value;
        }

        public string CloseTag()
            => "</mspace>";

        public string OpenTag()
            => $"<mspace={this.Param}>";
    }
}
