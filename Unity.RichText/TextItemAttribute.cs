using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unity.RichText
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
    internal class TextItemIdentifier : Attribute
    {
        public UnityRichTextFlag FlagType { get; set; }

        public TextItemIdentifier( UnityRichTextFlag flagType )
        {
            this.FlagType = flagType;
        }
    }
}
