using Unity.RichText.TextFlags.Interfaces;

namespace Unity.RichText.TextFlags.Texts
{
    [TextItemIdentifier( UnityRichTextFlag.SmallCaps )]
    internal class SmallCapsText : ITextItem
    {
        public string? Param => throw new NotImplementedException();

        public string CloseTag()
            => "</smallcaps>";

        public string OpenTag()
            => "<smallcaps>";
    }
}
