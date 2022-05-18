using DicModels.XML;
using Microsoft.EntityFrameworkCore;

namespace DicModels;

public class DicContext : DbContext
{
    public DbSet<Att> Atts { get; set; }
    public DbSet<Equivalent> Equivalents { get; set; }
    public DbSet<Feat> Feats { get; set; }
    public DbSet<FormRepresentation> FormRepresentations { get; set; }
    public DbSet<Lemma> Lemmas { get; set; }
    public DbSet<LexicalEntry> LexicalEntries { get; set; }
    public DbSet<Lexicon> Lexicons { get; set; }
    // add lexical resource model
    public DbSet<Multimedia> Multimedias { get; set; }
    public DbSet<RelatedForm> RelatedForms { get; set; }
    public DbSet<Sense> Senses { get; set; }
    public DbSet<SenseExample> SenseExamples { get; set; }
    public DbSet<SenseRelation> SenseRelations { get; set; }
    public DbSet<Val> Vals { get; set; }
    public DbSet<WordForm> WordForms { get; set; }


    public DicContext()
    {
    }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        // Use own connection string
        options.UseLazyLoadingProxies().UseSqlServer(
            // "Server=tcp:onesta.database.windows.net,1433;Initial Catalog=onesta-dev;Persist Security Info=False;User ID=onestadev;Password=YOURPASSWORD;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;",
            $"Server=tcp:learnersdic.database.windows.net,1433;Initial Catalog=learnersdic-sqldb;Persist Security Info=False;User ID=kimchiadmin;Password={yourpass};MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;",
            builder => builder.EnableRetryOnFailure());
    }
}