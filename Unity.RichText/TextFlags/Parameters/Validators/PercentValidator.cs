using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unity.RichText.TextFlags.Parameters.Validators
{
    internal static class PercentValidator
    {
        public static void Validate( string? value )
        {
            if ( string.IsNullOrWhiteSpace( value ))
                throw new ArgumentException( "value is null or empty." );

            if ( !value.EndsWith( "%" ) )
                throw new ArgumentException( $"value \"{value}\" doesn't end with '%'" );

            value = value.Substring(0, value.Length - 1);

            var percentage = int.Parse( value );

            if ( percentage < 0 || percentage > 100 )
                throw new ArgumentException( $"value \"{value}\" is not a valid percentage. Do me a favor and stay between 0 and 100." ); 
        }
    }
}
