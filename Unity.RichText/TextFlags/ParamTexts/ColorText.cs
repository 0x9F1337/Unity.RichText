﻿using Unity.RichText.TextFlags.Interfaces;
using Unity.RichText.TextFlags.Parameters.Validators;

namespace Unity.RichText.TextFlags.ParamTexts
{
    internal class ColorText : ITextItem
    {
        public string? Param { get; } = string.Empty;

        public ColorText( object param )
        {
            var value = param?.ToString();

            ColorValidator.Validate( value );

            this.Param = value;
        }

        public string CloseTag()
            => "</color>";

        public string OpenTag()
            => $"<color=#{this.Param}>";
    }
}
