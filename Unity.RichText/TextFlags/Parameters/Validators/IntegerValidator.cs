using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unity.RichText.TextFlags.Parameters.Validators
{
    internal static class IntegerValidator
    {
        public static void Validate( string? value )
        {
            if ( string.IsNullOrWhiteSpace( value ) )
                throw new ArgumentException( "value is null or empty." );

            int.Parse( value );
        }
    }
}
