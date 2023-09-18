using Unity.RichText.TextFlags.Interfaces;
using Unity.RichText.TextFlags.Parameters.Validators;

namespace Unity.RichText.TextFlags.ParamTexts
{
    [TextItemIdentifier( UnityRichTextFlag.Margin )]
    internal class MarginText : ITextItem, IParam    
    {
        public string? Param { get; private set; } = string.Empty;

        public string CloseTag()
            => "</margin>";

        public string OpenTag()
            => $"<margin={this.Param}>";

        public void SetParam( object param )
        {
            var value = param?.ToString();

            EmValidator.Validate( value );

            this.Param = value;
        }
    }
}
