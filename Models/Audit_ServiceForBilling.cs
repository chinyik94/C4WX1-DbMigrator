﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace C4WX1_DbMigrator.Models;

public partial class Audit_ServiceForBilling
{
    public string AuditAction { get; set; }

    public DateTime ActionTime { get; set; }

    public int ServiceForBillingID { get; set; }

    public int CategoryID_FK { get; set; }

    public string Title { get; set; }

    public string Description { get; set; }

    public string Duration1 { get; set; }

    public string Duration2 { get; set; }

    public DateTime CreatedDate { get; set; }

    public int CreatedBy_FK { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public int? ModifiedBy_FK { get; set; }

    public bool IsDeleted { get; set; }
}