using Unity.RichText.TextFlags.Interfaces;
using Unity.RichText.TextFlags.Parameters.Validators;

namespace Unity.RichText.TextFlags.ParamTexts
{
    internal class RotateText : ITextItem
    {
        public string? Param { get; } = string.Empty;

        public RotateText( object param )
        {
            var value = param?.ToString();

            IntegerValidator.Validate( value );

            this.Param = value;
        }

        public string CloseTag()
            => "</rotate>";

        public string OpenTag()
            => $"<rotate=\"{this.Param}\">";
    }
}
