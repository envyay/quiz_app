using QuizApp.Common;

namespace QuizApp;

public partial class CreateQuizForm : Form
{
    public CreateQuizForm()
    {
        InitializeComponent();
        HideABCD();
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
        
        var typeName = TypeCB.SelectedItem?.ToString() ?? "";
        var typeId = Constants.QuestionType(typeName);
        
        var content = QuestionContentTB.Text ?? "";
        var correctAnswer = CorrectAnswerTB.Text ?? "";
        

        if (typeId == Constants.MULTIPLE_CHOICE)
        {
            var aContent = ATB.Text ?? "";
            var bContent = BTB.Text ?? "";
            var cContent = CTB.Text ?? "";
            var dContent = DTB.Text ?? "";
        }
        else
        {
            
        }
        
    }
}