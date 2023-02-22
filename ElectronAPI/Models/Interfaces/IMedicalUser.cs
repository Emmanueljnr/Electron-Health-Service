namespace ElectronAPI.Models.Interfaces
{
    public interface IMedicalUser
    {
        void UpdateProfile();
        void ViewAppointments();
        void CancelAppointment();
        void RescheduleAppointment();
        void AppointmentStatus();
    }
}
