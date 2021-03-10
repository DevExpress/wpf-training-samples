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
using System.Windows.Navigation;
using System.Windows.Shapes;
using DevExpress.Xpf.Core;
using DevExpress.Xpf.Core.DataSources;
using EventsDB.EF;
using System.Data.Entity;
using DevExpress.Mvvm;

namespace sample_4_4 {
  /// <summary>
  /// Interaction logic for MainWindow.xaml
  /// </summary>
  public partial class MainWindow : DevExpress.Xpf.Core.ThemedWindow {
    public MainWindow() {
      InitializeComponent();
    }

    private void ConfigureScheduler(Event selectedEvent) {
      if (selectedEvent != null) {
        scheduler.IsEnabled = true;
        scheduler.LimitInterval = new DateTimeRange(
          selectedEvent.StartDate, selectedEvent.EndDate.AddDays(1));
        scheduler.Start = selectedEvent.StartDate;
        int days = ((int)(selectedEvent.EndDate - selectedEvent.StartDate).TotalDays) + 1;
        dayView.DayCount = days;
        dayView.TopRowTime = new TimeSpan(
          selectedEvent.CapacityRequirements.Min(cr => cr.StartTime.TimeOfDay.Ticks)) -
          new TimeSpan(0, 30, 0);
        schedulerSource.AppointmentsSource = selectedEvent.CapacityRequirements;
      }
      else {
        scheduler.IsEnabled = false;
        schedulerSource.AppointmentsSource = null;
      }
    }

    private void ThemedWindow_Loaded(object sender, RoutedEventArgs e) {
      ConfigureScheduler(grid.SelectedItem as Event);
    }

    private void grid_CurrentItemChanged(object sender, DevExpress.Xpf.Grid.CurrentItemChangedEventArgs e) {
      if (scheduler == null) return;
      ConfigureScheduler(e.NewItem as Event);
    }
  }
}
