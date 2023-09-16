using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity.RichText.TextFlags.Interfaces;

namespace Unity.RichText.TextFlags.ParamTexts
{
    internal class AlignText : ITextItem
    {
        public string? Param { get; }

        public AlignText( object param )
        {
            this.Param = param.ToString();
        }

        public string CloseTag()
            => "</align>";

        public string OpenTag()
            => $"<align=\"{this.Param}\">";
    }
}
