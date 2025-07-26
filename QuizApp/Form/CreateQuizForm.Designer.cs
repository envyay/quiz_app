using System.ComponentModel;

namespace QuizApp;

partial class CreateQuizForm
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }

        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        BackBtn = new System.Windows.Forms.Button();
        TypeCB = new System.Windows.Forms.ComboBox();
        QuestionContentLbl = new System.Windows.Forms.Label();
        QuestionContentTB = new System.Windows.Forms.TextBox();
        CorrectAnswerLbl = new System.Windows.Forms.Label();
        CorrectAnswerTB = new System.Windows.Forms.TextBox();
        ATB = new System.Windows.Forms.TextBox();
        BTB = new System.Windows.Forms.TextBox();
        CTB = new System.Windows.Forms.TextBox();
        DTB = new System.Windows.Forms.TextBox();
        ALbl = new System.Windows.Forms.Label();
        BLbl = new System.Windows.Forms.Label();
        CLbl = new System.Windows.Forms.Label();
        DLbl = new System.Windows.Forms.Label();
        AddBtn = new System.Windows.Forms.Button();
        QuestionsLB = new System.Windows.Forms.ListBox();
        QuestionsLbl = new System.Windows.Forms.Label();
        SuspendLayout();
        // 
        // BackBtn
        // 
        BackBtn.Location = new System.Drawing.Point(12, 12);
        BackBtn.Name = "BackBtn";
        BackBtn.Size = new System.Drawing.Size(100, 28);
        BackBtn.TabIndex = 0;
        BackBtn.Text = "Back";
        BackBtn.UseVisualStyleBackColor = true;
        BackBtn.Click += BackBtn_Click;
        // 
        // TypeCB
        // 
        TypeCB.FormattingEnabled = true;
        TypeCB.Items.AddRange(new object[] { "Multiple Choice", "True/False", "Open Ended" });
        TypeCB.Location = new System.Drawing.Point(12, 67);
        TypeCB.Name = "TypeCB";
        TypeCB.Size = new System.Drawing.Size(138, 23);
        TypeCB.TabIndex = 1;
        TypeCB.Text = "Question Type";
        TypeCB.SelectedIndexChanged += TypeCB_SelectedIndexChanged;
        // 
        // QuestionContentLbl
        // 
        QuestionContentLbl.Location = new System.Drawing.Point(12, 125);
        QuestionContentLbl.Name = "QuestionContentLbl";
        QuestionContentLbl.Size = new System.Drawing.Size(100, 19);
        QuestionContentLbl.TabIndex = 2;
        QuestionContentLbl.Text = "Content:";
        // 
        // QuestionContentTB
        // 
        QuestionContentTB.Location = new System.Drawing.Point(12, 147);
        QuestionContentTB.Multiline = true;
        QuestionContentTB.Name = "QuestionContentTB";
        QuestionContentTB.Size = new System.Drawing.Size(475, 221);
        QuestionContentTB.TabIndex = 3;
        // 
        // CorrectAnswerLbl
        // 
        CorrectAnswerLbl.Location = new System.Drawing.Point(12, 386);
        CorrectAnswerLbl.Name = "CorrectAnswerLbl";
        CorrectAnswerLbl.Size = new System.Drawing.Size(100, 21);
        CorrectAnswerLbl.TabIndex = 4;
        CorrectAnswerLbl.Text = "Correct Answer:";
        // 
        // CorrectAnswerTB
        // 
        CorrectAnswerTB.Location = new System.Drawing.Point(14, 410);
        CorrectAnswerTB.Name = "CorrectAnswerTB";
        CorrectAnswerTB.Size = new System.Drawing.Size(475, 23);
        CorrectAnswerTB.TabIndex = 5;
        // 
        // ATB
        // 
        ATB.Location = new System.Drawing.Point(56, 494);
        ATB.Name = "ATB";
        ATB.Size = new System.Drawing.Size(433, 23);
        ATB.TabIndex = 6;
        // 
        // BTB
        // 
        BTB.Location = new System.Drawing.Point(56, 537);
        BTB.Name = "BTB";
        BTB.Size = new System.Drawing.Size(433, 23);
        BTB.TabIndex = 7;
        // 
        // CTB
        // 
        CTB.Location = new System.Drawing.Point(56, 582);
        CTB.Name = "CTB";
        CTB.Size = new System.Drawing.Size(433, 23);
        CTB.TabIndex = 8;
        // 
        // DTB
        // 
        DTB.Location = new System.Drawing.Point(56, 629);
        DTB.Name = "DTB";
        DTB.Size = new System.Drawing.Size(433, 23);
        DTB.TabIndex = 9;
        // 
        // ALbl
        // 
        ALbl.Font = new System.Drawing.Font("Segoe UI", 12F);
        ALbl.Location = new System.Drawing.Point(22, 494);
        ALbl.Name = "ALbl";
        ALbl.Size = new System.Drawing.Size(28, 23);
        ALbl.TabIndex = 10;
        ALbl.Text = "A.";
        // 
        // BLbl
        // 
        BLbl.Font = new System.Drawing.Font("Segoe UI", 12F);
        BLbl.Location = new System.Drawing.Point(22, 537);
        BLbl.Name = "BLbl";
        BLbl.Size = new System.Drawing.Size(34, 23);
        BLbl.TabIndex = 11;
        BLbl.Text = "B.";
        // 
        // CLbl
        // 
        CLbl.Font = new System.Drawing.Font("Segoe UI", 12F);
        CLbl.Location = new System.Drawing.Point(22, 582);
        CLbl.Name = "CLbl";
        CLbl.Size = new System.Drawing.Size(34, 23);
        CLbl.TabIndex = 12;
        CLbl.Text = "C.";
        // 
        // DLbl
        // 
        DLbl.Font = new System.Drawing.Font("Segoe UI", 12F);
        DLbl.Location = new System.Drawing.Point(22, 629);
        DLbl.Name = "DLbl";
        DLbl.Size = new System.Drawing.Size(34, 23);
        DLbl.TabIndex = 13;
        DLbl.Text = "D.";
        // 
        // AddBtn
        // 
        AddBtn.Location = new System.Drawing.Point(12, 684);
        AddBtn.Name = "AddBtn";
        AddBtn.Size = new System.Drawing.Size(100, 28);
        AddBtn.TabIndex = 14;
        AddBtn.Text = "Add";
        AddBtn.UseVisualStyleBackColor = true;
        AddBtn.Click += AddBtn_Click;
        // 
        // QuestionsLB
        // 
        QuestionsLB.FormattingEnabled = true;
        QuestionsLB.Location = new System.Drawing.Point(586, 79);
        QuestionsLB.Name = "QuestionsLB";
        QuestionsLB.Size = new System.Drawing.Size(466, 289);
        QuestionsLB.TabIndex = 15;
        // 
        // QuestionsLbl
        // 
        QuestionsLbl.Location = new System.Drawing.Point(586, 59);
        QuestionsLbl.Name = "QuestionsLbl";
        QuestionsLbl.Size = new System.Drawing.Size(100, 19);
        QuestionsLbl.TabIndex = 16;
        QuestionsLbl.Text = "Questions:";
        // 
        // CreateQuizForm
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(1048, 721);
        Controls.Add(QuestionsLbl);
        Controls.Add(QuestionsLB);
        Controls.Add(AddBtn);
        Controls.Add(DLbl);
        Controls.Add(CLbl);
        Controls.Add(BLbl);
        Controls.Add(ALbl);
        Controls.Add(DTB);
        Controls.Add(CTB);
        Controls.Add(BTB);
        Controls.Add(ATB);
        Controls.Add(CorrectAnswerTB);
        Controls.Add(CorrectAnswerLbl);
        Controls.Add(QuestionContentTB);
        Controls.Add(QuestionContentLbl);
        Controls.Add(TypeCB);
        Controls.Add(BackBtn);
        Text = "CreateQuizForm";
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.Label QuestionsLbl;

    private System.Windows.Forms.Button AddBtn;
    private System.Windows.Forms.ListBox QuestionsLB;

    private System.Windows.Forms.Label CorrectAnswerLbl;
    private System.Windows.Forms.TextBox CorrectAnswerTB;
    private System.Windows.Forms.TextBox ATB;
    private System.Windows.Forms.TextBox BTB;
    private System.Windows.Forms.TextBox CTB;
    private System.Windows.Forms.TextBox DTB;
    private System.Windows.Forms.Label ALbl;
    private System.Windows.Forms.Label BLbl;
    private System.Windows.Forms.Label CLbl;
    private System.Windows.Forms.Label DLbl;

    private System.Windows.Forms.TextBox QuestionContentTB;

    private System.Windows.Forms.Label QuestionContentLbl;

    private System.Windows.Forms.ComboBox TypeCB;

    private System.Windows.Forms.Button BackBtn;

    #endregion
}