using Unity.RichText.TextFlags.Interfaces;

namespace Unity.RichText.TextFlags.ParamTexts
{
    internal class LineHeightText : ITextItem
    {
        public string? Param { get; }

        public LineHeightText( object param )
        {
            this.Param = param.ToString();
        }

        public string CloseTag()
            => "</line-height>";

        public string OpenTag()
            => $"<line-height={this.Param}>";
    }
}
