﻿using Unity.RichText.TextFlags.Interfaces;

namespace Unity.RichText.TextFlags.Texts
{
    [TextItemIdentifier( UnityRichTextFlag.Crossed )]
    internal class CrossedText : ITextItem
    {
        public string? Param => throw new NotImplementedException();

        public string CloseTag()
            => "</s>";

        public string OpenTag()
            => "<s>";
    }
}
