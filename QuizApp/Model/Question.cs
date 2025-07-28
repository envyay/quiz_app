using QuizApp.Common;

namespace QuizApp.Model;

public class Question : Entity<int>
{
    public string Content { get; set; }
    public int Type { get; set; }
    public string A { get; set; }
    public string B { get; set; }
    public string C { get; set; }
    public string D { get; set; }
    public string CorrectAnswer { get; set; }
    public int ExamId { get; set; }

    public virtual Answer Answer { get; set; }

    public string GetQuestionContent()
    {
        switch (Type)
        {
            case Constants.MULTIPLE_CHOICE:
                return $"{Content}{Environment.NewLine}" + 
                       $"A. {A}{Environment.NewLine}" +
                       $"B. {B}{Environment.NewLine}" +
                       $"C. {C}{Environment.NewLine}" +
                       $"D. {D}{Environment.NewLine}";
            case Constants.TRUE_FALSE:
                return $"{Content}{Environment.NewLine}" +
                       $"True {Environment.NewLine}" +
                       $"False {Environment.NewLine}";
            case Constants.OPEN_ENDED:
                return $"{Content}";
            default:
                return "";
        }
    }

    public override string ToString()
    {
        return $"{Content}";
    }
}