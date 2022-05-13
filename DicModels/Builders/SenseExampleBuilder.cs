using DicModels.XML;

namespace DicModels.Builders;

public class SenseExampleBuilder
{
    public static SenseExample BuildSenseExample(SenseExampleXml s)
    {
        SenseExample senseExample = new();
        senseExample.Feats = new List<Feat>();

        if (s.FeatsXml == null) return senseExample;
        foreach (FeatXml featXml in s.FeatsXml)
        {
            Feat newFeat = FeatBuilder.BuildFeat(featXml);
            senseExample.Feats.Add(newFeat);
        }

        return senseExample;
    }
}