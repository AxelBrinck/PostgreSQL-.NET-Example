using ArticleApp.Models;
using Microsoft.EntityFrameworkCore;

namespace ArticleApp.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<Article> Articles { get; set; }
    }
}