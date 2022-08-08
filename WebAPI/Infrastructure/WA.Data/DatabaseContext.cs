namespace Data;
public class DatabaseContext : Microsoft.EntityFrameworkCore.DbContext
{
    #region Solution (1)
    //public DatabaseContext() : base()
    //{
    //}

    //protected override void OnConfiguring
    //	(Microsoft.EntityFrameworkCore.DbContextOptionsBuilder optionsBuilder)
    //{
    //	base.OnConfiguring(optionsBuilder);

    //	if (optionsBuilder.IsConfigured == false)
    //	{
    //		// using Microsoft.EntityFrameworkCore;
    //		optionsBuilder
    //			.UseSqlServer(connectionString: "Password=1234512345;Persist Security Info=True;User ID=SA;Initial Catalog=DtxTripleA;Data Source=.");
    //	}
    //}
    #endregion /Solution (1)

    #region Solution (2)
    public DatabaseContext
        (Microsoft.EntityFrameworkCore.DbContextOptions<DatabaseContext> options) : base(options)
    {
        Database.EnsureCreated();
    }
    #endregion /Solution (2)

    #region Solution (3)
    /// <summary>
    /// Using Migrations!
    /// </summary>
    //public DatabaseContext
    //	(Microsoft.EntityFrameworkCore.DbContextOptions<DatabaseContext> options) : base(options)
    //{
    //}
    #endregion /Solution (3)
}
