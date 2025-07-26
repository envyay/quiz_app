namespace QuizApp;

public partial class PlayQuizForm : Form
{
    public PlayQuizForm()
    {
        InitializeComponent();
    }

    private void BackBtn_Click(object sender, EventArgs e)
    {
        var mainForm = new MainForm();
        mainForm.Show();
        this.Close();
    }
}