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
        LineHeight = 1 << 12,
        LineIndent = 1 << 13,
        Lowercase = 1 << 14,
        MSpace = 1 << 15,
        Margin = 1 << 16,
        Mark = 1 << 17,
        NoParse = 1 << 18,
        Nobr = 1 << 19,
        Rotate = 1 << 20,
        Size = 1 << 21,
        SmallCaps = 1 << 22,
        Space = 1 << 23,
        Sprite = 1 << 24,
        Strikethrough = 1 << 25,
        Style = 1 << 26,
        Subscript = 1 << 27,
        Superscript = 1 << 28,
        Underline = 1 << 29,
        Uppercase = 1 << 30,
        Width = 1 << 31
    }
}