using Unity.RichText.TextFlags.Interfaces;

namespace Unity.RichText.TextFlags.ParamTexts
{
    internal class SpaceText : ITextItem
    {
        public string? Param { get; }

        public SpaceText( object param )
        {
            this.Param = param.ToString();
        }

        public string CloseTag()
            => "</space>";

        public string OpenTag()
            => $"<space={this.Param}>";
    }
}
