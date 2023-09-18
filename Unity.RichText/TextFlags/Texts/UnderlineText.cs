using Unity.RichText.TextFlags.Interfaces;

namespace Unity.RichText.TextFlags.Texts
{
    [TextItemIdentifier( UnityRichTextFlag.Underline )]
    internal class UnderlineText : ITextItem
    {
        public string? Param => throw new NotImplementedException();

        public string CloseTag()
            => "</underline>";

        public string OpenTag()
            => "<underline>";
    }
}
