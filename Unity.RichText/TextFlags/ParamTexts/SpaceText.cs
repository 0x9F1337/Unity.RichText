using Unity.RichText.TextFlags.Interfaces;
using Unity.RichText.TextFlags.Parameters.Validators;

namespace Unity.RichText.TextFlags.ParamTexts
{
    internal class SpaceText : ITextItem
    {
        public string? Param { get; } = string.Empty;

        public SpaceText( object param )
        {
            var value = param?.ToString();

            EmValidator.Validate( value );

            this.Param = value;
        }

        public string CloseTag()
            => "</space>";

        public string OpenTag()
            => $"<space={this.Param}>";
    }
}
