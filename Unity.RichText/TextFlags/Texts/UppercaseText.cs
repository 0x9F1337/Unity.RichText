using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity.RichText.TextFlags.Interfaces;

namespace Unity.RichText.TextFlags.Texts
{
    [TextItemIdentifier( UnityRichTextFlag.Uppercase )]
    internal class UppercaseText : ITextItem
    {
        public string? Param => throw new NotImplementedException();

        public string CloseTag()
            => "</uppercase>";

        public string OpenTag()
            => "<uppercase>";
    }
}
