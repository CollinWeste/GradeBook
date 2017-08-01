// Copyright Collin Westenhaver 2017
// GradeBook +++

using System.ComponentModel;

namespace Gradebook
{
  public class AssignmentViewModel : DataObject
  {
    public BindingList<Assignment> Assignments { get; }

    public Assignment CurrentAssignment
    {
      get { return _assignment; }
      set { _assignment = value; RaisePropertyChanged(); }
    }
    private Assignment _assignment;

    public AssignmentViewModel()
    {
      Assignments = new BindingList<Assignment>()
      {
        new Assignment(){Name="asdfa"}, new Assignment(){Name="sdfasdfa"}
      };

      Assignments.ListChanged += (sender, args) =>
      {
        // w/e needed
      };
    }
  }
}
