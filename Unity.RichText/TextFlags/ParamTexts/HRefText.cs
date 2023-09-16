using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity.RichText.TextFlags.Interfaces;
using Unity.RichText.TextFlags.Parameters.Validators;

namespace Unity.RichText.TextFlags.ParamTexts
{
    internal class HRefText : ITextItem
    {
        public string? Param { get; } = string.Empty;

        public HRefText( object param )
        {
            var value = param?.ToString();

            StringValidator.Validate(value);

			this.Param = value;

            
        }

        public string CloseTag()
            => "</a>";

        public string OpenTag()
            => $"<a href=\"{this.Param}\">";
    }
}
