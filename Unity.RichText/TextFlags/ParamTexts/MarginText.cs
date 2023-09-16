using Unity.RichText.TextFlags.Interfaces;

namespace Unity.RichText.TextFlags.ParamTexts
{
    internal class MarginText : ITextItem
    {
        public string? Param { get; }

        public MarginText( object param )
        {
            this.Param = param.ToString();
        }

        public string CloseTag()
            => "</margin>";

        public string OpenTag()
            => $"<margin={this.Param}>";
    }
}
