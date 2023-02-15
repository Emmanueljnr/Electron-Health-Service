namespace ElectronAPI.Models.Interfaces
{
    public interface IAppointmentManager : IProfileManager
    {
        void BookAppointment();
        void ViewAppointments();
        void CancelAppointment();
        void RescheduleAppointment(); 
        void AppointmentStatus(); // Gives User the ability to View & Edit the appointment Status depending on [Doctor / Patient ]
    }
}
