namespace Unity.RichText
{
    [Flags]
    public enum UnityRichTextFlag
    {
        None = 0,
        Align = 1 << 0,
        AllCaps = 1 << 1,
        Bold = 1 << 2,
        CSpace = 1 << 3,
        Color = 1 << 4,
        Crossed = 1 << 5,
        Font = 1 << 6,
        FontWeight = 1 << 7,
        Gradient = 1 << 8,
        Href = 1 << 9,
        Indent = 1 << 10,
        Italic = 1 << 11,
        LineIndent = 1 << 12,
        Lowercase = 1 << 13,
        MSpace = 1 << 14,
        Margin = 1 << 15,
        Mark = 1 << 16,
        NoParse = 1 << 17,
        Nobr = 1 << 18,
        Rotate = 1 << 19,
        Size = 1 << 20,
        SmallCaps = 1 << 21,
        Space = 1 << 22,
        Sprite = 1 << 23,
        Strikethrough = 1 << 24,
        Style = 1 << 25,
        Subscript = 1 << 26,
        Superscript = 1 << 27,
        Underline = 1 << 28,
        Uppercase = 1 << 29,
        Width = 1 << 30,
        Break = 1 << 31
    }
}