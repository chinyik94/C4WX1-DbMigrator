﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace C4WX1_DbMigrator.Models;

public partial class PatientWoundVisitClinician
{
    public int PatientWoundVisitClinicianID { get; set; }

    public int? PatientWoundVisitID_FK { get; set; }

    public int? UserID_FK { get; set; }

    public int? ExternalDoctorID_FK { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? CreatedBy_FK { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public int? ModifiedBy_FK { get; set; }

    public bool IsDeleted { get; set; }

    public virtual ExternalDoctor ExternalDoctorID_FKNavigation { get; set; }

    public virtual PatientWoundVisit PatientWoundVisitID_FKNavigation { get; set; }

    public virtual User UserID_FKNavigation { get; set; }
}