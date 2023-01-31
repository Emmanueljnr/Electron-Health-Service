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

        public List<Appointment> Appointments { get; set; } //1 institution will have multiple appointments 


        public void hireDoctor() { }
        public void fireDoctor() { }
        public void ViewPatients() { }
        public void designatePatients() { } //assign particular patients to a particular doctor
        public void PrescribeMedication() { } //return a simple string for now
        public void ViewAppointments(Appointment appointment) { }
        public void AppointmentStatus(string status) { } // Complete or No show, Waiting, Rescheduled.. [return Boolean value] - Once ViewPatients has run, change AppointmentStatus
        public void doctorAvailability(string availability) { }
        public void BookAppointment(Appointment appointment) { } //book a new appointment
        public void RescheduleAppointment(Appointment appointment, DateTime newDateTime) { }
        public void CancelAppointment(Appointment appointment) { }
        public void UpdateProfile() { } // Allow Patient to update ONLY their profileImg
    }
}
