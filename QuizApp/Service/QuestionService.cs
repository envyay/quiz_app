using QuizApp.Common.Base;
using QuizApp.Model;

namespace QuizApp.Service;

public class QuestionService
{
    private readonly BaseRepository<int, Question> _questionRepository;

    public QuestionService()
    {
        _questionRepository = new BaseRepository<int, Question>();
    }

    public void Add(Question question)
    {
        _questionRepository.Add(question);
    }

    public List<Question> GetQuestionsByExamId(int examId)
    {
        return _questionRepository.Where(x => x.ExamId == examId).ToList();
    }
    
}