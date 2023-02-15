using ElectronAPI.Models.Abstract_Classes;

namespace ElectronAPI.Models
{
    public class Institution : User
    {
        public Institution(int id, string name, string email, int phoneNumber, string address)
        {
            InstitutionId = id;
            Name = name;
            Email = email;
            PhoneNumber = phoneNumber;
            Address = address;

            Doctors = new List<Doctor>();
            Patients = new List<Patient>();
            Appointments = new List<Appointment>();
        }

        #region Properties
        public int InstitutionId { get; private set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public int PhoneNumber { get; set; }
        public string Address { get; set; }
        #endregion

        #region Relationships
        public List<Doctor> Doctors { get; set; } //1 institution will have many Doctors 
        public List<Patient> Patients { get; set; } //1 institution will have many patients
        public List<Appointment> Appointments { get; set; } //1 institution will have multiple appointments 
        #endregion

        public void HireDoctor() { }
        public void FireDoctor() { }
        public void ViewPatients() { }
        public void DesignatePatients() { } 
        public void PrescribeMedication() { }

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
