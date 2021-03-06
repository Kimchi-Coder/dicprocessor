using DicModels.XML;

namespace DicModels.Builders;

public class RelatedFormBuilder
{
    public static RelatedForm BuildRelatedForm(RelatedFormXml r)
    {
        RelatedForm relatedForm = new();

        relatedForm.Feats = new List<Feat>();
        if (r.FeatsXml == null) return relatedForm;
        foreach (FeatXml featXml in r.FeatsXml)
        {
            Feat newFeat = FeatBuilder.BuildFeat(featXml);
            relatedForm.Feats.Add(newFeat);
        }

        return relatedForm;
    }
}