using Unity.RichText.TextFlags.Interfaces;

namespace Unity.RichText.TextFlags.ParamTexts
{
    internal class PosText : ITextItem
    {
        public string? Param { get; }

        public PosText( object param )
        {
            this.Param = param.ToString();
        }

        public string CloseTag()
            => "</pos>";

        public string OpenTag()
            => $"<pos={this.Param}>";
    }
}
