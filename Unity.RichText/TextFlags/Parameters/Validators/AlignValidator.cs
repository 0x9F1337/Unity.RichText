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

            if (!value.Equals( AlignParameter.Left, StringComparison.OrdinalIgnoreCase) &&
                !value.Equals( AlignParameter.Right, StringComparison.OrdinalIgnoreCase) &&
                !value.Equals( AlignParameter.Center, StringComparison.OrdinalIgnoreCase ) &&
                !value.Equals( AlignParameter.Justified, StringComparison.OrdinalIgnoreCase ) &&
                !value.Equals( AlignParameter.Flush, StringComparison.OrdinalIgnoreCase ) )
                throw new ArgumentException( $"value \"{value}\" has an unknown value. Please choose one in AlignParameter." );
        }
    }
}
