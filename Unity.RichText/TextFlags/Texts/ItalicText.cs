using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity.RichText.TextFlags.Interfaces;

namespace Unity.RichText.TextFlags.Texts
{
    [TextItemIdentifier( UnityRichTextFlag.Italic )]
    internal class ItalicText : ITextItem
    {
        public string? Param => throw new NotImplementedException(); 

        public string CloseTag()
            => "</i>";

        public string OpenTag()
            => "<i>";
    }
}
