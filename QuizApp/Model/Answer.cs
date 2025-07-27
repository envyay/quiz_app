namespace QuizApp.Model;

public class Answer : Entity<int>
{
    public string Data { get; set; }
    public int QuestionId { get; set; }
    public virtual Question Question { get; set; }
}