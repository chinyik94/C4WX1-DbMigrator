﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace C4WX1_DbMigrator.Models;

public partial class Audit_Branch
{
    public string AuditAction { get; set; }

    public DateTime ActionTime { get; set; }

    public int BranchID { get; set; }

    public string BranchName { get; set; }

    public string Address1 { get; set; }

    public string Address2 { get; set; }

    public string Address3 { get; set; }

    public string Contact { get; set; }

    public string Email { get; set; }

    public string Status { get; set; }

    public bool IsSystemUsed { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? CreatedBy_FK { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public int? ModifiedBy_FK { get; set; }

    public bool IsDeleted { get; set; }

    public int? CurrencyID_FK { get; set; }
}