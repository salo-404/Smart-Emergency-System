using System.Threading;
using Csc413_project.Models;

namespace Csc413_project.Services
{
    public class MissionTracker
    {
        // ManualResetEvent is used to signal when a mission is completed
        
        private readonly ManualResetEvent _missionCompletedSignal = new(false);

        public async Task TrackMissionAsync(EmergencyCase emergencyCase)
        {
            // simulate mission work
            await Task.Delay(3000);

            // mark case as completed
            emergencyCase.Status = "Completed";

            // signal that mission is done
            _missionCompletedSignal.Set();
        }

        public void WaitForMissionCompletion()
        {
            _missionCompletedSignal.WaitOne();
        }

        public void ResetSignal()
        {
            _missionCompletedSignal.Reset();
        }
    }
}