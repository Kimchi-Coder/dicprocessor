using DicModels.XML;

namespace DicModels.Builders;

public class FeatBuilder
{
    public static Feat BuildFeat(FeatXml f)
    {
        Feat feat = new();
        feat.Att = f.AttXml ?? string.Empty;
        feat.Val = f.ValXml ?? string.Empty;

        return feat;
    }
}