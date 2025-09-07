using System.ComponentModel.DataAnnotations;

namespace DoctorAppointment.Models
{
    public class Doctor
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Phone { get; set; }
        public string? Spec { get; set; }
        public string? LicenseFile { get; set; }

        public ICollection<Appointment> Appointments { get; set; } = new List<Appointment>();
       
    }
}
