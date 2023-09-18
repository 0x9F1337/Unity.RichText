using Unity.RichText.TextFlags.Interfaces;

namespace Unity.RichText.TextFlags.Texts
{
    [TextItemIdentifier(UnityRichTextFlag.AllCaps)]
    internal class AllCapsText : ITextItem
    {
        public string? Param => throw new NotImplementedException();

        public string CloseTag()
            => "</allcaps>";

        public string OpenTag()
            => "<allcaps>";
    }
}
