using System;
using System.Collections.Generic;

namespace sample_4_6 {
  public class GanttViewModel {
    public GanttViewModel() {
      var today = DateTime.Today;
      var tomorrow = today.AddDays(1);

      var tasks = new List<Task> {
        new Task { Id=1, Name="Check out DevExpress WPF components",
          StartDate=today, Duration=TimeSpan.FromHours(16), Extra="Important job" },

        new Task { Id=2, ParentId=1, Name="Gantt Control",
          StartDate=today, Duration=TimeSpan.FromHours(4), Extra="Project planning" },

        new Task { Id=3, ParentId=1, Name="Data Grid",
          StartDate=tomorrow, Duration=TimeSpan.FromHours(6), Extra="Data overviews" },

        new Task { Id=4, ParentId=1, Name="... others",
          StartDate=tomorrow, Duration=TimeSpan.FromHours(4) },

        new Task { Id=5, Name="MVVM with DevExpress",
          Duration = TimeSpan.FromHours(8), Predecessors = new List<int> { 1 } },

        new Task { Id=6, Name="Create own DevExpress WPF based application",
          Duration = TimeSpan.FromHours(1), Predecessors = new List<int> { 1, 5 } }
      };
      Tasks = tasks;
    }

    public IEnumerable<Task> Tasks { get; set; }
  }
}