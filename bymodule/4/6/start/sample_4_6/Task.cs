using System;
using System.Collections.Generic;

namespace sample_4_6 {
  public class Task {
    public int Id { get; set; }
    public int? ParentId { get; set; }

    public string Name { get; set; }
    
    public DateTime? StartDate { get; set; }
    public TimeSpan Duration { get; set; }
    
    public string Extra { get; set; }
    
    public IEnumerable<int> Predecessors { get; set; }
  }
}