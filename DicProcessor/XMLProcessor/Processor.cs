using System.Xml;

namespace DicProcessor.XMLProcessor;

public class Processor
{
   public static void LoadAndSave()
   {
      // using (MemoryStream mso = new())
      // {
      //    
      // string text = Endpoint.UTF8.GetString
      //
      // XmlDocument doc = new();
      // doc.LoadXml(text);
      // }
      
      //Create the XmlDocument.
      XmlDocument doc = new();

      //Load the document with the last book node.
      XmlTextReader reader = new XmlTextReader("../XMLFiles/5000.xml");
      reader.WhitespaceHandling = WhitespaceHandling.None;
      reader.MoveToContent();
      reader.Read();
      reader.Skip(); //Skip the first book.
      reader.Skip(); //Skip the second book.
      doc.Load(reader);

      doc.Save(Console.Out);
      // XmlDocument doc = new();
      // doc.LoadXml();
   }
}