using Unity.RichText.TextFlags.Interfaces;

namespace Unity.RichText.TextFlags.ParamTexts
{
    internal class SizeText : ITextItem
    {
        public string? Param { get; }

        public SizeText( object param )
        {
            this.Param = param.ToString();
        }

        public string CloseTag()
            => "</size>";

        public string OpenTag()
            => $"<size={this.Param}>";
    }
}
