using ElectronAPI.Models.Abstract_Classes;
using ElectronAPI.Models.Interfaces;

namespace ElectronAPI.Models.Users
{
    public class Doctor
    {
        public Doctor(int id, string name, string email, int phoneNumber, char gender, string profileImg, string address)
        {
            DoctorId = id;
            Name = name;
            Email = email;
            PhoneNumber = phoneNumber;
            Gender = gender;
            ProfileImg = profileImg;
            Address = address;

            Patients = new List<Patient>();
            Institutions = new List<Institution>();
            Appointments = new List<Appointment>();
        }

        #region Properties
        public int DoctorId { get; private set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public int PhoneNumber { get; set; }
        public char Gender { get; set; }
        public string ProfileImg { get; set; }
        public string Address { get; set; }
        #endregion

        #region Relationships
        public List<Patient> Patients { get; set; } //1 doctor has many patienst
        public List<Institution> Institutions { get; set; } //1 doctor can belong to many institutions
        public List<Appointment> Appointments { get; set; } //1 doctor has many appointments 
        #endregion


    }
}
