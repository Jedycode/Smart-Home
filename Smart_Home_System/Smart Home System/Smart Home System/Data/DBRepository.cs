using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;
using SQLite;
using Smart_Home_System.Model.DeviceManager;
using Smart_Home_System.Model.Devices;
using System.Collections.ObjectModel;
using System.IO;


namespace Smart_Home_System.Data
{
    public class DBRepository
    {
        static DBRepository database;

        public static DBRepository Database
        {
            get
            {
                if (database == null)
                {
                    database = new DBRepository(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Devices.db1"));
                }
                return database;
            }
        }
        readonly SQLiteConnection _database;

        public DBRepository(string dbPath)
        {
            _database = new SQLiteConnection(dbPath);
            _database.CreateTable<Device>();
        }

        public List<Device> GetDevices()
        {
            return _database.Table<Device>().ToList();
        }
        public void DeleteDeviceTable()
        {
            _database.DeleteAll<Device>();
        }


        public Device GetDevice(int id)
        {
            return _database.Table<Device>()
                            .Where(i => i.ID == id)
                            .FirstOrDefault();
        }
        public List<Device> GetDeviceWithCertainType(string deviceType)
        {
           return _database.Table<Device>()
                            .Where(i => i.DeviceType == deviceType)
                            .ToList();
        }
        public ObservableCollection<Device> ConvertDeviceList_To_OBCollection(List<Device> deviceList)
        {
            ObservableCollection<Device> deviceCollection = new ObservableCollection<Device>();
            foreach(Device device in deviceList)
            {
                deviceCollection.Add(device);
            }
            return deviceCollection;
        }
        public ObservableCollection<Device> GetDeviceWithCertainType_OBCollection(string deviceType)
        {
            ObservableCollection<Device> certainDeviceCollection = new ObservableCollection<Device>();
            List<Device> deviceList = GetDeviceWithCertainType(deviceType);
            foreach(Device device in deviceList)
            {
                certainDeviceCollection.Add(device);
            }
            return certainDeviceCollection;
        }
        public ObservableCollection<Device> GetDeviceWithCertainType_OBCollection(List<string> deviceType)
        {
            ObservableCollection<Device> certainDeviceCollection = new ObservableCollection<Device>();
            for(int i = 0; i < deviceType.Count; i++)
            {
                List<Device> deviceList = GetDeviceWithCertainType(deviceType[i]);
                foreach (Device device in deviceList)
                {
                    certainDeviceCollection.Add(device);
                }
            }
            return certainDeviceCollection;
        }

        public int SaveDevice(Device device)
        {
            if (device.ID != 0)
            {
                return _database.Update(device);
            }
            else
            {
                return _database.Insert(device);
            }
        }
        public void SaveDevice(int ID)
        {
            Device device = GetDevice(ID);
            SaveDevice(device);
        }
        public void 
            
            SaveDeviceList(List<Device> deviceList)
        {
            foreach(Device device in deviceList)
            {
                SaveDevice(device);
            }
        }
        public int DeleteDevice(Device device)
        {
            return _database.Delete(device);
        }

    }
}

