using Unity.RichText.TextFlags.Interfaces;

namespace Unity.RichText.TextFlags.Texts
{
    internal class SubscriptText : ITextItem
    {
        public string? Param => throw new NotImplementedException();

        public string CloseTag()
            => "</sub>";

        public string OpenTag()
            => "<sub>";
    }
}
