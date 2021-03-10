using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm.POCO;
using System;
using System.Windows;

namespace DXBindingDemo {
  public class UserViewModel {
    public string FirstName { get; set; }
    public string LastName { get; set; }
  }

  public class ViewModel {
    public ViewModel() {
      Owner = new UserViewModel { FirstName = "Agatha", LastName = "Christie" };
      SimpleString = "This is a string";
      SimpleInt = 101;
    }

    public UserViewModel Owner { get; set; }

    public string SimpleString { get; set; }
    public int SimpleInt { get; set; }

    public int Square(int x) => x * x;
    public int Sqrt(int x) => (int)Math.Round(Math.Sqrt(x));

    public bool Check1 { get; set; }
    public bool Check2 { get; set; }

    public void DoSomething(string arg1, int arg2) {
      MessageBox.Show($"DoSomething called with '{arg1}' and {arg2}");
    }
  }
}