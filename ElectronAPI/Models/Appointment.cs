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

        /// <summary>
        /// Relationships
        /// </summary>
        public Patient Patient { get; set; } // 1 appointment has one patient
        public Doctor Doctor { get; set; } // 1 appointment has one doctor



        public void BookAppointment(Appointment appointment) { } //book a new appointment
        public void ViewAppointments(Appointment appointment) { } // view existing appointments 
        public void RescheduleAppointment(Appointment appointment, DateTime newDateTime) { }
        public void CancelAppointment(Appointment appointment) { } 
        public void AppointmentStatus(string status) {  } // Complete or not [return Boolean value]#

    }
}
