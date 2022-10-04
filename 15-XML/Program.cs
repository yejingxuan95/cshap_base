using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace _15_XML
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlDocument doc = new XmlDocument();
            if (File.Exists("Books.xml")) {
                doc.Load("Books.xml");
                XmlElement books = doc.DocumentElement;
                XmlNodeList xmlNodeList = books.ChildNodes;
                foreach (XmlNode item in xmlNodeList)
                {
                    Console.WriteLine(item.InnerText);
                }
            }
            else
            {
                XmlDeclaration dec = doc.CreateXmlDeclaration("1.0", "utf-8", null);
                doc.AppendChild(dec);
                XmlElement books = doc.CreateElement("Books");
                doc.AppendChild(books);
                XmlElement book = doc.CreateElement("Book");
                books.AppendChild(book);
                XmlElement name = doc.CreateElement("Name");
                name.InnerText = "三国演义";
                name.SetAttribute("author", "罗贯中");
                book.AppendChild(name);
                doc.Save("Books.xml");

            }

            
        }

        private static void Create() {
            XmlDocument doc = new XmlDocument();
            XmlDeclaration dec = doc.CreateXmlDeclaration("1.0", "utf-8", null);
            doc.AppendChild(dec);
            XmlElement books = doc.CreateElement("Books");
            doc.AppendChild(books);
            XmlElement book = doc.CreateElement("Book");
            books.AppendChild(book);
            XmlElement name = doc.CreateElement("Name");
            name.InnerText = "三国演义";
            name.SetAttribute("author", "罗贯中");
            book.AppendChild(name);
            doc.Save("new.xml");
        }
    }
}
