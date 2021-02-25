using BabySmash.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinForms = System.Windows.Forms;

namespace BabySmash.Services
{
    public class DeviceInformationService
    {
        public bool IsPrimary { get; private set; }

        public List<DeviceScreen> GetAvailableScreens()
        {
            List<DeviceScreen> ScreenList = new();

            foreach (WinForms.Screen s in WinForms.Screen.AllScreens)
            {
                ScreenList.Add(
                    new DeviceScreen
                    {
                        DeviceName = s.DeviceName,
                        Left = s.WorkingArea.Left,
                        Top = s.WorkingArea.Top,
                        Width = s.WorkingArea.Width,
                        Height = s.WorkingArea.Height,
                        IsPrimary = s.Primary
                    });
            }

            return ScreenList;
        }
    }
}
