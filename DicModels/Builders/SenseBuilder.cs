using DicModels.XML;

namespace DicModels.Builders;

public class SenseBuilder
{
    public static Sense BuildSense(SenseXml s)
    {
        Sense sense = new();
        sense.Feats = new List<Feat>();
        foreach (FeatXml featXml in s.FeatsXml)
        {
            Feat newFeat = FeatBuilder.BuildFeat(featXml);
            sense.Feats.Add(newFeat);
        }

        sense.SenseExample = new List<SenseExample>();
        foreach (SenseExampleXml senseExampleXml in s.SenseExamples)
        {
            SenseExample newSenseExample = SenseExampleBuilder.BuildSenseExample(senseExampleXml);
            sense.SenseExample.Add(newSenseExample);
        } 
        
        //EquivalentBuilder

        sense.Att = s.Att;
        sense.Val = s.Val;

        return sense;
    }
}