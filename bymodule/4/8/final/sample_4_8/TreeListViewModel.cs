using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sample_4_8 {
  public class TreeListViewModel {
    public class SelfReferencingItem {
      public int Id { get; set; }
      public int? ParentId { get; set; }
      public string Name { get; set; }
    }

    public IEnumerable<SelfReferencingItem> SelfReferencingData { get; set; }

    public class HierarchicalItem {
      public string Name { get; set; }
      public IEnumerable<HierarchicalItem> Children { get; set; }
    }

    public IEnumerable<HierarchicalItem> HierarchicalData { get; set; }

    public abstract class ComplexHierarchicalItemBase {
      public string Name { get; set; }
    }

    public class ComplexItemWithChild1 : ComplexHierarchicalItemBase {
      public string ComplexItemWithChild1Property { get; set; }
      public IEnumerable<ChildType1> Children { get; set; }
    }

    public class ComplexItemWithChild2 : ComplexHierarchicalItemBase {
      public string ComplexItemWithChild2Property { get; set; }
      public IEnumerable<ChildType2> Children { get; set; }
    }

    public class ChildType1 {
      public string StrVal { get; set; }
    }

    public class ChildType2 {
      public int IntVal { get; set; }
    }

    public IEnumerable<ComplexHierarchicalItemBase> ComplexHierarchicalDataSameChildCollection { get; set; }

    public class ComplexItemWithCustomChild1 : ComplexHierarchicalItemBase {
      public IEnumerable<ChildType1> Type1Children { get; set; }
    }

    public class ComplexItemWithCustomChild2 : ComplexHierarchicalItemBase {
      public IEnumerable<ChildType2> GetChildrenOfType2() {
        return new List<ChildType2> {
          new ChildType2 { IntVal = 42 },
          new ChildType2 { IntVal = 101 }
        };
      }
    }

    public IEnumerable<ComplexHierarchicalItemBase> ComplexHierarchicalDataDifferentChildStructures { get; set; }

    public TreeListViewModel() {
      SelfReferencingData = new List<SelfReferencingItem> {
        new SelfReferencingItem { Id = 1, Name = "Root" },
        new SelfReferencingItem { Id = 2, ParentId = 1, Name = "Sub 1" },
        new SelfReferencingItem { Id = 3, ParentId = 1, Name = "Sub 2" },
        new SelfReferencingItem { Id = 4, ParentId = 2, Name = "Sub Sub 1" }
      };

      HierarchicalData = new List<HierarchicalItem> {
        new HierarchicalItem { Name = "Root", Children = new List<HierarchicalItem> {
          new HierarchicalItem { Name = "Sub 1", Children = new List<HierarchicalItem> {
            new HierarchicalItem { Name = "Sub Sub 1" }
          } },
          new HierarchicalItem { Name = "Sub 2" }
        } }
      };

      ComplexHierarchicalDataSameChildCollection = new List<ComplexHierarchicalItemBase> {
        new ComplexItemWithChild1 {
          Name = "Complex Item 1",
          ComplexItemWithChild1Property = "Complex Item with Child Type 1",
          Children = new List<ChildType1> {
            new ChildType1 { StrVal = "Child Type 1" }
          }
        },
        new ComplexItemWithChild2 {
          Name = "Complex Item 2",
          ComplexItemWithChild2Property = "Complex Item with Child Type 2",
          Children = new List<ChildType2> {
            new ChildType2 { IntVal = 42 }
          }
        }
      };

      ComplexHierarchicalDataDifferentChildStructures = new List<ComplexHierarchicalItemBase> {
        new ComplexItemWithCustomChild1 { Name = "Complex Item 1", Type1Children = new List<ChildType1> {
          new ChildType1 { StrVal = "Child Type 1" }
        } },
        new ComplexItemWithCustomChild2 { Name = "Complex Item 2" }
      };
    }
  }
}
