using Unity.RichText.TextFlags.Interfaces;

namespace Unity.RichText.TextFlags.ParamTexts
{
    internal class StyleText : ITextItem
    {
        public string? Param { get; }

        public StyleText( object param )
        {
            this.Param = param.ToString();
        }

        public string CloseTag()
            => "</style>"; 

        public string OpenTag()
            => $"<style=\"{this.Param}\">";
    }
}
