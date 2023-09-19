
using NUnit.Framework.Constraints;
using System.Diagnostics;

namespace Unity.RichText.Tests
{
    [TestFixture]
    public class Tests
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
    }
}