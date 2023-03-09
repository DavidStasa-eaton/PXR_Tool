using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using StasaLibrary;

namespace PXR_Tool
{
    public partial class EventsFrame : UserControl
    {

        BindingList<StasaLibrary.EtuEvents.EventSummary> summaryEvents;
        BindingList<StasaLibrary.EtuEvents.EventTimeAdjustment> timeAdjustmentEvents;
        BindingList<StasaLibrary.EtuEvents.EventTrip> tripEvents;
        BindingList<StasaLibrary.EtuEvents.EventTrip> alarmEvents;
        public EventsFrame()
        {
            InitializeComponent();

            summaryEvents = new BindingList<StasaLibrary.EtuEvents.EventSummary>();
            summaryBindedDataSource.BindEvents(summaryEvents);

            timeAdjustmentEvents = new BindingList<StasaLibrary.EtuEvents.EventTimeAdjustment>();
            timeAdjustmentBindDataSource.BindEvents(timeAdjustmentEvents);

            tripEvents = new BindingList<StasaLibrary.EtuEvents.EventTrip>();
            tripBindedDataSource.BindEvents(tripEvents);

            alarmEvents = new BindingList<StasaLibrary.EtuEvents.EventTrip>();
            alarmBindedDataSource.BindEvents(alarmEvents);
        }

        private async void readSummaryEventsButton_Click(object sender, EventArgs e)
        {
            readSummaryEventsButton.WorkStart();

            EtuRequest request = Program.connectedDevice.eventSummaryPG.ReadRequest();
            EtuResponse response = await MainForm.instance.device.AsyncTransaction(request);

            StasaLibrary.EtuEvents.EventSummary[] newSummaryEvents = StasaLibrary.EtuEvents.EventSummary.ParseSummaryEvents(
                response, 
                Program.connectedDevice);
            summaryEvents.Clear();
            for (int i = newSummaryEvents.Length - 1; i >= 0; i--)
            {
                summaryEvents.Add(newSummaryEvents[i]);
            }
            summaryCountLabel.Text = newSummaryEvents.Length.ToString();

            readSummaryEventsButton.ParseBool(response.goodResponse);
        }

        private async void readTimeAdjustmentEventsButton_Click(object sender, EventArgs e)
        {
            readTimeAdjustmentEventsButton.WorkStart();
            EtuRequest request = Program.connectedDevice.eventTimeAdjustmentPG.ReadRequest();
            EtuResponse response = await MainForm.instance.device.AsyncTransaction(request);

            StasaLibrary.EtuEvents.EventTimeAdjustment[] newTimeAdjustmentEvents = StasaLibrary.EtuEvents.EventTimeAdjustment.ParseTimeAdjustmentEvents(
                response,
                Program.connectedDevice);
            timeAdjustmentEvents.Clear();
            for (int i = newTimeAdjustmentEvents.Length - 1; i >= 0; i--)
            {
                timeAdjustmentEvents.Add(newTimeAdjustmentEvents[i]);
            }
            timeAdjustmentCountLabel.Text = newTimeAdjustmentEvents.Length.ToString();

            readTimeAdjustmentEventsButton.ParseBool(response.goodResponse);
        }

        private async void tripWaveformGraph_ButtonClickedEvent(object sender, EventArgs e)
        {
            EtuRequest request = Program.connectedDevice.eventTripDict["snapshot"].ReadRequest();
            EtuResponse response = await MainForm.instance.device.AsyncTransaction(request);

            Tuple<StasaLibrary.EtuEvents.EventTrip[], StasaLibrary.EtuEvents.WaveformData> tripData = StasaLibrary.EtuEvents.EventTrip.ParseTripEvents(
                response,
                Program.connectedDevice.eventTripDict,
                Program.connectedDevice);
            tripEvents.Clear();
            for (int i = tripData.Item1.Length - 1; i >= 0; i--)
            {
                tripEvents.Add(tripData.Item1[i]);
            }
            tripWaveformGraph.waveformData = tripData.Item2;
        }

        private async void alarmWaveformGraph_ButtonClickedEvent(object sender, EventArgs e)
        {
            EtuRequest request = Program.connectedDevice.eventAlarmDict["snapshot"].ReadRequest();
            EtuResponse response = await MainForm.instance.device.AsyncTransaction(request);

            Tuple<StasaLibrary.EtuEvents.EventTrip[], StasaLibrary.EtuEvents.WaveformData> alarmData = StasaLibrary.EtuEvents.EventTrip.ParseTripEvents(
                response,
                Program.connectedDevice.eventAlarmDict,
                Program.connectedDevice);
            alarmEvents.Clear();
            for (int i = alarmData.Item1.Length - 1; i >= 0; i--)
            {
                alarmEvents.Add(alarmData.Item1[i]);
            }
            alarmWaveformGraph.waveformData = alarmData.Item2;
        }

        private void summarySaveToCsvFileButton_Click(object sender, EventArgs e)
        {
            summaryBindedDataSource.SaveToCSV("SummaryEvents.csv");
        }

        private void timeAdjustmentSaveToCsvFileButton_Click(object sender, EventArgs e)
        {
            timeAdjustmentBindDataSource.SaveToCSV("TimeAdjustmentEvents.csv");
        }

        private void tripSaveToCsvFileButton_Click(object sender, EventArgs e)
        {
            tripBindedDataSource.SaveToCSV("TripEvents.csv");
        }

        private void alarmSaveToCsvFileButton_Click(object sender, EventArgs e)
        {
            alarmBindedDataSource.SaveToCSV("AlarmEvents.csv");
        }
    }
}
