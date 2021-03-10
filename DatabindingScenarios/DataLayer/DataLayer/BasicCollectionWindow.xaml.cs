using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using DevExpress.Xpf.Core;


namespace DataLayer {

  public partial class BasicCollectionWindow : DevExpress.Xpf.Core.ThemedWindow {
    public BasicCollectionWindow() {
      InitializeComponent();
    }
  }

  public class Person {
    public string Name { get; set; }
    public int Age { get; set; }

  }

  public class BasicCollectionViewModel {
    public BasicCollectionViewModel() {
      People = new List<Person>{
        new Person{Name="Ralph", Age=77},
        new Person{Name="Oliver", Age=23},
       new Person{Name="Harry", Age=72},
       new Person{Name="Anna", Age=38}
      };
    }

    public IList<Person> People { get; private set; }
  }
}
