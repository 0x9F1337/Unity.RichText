using Unity.RichText.TextFlags.Interfaces;
using Unity.RichText.TextFlags.Parameters.Validators;

namespace Unity.RichText.TextFlags.ParamTexts
{
    [TextItemIdentifier( UnityRichTextFlag.Space )]
    internal class SpaceText : ITextItem, IParam
    {
        public string? Param { get; private set; } = string.Empty;

        public string CloseTag()
            => "</space>";

        public string OpenTag()
            => $"<space={this.Param}>";

        public void SetParam( string? value )
        {
            EmValidator.Validate( value );

            this.Param = value;
        }
    }
}
