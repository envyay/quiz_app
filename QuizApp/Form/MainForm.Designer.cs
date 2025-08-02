namespace QuizApp;

partial class MainForm
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
        CreateQuizBtn = new System.Windows.Forms.Button();
        CloseAppBtn = new System.Windows.Forms.Button();
        SuspendLayout();
        // 
        // CreateQuizBtn
        // 
        CreateQuizBtn.Location = new System.Drawing.Point(66, 96);
        CreateQuizBtn.Name = "CreateQuizBtn";
        CreateQuizBtn.Size = new System.Drawing.Size(459, 30);
        CreateQuizBtn.TabIndex = 0;
        CreateQuizBtn.Text = "Create Quiz";
        CreateQuizBtn.UseVisualStyleBackColor = true;
        CreateQuizBtn.Click += CreateQuizBtn_Click;
        // 
        // CloseAppBtn
        // 
        CloseAppBtn.Location = new System.Drawing.Point(66, 143);
        CloseAppBtn.Name = "CloseAppBtn";
        CloseAppBtn.Size = new System.Drawing.Size(459, 30);
        CloseAppBtn.TabIndex = 2;
        CloseAppBtn.Text = "Close App";
        CloseAppBtn.UseVisualStyleBackColor = true;
        CloseAppBtn.Click += CloseAppBtn_Click;
        // 
        // MainForm
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(590, 294);
        Controls.Add(CloseAppBtn);
        Controls.Add(CreateQuizBtn);
        Text = "Main Form";
        ResumeLayout(false);
    }

    private System.Windows.Forms.Button CloseAppBtn;

    private System.Windows.Forms.Button CreateQuizBtn;

    #endregion
}