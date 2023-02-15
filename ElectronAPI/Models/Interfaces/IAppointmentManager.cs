namespace ElectronAPI.Models.Interfaces
{
    public interface IAppointmentManager
    {
        public void BookAppointment();
        public void viewAppointments();
        public void appointmentStatus();
        public void cancelAppointment();
        public void rescheduleAppointment();
    }
}
