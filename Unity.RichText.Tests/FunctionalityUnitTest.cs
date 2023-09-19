
using NUnit.Framework.Constraints;
using System.Diagnostics;

namespace Unity.RichText.Tests
{
    [TestFixture(Category = "function", Description = "Unit tests to ensure functionality.")]
    public class FunctionalityTests
    {
        [SetUp]
        public void Setup()
        {
            Trace.Listeners.Add( new ConsoleTraceListener() );
        }

        [TearDown]
        public void End()
        {
            Trace.Flush();
        }

        [Test]
        public void TestBold()
        {
            string value = "test";

            string modified = UnityRichText.Nested( value, UnityRichTextFlag.Bold );

            Assert.That( modified, Is.EqualTo( "<b>test</b>" ) );

            Trace.WriteLine( modified );

            Assert.Pass();
        }

        [Test]
        public void TestItalic()
        {
            string value = "test";

            string modified = UnityRichText.Nested( value, UnityRichTextFlag.Italic );

            Assert.That( modified, Is.EqualTo( "<i>test</i>" ) );

            Trace.WriteLine( modified );

            Assert.Pass();
        }

        [Test]
        public void TestNestedBold()
        {
            string value = "test";

            string modified = UnityRichText.Nested( value, UnityRichTextFlag.Bold );

            Assert.That( modified, Is.EqualTo( "<b>test</b>" ) );

            Trace.WriteLine( modified );

            Assert.Pass();
        }

        [Test]
        public void TestNestedItalic()
        {
            string value = "test";

            string modified = UnityRichText.Nested( value, UnityRichTextFlag.Italic );

            Assert.That( modified, Is.EqualTo( "<i>test</i>" ) );

            Trace.WriteLine( modified );

            Assert.Pass();

        }

        [Test]
        public void TestNestedBoldItalic()
        {
            string value = "test";

            string modified = UnityRichText.Nested( value, UnityRichTextFlag.Bold | UnityRichTextFlag.Italic );

            Assert.That( modified, Is.EqualTo( "<b><i>test</i></b>" ) );

            Trace.WriteLine( modified );

            Assert.Pass();
        }

        [Test]
        public void TestNestedItalicBold()
        {
            string value = "test";

            string modified = UnityRichText.Nested( value, UnityRichTextFlag.Italic | UnityRichTextFlag.Bold );

            Assert.That( modified, Is.EqualTo( "<b><i>test</i></b>" ) );

            Trace.WriteLine( modified );

            Assert.Pass();
        }

        [Test]
        public void TestNestedFull()
        {
            string modified = UnityRichText.Nested(
                ("H", UnityRichTextFlag.None),
                ("ell", UnityRichTextFlag.Italic),
                ("O W", UnityRichTextFlag.Bold),
                ("or", UnityRichTextFlag.Italic | UnityRichTextFlag.Bold),
                ("ld!", UnityRichTextFlag.Bold | UnityRichTextFlag.Italic) );

            Assert.That( modified, Is.EqualTo( "H<i>ell</i><b>O W</b><b><i>or</i></b><b><i>ld!</i></b>" ) );

            Trace.WriteLine( modified );

            Assert.Pass();
        }

        [Test]
        public void TestHref()
        {
            string modified = UnityRichText.Nested( "This is a test", UnityRichTextFlag.Href, "https://www.google.com" );

            Assert.That( modified, Is.EqualTo( "<a href=\"https://www.google.com\">This is a test</a>" ) );

            Trace.WriteLine( modified );

            Assert.Pass();
        }

        [Test]
        public void TestAlign()
        {
            string modified = UnityRichText.Nested(
                ("Hello", UnityRichTextFlag.Align, TextFlags.Parameters.AlignParameter.Left),
                ("World", UnityRichTextFlag.Align, TextFlags.Parameters.AlignParameter.Right)
            );

            Assert.That( modified, Is.EqualTo( "<align=\"left\">Hello</align><align=\"right\">World</align>" ) );

            Trace.WriteLine( modified );

            Assert.Pass();
        }

        [Test]
        public void TestAllCaps()
        {
            string modified = UnityRichText.Nested(
                ("Hello", UnityRichTextFlag.None),
                ("World", UnityRichTextFlag.AllCaps)
            );

            Assert.That( modified, Is.EqualTo( "Hello<allcaps>World</allcaps>" ) );

            Trace.WriteLine( modified );

            Assert.Pass();
        }

        [Test]
        public void TestColorWithBold()
        {
            string modified = UnityRichText.Nested(
                ("Hello", UnityRichTextFlag.None, "Testual"),
                ("World", UnityRichTextFlag.Bold | UnityRichTextFlag.Color, "#fcba03")
            );

            Assert.That( modified, Is.EqualTo( "Hello<b><color=#fcba03>World</color></b>" ) );

            Trace.WriteLine( modified );

            Assert.Pass();
        }

        [Test]
        public void TestMultipleColors()
        {
            string modified = UnityRichText.Nested(
                ("Hello", UnityRichTextFlag.Color, "#380024"),
                ("World", UnityRichTextFlag.Bold | UnityRichTextFlag.Color, "#fcba03"));

            Assert.That( modified, Is.EqualTo( "<color=#380024>Hello</color><b><color=#fcba03>World</color></b>" ) );

            Trace.WriteLine( modified );

            Assert.Pass();
        }

        [Test]
        public void TestCSpace()
        {
            string modified = UnityRichText.Nested( "Hello", UnityRichTextFlag.CSpace, "5em" );

            Assert.That( modified, Is.EqualTo( "<cspace=5em>Hello</cspace>" ) );

            Trace.WriteLine( modified );

            Assert.Pass();
        }

        [Test]
        public void TestCrossed()
        {
            string modified = UnityRichText.Nested( "Hello", UnityRichTextFlag.Crossed );

            Assert.That( modified, Is.EqualTo( "<s>Hello</s>" ) );

            Trace.WriteLine( modified );

            Assert.Pass();
        }

        [Test]
        public void TestFont()
        {
            string modified = UnityRichText.Nested( "Hello", UnityRichTextFlag.Font, "Tahoma" );

            Assert.That( modified, Is.EqualTo( "<font=\"Tahoma\">Hello</font>" ) );

            Trace.WriteLine( modified );

            Assert.Pass();
        }

        [Test]
        public void TestFontWeight()
        {
            string modified = UnityRichText.Nested( "Hello", UnityRichTextFlag.FontWeight, "100" );

            Assert.That( modified, Is.EqualTo( "<font-weight=\"100\">Hello</font-weight>" ) );

            Trace.WriteLine( modified );

            Assert.Pass();
        }

        [Test]
        public void TestGradient()
        {
            string modified = UnityRichText.Nested( "Hello", UnityRichTextFlag.Gradient, "White to Blue" );

            Assert.That( modified, Is.EqualTo( "<gradient=\"White to Blue\">Hello</gradient>" ) );

            Trace.WriteLine( modified );

            Assert.Pass();
        }

        [Test]
        public void TestIndent()
        {
            string modified = UnityRichText.Nested( "Hello", UnityRichTextFlag.Indent, "20%" );

            Assert.That( modified, Is.EqualTo( "<indent=20%>Hello</indent>" ) );

            Trace.WriteLine( modified );

            Assert.Pass();
        }

        [Test]
        public void TestLineIndent()
        {
            string modified = UnityRichText.Nested( "Hello", UnityRichTextFlag.LineIndent, "35%" );

            Assert.That( modified, Is.EqualTo( "<line-indent=35%>Hello</line-indent>" ) );

            Trace.WriteLine( modified );

            Assert.Pass();
        }

        [Test]
        public void TestLowercase()
        {
            string modified = UnityRichText.Nested( "Hello", UnityRichTextFlag.Lowercase );

            Assert.That( modified, Is.EqualTo( "<lowercase>Hello</lowercase>" ) );

            Trace.WriteLine( modified );

            Assert.Pass();
        }

        [Test]
        public void TestMSpace()
        {
            string modified = UnityRichText.Nested( 
                ("Hello ", UnityRichTextFlag.None, null), 
                ("World", UnityRichTextFlag.MSpace, "10em" ));

            Assert.That( modified, Is.EqualTo( "Hello <mspace=10em>World</mspace>" ) );

            Trace.WriteLine( modified );

            Assert.Pass();
        }

        [Test]
        public void TestNoBreak()
        {
            string modified = UnityRichText.Nested(
                ("Hello ", UnityRichTextFlag.None),
                ("World", UnityRichTextFlag.Nobr) );

            Assert.That( modified, Is.EqualTo( "Hello <nobr>World</nobr>" ) );

            Trace.WriteLine( modified );

            Assert.Pass();
        }

        [Test]
        public void TestMargin()
        {
            string modified = UnityRichText.Nested( "Hello", UnityRichTextFlag.Margin, "5em" );

            Assert.That( modified, Is.EqualTo( "<margin=5em>Hello</margin>" ) );

            Trace.WriteLine( modified );

            Assert.Pass();
        }

        [Test]
        public void TestMark()
        {
            string modified = UnityRichText.Nested( "Hello", UnityRichTextFlag.Mark, "380024" );

            Assert.That( modified, Is.EqualTo( "<mark=#380024>Hello</mark>" ) );

            Trace.WriteLine( modified );

            Assert.Pass();
        }

        [Test]
        public void TestNoParse()
        {
            string modified = UnityRichText.Nested( "He<b>ll</b>o", UnityRichTextFlag.NoParse );

            Assert.That( modified, Is.EqualTo( "<noparse>He<b>ll</b>o</noparse>" ) );

            Trace.WriteLine( modified );

            Assert.Pass();
        }

        [Test]
        public void TestRotate()
        {
            string modified = UnityRichText.Nested( "Hello", UnityRichTextFlag.Rotate, "45" );

            Assert.That( modified, Is.EqualTo( "<rotate=\"45\">Hello</rotate>" ) );

            Trace.WriteLine( modified );

            Assert.Pass();
        }

        [Test]
        public void TestSize()
        {
            string modified = UnityRichText.Nested( "Hello", UnityRichTextFlag.Size, "35%" );

            Assert.That( modified, Is.EqualTo( "<size=35%>Hello</size>" ) );

            Trace.WriteLine( modified );

            Assert.Pass();
        }

        [Test]
        public void TestSmallCaps()
        {
            string modified = UnityRichText.Nested( "Hello", UnityRichTextFlag.SmallCaps );

            Assert.That( modified, Is.EqualTo( "<smallcaps>Hello</smallcaps>" ) );

            Trace.WriteLine( modified );

            Assert.Pass();
        }

        [Test]
        public void TestSpace()
        {
            string modified = UnityRichText.Nested( "Hello", UnityRichTextFlag.Space, "13em" );

            Assert.That( modified, Is.EqualTo( "<space=13em>Hello</space>" ) );

            Trace.WriteLine( modified );

            Assert.Pass();
        }

        [Test]
        public void TestSprite()
        {
            string modified = UnityRichText.Nested( "Hello", UnityRichTextFlag.Sprite, "hl2_default" );

            Assert.That( modified, Is.EqualTo( "<sprite name=\"hl2_default\">Hello</sprite>" ) );

            Trace.WriteLine( modified );

            Assert.Pass();
        }

        [Test]
        public void TestStrikethrough()
        {
            string modified = UnityRichText.Nested( "Hello", UnityRichTextFlag.Strikethrough );

            Assert.That( modified, Is.EqualTo( "<strikethrough>Hello</strikethrough>" ) );

            Trace.WriteLine( modified );

            Assert.Pass();
        }

        [Test]
        public void TestStyle()
        {
            string modified = UnityRichText.Nested( "Hello", UnityRichTextFlag.Style, "h1" );

            Assert.That( modified, Is.EqualTo( "<style=\"h1\">Hello</style>" ) );

            Trace.WriteLine( modified );

            Assert.Pass();
        }

        [Test]
        public void TestSubscript()
        {
            string modified = UnityRichText.Nested( "Hello", UnityRichTextFlag.Subscript );

            Assert.That( modified, Is.EqualTo( "<sub>Hello</sub>" ) );

            Trace.WriteLine( modified );

            Assert.Pass();
        }

        [Test]
        public void TestSuperscript()
        {
            string modified = UnityRichText.Nested( "Hello", UnityRichTextFlag.Superscript );

            Assert.That( modified, Is.EqualTo( "<sup>Hello</sup>" ) );

            Trace.WriteLine( modified );

            Assert.Pass();
        }

        [Test]
        public void TestUnderline()
        {
            string modified = UnityRichText.Nested( "Hello", UnityRichTextFlag.Underline );

            Assert.That( modified, Is.EqualTo( "<underline>Hello</underline>" ) );

            Trace.WriteLine( modified );

            Assert.Pass();
        }

        [Test]
        public void TestUppercase()
        {
            string modified = UnityRichText.Nested( "Hello", UnityRichTextFlag.Uppercase );

            Assert.That( modified, Is.EqualTo( "<uppercase>Hello</uppercase>" ) );

            Trace.WriteLine( modified );

            Assert.Pass();
        }

        [Test]
        public void TestWidth()
        {
            string modified = UnityRichText.Nested( "Hello", UnityRichTextFlag.Width, "60%" );

            Assert.That( modified, Is.EqualTo( "<width=60%>Hello</width>" ) );

            Trace.WriteLine( modified );

            Assert.Pass();
        }

        [Test]
        public void TestBreak()
        {
            string modified = UnityRichText.Nested(
                ("Hello", UnityRichTextFlag.Break),
                (" World", UnityRichTextFlag.None) );

            Assert.That( modified, Is.EqualTo( "Hello<br> World" ) );

            Trace.WriteLine( modified );

            Assert.Pass();
        }
    }
}