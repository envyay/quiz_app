using System.ComponentModel;

namespace QuizApp;

partial class EditQuizForm
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
        TypeCB = new System.Windows.Forms.ComboBox();
        QuestionContentTB = new System.Windows.Forms.TextBox();
        ContentLbl = new System.Windows.Forms.Label();
        CorrectAnswerLbl = new System.Windows.Forms.Label();
        CorrectAnswerTB = new System.Windows.Forms.TextBox();
        ALbl = new System.Windows.Forms.Label();
        BLbl = new System.Windows.Forms.Label();
        CLbl = new System.Windows.Forms.Label();
        DLbl = new System.Windows.Forms.Label();
        ATB = new System.Windows.Forms.TextBox();
        BTB = new System.Windows.Forms.TextBox();
        CTB = new System.Windows.Forms.TextBox();
        DTB = new System.Windows.Forms.TextBox();
        SaveBtn = new System.Windows.Forms.Button();
        SuspendLayout();
        // 
        // TypeCB
        // 
        TypeCB.FormattingEnabled = true;
        TypeCB.Location = new System.Drawing.Point(16, 67);
        TypeCB.Name = "TypeCB";
        TypeCB.Size = new System.Drawing.Size(138, 23);
        TypeCB.TabIndex = 1;
        TypeCB.Text = "Question Type";
        TypeCB.SelectedIndexChanged += TypeCB_SelectedIndexChanged;
        // 
        // QuestionContentTB
        // 
        QuestionContentTB.Location = new System.Drawing.Point(18, 123);
        QuestionContentTB.Multiline = true;
        QuestionContentTB.Name = "QuestionContentTB";
        QuestionContentTB.Size = new System.Drawing.Size(481, 23);
        QuestionContentTB.TabIndex = 2;
        // 
        // ContentLbl
        // 
        ContentLbl.Location = new System.Drawing.Point(20, 105);
        ContentLbl.Name = "ContentLbl";
        ContentLbl.Size = new System.Drawing.Size(92, 15);
        ContentLbl.TabIndex = 3;
        ContentLbl.Text = "Content:";
        // 
        // CorrectAnswerLbl
        // 
        CorrectAnswerLbl.Location = new System.Drawing.Point(16, 166);
        CorrectAnswerLbl.Name = "CorrectAnswerLbl";
        CorrectAnswerLbl.Size = new System.Drawing.Size(91, 18);
        CorrectAnswerLbl.TabIndex = 4;
        CorrectAnswerLbl.Text = "Correct Answer:";
        // 
        // CorrectAnswerTB
        // 
        CorrectAnswerTB.Location = new System.Drawing.Point(16, 187);
        CorrectAnswerTB.Name = "CorrectAnswerTB";
        CorrectAnswerTB.Size = new System.Drawing.Size(483, 23);
        CorrectAnswerTB.TabIndex = 5;
        // 
        // ALbl
        // 
        ALbl.Font = new System.Drawing.Font("Segoe UI", 12F);
        ALbl.Location = new System.Drawing.Point(32, 234);
        ALbl.Name = "ALbl";
        ALbl.Size = new System.Drawing.Size(28, 23);
        ALbl.TabIndex = 6;
        ALbl.Text = "A.";
        // 
        // BLbl
        // 
        BLbl.Font = new System.Drawing.Font("Segoe UI", 12F);
        BLbl.Location = new System.Drawing.Point(32, 270);
        BLbl.Name = "BLbl";
        BLbl.Size = new System.Drawing.Size(28, 23);
        BLbl.TabIndex = 7;
        BLbl.Text = "B.";
        // 
        // CLbl
        // 
        CLbl.Font = new System.Drawing.Font("Segoe UI", 12F);
        CLbl.Location = new System.Drawing.Point(32, 310);
        CLbl.Name = "CLbl";
        CLbl.Size = new System.Drawing.Size(28, 23);
        CLbl.TabIndex = 8;
        CLbl.Text = "C.";
        // 
        // DLbl
        // 
        DLbl.Font = new System.Drawing.Font("Segoe UI", 12F);
        DLbl.Location = new System.Drawing.Point(32, 348);
        DLbl.Name = "DLbl";
        DLbl.Size = new System.Drawing.Size(28, 23);
        DLbl.TabIndex = 9;
        DLbl.Text = "D.";
        // 
        // ATB
        // 
        ATB.Location = new System.Drawing.Point(66, 234);
        ATB.Name = "ATB";
        ATB.Size = new System.Drawing.Size(433, 23);
        ATB.TabIndex = 10;
        // 
        // BTB
        // 
        BTB.Location = new System.Drawing.Point(66, 272);
        BTB.Name = "BTB";
        BTB.Size = new System.Drawing.Size(433, 23);
        BTB.TabIndex = 11;
        // 
        // CTB
        // 
        CTB.Location = new System.Drawing.Point(66, 310);
        CTB.Name = "CTB";
        CTB.Size = new System.Drawing.Size(433, 23);
        CTB.TabIndex = 12;
        // 
        // DTB
        // 
        DTB.Location = new System.Drawing.Point(66, 348);
        DTB.Name = "DTB";
        DTB.Size = new System.Drawing.Size(433, 23);
        DTB.TabIndex = 13;
        // 
        // SaveBtn
        // 
        SaveBtn.Location = new System.Drawing.Point(399, 394);
        SaveBtn.Name = "SaveBtn";
        SaveBtn.Size = new System.Drawing.Size(100, 23);
        SaveBtn.TabIndex = 14;
        SaveBtn.Text = "Save";
        SaveBtn.UseVisualStyleBackColor = true;
        SaveBtn.Click += SaveBtn_Click;
        // 
        // EditQuizForm
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(1010, 678);
        Controls.Add(SaveBtn);
        Controls.Add(DTB);
        Controls.Add(CTB);
        Controls.Add(BTB);
        Controls.Add(ATB);
        Controls.Add(DLbl);
        Controls.Add(CLbl);
        Controls.Add(BLbl);
        Controls.Add(ALbl);
        Controls.Add(CorrectAnswerTB);
        Controls.Add(CorrectAnswerLbl);
        Controls.Add(ContentLbl);
        Controls.Add(QuestionContentTB);
        Controls.Add(TypeCB);
        Text = "EditForm";
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.Button SaveBtn;

    private System.Windows.Forms.TextBox BTB;
    private System.Windows.Forms.TextBox CTB;
    private System.Windows.Forms.TextBox DTB;

    private System.Windows.Forms.Label BLbl;
    private System.Windows.Forms.Label CLbl;
    private System.Windows.Forms.Label DLbl;
    private System.Windows.Forms.TextBox ATB;

    private System.Windows.Forms.Label ALbl;

    private System.Windows.Forms.TextBox CorrectAnswerTB;

    private System.Windows.Forms.Label CorrectAnswerLbl;

    private System.Windows.Forms.Label ContentLbl;

    private System.Windows.Forms.TextBox QuestionContentTB;

    private System.Windows.Forms.ComboBox TypeCB;

    #endregion
}