using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity.RichText.TextFlags.Interfaces;
using Unity.RichText.TextFlags.Parameters.Validators;

namespace Unity.RichText.TextFlags.ParamTexts
{
    [TextItemIdentifier( UnityRichTextFlag.Href )]
    internal class HRefText : ITextItem, IParam
    {
        public string? Param { get; private set; } = string.Empty;

        public string CloseTag()
            => "</a>";

        public string OpenTag()
            => $"<a href=\"{this.Param}\">";

        public void SetParam( string? value )
        {
            StringValidator.Validate( value );

            this.Param = value;
        }
    }
}
