namespace Csc413_project.Models
{
    public class EmergencyCase
    {
        public int CaseId { get; set; }
        public string CallerName { get; set; } = string.Empty;
        public string EmergencyType { get; set; } = string.Empty;
        public int Priority { get; set; }
        public string Description { get; set; } = string.Empty;
        public string Status { get; set; } = "Pending";
        public string AssignedResponder { get; set; } = "None";

        public override string ToString()
        {
            return $"Case #{CaseId} | {CallerName} | {EmergencyType} | Priority {Priority} | Status: {Status} | Responder: {AssignedResponder}";
        }
    }
}