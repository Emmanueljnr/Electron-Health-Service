namespace ElectronAPI.Models
{
    public class Institution
    {
        public Institution(int id, string name, string email, int phoneNumber, string address)
        {
            InstitutionId = id;
            Name = name;
            Email = email;
            PhoneNumber = phoneNumber;
            Address = address;
        }

        public int InstitutionId { get; private set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public int PhoneNumber { get; set; }
        public string Address { get; set; }

        //Relationships
        public List<Doctor> Doctors { get; set; } //1 institution will have many Doctors 
        public List<Patient> Patients { get; set; } //1 institution will have many patients
    }
}
