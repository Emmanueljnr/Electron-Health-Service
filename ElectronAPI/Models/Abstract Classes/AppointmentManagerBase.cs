using ElectronAPI.Models.Interfaces;

namespace ElectronAPI.Models.Abstract_Classes
{
    public abstract class AppointmentManagerBase : IAppointmentManager
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public int PhoneNumber { get; set; }
        public string ProfileImg { get; set; }
        public string Address { get; set; }

        public abstract void BookAppointment();
        public abstract void ViewAppointments();
        public abstract void RescheduleAppointment();
        public abstract void UpdateAppointmentStatus();
        public abstract void CancelAppointment();
        public abstract void AppointmentStatus();
        public abstract void UpdateProfile(); //This is coming from IProfileManager Interface


    }
}
