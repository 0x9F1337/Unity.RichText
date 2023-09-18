using Unity.RichText.TextFlags.Interfaces;

namespace Unity.RichText.TextFlags.Texts
{
    [TextItemIdentifier( UnityRichTextFlag.Nobr )]
    internal class NoBreakText : ITextItem
    {
        public string? Param => throw new NotImplementedException();

        public string CloseTag()
            => "</nobr>";

        public string OpenTag()
            => "<nobr>";
    }
}
