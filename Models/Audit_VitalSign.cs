﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace C4WX1_DbMigrator.Models;

public partial class Audit_VitalSign
{
    public string AuditAction { get; set; }

    public DateTime ActionTime { get; set; }

    public int id { get; set; }

    public int patientId { get; set; }

    public string source { get; set; }

    public int icaId { get; set; }

    public bool isDeleted { get; set; }

    public int? createdBy { get; set; }

    public DateTime createdDate { get; set; }

    public int? updatedBy { get; set; }

    public DateTime? updatedDate { get; set; }
}