﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace C4WX1_DbMigrator.Models;

public partial class Audit_NotificationVitalSignDetail
{
    public string AuditAction { get; set; }

    public DateTime ActionTime { get; set; }

    public int id { get; set; }

    public int notificationId { get; set; }

    public DateTime createdDate { get; set; }

    public DateTime? updatedDate { get; set; }

    public int VitalSignDetailId { get; set; }
}