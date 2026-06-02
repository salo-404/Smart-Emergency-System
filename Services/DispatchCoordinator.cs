using Csc413_project.Models;

namespace Csc413_project.Services
{
    public class DispatchCoordinator
    {
        private readonly List<ResponderUnit> _responders;
        private readonly object _lock = new();
        private readonly SemaphoreSlim _semaphore;

        public DispatchCoordinator(List<ResponderUnit> responders, int maxConcurrentDispatches)
        {
            _responders = responders;
            _semaphore = new SemaphoreSlim(maxConcurrentDispatches);
        }

        public List<ResponderUnit> GetAllResponders()
        {
            lock (_lock)
            {
                return new List<ResponderUnit>(_responders);
            }
        }

        public async Task<ResponderUnit?> AssignResponderAsync(EmergencyCase emergencyCase)
        {// SemaphoreSlim limits how many dispatch operations can run at the same time
            await _semaphore.WaitAsync();

            try
            {
                await Task.Delay(1000);
                // lock is used to prevent race conditions when multiple threads access the request list
                lock (_lock)
                {
                    string requestedType = emergencyCase.EmergencyType.Trim();

                    var availableResponder = _responders.FirstOrDefault(r =>
                        r.IsAvailable &&
                        (
                            r.ResponderType.Trim().Equals(requestedType, StringComparison.OrdinalIgnoreCase) ||
                            r.ResponderType.Equals("General", StringComparison.OrdinalIgnoreCase) ||
                            requestedType.Equals("General", StringComparison.OrdinalIgnoreCase)
                        ));

                    if (availableResponder != null)
                    {
                        availableResponder.IsAvailable = false;
                        availableResponder.CurrentMission = $"Case #{emergencyCase.CaseId}";
                        emergencyCase.AssignedResponder = availableResponder.ResponderName;
                        emergencyCase.Status = "Dispatched";
                    }

                    return availableResponder;
                }
            }
            finally
            {
                _semaphore.Release();
            }
        }

        public void ReleaseResponder(string responderName)
        {
            lock (_lock)
            {
                var responder = _responders.FirstOrDefault(r => r.ResponderName == responderName);
                if (responder != null)
                {
                    responder.IsAvailable = true;
                    responder.CurrentMission = "None";
                }
            }
        }
    }
}