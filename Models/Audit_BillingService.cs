﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace C4WX1_DbMigrator.Models;

public partial class Audit_BillingService
{
    public string AuditAction { get; set; }

    public DateTime ActionTime { get; set; }

    public int ServiceID { get; set; }

    public string Title { get; set; }

    public int CategoryID_FK { get; set; }

    public decimal CostPerSession { get; set; }

    public bool Weekend { get; set; }

    public string Status { get; set; }

    public string Remarks { get; set; }

    public DateTime CreatedDate { get; set; }

    public int CreatedBy_FK { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public int? ModifiedBy_FK { get; set; }

    public bool IsDeleted { get; set; }
}