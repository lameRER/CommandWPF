using System.Collections.ObjectModel;
using System.Windows.Input;
using CommandWPF.Infrastructure.Command;
using CommandWPF.Model;
using CommandWPF.Model.Interface;

namespace CommandWPF.ViewModel
{
    internal class MainWindowsViewModel : Base.ViewModel
    {
        private enum AutoFactory
        {
            Empty,
            Car,
            Truck
        }
        private string _title = "Завод по производству автомобилей";

        public string Title { get => _title; set => Set(ref _title, value); }

        private int _selectedAuto;

        public int SelectedAuto
        {
            get => _selectedAuto; set => Set(ref _selectedAuto, value);
        }

        public ObservableCollection<Auto> Autos { get; } = new();

        private ICommand _addAutoCommand;

        public ICommand AddAutoCommand =>
            _addAutoCommand ?? new LambdaCommand(OnAddAutoCommandExecuted, CanAddAutoCommandExecute);

        private void OnAddAutoCommandExecuted(object? parameter)
        {
            if(parameter is null) return;
            var autoFactory = GetFactory((int)parameter);
            
            Autos.Add(new Auto(autoFactory));
        }

        private static bool CanAddAutoCommandExecute(object? parameter)
        {
            if (parameter is null) return false;
            return (int)parameter != 0;
        }

        private static IAutoFactory? GetFactory(int factory)
        {
            return (AutoFactory) factory switch
            {
                AutoFactory.Car => new CarFactory(),
                AutoFactory.Truck => new TruckFactory(),
                _ => null
            };
        }
    }
}
