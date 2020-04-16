using System;
using System.Collections.Generic;
using System.Text;
using Smart_Home_System.Model.DeviceManager;

namespace Smart_Home_System.Model.Devices
{
    [SQLite.Table("Device")]
    class DoorSensor: Device
    {
        public DoorSensor(int ID, string Name, bool PowerOn) : base(ID,Name, PowerOn)
        {
            base.DeviceType = "Door Sensor";
        }
    }
}
