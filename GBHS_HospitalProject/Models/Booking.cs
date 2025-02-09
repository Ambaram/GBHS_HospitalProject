﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace GBHS_HospitalProject.Models
{
    public class Booking
    {
        [Key]
        public int BookingID { get; set; }
        public DateTime BookingStartTime { get; set; }
        public DateTime BookingEndTime { get; set; }
        public string BookingReasonToVisit { get; set; }

        [ForeignKey("Patient")]
        public string PatientID { get; set; }
        public virtual Patient Patient { get; set; }

        [ForeignKey("Specialist")]
        public int? SpecialistID { get; set; }
        public virtual Specialist Specialist { get; set; }
    }

    //DTO class
    public class BookingDto
    {
        public BookingDto()
        {

        }
        public BookingDto(int bookingID, DateTime bookingStartTime, DateTime bookingEndTime, string bookingReasonToVisit, string patientID, string patientFirstName, string patientLastName, int specialistID, string specialistFirstName, string specialistLastName)
        {
            BookingID = bookingID;
            BookingStartTime = bookingStartTime;
            BookingEndTime = bookingEndTime;
            BookingReasonToVisit = bookingReasonToVisit;
            PatientID = patientID;
            PatientFirstName = patientFirstName;
            PatientLastName = patientLastName;
            SpecialistID = specialistID;
            SpecialistFirstName = specialistFirstName;
            SpecialistLastName = specialistLastName;
        }
        public BookingDto(int bookingID, DateTime bookingStartTime, DateTime bookingEndTime, string bookingReasonToVisit, int specialistID, string specialistFirstName, string specialistLastName)
        {
            BookingID = bookingID;
            BookingStartTime = bookingStartTime;
            BookingEndTime = bookingEndTime;
            BookingReasonToVisit = bookingReasonToVisit;
            SpecialistID = specialistID;
            SpecialistFirstName = specialistFirstName;
            SpecialistLastName = specialistLastName;
        }

        public BookingDto(int bookingID, DateTime bookingStartTime, DateTime bookingEndTime, string bookingReasonToVisit)
        {
            BookingID = bookingID;
            BookingStartTime = bookingStartTime;
            BookingEndTime = bookingEndTime;
            BookingReasonToVisit = bookingReasonToVisit;
        }

        public int BookingID { get; set; }
        public DateTime BookingStartTime { get; set; }
        public DateTime BookingEndTime { get; set; }
        public string BookingReasonToVisit { get; set; }
        public string PatientID { get; set; }
        public string PatientFirstName { get; set; }
        public string PatientLastName { get; set; }
        public string PatentPhoneNumber { get; set; }//used for loading patient in booking update page
        public int SpecialistID { get; set; }
        public string SpecialistFirstName { get; set; }
        public string SpecialistLastName { get; set; }
    }
}



