using DicModels.XML;

namespace DicModels.Builders;

public class FeatBuilder
{
    public static Feat BuildFeat(FeatXml f)
    {
        Feat feat = new();
        feat.Att = f.Att ?? string.Empty;
        feat.Val = f.Val ?? string.Empty;

        return feat;
    }
}