using Unity.RichText.TextFlags.Interfaces;

namespace Unity.RichText.TextFlags.ParamTexts
{
    internal class VOffsetText : ITextItem
    {
        public string? Param { get; }

        public VOffsetText( object param )
        {
            this.Param = param.ToString();
        }

        public string CloseTag()
            => "</voffset>";

        public string OpenTag()
            => $"<voffset={this.Param}>";
    }
}
