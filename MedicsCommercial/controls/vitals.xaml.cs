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
using MedicsCommercial.Libraries;

namespace MedicsCommercial.controls
{
    /// <summary>
    /// Interaction logic for vitals.xaml
    /// </summary>
    public partial class vitals : UserControl
    {
        //Globals
        SystemMessages _systemMessages = SystemMessages.Instance;

        public vitals()
        {
            InitializeComponent();

            vitalsSetUp();

            //Get new vitals from main window
            _systemMessages.HandleSystemMessage += new EventHandler(vitalsOnHandleMessage);
        }

        public void vitalsSetUp()
        {
            //fake set up code, replace
            logListBox.Items.Add("Hello world");

            hrValueLabel.Content = "80";
            hrRateLabel.Content = "bpm";

            bpValueLabel.Content = "120/80";
            bpRateLabel.Content = "";

            spValueLabel.Content = "68";
            spRateLabel.Content = "%";

            etValuelabel.Content = "25";
            etRateLabel.Content = "mmHG";

            respValueLabel.Content = "15";
            respRateLabel.Content = "bpm";

            tempValueLabel.Content = "98.8";
            tempRateLabel.Content = "F";

        }

        //Meesage Handler Thread
        public void vitalsOnHandleMessage(object sender, EventArgs args)
        {
            var vitalsMessageEvent = args as SystemMessageEventArgs;
            if (vitalsMessageEvent != null)
            {
                handleVitalsMessage(vitalsMessageEvent.systemMessage);    
            }
        }

        //Handle Message data
        public void handleVitalsMessage(Patient vitalsPayload)
        {
            try
            {
                //code to work off the main thread
                this.Dispatcher.Invoke((Action)(() =>
                    {
                        hrValueLabel.Content = vitalsPayload.HR.ToString();
                        hrRateLabel.Content = "bpm";

                        //bp work
                        string BP = vitalsPayload.NIBPSYS.ToString() + "/" + vitalsPayload.NIBPDIA.ToString();
                        bpValueLabel.Content = BP;
                        bpRateLabel.Content = "";

                        spValueLabel.Content = vitalsPayload.SPO2.ToString();
                        spRateLabel.Content = "%";

                        etValuelabel.Content = vitalsPayload.EtC02.ToString();
                        etRateLabel.Content = "mmHG";

                        respValueLabel.Content = vitalsPayload.Resp.ToString();
                        respRateLabel.Content = "bpm";

                        tempValueLabel.Content = vitalsPayload.Temp.ToString();
                        tempRateLabel.Content = "F";
                    }));
                 
            }
            catch
            {

            }
        }

        //Add new vitals
        public void addVitals(Patient vitalsPayload)
        {
            try
            {
                hrValueLabel.Content = vitalsPayload.HR.ToString();
                hrRateLabel.Content = "bpm";

                //bp work
                string BP = vitalsPayload.NIBPSYS.ToString() + "/" + vitalsPayload.NIBPDIA.ToString();
                bpValueLabel.Content = BP;
                bpRateLabel.Content = "";

                spValueLabel.Content = vitalsPayload.SPO2.ToString();
                spRateLabel.Content = "%";

                etValuelabel.Content = vitalsPayload.EtC02.ToString();
                etRateLabel.Content = "mmHG";

                respValueLabel.Content = vitalsPayload.Resp.ToString();
                respRateLabel.Content = "bpm";

                tempValueLabel.Content = vitalsPayload.Temp.ToString();
                tempRateLabel.Content = "F";
            }
            catch
            { }
        }
    }
}
