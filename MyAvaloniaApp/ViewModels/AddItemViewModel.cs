using MyAvaloniaApp.Models;
using ReactiveUI;
using System;
using System.Reactive;
using System.Text;
using System.Threading.Tasks;

namespace MyAvaloniaApp.ViewModels
{
    public class AddItemViewModel : ViewModelBase
    {
        public string _description = String.Empty;

        public ReactiveCommand<Unit, ToDoItem> OkCommand { get; }
        public ReactiveCommand<Unit, Unit> CancelCommand { get; }

        public AddItemViewModel()
        {
            var isValidObsarvable = this.WhenAnyValue(
                x => x.Description,
                x => !string.IsNullOrWhiteSpace(x));

            OkCommand = ReactiveCommand.Create(
                () => new ToDoItem { Description = Description }, isValidObsarvable);
            CancelCommand = ReactiveCommand.Create(() => { });
        }

        public string Description
        {
            get => _description;
            set => this.RaiseAndSetIfChanged(ref _description, value);
        }
    }
}
