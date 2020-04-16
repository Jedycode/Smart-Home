using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Smart_Home_System.Model.DeviceManager
{
    public class Device: INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        void OnPropertyChanged([CallerMemberName] string name = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(name));
                Data.DBRepository.Database.SaveDevice(this);
            }
        }
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        private string name;
        public string Name
        {
            get { return name; }
            set
            {
                if (name != value)
                {
                    name = value;
                    OnPropertyChanged();
                }
            }
        }
        public string DeviceType { get; set; }
        private bool powerOn;
        public bool PowerOn
        {
            get { return powerOn; }
            set
            {
                if (powerOn != value)
                {
                    powerOn = value;
                    OnPropertyChanged("PowerOn");
                }
            }
        }

        public Device()
        {

        }
        public Device(int ID, string Name, bool PowerOn)
        {
            this.ID = ID;
            this.Name = Name;
            this.PowerOn = PowerOn;
        }
    }
}
