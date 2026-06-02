namespace Csc413_project.Models
{
    public class ResponderUnit
    {
        public int ResponderId { get; set; }
        public string ResponderName { get; set; } = string.Empty;
        public string ResponderType { get; set; } = string.Empty;
        public bool IsAvailable { get; set; } = true;
        public string CurrentMission { get; set; } = "None";

        public override string ToString()
        {
            string status = IsAvailable ? "Available" : "Busy";
            return $"{ResponderName} | {ResponderType} | {status} | {CurrentMission}";
        }
    }
}