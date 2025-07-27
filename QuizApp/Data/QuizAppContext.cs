using Microsoft.EntityFrameworkCore;
using QuizApp.Model;

namespace QuizApp.Data;

public class QuizAppContext : DbContext
{
    public DbSet<Question> Questions { get; set; } = null!;
    public DbSet<Answer> Answers { get; set; } = null!;
    public DbSet<Exam> Exams { get; set; } = null!;

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(
            @"Server=localhost;Database=QuizApp;User Id=sa;Password=123456;TrustServerCertificate=True");
    }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Question>()
            .HasOne(q => q.Answer)
            .WithOne(a => a.Question)
            .HasForeignKey<Answer>(a => a.QuestionId);
    }
}