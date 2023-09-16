using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unity.RichText.TextFlags.Parameters.Validators
{
    internal static class AlignValidator
    {
        public static void Validate( string? value )
        {
            if (string.IsNullOrWhiteSpace(value)) 
                throw new ArgumentException("value is null or empty.");

            if ( value == AlignParameter.Left ||
                value == AlignParameter.Right ||
                value == AlignParameter.Center ||
                value == AlignParameter.Justified ||
                value == AlignParameter.Flush )
                throw new ArgumentException( $"value \"{value}\" has an unknown value. Please choose one in AlignParameter." );
        }
    }
}
