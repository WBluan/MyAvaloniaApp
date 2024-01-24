using MyAvaloniaApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAvaloniaApp.Services
{
    public class ToDoListService
    {
        public IEnumerable<ToDoItem> GetItems() => new[]
        {
            new ToDoItem { Description = "Walk the dog", TrashCanPath = "assets/trash-can.png" },
            new ToDoItem { Description = "Buy some milk", TrashCanPath = "assets/trash-can.png" },
            new ToDoItem { Description = "Learn Avalonia", IsChecked = true, TrashCanPath = "assets/trash-can.png" },
        };
    }
}
