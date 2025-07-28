using System.ComponentModel;

namespace QuizApp;

partial class ViewResult
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
        ResultTb = new System.Windows.Forms.TextBox();
        ViewResultLbl = new System.Windows.Forms.Label();
        PointLbl = new System.Windows.Forms.Label();
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
        // ResultTb
        // 
        ResultTb.Location = new System.Drawing.Point(17, 85);
        ResultTb.Multiline = true;
        ResultTb.Name = "ResultTb";
        ResultTb.Size = new System.Drawing.Size(419, 487);
        ResultTb.TabIndex = 1;
        // 
        // ViewResultLbl
        // 
        ViewResultLbl.Location = new System.Drawing.Point(17, 58);
        ViewResultLbl.Name = "ViewResultLbl";
        ViewResultLbl.Size = new System.Drawing.Size(95, 24);
        ViewResultLbl.TabIndex = 2;
        ViewResultLbl.Text = "View Result:";
        ViewResultLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // PointLbl
        // 
        PointLbl.Location = new System.Drawing.Point(341, 58);
        PointLbl.Name = "PointLbl";
        PointLbl.Size = new System.Drawing.Size(95, 24);
        PointLbl.TabIndex = 3;
        PointLbl.Text = "1/100 points";
        PointLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // ViewResult
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(800, 584);
        Controls.Add(PointLbl);
        Controls.Add(ViewResultLbl);
        Controls.Add(ResultTb);
        Controls.Add(BackBtn);
        Text = "ViewResult";
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.Label ViewResultLbl;
    private System.Windows.Forms.Label PointLbl;

    private System.Windows.Forms.Button BackBtn;
    private System.Windows.Forms.TextBox ResultTb;

    #endregion
}