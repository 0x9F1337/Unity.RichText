using Unity.RichText.TextFlags.Interfaces;

namespace Unity.RichText.TextFlags.Texts
{
    internal class NoParseText : ITextItem
    {
        public string? Param => throw new NotImplementedException();

        public string CloseTag()
            => "</noparse>";

        public string OpenTag()
            => "<noparse>";
    }
}
