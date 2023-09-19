using Unity.RichText.TextFlags.Interfaces;
using Unity.RichText.TextFlags.Parameters.Validators;

namespace Unity.RichText.TextFlags.ParamTexts
{
    [TextItemIdentifier( UnityRichTextFlag.Color )]
    internal class ColorText : ITextItem, IParam
    {
        public string? Param { get; private set; } = string.Empty;

        public string CloseTag()
            => "</color>";

        public string OpenTag()
            => $"<color={this.Param}>";

        public void SetParam( object param )
        {
            var value = param?.ToString();

            ColorValidator.Validate( value );

            if ( !value?.StartsWith( "#" ) ?? false )
                value = "#" + value;

            this.Param = value;
        }
    }
}
