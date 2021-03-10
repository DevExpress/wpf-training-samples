using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace sample_4_10 {
  public class DiagramModel {
    public class Element {
      public int Id { get; set; }
      public Brush Brush { get; set; }
      public string Title { get; set; }
      public string Content { get; set; }
    }

    public class Connection {
      public int From { get; set; }
      public int To { get; set; }
    }

    public DiagramModel() {
      Elements = new List<Element> {
        new Element { Id = 1, Brush = Brushes.Red, Title = "Step 1: Initialization", Content = "Begin by making sure all values are initialized correctly" },
        new Element { Id = 2, Brush = Brushes.Aqua, Title = "Step 2: Processing", Content = "Process values and generate results" },
        new Element { Id = 3, Brush = Brushes.Yellow, Title = "Step 3: Output/Update", Content = "Push result values to the user interface, or update existing output with new results" }
      };

      Connections = new List<Connection> {
        new Connection { From = 1, To = 2 },
        new Connection { From = 2, To = 3 }
      };
    }

    public IEnumerable<Element> Elements { get; set; }
    public IEnumerable<Connection> Connections { get; set; }
  }
}
