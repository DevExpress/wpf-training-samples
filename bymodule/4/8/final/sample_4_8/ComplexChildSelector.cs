using DevExpress.Xpf.Grid;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sample_4_8 {
  public class ComplexChildSelector : IChildNodesSelector {
    public IEnumerable SelectChildren(object item) {
      if (item is TreeListViewModel.ComplexItemWithCustomChild1 cicc1)
        return cicc1.Type1Children;
      else if (item is TreeListViewModel.ComplexItemWithCustomChild2 cicc2)
        return cicc2.GetChildrenOfType2();
      else
        return null;
    }
  }
}
