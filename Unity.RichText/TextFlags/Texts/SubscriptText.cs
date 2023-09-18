using Unity.RichText.TextFlags.Interfaces;

namespace Unity.RichText.TextFlags.Texts
{
    [TextItemIdentifier( UnityRichTextFlag.Subscript )]
    internal class SubscriptText : ITextItem
    {
        public string? Param => throw new NotImplementedException();

        public string CloseTag()
            => "</sub>";

        public string OpenTag()
            => "<sub>";
    }
}
