﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace C4WX1_DbMigrator.Models;

public partial class Audit_EnquirySCM
{
    public string AuditAction { get; set; }

    public DateTime ActionTime { get; set; }

    public int EnquiryConfigID_FK { get; set; }

    public int UserID_FK { get; set; }
}