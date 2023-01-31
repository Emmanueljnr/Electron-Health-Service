namespace ElectronAPI.Models
{
    public class Appointment
    {
        public Appointment(int id, string status, DateTime dateTime)
        {
            AppointmentId = id;
            Status = status;
            DateTime = dateTime;
        }

        public int AppointmentId { get; private set; }
        public string Status { get; set; }
        public DateTime DateTime { get; set; }

        //Relationships
        public Patient Patient { get; set; } // 1 appointment has one patient
        public Doctor Doctor { get; set; } // 1 appointment has one doctor
    }
}
