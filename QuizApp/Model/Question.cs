namespace QuizApp.Model;

public class Question : Entity<int>
{
    public string Content { get; set; }
    public int Type {get; set;}
    public string A { get; set; }
    public string B { get; set; }
    public string C { get; set; }
    public string D { get; set; }
    public string CorrectAnswer { get; set; }
    public int ExamId { get; set; }
    
    public virtual Answer Answer { get; set; }

    public override string ToString()
    {
        return $"{Content}";
    }
}