using ElectronAPI.Models.Abstract_Classes;

namespace ElectronAPI.Models
{
    public class Appointment : AppointmentManagerBase
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

        public override void AppointmentStatus()
        {
            throw new NotImplementedException();
        }

        public override void BookAppointment()
        {
            throw new NotImplementedException();
        }

        public override void CancelAppointment()
        {
            throw new NotImplementedException();
        }

        public override void RescheduleAppointment()
        {
            throw new NotImplementedException();
        }

        public override void UpdateAppointmentStatus()
        {
            throw new NotImplementedException();
        }

        public override void UpdateProfile()
        {
            throw new NotImplementedException();
        }

        public override void ViewAppointments()
        {
            throw new NotImplementedException();
        }
    }
}
