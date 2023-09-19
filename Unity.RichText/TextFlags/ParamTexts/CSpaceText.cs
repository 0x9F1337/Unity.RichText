using Unity.RichText.TextFlags.Interfaces;
using Unity.RichText.TextFlags.Parameters.Validators;

namespace Unity.RichText.TextFlags.ParamTexts
{
    [TextItemIdentifier( UnityRichTextFlag.CSpace )]
    internal class CSpaceText : ITextItem, IParam
    {
        public string? Param { get; private set; } = string.Empty;

        public string CloseTag()
            => "</cspace>";

        public string OpenTag()
            => $"<cspace={this.Param}>";

        public void SetParam( string? value )
        {
            EmValidator.Validate( value );

            this.Param = value;
        }
    }
}
