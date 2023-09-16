using Unity.RichText.TextFlags.Interfaces;

namespace Unity.RichText.TextFlags.ParamTexts
{
    internal class AlphaText : ITextItem
    {
        public string? Param { get; }

        public AlphaText( object param )
        {
            this.Param = param.ToString();
        }

        public string CloseTag()
            => "</alpha>";

        public string OpenTag()
            => $"<alpha={this.Param}>";
    }
}
