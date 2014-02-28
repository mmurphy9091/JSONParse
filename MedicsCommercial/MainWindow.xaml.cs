using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using MedicsCommercial.controls;
using MedicsCommercial.Libraries;
using System.IO;
using System.Timers;

namespace MedicsCommercial
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //Globals
        Patient currentPatient = new Patient();
        private Timer vitalsTimer;
        Messages _messages = Messages.Instance;
        SystemMessages _systemMessages = SystemMessages.Instance;

        //initialize controls
        vitals VITALSCONTROL = new vitals();
        videoControl VIDEOCONTROL = new videoControl();
        fileControl FILECONTROL = new fileControl();

        //zoll setup
        zollInterface ZOLLPOLL = new zollInterface();
        //StreamReader ZOLLstream = new StreamReader();

        public MainWindow()
        {
            InitializeComponent();
            setup();

            //Message Handler
            _messages.HandleMessage += new EventHandler(OnHandleMessage);

            //Vitals timer
            vitalsTimer = new System.Timers.Timer(3000);
            vitalsTimer.Elapsed += new ElapsedEventHandler(vitalsEventThread);
            vitalsTimer.Enabled = true;

        }

        public void setup()
        {
            //vitals stack
            vitalsStack.Children.Clear();
            vitalsStack.Children.Add(VITALSCONTROL);

            //video stack
            videoStack.Children.Clear();
            videoStack.Children.Add(VIDEOCONTROL);

            //file stack
            fileStack.Children.Clear();
            fileStack.Children.Add(FILECONTROL);

        }

        //Vitals timer event
        private void vitalsEventThread(object source, ElapsedEventArgs e)
        {
            currentPatient.Trend = ZOLLPOLL.getTrend();
            currentPatient.setVitals();

            _systemMessages.AddMessage(currentPatient);
        }

        //Message Handler Event
        public void OnHandleMessage(object sender, EventArgs args)
        {
            var messageEvent = args as MessageEventArgs;
            if (messageEvent != null)
            {
                string message = messageEvent.Message;
                //Put some function here for what to do when message recieved from the children controls
            }
        }
    }
}
