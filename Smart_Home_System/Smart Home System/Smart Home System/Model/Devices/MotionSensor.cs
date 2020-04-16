using System;
using System.Collections.Generic;
using System.Text;
using Smart_Home_System.Model.DeviceManager;

namespace Smart_Home_System.Model.Devices
{
    [SQLite.Table("Device")]
    class MotionSensor: Device
    {
        public MotionSensor(int ID, string Name, bool PowerOn) : base(ID, Name, PowerOn)
        {
            base.DeviceType = "Motion Sensor";
        }
    }
}
