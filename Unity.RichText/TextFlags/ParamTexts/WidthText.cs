using Unity.RichText.TextFlags.Interfaces;

namespace Unity.RichText.TextFlags.ParamTexts
{
    internal class WidthText : ITextItem
    {
        public string? Param { get; }

        public WidthText( object param )
        {
            this.Param = param.ToString();
        }

        public string CloseTag()
            => "</width>";

        public string OpenTag()
            => $"<width={this.Param}>";
    }
}
