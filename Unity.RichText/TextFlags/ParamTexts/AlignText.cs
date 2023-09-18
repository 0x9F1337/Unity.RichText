using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity.RichText.TextFlags.Interfaces;
using Unity.RichText.TextFlags.Parameters.Validators;

namespace Unity.RichText.TextFlags.ParamTexts
{
    [TextItemIdentifier(UnityRichTextFlag.Align)]
    internal class AlignText : ITextItem, IParam
    {
        public string? Param { get; private set; } = string.Empty;

        public string CloseTag()
            => "</align>";

        public string OpenTag()
            => $"<align=\"{this.Param}\">";

        public void SetParam( object param )
        {
            var value = param?.ToString();

            AlignValidator.Validate( value );

            this.Param = value;
        }
    }
}
