using MarkdownSharp;
using NUnit.Framework;

namespace MarkdownSharpTests
{
    [TestFixture]
	public class MarkdownXrcTests : BaseTest
    {
		// Autolink are not recognized using virtual path.
		//[Test]
		//public void Autlink()
		//{
		//    string input = "Autolink: <~/url/example.html>.";
		//    string expected = "<p>Autolink: <a href=\"~/url/example.html\">~/url/example.html</a>.</p>\n";

		//    string actual = m.Transform(input);

		//    Assert.AreEqual(expected, actual);
		//}

        [Test]
        public void InlineLink_without_virtualpath()
        {
			var target = new Markdown();

			string input = "Inline link: [URL](~/url/example.html).";
            string expected = "<p>Inline link: <a href=\"~/url/example.html\">URL</a>.</p>\n";

            string actual = target.Transform(input);

            Assert.AreEqual(expected, actual);
        }

		[Test]
		public void InlineLink_with_virtualpath()
		{
			var target = new Markdown();
			target.BaseUrl = "/virtualpath/";

			string input = "Inline link: [URL](~/url/example.html).";
			string expected = "<p>Inline link: <a href=\"/virtualpath/url/example.html\">URL</a>.</p>\n";

			string actual = target.Transform(input);

			Assert.AreEqual(expected, actual);
		}

		[Test]
		public void ReferenceStyleLink_without_virtualpath()
		{
			var target = new Markdown();

			string input = "Reference style link: [linkref1][].\n\n[linkref1]: ~/url/example.html";
			string expected = "<p>Reference style link: <a href=\"~/url/example.html\">linkref1</a>.</p>\n";

			string actual = target.Transform(input);

			Assert.AreEqual(expected, actual);
		}

		[Test]
		public void ReferenceStyleLink_with_virtualpath()
		{
			var target = new Markdown();
			target.BaseUrl = "/virtualpath";

			string input = "Reference style link: [linkref1][].\n\n[linkref1]: ~/url/example.html";
			string expected = "<p>Reference style link: <a href=\"/virtualpath/url/example.html\">linkref1</a>.</p>\n";

			string actual = target.Transform(input);

			Assert.AreEqual(expected, actual);
		}


		[Test]
		public void InlineImg_without_virtualpath()
		{
			var target = new Markdown();

			string input = "Image: ![Alt text](~/path/to/img.jpg).";
			string expected = "<p>Image: <img src=\"~/path/to/img.jpg\" alt=\"Alt text\" />.</p>\n";

			string actual = target.Transform(input);

			Assert.AreEqual(expected, actual);
		}

		[Test]
		public void InlineImg_with_virtualpath()
		{
			var target = new Markdown();
			target.BaseUrl = "/virtualpath/";

			string input = "Image: ![Alt text](~/path/to/img.jpg).";
			string expected = "<p>Image: <img src=\"/virtualpath/path/to/img.jpg\" alt=\"Alt text\" />.</p>\n";

			string actual = target.Transform(input);

			Assert.AreEqual(expected, actual);
		}

		[Test]
		public void ReferenceImg_without_virtualpath()
		{
			var target = new Markdown();

			string input = "Image: ![Alt text][id].\n\n[id]: ~/url/to/image  \"Optional title attribute\"";
			string expected = "<p>Image: <img src=\"~/url/to/image\" alt=\"Alt text\" title=\"Optional title attribute\" />.</p>\n";

			string actual = target.Transform(input);

			Assert.AreEqual(expected, actual);
		}

		[Test]
		public void ReferenceImg_with_virtualpath()
		{
			var target = new Markdown();
			target.BaseUrl = "/virtualpath/";

			string input = "Image: ![Alt text][id].\n\n[id]: ~/url/to/image  \"Optional title attribute\"";
			string expected = "<p>Image: <img src=\"/virtualpath/url/to/image\" alt=\"Alt text\" title=\"Optional title attribute\" />.</p>\n";

			string actual = target.Transform(input);

			Assert.AreEqual(expected, actual);
		}
    }
}
