using Avalonia.Media.Immutable;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAvaloniaApp.Models
{
    public class ToDoItem
    {
        public string Description { get; set; } = String.Empty;
        public bool IsChecked { get; set; }
        public string TrashCanPath { get; set; } = "assets/trash-can.png";


    }
}
