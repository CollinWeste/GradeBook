// Copyright Collin Westenhaver 2017
// GradeBook +++

using System;
using System.ComponentModel;

namespace Gradebook
{
  /// <summary>
  /// Container for gradebook assignments
  /// </summary>
  public class Assignment : DataObject
  {
    public string Name
    {
      get { return _name; }
      set { _name = value; RaisePropertyChanged(); }
    }
    private string _name;

    public DateTime DueDate
    {
      get { return _dueDate; }
      set { _dueDate = value; RaisePropertyChanged(nameof(Due)); }
    }
    private DateTime _dueDate;

    public string Due => DueDate.ToShortDateString();

    public BindingList<Question> Questions { get; set; }
  }
}
