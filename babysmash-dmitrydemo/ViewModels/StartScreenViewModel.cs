using BabySmash.Entities;
using BabySmash.Services;
using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Timers;

namespace BabySmash.ViewModels
{
    public class StartScreenViewModel : BindableBase
    {
        private Timer _ImageRotateTimer;
        private readonly List<string> ImagesToRotateList;

        // Services
        private DeviceInformationService _deviceInfo = new DeviceInformationService();

        // Collections
        public ObservableCollection<DeviceScreen> AvailableScreensList 
            { get; private set; } = new ObservableCollection<DeviceScreen>();

        // Properties
        private string _RotatingImageUrL;

        public string RotatingImageUrl 
        { 
            get
            {
                return _RotatingImageUrL;
            }
            private set
            {
                SetProperty(ref _RotatingImageUrL, value);
            }
         }

        #region Init
        public StartScreenViewModel()
        {
            // Initial list of screens, this happens really quickly no need for async for first attempt
            AvailableScreensList = new ObservableCollection<DeviceScreen>();

            var screens = _deviceInfo.GetAvailableScreens();
            foreach (DeviceScreen s in screens)
            {
                AvailableScreensList.Add(s);
            }

            RotatingImageUrl = String.Format("/Resources/Images/{0}.jpg", "BabySmash-family");

            // Setup images to rotate + timer
            ImagesToRotateList = new List<string>();
            ImagesToRotateList.Add("BabySmash-family");
            ImagesToRotateList.Add("BabySmash-Screenshot");
            ImagesToRotateList.Add("scotthanselman");

            _ImageRotateTimer = new System.Timers.Timer();
            _ImageRotateTimer.Interval = 2000;

            // Hook up the Elapsed event for the timer. 
            _ImageRotateTimer.Elapsed += _ImageRotateTimer_Elapsed;

            // Have the timer fire repeated events (true is the default)
            _ImageRotateTimer.AutoReset = true;

            // Start the timer
            _ImageRotateTimer.Enabled = true;
        }

        private void _ImageRotateTimer_Elapsed(object sender, ElapsedEventArgs e)
        {
            Random rnd = new Random();
            var nextRnd = rnd.Next(3);

            RotatingImageUrl = String.Format("/Resources/Images/{0}.jpg", ImagesToRotateList[nextRnd]);
        }
        #endregion

        #region Commands
        private DelegateCommand _commandStartGame = null;
        public DelegateCommand CommandStartGame =>
            _commandStartGame ?? (_commandStartGame = new DelegateCommand(CommandStartGameExecute));

        private void CommandStartGameExecute()
        {
            // TODO: add logic here to start the game
        }

        private DelegateCommand _commandCancel = null;
        public DelegateCommand CommandCancel =>
            _commandCancel ?? (_commandCancel = new DelegateCommand(CommandCancelExecute));

        private void CommandCancelExecute()
        {
            // TODO: add logic here to exit game
        }
        #endregion
    }
}
