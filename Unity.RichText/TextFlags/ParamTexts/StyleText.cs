using Unity.RichText.TextFlags.Interfaces;
using Unity.RichText.TextFlags.Parameters.Validators;

namespace Unity.RichText.TextFlags.ParamTexts
{
    [TextItemIdentifier( UnityRichTextFlag.Style )]
    internal class StyleText : ITextItem, IParam
    {
        public string? Param { get; private set; } = string.Empty;

        public string CloseTag()
            => "</style>";

        public string OpenTag()
            => $"<style=\"{this.Param}\">";

        public void SetParam( object param )
        {
            var value = param?.ToString();

            StringValidator.Validate( value );

            this.Param = value;
        }
    }
}
