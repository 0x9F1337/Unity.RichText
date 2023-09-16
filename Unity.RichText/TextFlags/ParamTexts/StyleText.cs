using Unity.RichText.TextFlags.Interfaces;
using Unity.RichText.TextFlags.Parameters.Validators;

namespace Unity.RichText.TextFlags.ParamTexts
{
    internal class StyleText : ITextItem
    {
        public string? Param { get; } = string.Empty;

        public StyleText( object param )
        {
            var value = param?.ToString();

            StringValidator.Validate( value );

            this.Param = value;
        }

        public string CloseTag()
            => "</style>";

        public string OpenTag()
            => $"<style=\"{this.Param}\">";
    }
}
