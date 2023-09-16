using Unity.RichText.TextFlags.Interfaces;
using Unity.RichText.TextFlags.Parameters.Validators;

namespace Unity.RichText.TextFlags.ParamTexts
{
    internal class SpriteText : ITextItem
    {
        public string? Param { get; } = string.Empty;

        public SpriteText( object param )
        {
            var value = param?.ToString();

            StringValidator.Validate( value );

            this.Param = value;
        }

        public string CloseTag()
            => "</sprite>"; // TODO check this? I Believe there is no closing tag.

        public string OpenTag()
            => $"<sprite name=\"{this.Param}\">";
    }
}
