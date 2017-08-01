using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NGenerics.Extensions;

namespace Gradebook
{
  public class StudentViewModel
  {
    public BindingList<Student> Students { get; set; }

    public void SetAssignment(Assignment assignment)
    {
      Students.ForEach(x => x.Scores = x.AssignmentScores[assignment]);
    }
  }
}
