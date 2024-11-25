﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace C4WX1_DbMigrator.Models;

public partial class Audit_PatientWound
{
    public string AuditAction { get; set; }

    public DateTime ActionTime { get; set; }

    public int PatientWoundID { get; set; }

    public int? PatientID_FK { get; set; }

    public int? InitialCareAssessmentID_FK { get; set; }

    public DateTime? OccurDate { get; set; }

    public DateTime? SeenDate { get; set; }

    public string Site { get; set; }

    public bool IsDeleted { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? CreatedBy_FK { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public int? ModifiedBy_FK { get; set; }

    public string LocationOfWound { get; set; }

    public int? CareReportID_FK { get; set; }

    public string ActionDescription { get; set; }

    public string Remarks { get; set; }

    public string Category { get; set; }

    public string Stage { get; set; }

    public int? WoundStatusID_FK { get; set; }

    public string Comments { get; set; }

    public string Status { get; set; }

    public string StatusRemark { get; set; }

    public string LocationRemark { get; set; }
}