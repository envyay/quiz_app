﻿using QuizApp.Common;
using QuizApp.Model;
using QuizApp.Service;
using Timer = System.Threading.Timer;

namespace QuizApp;

public partial class CreateQuizForm : Form
{
    private readonly QuestionService _questionService;
    private readonly ExamService _examService;
    private readonly int _examId;

    public CreateQuizForm(int? examId = null)
    {
        _questionService = new QuestionService();
        _examService = new ExamService();
        InitializeComponent();
        HideABCD();

        _examId = examId ?? CreateExam();
        GetQuestionsLB();
    }

    private void BackBtn_Click(object sender, EventArgs e)
    {
        var mainForm = new MainForm();
        mainForm.Show();
        this.Close();
    }

    private void TypeCB_SelectedIndexChanged(object sender, EventArgs e)
    {
        var typeName = TypeCB.SelectedItem?.ToString() ?? "";
        var typeId = Constants.QuestionType(typeName);

        switch (typeId)
        {
            case Constants.MULTIPLE_CHOICE:
                ShowABCD();
                break;
            case Constants.TRUE_FALSE:
            case Constants.OPEN_ENDED:
                HideABCD();
                break;
            default:
                break;
        }
    }

    void HideABCD()
    {
        /// A
        ALbl.Hide();
        ATB.Hide();

        /// B
        BLbl.Hide();
        BTB.Hide();

        /// C
        CLbl.Hide();
        CTB.Hide();

        /// D
        DLbl.Hide();
        DTB.Hide();
    }

    void ShowABCD()
    {
        /// A
        ALbl.Show();
        ATB.Show();

        /// B
        BLbl.Show();
        BTB.Show();

        /// C
        CLbl.Show();
        CTB.Show();

        /// D
        DLbl.Show();
        DTB.Show();
    }

    private void AddBtn_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(QuestionContentTB.Text) ||
            string.IsNullOrWhiteSpace(CorrectAnswerTB.Text) ||
            TypeCB.SelectedIndex == -1)
        {
            MessageBox.Show("Please fill in all required fields.");
            return;
        }
        
        if (ATB == null || BTB == null || CTB == null || DTB == null)
        {
            MessageBox.Show("Please fill in all options for multiple choice questions.");
            return;
        }
        
        var typeName = TypeCB.SelectedItem?.ToString() ?? "";
        var type = Constants.QuestionType(typeName);

        var content = QuestionContentTB.Text ?? "";
        var correctAnswer = CorrectAnswerTB.Text ?? "";
        var aContent = ATB.Text ?? "";
        var bContent = BTB.Text ?? "";
        var cContent = CTB.Text ?? "";
        var dContent = DTB.Text ?? "";

        var question = new Question
        {
            Content = content,
            Type = type,
            A = aContent,
            B = bContent,
            C = cContent,
            D = dContent,
            CorrectAnswer = correctAnswer,
            ExamId = _examId
        };

        _questionService.Add(question);
        
        QuestionContentTB.Clear();
        CorrectAnswerTB.Clear();
        ATB.Clear();
        BTB.Clear();
        CTB.Clear();
        DTB.Clear();
        TypeCB.SelectedIndex = -1;

        QuestionContentTB.Focus();

        GetQuestionsLB();
    }

    public void GetQuestionsLB()
    {
        QuestionsLB.Items.Clear();
        var questions = _questionService.GetQuestionsByExamId(_examId).Select(x => x.ToString()).ToArray();
        QuestionsLB.Items.AddRange(questions);
    }


    public int CreateExam()
    {
        var exam = new Exam
        {
            Name = DateTime.Now.ToLongTimeString(),
        };
        var newExam = _examService.AddExam(exam);
        return newExam.Id;
    }

    private void PlayBtn_Click(object sender, EventArgs e)
    {
        var PlayForm = new PlayQuizForm(_examId);
        PlayForm.Show();
        this.Hide();
    }


    private void EditBtn_Click(object sender, EventArgs e)
    {
        var EditForm = new EditQuizForm();
        
        int selectedIndex = QuestionsLB.SelectedIndex;
        if (selectedIndex >= 0 && selectedIndex < QuestionsLB.Items.Count)
        {
            var selectedQuestion = _questionService.GetQuestionsByExamId(_examId)[selectedIndex];
            EditForm.LoadQuestion(_examId, selectedQuestion);
            EditForm.Show();
            this.Close();
        }
        else
        {
            MessageBox.Show("Please select a question to edit.");
        }
    }

    private void DeleteBtn_Click(object sender, EventArgs e)
    {
        int selectedIndex = QuestionsLB.SelectedIndex;
        if (selectedIndex >= 0 && selectedIndex < QuestionsLB.Items.Count)
        {
            var question = _questionService.GetQuestionsByExamId(_examId)[selectedIndex];
            _questionService.Delete(question.Id);
            GetQuestionsLB();
        }
        else
        {
            MessageBox.Show("Please select a question to delete.");
        }
    }
}