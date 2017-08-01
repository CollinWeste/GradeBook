// Copyright Collin Westenhaver 2017
// GradeBook +++

using System.ComponentModel;
using System.Runtime.CompilerServices;
using Gradebook.Annotations;

namespace Gradebook
{
  /// <summary>
  /// Base class for all objects who need to notify changes
  /// </summary>
  public abstract class DataObject : INotifyPropertyChanged
  {
    public event PropertyChangedEventHandler PropertyChanged;
    
    [NotifyPropertyChangedInvocator]
    protected virtual void RaisePropertyChanged([CallerMemberName] string propertyName = null)
    {
      PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
  }
}
