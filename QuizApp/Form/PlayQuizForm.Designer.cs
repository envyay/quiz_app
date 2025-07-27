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
        // PlayQuizForm
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(901, 557);
        Controls.Add(BackBtn);
        Text = "PlayQuizForm";
        ResumeLayout(false);
    }

    private System.Windows.Forms.Button BackBtn;

    #endregion
}