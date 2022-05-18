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
   public static async Task LoadAndSave()
   {
      Console.WriteLine("Reading with Stream");
      
      XmlSerializer serializer =
         new XmlSerializer(typeof(LexicalResourceXml));

      LexicalResourceXml? i;
      // started last 2 1018
      string path = "/home/jh/Documents/coding/DicProcessor/DicProcessor/XMLFiles/51947_2.xml";

      XmlReaderSettings settings = new XmlReaderSettings();
      settings.ValidationEventHandler += new ValidationEventHandler(ValidationCallBack);
      using (XmlReader reader = XmlReader.Create(path, settings))
      {
         i = (LexicalResourceXml)serializer.Deserialize(reader)!;
      }

      using (DicContext db = new DicContext())
      {
         if (i?.LexiconXml != null)
         {
            Lexicon lexicon = LexiconBuilder.BuildLexicon(i.LexiconXml);
            await db.Set<Lexicon>().AddAsync(lexicon);    
            await db.SaveChangesAsync();
         }
      }

      static void ValidationCallBack(object sender, ValidationEventArgs e)
      {
         Console.WriteLine("Validation Error: {0}", e.Message);
      }
   }
}