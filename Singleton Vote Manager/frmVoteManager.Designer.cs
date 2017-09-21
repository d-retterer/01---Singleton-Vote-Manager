namespace Singleton_Vote_Manager
{
  partial class frmVoteManager
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
      this.m_btnCreateVotingBooth = new System.Windows.Forms.Button();
      this.m_btnViewVoteTotals = new System.Windows.Forms.Button();
      this.m_tbBobVotes = new System.Windows.Forms.TextBox();
      this.m_tbTomVotes = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // m_btnCreateVotingBooth
      // 
      this.m_btnCreateVotingBooth.Location = new System.Drawing.Point(53, 51);
      this.m_btnCreateVotingBooth.Name = "m_btnCreateVotingBooth";
      this.m_btnCreateVotingBooth.Size = new System.Drawing.Size(175, 55);
      this.m_btnCreateVotingBooth.TabIndex = 0;
      this.m_btnCreateVotingBooth.Text = "Create Voting Booth";
      this.m_btnCreateVotingBooth.UseVisualStyleBackColor = true;
      this.m_btnCreateVotingBooth.Click += new System.EventHandler(this.m_btnCreateVotingBooth_Click);
      // 
      // m_btnViewVoteTotals
      // 
      this.m_btnViewVoteTotals.Location = new System.Drawing.Point(53, 134);
      this.m_btnViewVoteTotals.Name = "m_btnViewVoteTotals";
      this.m_btnViewVoteTotals.Size = new System.Drawing.Size(175, 31);
      this.m_btnViewVoteTotals.TabIndex = 1;
      this.m_btnViewVoteTotals.Text = "View Vote Totals";
      this.m_btnViewVoteTotals.UseVisualStyleBackColor = true;
      this.m_btnViewVoteTotals.Click += new System.EventHandler(this.m_btnViewVoteTotals_Click);
      // 
      // m_tbBobVotes
      // 
      this.m_tbBobVotes.Location = new System.Drawing.Point(128, 182);
      this.m_tbBobVotes.Name = "m_tbBobVotes";
      this.m_tbBobVotes.Size = new System.Drawing.Size(100, 20);
      this.m_tbBobVotes.TabIndex = 2;
      this.m_tbBobVotes.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      // 
      // m_tbTomVotes
      // 
      this.m_tbTomVotes.Location = new System.Drawing.Point(128, 208);
      this.m_tbTomVotes.Name = "m_tbTomVotes";
      this.m_tbTomVotes.Size = new System.Drawing.Size(100, 20);
      this.m_tbTomVotes.TabIndex = 2;
      this.m_tbTomVotes.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(72, 185);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(26, 13);
      this.label1.TabIndex = 3;
      this.label1.Text = "Bob";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(72, 211);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(28, 13);
      this.label2.TabIndex = 3;
      this.label2.Text = "Tom";
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(284, 262);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.m_tbTomVotes);
      this.Controls.Add(this.m_tbBobVotes);
      this.Controls.Add(this.m_btnViewVoteTotals);
      this.Controls.Add(this.m_btnCreateVotingBooth);
      this.Name = "Form1";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Board of Elections";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button m_btnCreateVotingBooth;
    private System.Windows.Forms.Button m_btnViewVoteTotals;
    private System.Windows.Forms.TextBox m_tbBobVotes;
    private System.Windows.Forms.TextBox m_tbTomVotes;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;

  }
}

