using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unity.RichText.TextFlags.Interfaces
{
    internal interface IParam
    {
        public string Param { get; }
        void SetParam(object param);
    }
}
