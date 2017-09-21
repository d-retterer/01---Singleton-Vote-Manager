namespace Singleton_Vote_Manager
{
  partial class VotingBooth
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

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
      this.m_btnVoteForBob = new System.Windows.Forms.Button();
      this.m_btnVoteForTom = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // m_btnVoteForBob
      // 
      this.m_btnVoteForBob.Location = new System.Drawing.Point(88, 70);
      this.m_btnVoteForBob.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.m_btnVoteForBob.Name = "m_btnVoteForBob";
      this.m_btnVoteForBob.Size = new System.Drawing.Size(185, 37);
      this.m_btnVoteForBob.TabIndex = 0;
      this.m_btnVoteForBob.Text = "Vote for Bob";
      this.m_btnVoteForBob.UseVisualStyleBackColor = true;
      this.m_btnVoteForBob.Click += new System.EventHandler(this.m_btnVoteForBob_Click);
      // 
      // m_btnVoteForTom
      // 
      this.m_btnVoteForTom.Location = new System.Drawing.Point(88, 166);
      this.m_btnVoteForTom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.m_btnVoteForTom.Name = "m_btnVoteForTom";
      this.m_btnVoteForTom.Size = new System.Drawing.Size(185, 37);
      this.m_btnVoteForTom.TabIndex = 1;
      this.m_btnVoteForTom.Text = "Vote for Tom";
      this.m_btnVoteForTom.UseVisualStyleBackColor = true;
      this.m_btnVoteForTom.Click += new System.EventHandler(this.m_btnVoteForTom_Click);
      // 
      // VotingBooth
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(379, 322);
      this.Controls.Add(this.m_btnVoteForTom);
      this.Controls.Add(this.m_btnVoteForBob);
      this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.Name = "VotingBooth";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "VotingBooth";
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Button m_btnVoteForBob;
    private System.Windows.Forms.Button m_btnVoteForTom;
  }
}