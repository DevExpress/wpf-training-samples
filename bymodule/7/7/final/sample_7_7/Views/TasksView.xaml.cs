using sample_7_7.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace sample_7_7.Views {
  /// <summary>
  /// Interaction logic for TasksView.xaml
  /// </summary>
  public partial class TasksView : UserControl {
    public TasksView() {
      InitializeComponent();
    }

    private void UserControl_Loaded(object sender, RoutedEventArgs e) {
      var today = DateTime.Today;
      var tasks = new ObservableCollection<TaskViewModel> {
        TaskViewModel.Create("Do shopping", today),
        TaskViewModel.Create("Dinner with Joe", today + TimeSpan.FromDays(2)),
        TaskViewModel.Create("Car in shop", today + TimeSpan.FromDays(1)),
        TaskViewModel.Create("Clean patio", today + TimeSpan.FromDays(1)),
        TaskViewModel.Create("Take the garbage out", today + TimeSpan.FromDays(4)),
        TaskViewModel.Create("Complete MVVM lab", today),
        TaskViewModel.Create("Vegas, baby!", today + TimeSpan.FromDays(10))
      };
      var viewModel = DataContext as TasksViewModel;
      viewModel.Tasks = tasks;
    }
  }
}
