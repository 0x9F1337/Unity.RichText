using Unity.RichText.TextFlags.Interfaces;

namespace Unity.RichText.TextFlags.ParamTexts
{
    internal class FontWeightText : ITextItem
    {
        public string? Param { get; }

        public FontWeightText( object param )
        {
            this.Param = param.ToString();
        }

        public string CloseTag()
            => "</font-weight>";

        public string OpenTag()
            => $"<font-weight=\"{this.Param}\">";
    }
}
