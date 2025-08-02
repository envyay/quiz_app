using System.ComponentModel;

namespace QuizApp;

partial class PlayQuizForm
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
        QuestionTypeLbl = new System.Windows.Forms.Label();
        AnswerLbl = new System.Windows.Forms.Label();
        AnswerTb = new System.Windows.Forms.TextBox();
        QuestionContentTb = new System.Windows.Forms.TextBox();
        PreviousBtn = new System.Windows.Forms.Button();
        NextBtn = new System.Windows.Forms.Button();
        SubmitBtn = new System.Windows.Forms.Button();
        NoQuestionsLbl = new System.Windows.Forms.Label();
        TimerLbl = new System.Windows.Forms.Label();
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
        // QuestionTypeLbl
        // 
        QuestionTypeLbl.Location = new System.Drawing.Point(12, 70);
        QuestionTypeLbl.Name = "QuestionTypeLbl";
        QuestionTypeLbl.Size = new System.Drawing.Size(177, 20);
        QuestionTypeLbl.TabIndex = 1;
        QuestionTypeLbl.Text = "label1";
        // 
        // AnswerLbl
        // 
        AnswerLbl.Location = new System.Drawing.Point(12, 240);
        AnswerLbl.Name = "AnswerLbl";
        AnswerLbl.Size = new System.Drawing.Size(92, 24);
        AnswerLbl.TabIndex = 3;
        AnswerLbl.Text = "Answer:";
        // 
        // AnswerTb
        // 
        AnswerTb.Location = new System.Drawing.Point(12, 267);
        AnswerTb.Name = "AnswerTb";
        AnswerTb.Size = new System.Drawing.Size(134, 23);
        AnswerTb.TabIndex = 4;
        AnswerTb.TextChanged += AnswerTb_TextChanged;
        // 
        // QuestionContentTb
        // 
        QuestionContentTb.Location = new System.Drawing.Point(12, 93);
        QuestionContentTb.Multiline = true;
        QuestionContentTb.Name = "QuestionContentTb";
        QuestionContentTb.Size = new System.Drawing.Size(376, 137);
        QuestionContentTb.TabIndex = 2;
        // 
        // PreviousBtn
        // 
        PreviousBtn.Location = new System.Drawing.Point(163, 266);
        PreviousBtn.Name = "PreviousBtn";
        PreviousBtn.Size = new System.Drawing.Size(60, 23);
        PreviousBtn.TabIndex = 5;
        PreviousBtn.Text = "<";
        PreviousBtn.UseVisualStyleBackColor = true;
        PreviousBtn.Click += PreviousBtn_Click;
        // 
        // NextBtn
        // 
        NextBtn.Location = new System.Drawing.Point(229, 266);
        NextBtn.Name = "NextBtn";
        NextBtn.Size = new System.Drawing.Size(60, 23);
        NextBtn.TabIndex = 6;
        NextBtn.Text = ">";
        NextBtn.UseVisualStyleBackColor = true;
        NextBtn.Click += NextBtn_Click;
        // 
        // SubmitBtn
        // 
        SubmitBtn.Location = new System.Drawing.Point(308, 266);
        SubmitBtn.Name = "SubmitBtn";
        SubmitBtn.Size = new System.Drawing.Size(80, 23);
        SubmitBtn.TabIndex = 7;
        SubmitBtn.Text = "Submit";
        SubmitBtn.UseVisualStyleBackColor = true;
        SubmitBtn.Click += SubmitBtn_Click;
        // 
        // NoQuestionsLbl
        // 
        NoQuestionsLbl.Location = new System.Drawing.Point(321, 74);
        NoQuestionsLbl.Name = "NoQuestionsLbl";
        NoQuestionsLbl.Size = new System.Drawing.Size(67, 16);
        NoQuestionsLbl.TabIndex = 8;
        NoQuestionsLbl.Text = "1/100";
        NoQuestionsLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // TimerLbl
        // 
        TimerLbl.Font = new System.Drawing.Font("Segoe UI", 20F);
        TimerLbl.Location = new System.Drawing.Point(404, 9);
        TimerLbl.Name = "TimerLbl";
        TimerLbl.Size = new System.Drawing.Size(122, 42);
        TimerLbl.TabIndex = 9;
        TimerLbl.Text = "00:00:00";
        // 
        // PlayQuizForm
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(901, 557);
        Controls.Add(TimerLbl);
        Controls.Add(NoQuestionsLbl);
        Controls.Add(SubmitBtn);
        Controls.Add(NextBtn);
        Controls.Add(PreviousBtn);
        Controls.Add(AnswerTb);
        Controls.Add(AnswerLbl);
        Controls.Add(QuestionContentTb);
        Controls.Add(QuestionTypeLbl);
        Controls.Add(BackBtn);
        Text = "PlayQuizForm";
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.Label TimerLbl;

    private System.Windows.Forms.Label NoQuestionsLbl;

    private System.Windows.Forms.Button SubmitBtn;

    private System.Windows.Forms.Button PreviousBtn;
    private System.Windows.Forms.Button NextBtn;

    private System.Windows.Forms.Label AnswerLbl;
    private System.Windows.Forms.TextBox AnswerTb;

    private System.Windows.Forms.Label QuestionTypeLbl;
    private System.Windows.Forms.TextBox QuestionContentTb;

    private System.Windows.Forms.Button BackBtn;

    #endregion
}