using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Unity.RichText
{
    internal static class Helper
    {
        public static (uint R, uint G, uint B, uint A, bool Valid) GetRGBAFromHexString( string hex )
        {
            if ( string.IsNullOrWhiteSpace( hex ) )
                return (0, 0, 0, 255, false);

            if ( !uint.TryParse( hex, out uint hexCode ) )
                return (0, 0, 0, 255, false);

            if ( hex.Length == 8 )
            {
                var rgba = GetRGBAFromHex( hexCode );

                return (rgba.R, rgba.G, rgba.B, rgba.A, true);
            }
            else if ( hex.Length == 6 )
            {
                var rgb = GetRGBFromHex( hexCode );

                return (rgb.R, rgb.G, rgb.B, 255, true);
            }
            else
            {
                return (0, 0, 0, 255, false);
            }
        }

        public static (uint R, uint G, uint B, uint A) GetRGBAFromHex( uint hexCode )
        {
            uint r = ( hexCode >> 24 ) & 0xFF;
            uint g = ( hexCode >> 16 ) & 0xFF;
            uint b = ( hexCode >> 8 ) & 0xFF;
            uint a = ( hexCode ) & 0xFF;

            return (r, g, b, a);
        }

        public static (uint R, uint G, uint B) GetRGBFromHex( uint hexCode )
        {
            uint r = ( hexCode >> 16 ) & 0xFF;
            uint g = ( hexCode >> 8 ) & 0xFF;
            uint b = ( hexCode ) & 0xFF;

            return (r, g, b);
        }
    }
}

