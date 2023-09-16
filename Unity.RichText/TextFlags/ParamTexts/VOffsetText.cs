using Unity.RichText.TextFlags.Interfaces;
using Unity.RichText.TextFlags.Parameters.Validators;

namespace Unity.RichText.TextFlags.ParamTexts
{
    internal class VOffsetText : ITextItem
    {
        public string? Param { get; } = string.Empty;

        public VOffsetText( object param )
        {
            var value = param?.ToString();

            EmValidator.Validate( value );

            this.Param = value;
        }

        public string CloseTag()
            => "</voffset>";

        public string OpenTag()
            => $"<voffset={this.Param}>";
    }
}
