using Csc413_project.Models;

namespace Csc413_project.Services
{
    public class EmergencyRequestManager
    {
        private readonly List<EmergencyCase> _requests = new();
        private readonly object _lock = new();

        public void AddRequest(EmergencyCase emergencyCase)
        {
            lock (_lock)
            {
                _requests.Add(emergencyCase);
            }
        }

        public List<EmergencyCase> GetAllRequests()
        {
            lock (_lock)
            {
                return new List<EmergencyCase>(_requests);
            }
        }

        public EmergencyCase? GetNextPendingCase()
        {
            lock (_lock)
            {
                return _requests
                    .Where(c => c.Status == "Pending")
                    .OrderByDescending(c => c.Priority)
                    .FirstOrDefault();
            }
        }
    }
}