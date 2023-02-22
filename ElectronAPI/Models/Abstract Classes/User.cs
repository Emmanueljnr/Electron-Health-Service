using ElectronAPI.Models.Interfaces;

namespace ElectronAPI.Models.Abstract_Classes
{
    public abstract class User
    {
        #region constructor
        public User(int id, string name, string email, int phoneNumber, string profileImg, string address)
        {
            Id = id;
            Name = name;
            Email = email;
            PhoneNumber = phoneNumber;
            ProfileImg = profileImg;
            Address = address;
        }
        #endregion

        #region Properties
        public int Id { get; private set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public int PhoneNumber { get; set; }
        public string ProfileImg { get; set; }
        public string Address { get; set; }
        #endregion

        public abstract void AppointmentStatus();

        public abstract void BookAppointment();

        public abstract void CancelAppointment();

        public abstract void RescheduleAppointment();

        public virtual void UpdateProfile() 
        {
            //ProfileImg = "https://t4.ftcdn.net/jpg/02/60/04/09/360_F_260040900_oO6YW1sHTnKxby4GcjCvtypUCWjnQRg5.jpg";
        }

        public abstract void ViewAppointments();
    }

}
