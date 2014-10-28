using System.IO;
using System.Text.RegularExpressions;
using ICSharpCode.SharpZipLib.Zip;

namespace eBdb.EpubReader {
    public class ContentData
    {
        private readonly ZipEntry _ZipEntry;
        private readonly ZipFile _ZipFile;
        public string FileName { get; private set; }
        public string Content
        {
            get
            {
                using (Stream zipStream =
                 _ZipFile.GetInputStream(_ZipEntry))
                {
                    using (StreamReader reader = new StreamReader(zipStream))
                        return reader.ReadToEnd();
                }
            }
        }

        public ContentData(string fileName, ZipFile zipFile, ZipEntry zipEntry)
        {
            FileName = fileName;
            _ZipEntry = zipEntry;
            _ZipFile = zipFile;
        }

        public string GetContentAsPlainText()
        {
            Match m = Regex.Match(Content, @"<body[^>]*>.+</body>",
                Utils.REO_csi);
            return m.Success ? Utils.ClearText(m.Value) : "";
        }
    }
}
