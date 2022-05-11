using DicModels.XML;

namespace DicModels.Builders;

public class WordFormBuilder
{
    public static WordForm BuildWordForm(WordFormXml w)
    {
        WordForm wordForm = new();
        wordForm.Feats = new List<Feat>();

        foreach (FeatXml featXml in w.FeatsXml)
        {
            Feat newFeat = FeatBuilder.BuildFeat(featXml);
            wordForm.Feats.Add(newFeat);
        }

        return wordForm;
    }
}