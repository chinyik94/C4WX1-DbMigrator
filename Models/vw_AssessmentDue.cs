﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace C4WX1_DbMigrator.Models;

public partial class vw_AssessmentDue
{
    public int patientId { get; set; }

    public string source { get; set; }

    public int icaId { get; set; }

    public DateTime createdDate { get; set; }

    public int? createdBy { get; set; }

    public DateTime? updatedDate { get; set; }

    public int? updatedBy { get; set; }

    public string AssessmentName { get; set; }

    public DateTime? DueDate { get; set; }
}