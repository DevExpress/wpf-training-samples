using System;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm;
using DevExpress.Mvvm.POCO;

namespace sample_7_7.ViewModels {
  [POCOViewModel]
  public class TaskViewModel {
    protected TaskViewModel(string subject, DateTime dueDate) {
      this.Subject = subject;
      this.DueDate = dueDate;
    }

    protected TaskViewModel() : this("Something important", DateTime.Now.AddDays(1)) { }

    public static TaskViewModel Create(string subject, DateTime dueDate) {
      return ViewModelSource.Create(() =>
      new TaskViewModel(subject, dueDate));
    }

    public static TaskViewModel Create() {
      return ViewModelSource.Create(() => new TaskViewModel()); ;
    }

    public virtual string Subject { get; set; }
    public virtual DateTime DueDate { get; set; }

    public void Postpone() {
      DueDate = DueDate + TimeSpan.FromDays(1);
    }

    public virtual bool Done { get; set; }

    public bool CanMarkDone() {
      return !Done;
    }

    public void MarkDone() {
      if (MessageBoxService.ShowMessage(
        "Are you sure?", "Question",
        MessageButton.YesNo, MessageIcon.Question,
        MessageResult.No) == MessageResult.Yes)
        Done = true;
    }

    [ServiceProperty(SearchMode = ServiceSearchMode.PreferParents)]
    public virtual IMessageBoxService MessageBoxService { get { return null; } }
  }
}