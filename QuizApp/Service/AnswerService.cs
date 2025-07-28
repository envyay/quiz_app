using QuizApp.Common.Base;
using QuizApp.Model;

namespace QuizApp.Service;

public class AnswerService
{
    private readonly BaseRepository<int, Answer> _answerRepository;

    public AnswerService()
    {
        _answerRepository = new BaseRepository<int, Answer>();
    }

    public void AddRange(IEnumerable<Answer> answers)
    {
        _answerRepository.AddRange(answers);
    }
}