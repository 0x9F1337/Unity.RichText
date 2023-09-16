using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity.RichText.TextFlags.Interfaces;
using Unity.RichText.TextFlags.Parameters.Validators;

namespace Unity.RichText.TextFlags.ParamTexts
{
    internal class AlignText : ITextItem
    {
        public string? Param { get; } = string.Empty;

        public AlignText( object param )
        {
            var value = param?.ToString();

            AlignValidator.Validate( value );

            this.Param = value;
        }

        public string CloseTag()
            => "</align>";

        public string OpenTag()
            => $"<align=\"{this.Param}\">";
    }
}
