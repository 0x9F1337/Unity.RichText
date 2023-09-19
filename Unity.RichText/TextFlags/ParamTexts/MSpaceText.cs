using Unity.RichText.TextFlags.Interfaces;
using Unity.RichText.TextFlags.Parameters.Validators;

namespace Unity.RichText.TextFlags.ParamTexts
{
    [TextItemIdentifier( UnityRichTextFlag.MSpace )]
    internal class MSpaceText : ITextItem, IParam
    {
        public string? Param { get; private set; } = string.Empty;

        public string CloseTag()
            => "</mspace>";

        public string OpenTag()
            => $"<mspace={this.Param}>";

        public void SetParam( string? value )
        {
            EmValidator.Validate( value );

            this.Param = value;
        }
    }
}
