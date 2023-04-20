using System.Xml.Xsl;
using System.Xml;

namespace XSLT_Documant
{ 
    class Program
    {
        static void Main(string[] args)
        {
            string fileName = @"D:\\user\\xsltdocumant.xslt";

            XmlTextWriter xmlWriter = new XmlTextWriter(fileName, System.Text.Encoding.UTF8);
            xmlWriter.Formatting = Formatting.Indented;
            xmlWriter.WriteStartDocument();
            xmlWriter.WriteStartElement("xsl", "stylesheet", "http://www.w3.org/1999/XSL/Transform");
            xmlWriter.WriteAttributeString("version", "1.0");

            xmlWriter.WriteStartElement("xsl", "template", "http://www.w3.org/1999/XSL/Transform");
            xmlWriter.WriteAttributeString("match", "/");
            xmlWriter.WriteStartElement("html");
            xmlWriter.WriteStartElement("body");
            xmlWriter.WriteStartElement("h1");
            xmlWriter.WriteString("XSLT Örneği");
            xmlWriter.WriteEndElement();
            xmlWriter.WriteStartElement("p");
            xmlWriter.WriteStartElement("xsl", "value-of", "http://www.w3.org/1999/XSL/Transform");
            xmlWriter.WriteAttributeString("select", "/mesaj");
            xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();
            xmlWriter.WriteEndDocument();
            xmlWriter.Flush();
            xmlWriter.Close();

            XslCompiledTransform xslt = new XslCompiledTransform();
            xslt.Load(fileName);
           
        }
    }

}