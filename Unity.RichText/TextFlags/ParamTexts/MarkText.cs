using Unity.RichText.TextFlags.Interfaces;

namespace Unity.RichText.TextFlags.ParamTexts
{
    internal class MarkText : ITextItem
    {
        public string? Param { get; }

        public MarkText( object param )
        {
            this.Param = param.ToString();
        }

        public string CloseTag()
            => "</mark>";

        public string OpenTag()
            => $"<mark={this.Param}>";
    }
}
