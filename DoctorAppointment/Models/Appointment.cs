using System.ComponentModel.DataAnnotations;

namespace DoctorAppointment.Models
{
    public class Appointment
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public DateTime  CreatedDate { get; set; }
        public int   DoctorId { get; set; }
        public Doctor? Doctors { get; set; }

        // FK for Patient
   
        public int PatientId { get; set; }
        public Patient? Patients { get; set; }
    }
}
