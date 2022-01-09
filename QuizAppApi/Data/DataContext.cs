using Microsoft.EntityFrameworkCore;
using QuizAppApi.Model;

namespace QuizAppApi.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)  {}

        public DbSet<Question> Questions { get; set; }
        public DbSet<QuestionOption> QuestionOptions { get; set; }
    }
}
