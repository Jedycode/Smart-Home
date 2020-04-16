using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using Smart_Home_System.Model.DeviceManager;
using System.Threading.Tasks;
using Smart_Home_System.Model.Devices;
using System.Windows.Input;
using Smart_Home_System.Views;
using System.ComponentModel;
using System.Drawing;

namespace Smart_Home_System.ViewModel
{
    class DeviceManagmentViewModel: INotifyPropertyChanged
    {
        public ICommand RecreateDeviceListCommand => new Xamarin.Forms.Command(RecreateDeviceList);
        public ICommand DeleteDeviceListCommand => new Xamarin.Forms.Command(DeleteDeviceList);
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(string name)
        {
            if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs(name));
        }
        private ObservableCollection<Device> _devices = new ObservableCollection<Device>();
        public ObservableCollection<Device> DevicesOBCollection 
        {
            get { return _devices; }
            set
            {
                _devices = value;
                OnPropertyChanged("DevicesOBCollection");
            }
        }
        public DeviceManagmentViewModel()
        {
            DevicesOBCollection = Read_OBCollection_FromDatabase();
        }
        //Create private list of devices
        //Add random to this list
        //Save list to database
        //Read list from database and push to observation collecion

        private List<Device> CreateDeviceList()
        {
            List<Device> DeviceList = new List<Device>();
            DeviceList.Add(new Camera(0, "Camera 1", false));
            DeviceList.Add(new Camera(0, "Camera 2", false));
            DeviceList.Add(new DoorSensor(0, "Hall room door sensor", true));
            DeviceList.Add(new DoorSensor(0, "Garage door sensor", true));
            DeviceList.Add(new Heater(0, "Kids room heater", true));
            DeviceList.Add(new Heater(0, "Bedroom heater", false));
            DeviceList.Add(new Heater(0, "Hall heater", true));
            DeviceList.Add(new LightBulb(0, "Kids room Light", true));
            DeviceList.Add(new LightBulb(0, "Hall Light", true));
            return DeviceList;
        }
        private ObservableCollection<Device> CreateDeviceCollection()
        {
            List<Device> deviceList = CreateDeviceList();
            Data.DBRepository.Database.SaveDeviceList(deviceList);
            deviceList = Data.DBRepository.Database.GetDevices();
            return Data.DBRepository.Database.ConvertDeviceList_To_OBCollection(deviceList);
        }
        private ObservableCollection<Device> Read_OBCollection_FromDatabase()
        {
            List<Device> deviceList = Data.DBRepository.Database.GetDevices();
            return Data.DBRepository.Database.ConvertDeviceList_To_OBCollection(deviceList);
        }

        public void RecreateDeviceList()
        {
            Data.DBRepository.Database.DeleteDeviceTable();
            DevicesOBCollection = Read_OBCollection_FromDatabase();
            DevicesOBCollection = CreateDeviceCollection();

        }
        public void DeleteDeviceList()
        {
            Data.DBRepository.Database.DeleteDeviceTable();
            DevicesOBCollection = Read_OBCollection_FromDatabase();
        }
    }
}
