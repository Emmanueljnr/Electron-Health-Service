using ElectronAPI.Models.Abstract_Classes;

namespace ElectronAPI.Models.Users
{
    public class Appointment
    {
        public Appointment(int id, string status, DateTime dateTime)
        {
            AppointmentId = id;
            Status = status;
            DateTime = dateTime;
        }

        #region Properties
        public int AppointmentId { get; private set; }
        public string Status { get; set; }
        public DateTime DateTime { get; set; }
        #endregion

        #region Relationships
        public Patient Patient { get; set; } // 1 appointment has one patient
        public Doctor Doctor { get; set; } // 1 appointment has one doctor
        public int InstitutionId { get; set; }
        public Institution Institution { get; set; }
        #endregion
    }
}
