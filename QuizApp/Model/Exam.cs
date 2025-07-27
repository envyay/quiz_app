namespace QuizApp.Model;

public class Exam : Entity<int>
{
    public string Name { get; set; }
    
    public ICollection<Question> Questions { get; set; } = null!;
}