using Unity.RichText.TextFlags.Interfaces;

namespace Unity.RichText.TextFlags.Texts
{
    internal class StrikeThroughText : ITextItem
    {
        public string? Param => throw new NotImplementedException();

        public string CloseTag()
            => "</strikethrough>";

        public string OpenTag()
            => "<strikethrough>";
    }
}
