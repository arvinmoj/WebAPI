using Microsoft.EntityFrameworkCore;
namespace Data;
public partial class DatabaseContext : DbContext
{
    #region Solution (1)

    // public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
    // {
    // }

    // protected override void OnConfiguring
    //     (Microsoft.EntityFrameworkCore.DbContextOptionsBuilder optionsBuilder)
    // {
    //     base.OnConfiguring(optionsBuilder);

    //     if (optionsBuilder.IsConfigured == false)
    //     {
    //         // using Microsoft.EntityFrameworkCore;
    //         optionsBuilder
    //             .UseSqlServer(connectionString: "Password=****;Persist Security Info=True;User ID=****; Initial Catalog = ****; Data Source=***.***.***.***,****");
    //     }
    // }
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
    // public DatabaseContext
    //     (Microsoft.EntityFrameworkCore.DbContextOptions<DatabaseContext> options) : base(options)
    // {
    // }
    #endregion /Solution (3)

    #region Solution (4)
    // public DatabaseContext()
    // {
    // }
    // public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
    // {
    // }
    // protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    // {
    //     if (!optionsBuilder.IsConfigured)
    //     {
    //         optionsBuilder.UseSqlServer("Password=****;Persist Security Info=True;User ID=****; Initial Catalog = ****; Data Source=***.***.***.***,****");
    //     }
    // }

    // protected override void OnModelCreating(ModelBuilder modelBuilder)
    // {
    //     modelBuilder.HasDefaultSchema("database");

    //     OnModelCreatingPartial(modelBuilder);
    // }

    // partial void OnModelCreatingPartial(ModelBuilder modelBuilder);

    #endregion /Solution (4)

    // **********
    public Microsoft.EntityFrameworkCore.DbSet<Models.ToDoModel> ToDoLists { get; set; }
    // **********
}
