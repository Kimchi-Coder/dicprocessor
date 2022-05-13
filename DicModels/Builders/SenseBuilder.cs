using DicModels.XML;

namespace DicModels.Builders;

public class SenseBuilder
{
    public static Sense BuildSense(SenseXml s)
    {
        Sense sense = new();
        sense.Feats = new List<Feat>();
        if (s.FeatsXml != null)
            foreach (FeatXml featXml in s.FeatsXml)
            {
                Feat newFeat = FeatBuilder.BuildFeat(featXml);
                sense.Feats.Add(newFeat);
            }

        sense.SenseExample = new List<SenseExample>();
        if (s.SenseExamplesXml != null)
            foreach (SenseExampleXml senseExampleXml in s.SenseExamplesXml)
            {
                SenseExample newSenseExample = SenseExampleBuilder.BuildSenseExample(senseExampleXml);
                sense.SenseExample.Add(newSenseExample);
            }

        sense.Equivalents = new List<Equivalent>();
        if (s.EquivalentsXml != null)
            foreach (EquivalentXml equivalentXml in s.EquivalentsXml)
            {
                Equivalent newEquivalent = EquivalentBuilder.BuildEquivalent(equivalentXml);
                sense.Equivalents.Add(newEquivalent);
            }

        sense.Multimedias = new List<Multimedia>();
        if (s.MultimediasXml != null)
            foreach (MultimediaXml multimediaXml in s.MultimediasXml)
            {
                Multimedia newMultimedia = MultimediaBuilder.BuildMultimedia(multimediaXml);
                sense.Multimedias.Add(newMultimedia);
            }

        sense.SenseRelations = new List<SenseRelation>();
        if (s.SenseRelationsXml != null)
            foreach (SenseRelationXml senseRelationXml in s.SenseRelationsXml)
            {
                SenseRelation newSenseRelation = SenseRelationBuilder.BuildSenseRelation(senseRelationXml);
                sense.SenseRelations.Add(newSenseRelation);
            }

        sense.Att = s.AttXml ?? string.Empty;
        sense.Val = s.ValXml ?? string.Empty;

        return sense;
    }
}