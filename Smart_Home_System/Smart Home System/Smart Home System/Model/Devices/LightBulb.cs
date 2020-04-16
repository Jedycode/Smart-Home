using System;
using System.Collections.Generic;
using System.Text;
using Smart_Home_System.Model.DeviceManager;

namespace Smart_Home_System.Model.Devices
{
    [SQLite.Table("Device")]
    class LightBulb: Device
    {
        public LightBulb(int ID, string Name, bool PowerOn) : base(ID, Name, PowerOn)
        {
            base.DeviceType = "Light Bulb";
        }
    }
}
