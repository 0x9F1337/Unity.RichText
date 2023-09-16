using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unity.RichText.TextFlags.Parameters.Validators
{
    internal static class EmValidator
    {
        public static void Validate( string? value )
        {
            if ( string.IsNullOrWhiteSpace( value ))
                throw new ArgumentException( "value is null or empty." );

            if ( !value.EndsWith( "em" ) )
                throw new ArgumentException( $"value \"{value}\" doesn't end with 'em'" );

            value = value.Substring( 0, value.Length - 2 );

            decimal.Parse( value, NumberStyles.AllowDecimalPoint | NumberStyles.AllowLeadingSign, CultureInfo.InvariantCulture );
        }
    }
}
