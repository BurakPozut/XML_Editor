using System.IO.Packaging;
using System.Xml;
using XML_Editor.Models;
using Aspose.Pdf;

namespace XML_Editor;

public class XmlManager
{
    public void UpdateXml(MazeretModel[] mazeretModels)
    {
        string xmlFilePath = @"C:\Users\Burak\Desktop\mazeret.xml";
        XmlDocument doc = new();
        doc.Load(xmlFilePath);

        XmlNamespaceManager namespaceManager = new(doc.NameTable);
        namespaceManager.AddNamespace("text", "urn:oasis:names:tc:opendocument:xmlns:text:1.0");

        XmlNodeList nodes = doc.SelectNodes("//text:p[@text:style-name='P10']", namespaceManager);

        if (nodes?.Count > 0)
        {
            foreach (XmlNode node in nodes)
            {
                node.InnerText = mazeretModels[0].Mahkemeİsmi;
            }

            doc.Save(xmlFilePath);

            Console.WriteLine("Node edited successfully");
        }
        else
        {
            Console.WriteLine("Node not found in the XML file");
            return;
        }


        // string odtFilePath = "output.odt";

        // using (Package odtPackage = Package.Open(odtFilePath, FileMode.Create))
        // {
        //     PackagePart contentPart = odtPackage.CreatePart(new Uri("/content.xml", UriKind.Relative), "application/xml");

        //     using (Stream contentStream = contentPart.GetStream())
        //     {
        //         using (StreamWriter contentWriter = new StreamWriter(contentStream))
        //         {
        //             string editedXMLContent = File.ReadAllText(xmlFilePath);

        //             contentWriter.Write(editedXMLContent);
        //         }
        //     }
        // }

        //License license = new License();

        Document document = new();
        document.BindXml(xmlFilePath);
        document.Save(@"C:\Users\Burak\Desktop\XmlToPdf.pdf");


        System.Console.WriteLine("ODT document created using the edited XML and saved");
    }
}