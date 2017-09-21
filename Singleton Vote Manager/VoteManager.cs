using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Singleton_Vote_Manager
{
  public class VoteManager  // This is the singleton class
  {
    // Properties
    private int _BobVotes;

    public int m_BobVotes
    {
      get
      {
        return _BobVotes;
      }

      set
      {
        _BobVotes = value;
      }

    }

    private int _TomVotes;

    public int m_TomVotes
    {
      get
      {
        return _TomVotes;
      }

      set
      {
        _TomVotes = value;
      }

    }

    private static VoteManager _VMInstance;

    // Methods
    private VoteManager()  // This is the singleton's private constructor.
    {
      m_BobVotes = 0;
      m_TomVotes = 0;
    }

    public static VoteManager getInstance()
    {

      if (_VMInstance == null)
      {
        _VMInstance = new VoteManager();
      }
      return _VMInstance;
    }

    public void VoteForBob()
    {
      m_BobVotes++;
    }

    public void VoteForTom()
    {
      m_TomVotes++;
    }
  }
}
