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



        public void ViewPatients() { }
        public void AppointmentStatus(string status) { } // Complete or No show, Waiting, Rescheduled.. [return Boolean value] - Once ViewPatients has run, change AppointmentStatus
        public void PrescribeMedication() { } //return a simple string for now
        public void ViewAppointments(Appointment appointment) { }
        public void doctorAvailability(string availability) { }
        public void BookAppointment(Appointment appointment) {} //book a follow up/routine appointment with a patient
        public void RescheduleAppointment(Appointment appointment, DateTime newDateTime) { }
        public void CancelAppointment(Appointment appointment) { }
        public void UpdateProfile() { } // Allow Patient to update ONLY their profileImg
    }
}
