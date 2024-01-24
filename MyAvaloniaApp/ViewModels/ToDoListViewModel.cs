using MyAvaloniaApp.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MyAvaloniaApp.ViewModels
{
    public class ToDoListViewModel : ViewModelBase
    {

        public ToDoListViewModel(IEnumerable<ToDoItem> items)
        {
            ListItems = new ObservableCollection<ToDoItem>(items);
        }

        public ObservableCollection<ToDoItem> ListItems { get; }
    }
}
