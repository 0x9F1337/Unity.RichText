using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unity.RichText.TextFlags.Parameters.Validators
{
    internal static class ByteValidator
    {
        public static void Validate( string? value )
        {
            if ( value.StartsWith( "#" ) )
                value = value.Substring( 1 );

            if ( string.IsNullOrWhiteSpace( value ) )
                throw new ArgumentException( "value is null or empty." );

            byte.Parse( value );
        }
    }
}
