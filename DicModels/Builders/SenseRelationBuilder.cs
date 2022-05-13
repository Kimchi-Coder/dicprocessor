using DicModels.XML;

namespace DicModels.Builders;

public class SenseRelationBuilder
{
    public static SenseRelation BuildSenseRelation(SenseRelationXml s)
    {
        SenseRelation senseRelation = new();
        senseRelation.Feats = new List<Feat>();
        if (s.FeatsXml == null) return senseRelation;
        foreach (FeatXml featXml in s.FeatsXml)
        {
            Feat newFeat = FeatBuilder.BuildFeat(featXml);
            senseRelation.Feats.Add(newFeat);
        }

        return senseRelation;
    }
}