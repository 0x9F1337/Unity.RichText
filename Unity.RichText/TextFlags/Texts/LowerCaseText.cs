using Unity.RichText.TextFlags.Interfaces;

namespace Unity.RichText.TextFlags.Texts
{
    [TextItemIdentifier( UnityRichTextFlag.Lowercase )]
    internal class LowerCaseText : ITextItem
    {
        public string? Param => throw new NotImplementedException();

        public string CloseTag()
            => "</lowercase>";

        public string OpenTag()
            => "<lowercase>";
    }
}
