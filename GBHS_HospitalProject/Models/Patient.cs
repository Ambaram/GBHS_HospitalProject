﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace GBHS_HospitalProject.Models
{
    public class Patient
    {
        [Key,ForeignKey("ApplicationUser")]
        public string PatientID { get; set; }
        public virtual ApplicationUser ApplicationUser { get; set; }

        public string PatientFirstName { get; set; }
        public string PatientLastName { get; set; }
        public string PatientEmail { get; set; }
        public string PatientPhoneNumber { get; set; }
        public string PatientGender { get; set; }

        public ICollection<Booking> PatientBookings { get; set; }

        
        
    }

    //DTO
    public class PatientDto
    {
        public PatientDto(string patientID, string patientFirstName, string patientLastName, string patientPhoneNumber, string patientEmail, string patientGender)
        {
            PatientID = patientID;
            PatientFirstName = patientFirstName;
            PatientLastName = patientLastName;
            PatientPhoneNumber = patientPhoneNumber;
            PatientEmail = patientEmail;
            PatientGender = patientGender;
        }

        public string PatientID { get; set; }
        [Display(Name = "First name")]
        public string PatientFirstName { get; set; }
        [Display(Name = "Last name")]
        public string PatientLastName { get; set; }
        [Display(Name = "Email")]
        public string PatientEmail { get; set; }
        [Display(Name = "Phone number")]
        public string PatientPhoneNumber { get; set; }
        [Display(Name = "Gender")]
        public string PatientGender { get; set; }
    }
}