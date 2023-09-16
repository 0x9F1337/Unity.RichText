using Unity.RichText.TextFlags.Interfaces;

namespace Unity.RichText.TextFlags.ParamTexts
{
    internal class SpriteText : ITextItem
    {
        public string? Param { get; }

        public SpriteText( object param )
        {
            this.Param = param.ToString();
        }

        public string CloseTag()
            => "</sprite>"; // TODO check this? I Believe there is no closing tag.

        public string OpenTag()
            => $"<sprite name=\"{this.Param}\">";
    }
}
