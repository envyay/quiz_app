namespace QuizApp;

public partial class PlayQuizForm : Form
{
    private readonly int _examId;
    public PlayQuizForm(int examId)
    {
        _examId = examId;
        InitializeComponent();
    }

    private void BackBtn_Click(object sender, EventArgs e)
    {
        var mainForm = new MainForm();
        mainForm.Show();
        this.Close();
    }
}