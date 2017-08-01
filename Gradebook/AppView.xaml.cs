// Copyright Collin Westenhaver 2017
// GradeBook +++

using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using NGenerics.Extensions;

namespace Gradebook
{
  /// <summary>
  /// Interaction logic for AppView.xaml
  /// </summary>
  public partial class AppView : Window
  {
    public AssignmentViewModel AssignmentViewModel => AssignmentListView.DataContext as AssignmentViewModel;

    public AppView()
    {
      DataContext = this;
      InitializeComponent();
    }

    #region Commands

    public ICommand NewAssignmentCommand => new DelegateCommand(param =>
    {
      (AssignmentListView.DataContext as AssignmentViewModel)?.Assignments.AddNew();
    });

    public ICommand OpenAssignmentCommand => new DelegateCommand(param =>
    {
      // TODO:
    });

    public ICommand SaveAssignmentCommand => new DelegateCommand(param =>
    {
      // TODO:
    });

    #endregion

    private void AssignmentListView_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
    {
      AssignmentViewModel.CurrentAssignment = AssignmentListView.SelectedItem as Assignment;
    }
  }
}
