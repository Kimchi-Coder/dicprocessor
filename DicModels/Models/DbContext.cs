using Microsoft.EntityFrameworkCore;

namespace DicModels;

public class DicContext : DbContext
{
    public DbSet<LexicalEntryXml> LexicalEntries { get; set; }
    public DbSet<FeatXml> Feats { get; set; }
    public DbSet<SenseXml> Senses { get; set; }
    public DbSet<SenseExampleXml> SenseExamples { get; set; }
    public DbSet<LemmaXml> Lemmas { get; set; }
    public DbSet<EquivalentXml> Equivalents { get; set; }
    public DbSet<WordFormXml> WordForms { get; set; }


    public DicContext()
    {
    }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        // Use own connection string
        options.UseLazyLoadingProxies().UseSqlServer(
            "Server=tcp:onesta.database.windows.net,1433;Initial Catalog=onesta-dev;Persist Security Info=False;User ID=onestadev;Password=YOURPASSWORD;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;",
            builder => builder.EnableRetryOnFailure());
    }
}