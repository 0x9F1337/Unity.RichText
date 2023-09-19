using Unity.RichText.TextFlags.Interfaces;
using Unity.RichText.TextFlags.Parameters.Validators;

namespace Unity.RichText.TextFlags.ParamTexts
{
    [TextItemIdentifier( UnityRichTextFlag.Mark )]
    internal class MarkText : ITextItem, IParam
    {
        public string? Param { get; private set; } = string.Empty;

        public string CloseTag()
            => "</mark>";

        public string OpenTag()
            => $"<mark={this.Param}>";

        public void SetParam( string? value )
        {
            ColorValidator.Validate( value );

            if ( !value?.StartsWith( "#" ) ?? false )
                value = "#" + value;

            this.Param = value;
        }
    }
}
