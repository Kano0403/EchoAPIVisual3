using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
using System.Net;
using System.IO;
using System.Windows.Threading;
using System.Timers;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace EchoAPIVisual2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly System.Timers.Timer _timer;

        public MainWindow()
        {
            InitializeComponent();

            _timer = new System.Timers.Timer(250); //Updates every quarter second.
            _timer.Elapsed += new ElapsedEventHandler(OnTimedEvent);
        }

        private void OnTimedEvent(object source, ElapsedEventArgs e)
        {
            // My Quest:
            // string url = "http://10.0.0.9:6721/session";
            string url = null;
            this.Dispatcher.Invoke(() =>
            {
                url = "http://" + DeviceIpInputVar.Text + ":6721/session";
                Console.WriteLine(url);
            });
            // string txtPath = "D:\\VSSs\\EchoAPIVisual3\\";
            // string[] append = { null };

            GetResult(url);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var enabled = _timer.Enabled;

            if (enabled)
            {
                StartStopButton.Content = "Inactive";
                _timer.Enabled = false;
            }
            else
            {
                StartStopButton.Content = "Active";
                _timer.Enabled = true;
            }


        }

        private void GetResult(string url)
        {
            string result;
            // string fileName = "D:\\VSSs\\EchoAPIVisual3\\jsonMain.json";

            try
            {
                // get
                WebClient client = new WebClient();
                result = client.DownloadString(url);
                this.Dispatcher.Invoke(() =>
                {
                    Status.Text = "";
                });


                // set
                /*this.Dispatcher.Invoke(() =>
                {
                    MainLabel.Text = result;
                }); */

                // File.WriteAllText(fileName, result);

                Data data = JsonSerializer.Deserialize<Data>(result);

                Console.WriteLine(data.client_name);

                SetValues(data);
            }
            catch (WebException)
            {
                // handle error
                this.Dispatcher.Invoke(() =>
                {
                    Status.Text = "Not Connected / Inactive";
                });
                return;
            }
        }

        /* 
        private string GetResult(string url, string txtPath, string[] append)
        {
            string result;
            
            try
            {
                // get
                WebClient client = new WebClient();
                result = client.DownloadString(url);
                append[0] = result;

                // append, print
                File.AppendAllLines(System.IO.Path.Combine(txtPath, "TextFile1.txt"), append);
                MainLabel.Text = result;
                return result;
            }
            catch (WebException)
            {
                // handle error
               
                this.Dispatcher.Invoke(() =>
                {
                    MainLabel.Text = "No Response - Connection Refused" + Convert.ToString(counter);
                });
                counter += 1;
                return null;
            }
            catch (IndexOutOfRangeException)
            {
                MainLabel.Text = "IOR Ex.";
                return null;
            }
        } 
        */

        private bool iSConnected(string url)
        {
            string result;
            WebClient client = new WebClient();

            try
            {
                result = client.DownloadString(url);
                return true;
            }
            catch (WebException)
            {
                return false;
            }

        }

        private void SetValues(Data data)
        {
            this.Dispatcher.Invoke(() =>
            {


                SessionIdVar.Text = data.sessionid;
                SessionIpVar.Text = data.sessionip;

                // Blue
                try { BlueP1Name.Text = data.teams[0].players[0].name; } catch (IndexOutOfRangeException) { BlueP1Name.Text = "-- Unknown --"; }  catch (NullReferenceException) { BlueP1Name.Text = "-- Unknown --"; }
                try { BlueP1Ping.Text = data.teams[0].players[0].ping.ToString(); } catch (IndexOutOfRangeException) { BlueP1Ping.Text = "999"; } catch (NullReferenceException) { BlueP1Ping.Text = "999"; }
                try { BlueP2Name.Text = data.teams[0].players[1].name; } catch (IndexOutOfRangeException) { BlueP2Name.Text = "-- Unknown --"; }  catch (NullReferenceException) { BlueP2Name.Text = "-- Unknown --"; }
                try { BlueP2Ping.Text = data.teams[0].players[1].ping.ToString(); } catch (IndexOutOfRangeException) { BlueP2Ping.Text = "999"; } catch (NullReferenceException) { BlueP2Ping.Text = "999"; }
                try { BlueP3Name.Text = data.teams[0].players[2].name; } catch (IndexOutOfRangeException) { BlueP3Name.Text = "-- Unknown --"; }  catch (NullReferenceException) { BlueP3Name.Text = "-- Unknown --"; }
                try { BlueP3Ping.Text = data.teams[0].players[2].ping.ToString(); } catch (IndexOutOfRangeException) { BlueP3Ping.Text = "999"; } catch (NullReferenceException) { BlueP3Ping.Text = "999"; }
                try { BlueP4Name.Text = data.teams[0].players[3].name; } catch (IndexOutOfRangeException) { BlueP4Name.Text = "-- Unknown --"; }  catch (NullReferenceException) { BlueP4Name.Text = "-- Unknown --"; }
                try { BlueP4Ping.Text = data.teams[0].players[3].ping.ToString(); } catch (IndexOutOfRangeException) { BlueP4Ping.Text = "999"; } catch (NullReferenceException) { BlueP4Ping.Text = "999"; }
                try { BlueP5Name.Text = data.teams[0].players[4].name; } catch (IndexOutOfRangeException) { BlueP5Name.Text = "-- Unknown --"; }  catch (NullReferenceException) { BlueP5Name.Text = "-- Unknown --"; }
                try { BlueP5Ping.Text = data.teams[0].players[4].ping.ToString(); } catch (IndexOutOfRangeException) { BlueP5Ping.Text = "999"; } catch (NullReferenceException) { BlueP5Ping.Text = "999"; }

                // Orange
                try { OrangeP1Name.Text = data.teams[1].players[0].name; } catch (IndexOutOfRangeException) { OrangeP1Name.Text = "-- Unknown --"; }  catch (NullReferenceException) { OrangeP1Name.Text = "-- Unknown --"; }
                try { OrangeP1Ping.Text = data.teams[1].players[0].ping.ToString(); } catch (IndexOutOfRangeException) { OrangeP1Ping.Text = "999"; } catch (NullReferenceException) { OrangeP1Ping.Text = "999"; }
                try { OrangeP2Name.Text = data.teams[1].players[1].name; } catch (IndexOutOfRangeException) { OrangeP2Name.Text = "-- Unknown --"; }  catch (NullReferenceException) { OrangeP2Name.Text = "-- Unknown --"; }
                try { OrangeP2Ping.Text = data.teams[1].players[1].ping.ToString(); } catch (IndexOutOfRangeException) { OrangeP2Ping.Text = "999"; } catch (NullReferenceException) { OrangeP2Ping.Text = "999"; }
                try { OrangeP3Name.Text = data.teams[1].players[2].name; } catch (IndexOutOfRangeException) { OrangeP3Name.Text = "-- Unknown --"; }  catch (NullReferenceException) { OrangeP3Name.Text = "-- Unknown --"; }
                try { OrangeP3Ping.Text = data.teams[1].players[2].ping.ToString(); } catch (IndexOutOfRangeException) { OrangeP3Ping.Text = "999"; } catch (NullReferenceException) { OrangeP3Ping.Text = "999"; }
                try { OrangeP4Name.Text = data.teams[1].players[3].name; } catch (IndexOutOfRangeException) { OrangeP4Name.Text = "-- Unknown --"; }  catch (NullReferenceException) { OrangeP4Name.Text = "-- Unknown --"; }
                try { OrangeP4Ping.Text = data.teams[1].players[3].ping.ToString(); } catch (IndexOutOfRangeException) { OrangeP4Ping.Text = "999"; } catch (NullReferenceException) { OrangeP4Ping.Text = "999"; }
                try { OrangeP5Name.Text = data.teams[1].players[4].name; } catch (IndexOutOfRangeException) { OrangeP5Name.Text = "-- Unknown --"; }  catch (NullReferenceException) { OrangeP5Name.Text = "-- Unknown --"; }
                try { OrangeP5Ping.Text = data.teams[1].players[4].ping.ToString(); } catch (IndexOutOfRangeException) { OrangeP5Ping.Text = "999"; } catch (NullReferenceException) { OrangeP5Ping.Text = "999"; }
            });
        }
    }
}
