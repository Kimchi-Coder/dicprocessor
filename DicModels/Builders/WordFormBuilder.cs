using DicModels.XML;

namespace DicModels.Builders;

public class WordFormBuilder
{
    public static WordForm BuildWordForm(WordFormXml w)
    {
        WordForm wordForm = new();
        wordForm.Feats = new List<Feat>();

        if (w.FeatsXml == null) return wordForm;
        foreach (Feat newFeat in w.FeatsXml.Select(FeatBuilder.BuildFeat))
        {
            wordForm.Feats.Add(newFeat);
        }

        return wordForm;
    }
}