using QuizApp.Common.Base;
using QuizApp.Model;

namespace QuizApp.Service;

public class ExamService
{
    private readonly BaseRepository<int, Exam> _examRepository;
    private readonly BaseRepository<int, Question> _questionRepository;

    public ExamService()
    {
        _examRepository = new BaseRepository<int, Exam>();
        
        
        
        
        _questionRepository = new BaseRepository<int, Question>();
    }

    public Exam? GetExamById(int id)
    {
        return _examRepository.GetById(id);
    }

    public Exam AddExam(Exam exam)
    {
        return _examRepository.Add(exam);
    }

    public List<Question> GetQuestionsByExamId(int examId)
    {
        return _questionRepository.Where(x => x.ExamId == examId).ToList();
    }
}