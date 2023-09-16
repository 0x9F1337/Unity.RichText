using Unity.RichText.TextFlags.Interfaces;

namespace Unity.RichText.TextFlags.ParamTexts
{
    internal class FontText : ITextItem
    {
        public string? Param { get; }

        public FontText( object param )
        {
            this.Param = param.ToString();
        }

        public string CloseTag()
            => "</font>";

        public string OpenTag()
            => $"<font=\"{this.Param}\">";
    }
}
