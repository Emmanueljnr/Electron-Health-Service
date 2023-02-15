using ElectronAPI.Models.Abstract_Classes;
using ElectronAPI.Models.Interfaces;

namespace ElectronAPI.Models
{
    public class Patient : User, IAppointmentManager
    {
        public Patient(int id, string name, string email, int phoneNumber, char bloodtype, char gender, string profileimg, string address)
        {
            PatientId = id;
            Name = name;
            Email = email;  
            PhoneNumber = phoneNumber;
            BloodType = bloodtype;
            Gender = gender;
            ProfileImg = profileimg;
            Address = address;

            Appointments = new List<Appointment>();
            Institutions = new List<Institution>();
        }

        #region Properties
        public int PatientId { get; private set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public int PhoneNumber { get; set; }
        public char BloodType { get; set; }
        public char Gender { get; set; }
        public string ProfileImg { get; set; }
        public string Address { get; set; }
        #endregion

        #region Relationships
        public List<Appointment> Appointments { get; set; }
        public List<Institution> Institutions { get; set; }
        public int PrimaryDoctorId { get; set; }
        public Doctor PrimaryDoctor { get; set; }
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
