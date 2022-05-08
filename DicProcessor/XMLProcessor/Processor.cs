using System.Text;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using DicModels;

namespace DicProcessor.XMLProcessor;

public class Processor
{
   public static void LoadAndSave()
      // using (MemoryStream mso = new())
      // {
      //    
      // string text = Endpoint.UTF8.GetString
      //
      // XmlDocument doc = new();
      // doc.LoadXml(text);
      // }

   {
      Console.WriteLine("Reading with Stream");
      // Create an instance of the XmlSerializer.
      XmlSerializer serializer =
         new XmlSerializer(typeof(LexicalResourceXml));

      // Declare an object variable of the type to be deserialized.
      LexicalResourceXml i;
      string path = "/home/jh/Documents/coding/DicProcessor/DicProcessor/XMLFiles/5000.xml";

    
      XmlReaderSettings settings = new XmlReaderSettings();
      settings.DtdProcessing = DtdProcessing.Parse;
      settings.ValidationType = ValidationType.DTD;
      settings.ValidationEventHandler += new ValidationEventHandler (ValidationCallBack);
      using (XmlReader reader = XmlReader.Create("/home/jh/Documents/coding/DicProcessor/DicProcessor/XMLFiles/5000.xml", settings))

      // using (StreamReader reader = new StreamReader("/home/jh/Documents/coding/DicProcessor/DicProcessor/XMLFiles/5000.xml", Encoding.UTF8, true))
      {
         // Call the Deserialize method to restore the object's state.
         i = (LexicalResourceXml)serializer.Deserialize(reader);
      }
      //
      // // Write out the properties of the object.
      // Console.WriteLine(i.Lexicon);
      //
      //
      static void ValidationCallBack(object sender, ValidationEventArgs e) {
         Console.WriteLine("Validation Error: {0}", e.Message);
      }
      //
   }
}