namespace ElectronAPI.Models.Interfaces
{
    public interface IPatient
    {
        void ViewDoctorSchedule();
        void RequestAppointment();
        void ViewPrescriptions();
        void Request_Prescription_Refill();
        void PayBill();
        void ViewBill();
    }
}
