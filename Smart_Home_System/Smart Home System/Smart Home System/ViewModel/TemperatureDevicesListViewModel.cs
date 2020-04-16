using System;
using System.Collections.Generic;
using System.Text;
using Smart_Home_System.Model.DeviceManager;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Smart_Home_System.ViewModel
{
    class TemperatureDevicesListViewModel: INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        void OnPropertyChanged([CallerMemberName] string name = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(name));
            }
        }
        private ObservableCollection<Model.DeviceManager.Device> _devices = 
            new ObservableCollection<Model.DeviceManager.Device>();
        public ObservableCollection<Model.DeviceManager.Device> TemperatureDevicesList
        {
            get { return _devices; }
            set
            {
                if (_devices != value)
                {
                    _devices = value;
                    OnPropertyChanged("TemperatureDevicesList");
                }
            }
        }
        public TemperatureDevicesListViewModel()
        {
            TemperatureDevicesList = GetTemperatureDevices();
            
        }
        public ObservableCollection<Model.DeviceManager.Device> GetTemperatureDevices()
        {
            return Data.DBRepository.Database.GetDeviceWithCertainType_OBCollection("Heater");
        }
    }
}
