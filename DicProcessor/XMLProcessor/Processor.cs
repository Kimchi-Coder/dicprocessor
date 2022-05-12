using System.Text;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using DicModels;
using DicModels.Builders;
using DicModels.XML;

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
      LexicalResourceXml? i;
      string path = "C:\\Code\\dicprocessor\\DicProcessor\\XMLFiles\\5000_.xml";


      XmlReaderSettings settings = new XmlReaderSettings();
      // settings.DtdProcessing = DtdProcessing.Parse;
      // settings.ValidationType = ValidationType.DTD;
      settings.ValidationEventHandler += new ValidationEventHandler(ValidationCallBack);
      using (XmlReader reader = XmlReader.Create(path, settings))
      {
         // Call the Deserialize method to restore the object's state.
         i = (LexicalResourceXml)serializer.Deserialize(reader)!;
      }

      // // Write out the properties of the object.
      foreach (LexicalEntryXml element in i?.LexiconXml?.LexicalEntriesXml)
      {
         LexicalEntry newLexicalEntry = LexicalEntryBuilder.BuildLexicalEntry(element);
         Console.WriteLine($"{newLexicalEntry.Att} ");
         Console.WriteLine($"{newLexicalEntry.Val} ");
         Console.WriteLine($"{newLexicalEntry.Lemma.Feat.Att}");
         Console.WriteLine($"{newLexicalEntry.Lemma.Feat.Val}");
         Console.WriteLine($"{newLexicalEntry.Senses}");
         Console.WriteLine($"{newLexicalEntry.Val}");
         foreach (Feat feat in newLexicalEntry.Feats)
         {
            Console.WriteLine($"{feat.Att} ");
            Console.WriteLine($"{feat.Val} ");
         
         }

         if (newLexicalEntry is {WordForm.Feats: { }})
         {
            foreach (Feat feat in newLexicalEntry.WordForm.Feats)
            {
               Console.WriteLine($"{feat.Att} ");
               Console.WriteLine($"{feat.Val} ");
         
            }
         }

         if (newLexicalEntry is {Senses: { }})
         {
            foreach (Sense sense in newLexicalEntry.Senses)
            {
               if (sense.Equivalents != null)
                  foreach (Equivalent equivalent in sense.Equivalents)
                  {
                     foreach (Feat feat in equivalent.Feats)
                     {
                        Console.WriteLine($"{feat.Att} ");
                        Console.WriteLine($"{feat.Val} ");
                     }
                  }
            }
         }

      }

      static void ValidationCallBack(object sender, ValidationEventArgs e)
      {
         Console.WriteLine("Validation Error: {0}", e.Message);
      }
   }
}