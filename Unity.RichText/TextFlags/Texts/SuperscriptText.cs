﻿using Unity.RichText.TextFlags.Interfaces;

namespace Unity.RichText.TextFlags.Texts
{
    internal class SuperscriptText : ITextItem
    {
        public string? Param => throw new NotImplementedException();

        public string CloseTag()
            => "</sup>";

        public string OpenTag()
            => "<sup>";
    }
}
