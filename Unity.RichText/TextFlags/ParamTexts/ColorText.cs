using Unity.RichText.TextFlags.Interfaces;

namespace Unity.RichText.TextFlags.ParamTexts
{
    internal class ColorText : ITextItem
    {
        public string? Param { get; }

        public ColorText( object param )
        {
            this.Param = param.ToString();
        }

        public string CloseTag()
            => "</color>";

        public string OpenTag()
            => $"<color=#{this.Param}>";
    }
}
