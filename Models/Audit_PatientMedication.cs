﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace C4WX1_DbMigrator.Models;

public partial class Audit_PatientMedication
{
    public string AuditAction { get; set; }

    public DateTime ActionTime { get; set; }

    public int PatientMedicationID { get; set; }

    public string Allergies { get; set; }

    public bool? SelfAdminister { get; set; }

    public bool? Compliant { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? CreatedBy_FK { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public int? ModifiedBy_FK { get; set; }

    public bool IsDeleted { get; set; }
}