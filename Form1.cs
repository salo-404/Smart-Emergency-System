using Csc413_project.Models;
using Csc413_project.Services;

namespace Csc413_project
{
    public partial class Form1 : Form
    {
        private EmergencyRequestManager requestManager;
        private DispatchCoordinator dispatchCoordinator;
        private MissionTracker missionTracker;
        private int caseCounter = 1;

        public Form1()
        {
            InitializeComponent();

            requestManager = new EmergencyRequestManager();
            missionTracker = new MissionTracker();

            var responders = new List<ResponderUnit>
            {
                new ResponderUnit { ResponderId = 1, ResponderName = "Ambulance A1", ResponderType = "Ambulance" },
                new ResponderUnit { ResponderId = 2, ResponderName = "Fire Unit F1", ResponderType = "Firefighter" },
                new ResponderUnit { ResponderId = 3, ResponderName = "Police Unit P1", ResponderType = "Police" },
                new ResponderUnit { ResponderId = 4, ResponderName = "General Unit G1", ResponderType = "General" }
            };

            dispatchCoordinator = new DispatchCoordinator(responders, 2);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbEmergencyType.Items.Clear();
            cmbEmergencyType.Items.Add("Ambulance");
            cmbEmergencyType.Items.Add("Firefighter");
            cmbEmergencyType.Items.Add("Police");
            cmbEmergencyType.Items.Add("General");
            cmbEmergencyType.SelectedIndex = 0;

            numPriority.Minimum = 1;
            numPriority.Maximum = 5;
            numPriority.Value = 1;

            RefreshResponders();
            RefreshRequests();
        }

        private void AddRequest_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCallerName.Text))
            {
                MessageBox.Show("Caller name is required.", "Input Error");
                return;
            }

            var emergencyCase = new EmergencyCase
            {
                CaseId = caseCounter++,
                CallerName = txtCallerName.Text.Trim(),
                EmergencyType = cmbEmergencyType.SelectedItem?.ToString() ?? "General",
                Priority = (int)numPriority.Value,
                Description = txtDescription.Text.Trim(),
                Status = "Pending"
            };

            requestManager.AddRequest(emergencyCase);

            RefreshRequests();
            AddNotification($"New request registered → Case #{emergencyCase.CaseId}");

            txtCallerName.Clear();
            txtDescription.Clear();
            cmbEmergencyType.SelectedIndex = 0;
            numPriority.Value = 1;
        }

        private async void dispatch_Click(object sender, EventArgs e)
        {
            var nextCase = requestManager.GetNextPendingCase();

            if (nextCase == null)
            {
                AddNotification("No pending emergency cases available for dispatch.");
                return;
            }

            AddNotification($"Dispatching unit to Case #{nextCase.CaseId}...");

            var responder = await dispatchCoordinator.AssignResponderAsync(nextCase);

            if (responder == null)
            {
                AddNotification($"Dispatch failed → No available responder for Case #{nextCase.CaseId}");
            }
            else
            {
                AddNotification($"Assigned {responder.ResponderName} to Case #{nextCase.CaseId}");
            }

            RefreshRequests();
            RefreshResponders();
        }

        private async void btnCompleteMission_Click(object sender, EventArgs e)
        {
            if (lstRequests.SelectedItem is not EmergencyCase selectedCase)
            {
                AddNotification("Please select a dispatched case before completing the mission.");
                return;
            }

            if (selectedCase.Status != "Dispatched")
            {
                AddNotification($"Case #{selectedCase.CaseId} is not in a dispatched state.");
                return;
            }

            AddNotification($"Mission tracking started → Case #{selectedCase.CaseId}");
            missionTracker.ResetSignal();

            await missionTracker.TrackMissionAsync(selectedCase);
            missionTracker.WaitForMissionCompletion();

            dispatchCoordinator.ReleaseResponder(selectedCase.AssignedResponder);

            AddNotification($"Mission completed → Case #{selectedCase.CaseId}");
            AddNotification($"{selectedCase.AssignedResponder} is now available");

            RefreshRequests();
            RefreshResponders();
        }

        private void RefreshRequests()
        {
            lstRequests.Items.Clear();

            foreach (var r in requestManager.GetAllRequests())
            {
                lstRequests.Items.Add(r);
            }
        }

        private void RefreshResponders()
        {
            lstResponders.Items.Clear();

            foreach (var r in dispatchCoordinator.GetAllResponders())
            {
                lstResponders.Items.Add(r);
            }
        }

        private void AddNotification(string msg)
        {
            lstNotifications.Items.Add($"{DateTime.Now:HH:mm:ss} | {msg}");

            if (lstNotifications.Items.Count > 0)
            {
                lstNotifications.TopIndex = lstNotifications.Items.Count - 1;
            }
        }

        private void label3_Click(object sender, EventArgs e) { }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) { }
        private void label7_Click(object sender, EventArgs e) { }
        private void label6_Click(object sender, EventArgs e) { }
        private void lstResponders_SelectedIndexChanged(object sender, EventArgs e) { }
        private void lstNotifications_SelectedIndexChanged(object sender, EventArgs e) { }

        private void label7_Click_1(object sender, EventArgs e)
        {

        }
    }
}