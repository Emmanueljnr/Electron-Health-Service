namespace ElectronAPI.Models
{
    public class Doctor
    {
        public Doctor (int id, string name, string email, int phoneNumber, char gender, string profileImg, string address)
        {
            DoctorId = id;
            Name = name;
            Email = email;
            PhoneNumber = phoneNumber;
            Gender = gender; 
            ProfileImg = profileImg;
            Addrress = address;
        }

        public int DoctorId { get; private set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public int PhoneNumber { get; set; }
        public char Gender { get; set; }
        public string ProfileImg { get; set; }
        public string Addrress { get; set; }

        //Relationships
        public List<Patient> Patients { get; set; } //1 doctor has many patienst
        public List<Institution> Institutions { get; set; } //1 doctor can belong to many institutions
        public List<Appointment> Appointments { get; set; } //1 doctor has many appointments 
    }
}
