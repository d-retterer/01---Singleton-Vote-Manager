
// Design Patterns - Video Tutorials
// The Singleton Pattern
// By: Dave Retterer

#region Narrative
// The Singleton Pattern
//
// This demonstation is a very simple example of the Singleton Pattern.  There are lots of reasons to 
// use this pattern but some of them are beyond the introductory level as they deal with, for example,
// multiple threads gaining access to the singleton object.  I recommend that you refer to the 
// site 
//         a.	http://csharpindepth.com/Articles/General/Singleton.aspx  
// 
// because, even though it is somewhat old, it has a well presented discussion of thread-safe 
// singleton, simple singleton, and more as related to C# applications.
//
// In the video, I mention that this demonstration will be enhanced by adding observer pattern 
// funcitonality to update the VoteManager window when Voting Booth activity takes place.  You can
// find that code in the "06 - Observer Pattern" folder on GitHub and get some help with it in the 
// associated video tutorial.  
//
// The Gang of Four (GoF) definition of the Singleton Pattern is:
//
//    The Singleton Pattern is used to 
//              "ensure a class has only one instance, and 
//                    provide a global point of access to it."
// 
// The original UML Diagrams for the Design Patterns in the GoF book have been modernized to account
// new features in languages, some of which have been created because of the GoF book.
// The UML Diagram for the Singleton Pattern is 
//
//        +------------------------------+
//        |  Singleton                   |
//        +------------------------------+
//        | -singleton : Singleton       |
//        +------------------------------+
//        | -Singleton()                 |
//        | +getInstance() : Singleton   |
//        +------------------------------+

// indicating that the Singleton class has a property named singleton of type Singleton, a private
// constructor and a public method (named getInstance here) that returns a Singleton object.  Other 
// properties or fields and other methods are acceptable as long as they don't interfere with the 
// operation of the Singleton Pattern.
#endregion

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
  public partial class frmVoteManager : Form
  {
    private VoteManager vm;

    public frmVoteManager()
    {
      InitializeComponent();
      vm = VoteManager.getInstance();
      UpdateVoteTotals();
    }

    private void m_btnViewVoteTotals_Click(object sender, EventArgs e)
    {
      UpdateVoteTotals();
    }

    private void UpdateVoteTotals()
    {
      m_tbBobVotes.Text = vm.m_BobVotes.ToString();
      m_tbTomVotes.Text = vm.m_TomVotes.ToString();
    }

    private void m_btnCreateVotingBooth_Click(object sender, EventArgs e)
    {
      VotingBooth vb = new VotingBooth();
      vb.Show();
    }
  }
}
