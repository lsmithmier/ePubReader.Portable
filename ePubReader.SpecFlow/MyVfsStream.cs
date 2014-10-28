using ICSharpCode.SharpZipLib.VirtualFileSystem;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ePubReader.SpecFlow
{
    public class MyVfsStream : VfsStream
    {
        private readonly FileStream _Stream;

        public MyVfsStream(FileStream fileStream)
        {
            _Stream = fileStream;
        }

        public override string Name
        {
            get
            {
                return _Stream.Name;
            }
        }

        public override bool CanRead
        {
            get
            {
                return _Stream.CanRead;
            }
        }

        public override bool CanSeek
        {
            get
            {
                return _Stream.CanSeek;
            }
        }

        public override bool CanWrite
        {
            get
            {
                return _Stream.CanWrite;
            }
        }

        public override void Flush()
        {
            _Stream.Flush();
        }

        public override long Length
        {
            get
            {
                return _Stream.Length;
            }
        }

        public override long Position
        {
            get
            {
                return _Stream.Position;
            }
            set
            {
                _Stream.Position = value;
            }
        }

        public override int Read(byte[] buffer, int offset, int count)
        {
            return _Stream.Read(buffer, offset, count);
        }

        public override long Seek(long offset, SeekOrigin origin)
        {
            return _Stream.Seek(offset, origin);
        }

        public override void SetLength(long value)
        {
            _Stream.SetLength(value);
        }

        public override void Write(byte[] buffer, int offset, int count)
        {
            _Stream.Write(buffer, offset, count);
        }
    }
}
