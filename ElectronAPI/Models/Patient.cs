namespace ElectronAPI.Models
{
    public class Patient
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
        }

        public int PatientId { get; private set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public int PhoneNumber { get; set; }
        public char BloodType { get; set; }
        public char Gender { get; set; }
        public string ProfileImg { get; set; }
        public string Address { get; set; }

        /// <summary>
        /// Relationships
        /// </summary>
        public List<Appointment> Appointments { get; set; }
        public List<Institution> Institutions { get; set; }

        public void ViewAppointments(Appointment appointment) { }
        public void BookAppointment(Appointment appointment) { }
        public void RescheduleAppointment(Appointment appointment) { }
        public void CancelAppointment(Appointment appointment) { }
        public void AppointmentStatus(string status) { } // Complete or not [return Boolean value]
        public void UpdateProfile() { } // Allow Patient to update ONLY their profileImg
    }
}
