namespace Unity.RichText.TextFlags.Parameters.Validators
{
    internal static class ColorValidator
    {
        public static void Validate( string? value )
        {
            if ( value.StartsWith( "#" ) )
                value = value.Substring( 1 );

            if ( string.IsNullOrWhiteSpace( value ) )
                throw new ArgumentException( "value is null or empty." );

            (uint r, uint g, uint b, uint a, bool valid) argb = default;

            try
            {
                argb = Helper.GetRGBAFromHexString( value );
            }
            catch (Exception ex)
            {
                throw new ArgumentException( $"color value \"{value}\" caused an exception.", ex );
            }
            finally
            {
                if ( !argb.valid )
                    throw new ArgumentException( $"color value \"{value}\" is an invalid color. Colors must be represented in hex-format." );
            }
        }
    }
}
