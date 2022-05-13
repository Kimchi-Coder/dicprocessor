using DicModels.XML;

namespace DicModels.Builders;

public class LemmaBuilder
{
    public static Lemma BuildLemma(LemmaXml l)
    {
        Lemma lemma = new();
        // double check here in future
        if (l.FeatXml != null) lemma.Feat = FeatBuilder.BuildFeat(l.FeatXml);

        return lemma;
    }
}