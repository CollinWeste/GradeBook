using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gradebook
{
  public class Student : DataObject
  {
    public Dictionary<Assignment, BindingList<Score>> AssignmentScores { get; set; }

    public BindingList<Score> Scores
    {
      get { return _scores; }
      set { _scores = value; RaisePropertyChanged(); }
    }
    private BindingList<Score> _scores;
  }
}
