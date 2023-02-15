namespace ElectronAPI.Models.Interfaces
{
    public interface IProfileManager
    {
        string Name { get; set; }
        string Email { get; set; }
        int PhoneNumber { get; set; }
        string ProfileImg { get; set; }
        string Address { get; set; }
        void UpdateProfile();
    }
}
