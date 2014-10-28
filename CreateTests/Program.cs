using eBdb.EpubReader;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateTests
{
    class Program
    {
        static void Main(string[] args)
        {
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"C:\test\tests.txt"))
            {
                file.WriteLine("");
                file.WriteLine("Scenario Outline: Get ePub title                                                                                                                                                    ");
                file.WriteLine("	Given an ePub file named \"<filename>\"                                                                                                                                         ");
                file.WriteLine("	When I open the file using ePubReader                                                                                                                                           ");
                file.WriteLine("	Then the title is \"<title>\"                                                                                                                                                   ");
                file.WriteLine("                                                                                                                                                                                    ");
                file.WriteLine("Examples:                                                                                                                                                                           ");
                file.WriteLine("	| filename                                                                                    | title                                                                          |");

                foreach (var epubFile in Directory.EnumerateFiles(@"C:\test\", "*.epub"))
                {
                    try
                    {
                        Epub epub = new Epub(epubFile);
                        file.WriteLine(string.Format("|{0}|{1}|", epubFile, epub.Title[0]));
                    }
                    catch { }
                }

                file.WriteLine("");
                file.WriteLine("Scenario Outline: Get ePub content");
                file.WriteLine("	Given an ePub file named \"<filename>\"");
                file.WriteLine("	When I open the file using ePubReader");
                file.WriteLine("	Then the start of chapter 2 is \"<chapter2>\"");
                file.WriteLine("");
                file.WriteLine("Examples:");
                file.WriteLine("	| filename | chapter2 |");
                foreach (var epubFile in Directory.EnumerateFiles(@"C:\test\", "*.epub"))
                {
                    try
                    {
                        Epub epub = new Epub(epubFile);
                        file.WriteLine(string.Format("|{0}|{1}|", epubFile, 
                            epub.TOC[1].ContentData.Content
                            .Replace("\n", "")
                            .Replace("\r", "")
                            .Substring(0, 255)
                            .Trim()
                            ));
                    }
                    catch { }
                }

                file.WriteLine("");
                file.WriteLine("Scenario Outline: Get ePub text content");
                file.WriteLine("	Given an ePub file named \"<filename>\"");
                file.WriteLine("	When I open the file using ePubReader");
                file.WriteLine("	Then the start of chapter 2 is \"<chapter2>\"");
                file.WriteLine("");
                file.WriteLine("Examples:");
                file.WriteLine("	| filename | chapter2 |");
                foreach (var epubFile in Directory.EnumerateFiles(@"C:\test\", "*.epub"))
                {
                    try
                    {
                        Epub epub = new Epub(epubFile);
                        file.WriteLine(string.Format("|{0}|{1}|", epubFile, 
                            epub.TOC[1].ContentData.GetContentAsPlainText()
                            .Replace("\n", "")
                            .Replace("\r", "")
                            .Substring(0, 255)
                            .Trim()
                            ));
                    }
                    catch { }
                }

            }
        }
    }
}
