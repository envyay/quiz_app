using QuizApp.Model;

namespace QuizApp;

public partial class ViewResult : Form
{
    private Label TimeLbl;
    public ViewResult(Question[] questions, Answer[] answers, string time)
    {
        
        InitializeComponent();
        var point = 0;
        var result = "";
        for (var i = 0; i < questions.Length; i++)
        {
            var question = questions[i];
            var answer = answers[i];

            result += question.GetQuestionContent(true);
            
            result += $"{answer.Data}{Environment.NewLine}";
            
            if (question.CorrectAnswer == answer.Data)
            {
                point++;
                result += $"✅ {Environment.NewLine}{Environment.NewLine}";
            }
            else
            {
                result += $"❌ {Environment.NewLine}{Environment.NewLine}";
            }
        }
        PointLbl.Text = $"{point}/{questions.Length} points";

        ResultTb.Text = result;
        ResultTb.Text += $"Time: {time}{Environment.NewLine}";
        ResultTb.ScrollBars = ScrollBars.Vertical;
    }

    private void BackBtn_Click(object sender, EventArgs e)
    {
        var mainForm = new MainForm();
        mainForm.Show();
        this.Close();
    }
}