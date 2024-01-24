using Avalonia.Automation.Peers;
using MyAvaloniaApp.Services;
using MyAvaloniaApp.Models;
using MyAvaloniaApp.ViewModels;
using System;
using System.Collections;
using System.Collections.ObjectModel;
using ReactiveUI;
using System.Reactive.Linq;


namespace MyAvaloniaApp.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        //Create a private variable to store the 'ViewModelBase' 
        private ViewModelBase _contentViewModel;

        public MainWindowViewModel() 
        {
            //Create a service instance to fetch items from our mock database, as defined in the ToDoListServices file.
            var service = new ToDoListService();
            //Use the ToDoList variable to initialize a ToDoListVM and assign the items from the service variable to it
            ToDoList = new ToDoListViewModel(service.GetItems());
            //Assigns this ToDoList to the ViewModelBase variable
            _contentViewModel = ToDoList;
           
        }
        //Create a ToDoListViewModel variable
        public ToDoListViewModel ToDoList { get; }

        public SimpleViewModel SimpleViewModel { get; set;  } = new SimpleViewModel();

        public ViewModelBase ContentViewModel
        {
            get => _contentViewModel;
            private set => this.RaiseAndSetIfChanged(ref _contentViewModel, value);
        }

        public void AddItem()
        {
            AddItemViewModel addItemViewModel = new();

            Observable.Merge(
                addItemViewModel.OkCommand,
                addItemViewModel.CancelCommand.Select(_ => (ToDoItem?)null))
                .Take(1)
                .Subscribe(newItem =>
                {
                    if (newItem != null)
                    {
                        ToDoList.ListItems.Add(newItem);
                    }
                    ContentViewModel = ToDoList;
                });

            ContentViewModel = addItemViewModel;
        }











        #pragma warning disable CA1822 // Mark members as static
        public string Greeting => "Welcome to Avalonia!";
        #pragma warning restore CA1822 // Mark members as static

    }
}
