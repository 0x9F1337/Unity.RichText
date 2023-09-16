using Unity.RichText.TextFlags.Interfaces;

namespace Unity.RichText.TextFlags.ParamTexts
{
    internal class MSpaceText : ITextItem
    {
        public string? Param { get; }

        public MSpaceText( object param )
        {
            this.Param = param.ToString();
        }

        public string CloseTag()
            => "</mspace>";

        public string OpenTag()
            => $"<mspace={this.Param}>";
    }
}
