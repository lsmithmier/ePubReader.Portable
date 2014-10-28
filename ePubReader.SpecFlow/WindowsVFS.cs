using System;
using System.Collections.Generic;
using System.IO;
using ICSharpCode.SharpZipLib.VirtualFileSystem;

namespace ePubReader.SpecFlow
{
    public class WindowsVFS : IVirtualFileSystem
    {
        public void CopyFile(string fromFileName, string toFileName, bool overwrite)
        {
            throw new NotImplementedException();
        }

        public void CreateDirectory(string directory)
        {
            throw new NotImplementedException();
        }

        public VfsStream CreateFile(string filename)
        {
            throw new NotImplementedException();
        }

        public string CurrentDirectory
        {
            get { throw new NotImplementedException(); }
        }

        public void DeleteFile(string fileName)
        {
            throw new NotImplementedException();
        }

        public char DirectorySeparatorChar
        {
            get { throw new NotImplementedException(); }
        }

        public IEnumerable<string> GetDirectories(string directory)
        {
            throw new NotImplementedException();
        }

        public IDirectoryInfo GetDirectoryInfo(string directoryName)
        {
            throw new NotImplementedException();
        }

        public IFileInfo GetFileInfo(string filename)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<string> GetFiles(string directory)
        {
            throw new NotImplementedException();
        }

        public string GetFullPath(string path)
        {
            throw new NotImplementedException();
        }

        public string GetTempFileName()
        {
            throw new NotImplementedException();
        }

        public void MoveFile(string fromFileName, string toFileName)
        {
            throw new NotImplementedException();
        }

        public VfsStream OpenReadFile(string filename)
        {
            return new MyVfsStream(File.OpenRead(filename));
        }

        public VfsStream OpenWriteFile(string filename)
        {
            throw new NotImplementedException();
        }

        public void SetAttributes(string name, ICSharpCode.SharpZipLib.VirtualFileSystem.FileAttributes attributes)
        {
            throw new NotImplementedException();
        }

        public void SetLastWriteTime(string name, DateTime dateTime)
        {
            throw new NotImplementedException();
        }
    }
}
