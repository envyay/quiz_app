using QuizApp.Common;

namespace QuizApp;

public partial class CreateQuizForm : Form
{
    public CreateQuizForm()
    {
        InitializeComponent();
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
                break;
            case Constants.TRUE_FALSE:
                break;
            case Constants.OPEN_ENDED:
                break;
            default:
                break;
        }
    }
}