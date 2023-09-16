using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity.RichText.TextFlags.Interfaces;

namespace Unity.RichText.TextFlags.Texts
{
    internal class BoldText : ITextItem
    {
        public string? Param => throw new NotImplementedException();    

        public string CloseTag()
            => "</b>";

        public string OpenTag()
            => "<b>";
    }
}
