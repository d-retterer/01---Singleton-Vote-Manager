using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Singleton_Vote_Manager
{
  public partial class VotingBooth : Form
  {
    VoteManager vm;

    public VotingBooth()
    {
      InitializeComponent();
      vm = VoteManager.getInstance();
    }

    private void m_btnVoteForBob_Click(object sender, EventArgs e)
    {
      vm.VoteForBob();
     }

    private void m_btnVoteForTom_Click(object sender, EventArgs e)
    {
      vm.VoteForTom();
    }
  }
}
