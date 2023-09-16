using Unity.RichText.TextFlags.Interfaces;

namespace Unity.RichText.TextFlags.ParamTexts
{
    internal class GradientText : ITextItem
    {
        public string? Param { get; }

        public GradientText( object param )
        {
            this.Param = param.ToString();
        }

        public string CloseTag()
            => "</gradient>";

        public string OpenTag()
            => $"<gradient=\"{this.Param}\">";
    }
}
