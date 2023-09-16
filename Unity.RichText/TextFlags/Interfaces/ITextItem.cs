using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unity.RichText.TextFlags.Interfaces
{
    internal interface ITextItem
    {
        public string? Param { get; }
        public string OpenTag();
        public string CloseTag();
    }
}
