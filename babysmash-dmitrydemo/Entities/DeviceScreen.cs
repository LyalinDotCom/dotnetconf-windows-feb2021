using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BabySmash.Entities
{
    public class DeviceScreen
    {
        public string Description
        {
            get
            {
                return this.DeviceName + " (Primary=" + this.IsPrimary.ToString() + ")";
            }
        }

        // duplicate properties of WinForms Screen
        public string DeviceName { get; set; }
        public int Left { get; internal set; }
        public int Top { get; internal set; }
        public int Width { get; internal set; }
        public int Height { get; internal set; }
        public bool IsPrimary { get; internal set; }
    }
}
