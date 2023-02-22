using ElectronAPI.Models.Abstract_Classes;

namespace ElectronAPI.Models.Users
{
    public class Nurse : User
    {
        public Nurse(int id, string name, string email, int phoneNumber, string profileImg, string address) : base(id, name, email, phoneNumber, profileImg, address)
        {
            Console.WriteLine("Hi, I am the Nurse object");
        }

        public override void AppointmentStatus()
        {
            throw new NotImplementedException();
        }

        public override void BookAppointment()
        {
            throw new NotImplementedException();
        }

        public override void CancelAppointment()
        {
            throw new NotImplementedException();
        }

        public override void RescheduleAppointment()
        {
            throw new NotImplementedException();
        }

        public override void ViewAppointments()
        {
            throw new NotImplementedException();
        }
    }
}
