using Microsoft.EntityFrameworkCore;

namespace tetris;

public class ScoreContext : DbContext
{
    public DbSet<Score> Scores { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\PROJECTS\tetris\tetris\tetris.mdf;Integrated Security=True");
    }
}

    public class Score
    {
        public string ScoreId { get; set; }
    }

