namespace QuizApp;

public partial class MainForm : Form
{
    public MainForm()
    {
        InitializeComponent();
    }

    private void CreateQuizBtn_Click(object sender, EventArgs e)
    {
        var createQuizForm = new CreateQuizForm();
        createQuizForm.Show();
        this.Hide();
    }

    private void CloseAppBtn_Click(object sender, EventArgs e)
    {
        this.Close();
    }

    private void PlayQuizBtn_Click(object sender, EventArgs e)
    {
        var playQuizForm = new PlayQuizForm();
        playQuizForm.Show();
        this.Hide();
    }
}