using Unity.RichText.TextFlags.Interfaces;

namespace Unity.RichText.TextFlags.ParamTexts
{
    internal class RotateText : ITextItem
    {
        public string? Param { get; }

        public RotateText( object param )
        {
            this.Param = param.ToString();
        }

        public string CloseTag()
            => "</rotate>";

        public string OpenTag()
            => $"<rotate=\"{this.Param}\">";
    }
}
