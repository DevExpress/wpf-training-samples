using System;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm;
using DevExpress.Mvvm.POCO;
using System.Collections.ObjectModel;

namespace sample_7_7.ViewModels {
  [POCOViewModel]
  public class TasksViewModel {
    protected TasksViewModel() { }

    public static TasksViewModel Create() {
      return ViewModelSource.Create(() => new TasksViewModel());
    }

    public virtual ObservableCollection<TaskViewModel> Tasks { get; set; }

    [ServiceProperty(SearchMode = ServiceSearchMode.PreferParents)]
    public virtual IDialogService DialogService { get { return null; } }

    public void EditTask(object taskObject) {
      var task = taskObject as TaskViewModel;
      if (task != null) {
        var taskClone = TaskViewModel.CreateFrom(task);

        if (DialogService.ShowDialog(
          MessageButton.OKCancel, "Edit Task", "TaskView", taskClone) == MessageResult.OK) {
          task.LoadFrom(taskClone);
        }
      }
    }
  }
}