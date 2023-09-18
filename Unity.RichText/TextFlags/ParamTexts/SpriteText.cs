using Unity.RichText.TextFlags.Interfaces;
using Unity.RichText.TextFlags.Parameters.Validators;

namespace Unity.RichText.TextFlags.ParamTexts
{
    [TextItemIdentifier( UnityRichTextFlag.Sprite )]
    internal class SpriteText : ITextItem, IParam
    {
        public string? Param { get; private set; } = string.Empty;

        public string CloseTag()
            => "</sprite>"; // TODO check this? I Believe there is no closing tag.

        public string OpenTag()
            => $"<sprite name=\"{this.Param}\">";

        public void SetParam( object param )
        {
            var value = param?.ToString();

            StringValidator.Validate( value );

            this.Param = value;
        }
    }
}
