using Unity.RichText.TextFlags.Interfaces;

namespace Unity.RichText.TextFlags.ParamTexts
{
    internal class IndentText : ITextItem
    {
        public string? Param { get; }

        public IndentText( object param )
        {
            this.Param = param.ToString();
        }

        public string CloseTag()
            => "</indent>";

        public string OpenTag()
            => $"<indent={this.Param}>";
    }
}
