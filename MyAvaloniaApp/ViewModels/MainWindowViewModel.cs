using Avalonia.Automation.Peers;
using MyAvaloniaApp.Services;
using MyAvaloniaApp.Models;
using MyAvaloniaApp.ViewModels;
using System;
using System.Collections;
using System.Collections.ObjectModel;
using ReactiveUI;


namespace MyAvaloniaApp.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        private ViewModelBase _contentViewModel;

        public MainWindowViewModel() 
        {
            var service = new ToDoListService();
            ToDoList = new ToDoListViewModel(service.GetItems());
            _contentViewModel = ToDoList;
        }

        public ToDoListViewModel ToDoList { get; }

        public SimpleViewModel SimpleViewModel { get; set;  } = new SimpleViewModel();

        public ViewModelBase ContentViewModel
        {
            get => _contentViewModel;
            private set => this.RaiseAndSetIfChanged(ref _contentViewModel, value);
        }

        public void AddItem()
        {
            ContentViewModel = new AddItemViewModel();
        }











        #pragma warning disable CA1822 // Mark members as static
        public string Greeting => "Welcome to Avalonia!";
        #pragma warning restore CA1822 // Mark members as static

    }
}
