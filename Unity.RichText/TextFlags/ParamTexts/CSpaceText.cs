using Unity.RichText.TextFlags.Interfaces;

namespace Unity.RichText.TextFlags.ParamTexts
{
    internal class CSpaceText : ITextItem
    {
        public string? Param { get; }

        public CSpaceText( object param )
        {
            this.Param = param.ToString();
        }

        public string CloseTag()
            => "</cspace>";

        public string OpenTag()
            => $"<cspace={this.Param}>";
    }
}
