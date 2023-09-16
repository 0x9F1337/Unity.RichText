using Unity.RichText.TextFlags.Interfaces;
using Unity.RichText.TextFlags.Parameters.Validators;

namespace Unity.RichText.TextFlags.ParamTexts
{
    internal class CSpaceText : ITextItem
    {
        public string? Param { get; } = string.Empty;

        public CSpaceText( object param )
        {
            var value = param?.ToString();

            EmValidator.Validate( value );

            this.Param = value;
        }

        public string CloseTag()
            => "</cspace>";

        public string OpenTag()
            => $"<cspace={this.Param}>";
    }
}
