﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace C4WX1_DbMigrator.Models;

public partial class Audit_RegisteredDevice
{
    public string AuditAction { get; set; }

    public DateTime ActionTime { get; set; }

    public int DeviceID { get; set; }

    public int? DeviceType { get; set; }

    public string DeviceToken { get; set; }

    public int? UserID { get; set; }

    public bool? Status { get; set; }
}