using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity.RichText.TextFlags.Interfaces;

namespace Unity.RichText.TextFlags.ParamTexts
{
    internal class HRefText : ITextItem
    {
        public string? Param { get; }

        public HRefText( object param )
        {
            this.Param = param.ToString();
        }

        public string CloseTag()
            => "</a>";

        public string OpenTag()
            => $"<a href=\"{this.Param}\">";
    }
}
