
using QuizApp.Common;
using QuizApp.Model;
using QuizApp.Service;

namespace QuizApp;

public partial class EditQuizForm : Form
{
    private Question? _question;
    private int? _examId;
    private readonly QuestionService _questionService;
    public EditQuizForm()
    {
        _questionService = new QuestionService();
        InitializeComponent();
        HideABCD();
        TypeCB.Items.AddRange(new string[] { "Multiple Choice", "True/False", "Open Ended" });
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
        // A
        ALbl.Hide();
        ATB.Hide();

        // B
        BLbl.Hide();
        BTB.Hide();

        // C
        CLbl.Hide();
        CTB.Hide();

        // D
        DLbl.Hide();
        DTB.Hide();
    }

    void ShowABCD()
    {
        // A
        ALbl.Show();
        ATB.Show();
        // B
        BLbl.Show();
        BTB.Show();
        // C
        CLbl.Show();
        CTB.Show();
        // D
        DLbl.Show();
        DTB.Show();
    }

    public void LoadQuestion(int examId, Question selectedQuestion)
    {
        _examId = examId;
        _question = selectedQuestion;
        if (selectedQuestion == null)
        {
            MessageBox.Show("No question selected to edit.");
            return;
        }
        TypeCB.SelectedItem = Constants.QuestionTypeName(selectedQuestion.Type);
        

        switch (selectedQuestion.Type)
        {
            case Constants.MULTIPLE_CHOICE:
                ShowABCD();
                QuestionContentTB.Text = selectedQuestion.Content;
                CorrectAnswerTB.Text = selectedQuestion.CorrectAnswer;
                ATB.Text = selectedQuestion.A;
                BTB.Text = selectedQuestion.B;
                CTB.Text = selectedQuestion.C;
                DTB.Text = selectedQuestion.D;
                    break;
            
            case Constants.TRUE_FALSE:
                HideABCD();
                QuestionContentTB.Text = selectedQuestion.Content;
                CorrectAnswerTB.Text = selectedQuestion.CorrectAnswer;
                break;
            case Constants.OPEN_ENDED:
                HideABCD();
                QuestionContentTB.Text = selectedQuestion.Content;
                CorrectAnswerTB.Text = selectedQuestion.CorrectAnswer;
                break;
            default:
                break;
                
        }
    }

    private void SaveBtn_Click(object sender, EventArgs e)
    {
        var typeName = TypeCB.SelectedItem?.ToString() ?? "";
        var typeId = Constants.QuestionType(typeName);

        var content = QuestionContentTB.Text ?? "";
        var correctAnswer = CorrectAnswerTB.Text ?? "";
        
        if(_question == null)
        {
            MessageBox.Show("No question loaded to edit.");
            return;
        }
        
        _question.Type = typeId;
        _question.Content = content;
        _question.CorrectAnswer = correctAnswer;
        _question.A = ATB.Text;
        _question.B = BTB.Text;
        _question.C = CTB.Text;
        _question.D = DTB.Text;

        _questionService.Update(_question);
        MessageBox.Show("Question updated successfully.");
        this.Close();
        var createForm =  new CreateQuizForm(_examId);
        createForm.Show();
    }
}    