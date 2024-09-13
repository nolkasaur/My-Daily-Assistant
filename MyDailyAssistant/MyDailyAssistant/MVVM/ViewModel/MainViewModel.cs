using MyDailyAssistant.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDailyAssistant.MVVM.ViewModel
{
    internal class MainViewModel : ObservableObject
    {
        public RelayCommand HomeViewCommand { get; set; }
        public RelayCommand NotesViewCommand { get; set; }
        public RelayCommand ScheduleViewCommand { get; set; }
        public RelayCommand ToDoListViewCommand { get; set; }
        public RelayCommand WorkoutViewCommand { get; set; }

        public HomeViewModel HomeVM { get; set; }
        public NotesViewModel NotesVM { get; set; }
        public ScheduleViewModel ScheduleVM { get; set; }
        public ToDoListViewModel ToDoListVM { get; set; }
        public WorkoutViewModel WorkoutVM { get; set; }

        private object _currentView;

        public object CurrentView
        {
            get { return _currentView; }
            set
            {
                _currentView = value;
                OnPropertyChanged();
            }
        }

        public MainViewModel()
        {
            HomeVM = new HomeViewModel();
            NotesVM = new NotesViewModel();
            ScheduleVM = new ScheduleViewModel();
            ToDoListVM = new ToDoListViewModel();
            WorkoutVM = new WorkoutViewModel();

            CurrentView = HomeVM;

            HomeViewCommand = new RelayCommand(o =>
            {
                CurrentView = HomeVM;
            });

            NotesViewCommand = new RelayCommand(o =>
            {
                CurrentView = NotesVM;
            });

            ScheduleViewCommand = new RelayCommand(o =>
            {
                CurrentView = ScheduleVM;
            });

            ToDoListViewCommand = new RelayCommand(o =>
            {
                CurrentView = ToDoListVM;
            });

            WorkoutViewCommand = new RelayCommand(o =>
            {
                CurrentView = WorkoutVM;
            });
        }
    }
}
