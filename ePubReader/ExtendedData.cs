using ICSharpCode.SharpZipLib.Core;
using ICSharpCode.SharpZipLib.Zip;
using System;
using System.IO;

namespace eBdb.EpubReader {
    public class ExtendedData
    {
        private readonly ZipEntry _ExtendedZipEntry;
        private readonly ZipFile _ZipFile;
        public string FileName { get; private set; }
        public string Content
        {
            get
            {
                using (Stream zipStream = _ZipFile.GetInputStream(_ExtendedZipEntry))
                {
                    if (IsText) using (StreamReader reader = new StreamReader(zipStream)) return reader.ReadToEnd();
                    else return Convert.ToBase64String(GetContentAsBinary());
                }
            }
        }
        public bool IsText
        {
            get { return _ExtendedZipEntry.IsUnicodeText || Path.GetExtension(FileName).Equals(".ncx", StringComparison.CurrentCultureIgnoreCase) || Path.GetExtension(FileName).Equals(".css", StringComparison.CurrentCultureIgnoreCase); }
        }
        public string MimeType { get; private set; }

        public ExtendedData(string fileName, string mimeType, ZipFile zipFile, ZipEntry extendedZipEntry)
        {
            FileName = fileName;
            MimeType = mimeType;
            _ExtendedZipEntry = extendedZipEntry;
            _ZipFile = zipFile;
        }

        public byte[] GetContentAsBinary()
        {
            using (Stream zipStream = _ZipFile.GetInputStream(_ExtendedZipEntry))
            {
                using (MemoryStream memoryStream = new MemoryStream())
                {
                    byte[] buffer = new byte[4096];     // 4K is optimum
                    StreamUtils.Copy(zipStream, memoryStream, buffer);
                    memoryStream.Position = 0;
                    return memoryStream.ToArray();
                }
            }
        }
    }
}
