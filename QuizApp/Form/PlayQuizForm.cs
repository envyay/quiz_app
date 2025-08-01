﻿using QuizApp.Common;
using QuizApp.Model;
using QuizApp.Service;

namespace QuizApp;

public partial class PlayQuizForm : Form
{
    private int _index = 0;
    private readonly Question[] _questions;
    private readonly QuestionService _questionService;
    private readonly AnswerService _answerService;
    private TimerService _timerService;
    private System.Windows.Forms.Timer _timer;
    private readonly int _examId;
    private readonly Answer[] _answers;
    
    public PlayQuizForm(int examId)
    {
        _timerService = new TimerService();
        _questionService = new QuestionService();
        _answerService = new AnswerService();
        _examId = examId;
        _questions = GetQuestions();
        _answers = MapQuestionToAnswer();
        
        InitializeComponent();
        
        _timerService.Start();
        _timer = new System.Windows.Forms.Timer();
        _timer.Interval = 1000;
        _timer.Tick += OnTimerTick;
        _timer.Start();
        
        UpdateQuestionUI();
    }

    private void BackBtn_Click(object sender, EventArgs e)
    {
        var mainForm = new MainForm();
        mainForm.Show();
        this.Close();
    }

    private Question[] GetQuestions()
    {
        return _questionService.GetQuestionsByExamId(_examId).ToArray();
    }
    

    private void UpdateQuestionUI()
    {
        var question = _questions[_index];
        var typeName = Constants.QuestionTypeName(question.Type);
        QuestionTypeLbl.Text = typeName;

        QuestionContentTb.Multiline = true;
        QuestionContentTb.Text = question.GetQuestionContent();

        NoQuestionsLbl.Text = $"{_index + 1}/{_questions.Length}";
    }


    private void NextBtn_Click(object sender, EventArgs e)
    {
        if (_index >= (_questions.Length - 1)) return;
        
        _index++;
        UpdateQuestionUI();
        
        var answer = _answers[_index];
        AnswerTb.Text = answer.Data;
    }

    private void PreviousBtn_Click(object sender, EventArgs e)
    {
        if (_index <= 0) return;
        
        _index--;
        UpdateQuestionUI();
        
        var answer = _answers[_index];
        AnswerTb.Text = answer.Data;
    }
    

    private void SubmitBtn_Click(object sender, EventArgs e)
    {
        _answerService.AddRange(_answers);
        _timer.Stop();
        var time = _timerService.FormatTimeSpan(_timerService.Stop());
        var resultForm = new ViewResult(_questions, _answers, time);
        resultForm.Show();
        this.Close();
    }

    private Answer[] MapQuestionToAnswer()
    {
        var answers = _questions.Select(x => new Answer { QuestionId = x.Id} );
        return answers.ToArray();
    }

    private void AnswerTb_TextChanged(object sender, EventArgs e)
    {
        // Console.WriteLine(AnswerTb.Text);
        var answer = _answers[_index];
        answer.Data = AnswerTb.Text;
    }
    
    private void OnTimerTick(object? sender, EventArgs e)
    {
        TimerLbl.Text = _timerService.FormatTimeSpan(_timerService.Elapsed());
    }
}