using DicModels.XML;

namespace DicModels.Builders;

public class MultimediaBuilder
{
    public static Multimedia BuildMultimedia(MultimediaXml m)
    {
        Multimedia multimedia = new();

        multimedia.Feats = new List<Feat>();
        if (m.FeatsXml == null) return multimedia;
        foreach (FeatXml featXml in m.FeatsXml)
        {
            Feat newFeat = FeatBuilder.BuildFeat(featXml);
            multimedia.Feats.Add(newFeat);
        }

        return multimedia;
    }
}