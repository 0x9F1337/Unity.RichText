using Unity.RichText.TextFlags.Interfaces;

namespace Unity.RichText.TextFlags.Texts
{
    [TextItemIdentifier( UnityRichTextFlag.Break )]
    internal class BreakText : ITextItem
    {
        public string? Param => throw new NotImplementedException();

        public string CloseTag()
            => string.Empty;

        public string OpenTag()
            => "<br>";
    }
}
