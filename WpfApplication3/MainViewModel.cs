namespace WpfApplication3
{
    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    using QuantityTypes;

    public class MainViewModel : ViewModelBase
    {
        public MainViewModel()
        {
            UnitProvider.Default.TrySetDisplayUnit(typeof(Angle), "deg");

            this.Angles = new ObservableCollection<Angle>(new List<Angle> { 0 * Angle.Degree });
        }

        public ObservableCollection<Angle> Angles { get; private set; }
    }
}
