﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace C4WX1_DbMigrator.Models;

public partial class VitalSign
{
    public int id { get; set; }

    public int patientId { get; set; }

    public string source { get; set; }

    public int icaId { get; set; }

    public bool isDeleted { get; set; }

    public int? createdBy { get; set; }

    public DateTime createdDate { get; set; }

    public int? updatedBy { get; set; }

    public DateTime? updatedDate { get; set; }

    public virtual ICollection<CareReport> CareReports { get; set; } = new List<CareReport>();

    public virtual ICollection<InitialCareAssessment> InitialCareAssessments { get; set; } = new List<InitialCareAssessment>();

    public virtual ICollection<PatientWoundVisit> PatientWoundVisits { get; set; } = new List<PatientWoundVisit>();

    public virtual ICollection<VitalSignDetail> VitalSignDetails { get; set; } = new List<VitalSignDetail>();

    public virtual Patient patient { get; set; }
}