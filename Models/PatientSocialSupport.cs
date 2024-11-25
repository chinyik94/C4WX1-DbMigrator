﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace C4WX1_DbMigrator.Models;

public partial class PatientSocialSupport
{
    public int PatientSocialSupportID { get; set; }

    public int? PatientID_FK { get; set; }

    public int? InitialCareAssessmentID_FK { get; set; }

    public string Firstname { get; set; }

    public string Lastname { get; set; }

    public int? GenderID_FK { get; set; }

    public int? MaritalStatusID_FK { get; set; }

    public int? RelationshipID_FK { get; set; }

    public int? NationalityID_FK { get; set; }

    public string Contact { get; set; }

    public string Email { get; set; }

    public bool? NotifyEmail { get; set; }

    public bool? NotifySMS { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? CreatedBy_FK { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public int? ModifiedBy_FK { get; set; }

    public bool IsDeleted { get; set; }

    public bool? NotifyPhoneCall { get; set; }

    public bool? Spokeperson { get; set; }

    public bool? CanLogin { get; set; }

    public bool? BillTo { get; set; }

    public string UserType { get; set; }

    public virtual ICollection<CareReportSocialSupport> CareReportSocialSupports { get; set; } = new List<CareReportSocialSupport>();

    public virtual Code GenderID_FKNavigation { get; set; }

    public virtual InitialCareAssessment InitialCareAssessmentID_FKNavigation { get; set; }

    public virtual Code MaritalStatusID_FKNavigation { get; set; }

    public virtual Code NationalityID_FKNavigation { get; set; }

    public virtual Patient PatientID_FKNavigation { get; set; }

    public virtual Code RelationshipID_FKNavigation { get; set; }
}