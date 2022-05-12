using DicModels.XML;

namespace DicModels.Builders;

public class LemmaBuilder
{
    public static Lemma BuildLemma(LemmaXml l)
    {
        Lemma lemma = new();
        lemma.Feat = FeatBuilder.BuildFeat(l.FeatXml);

        return lemma;
    }
}