﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace C4WX1_DbMigrator.Models;

public partial class Audit_UserCategory
{
    public string AuditAction { get; set; }

    public DateTime ActionTime { get; set; }

    public int UserCategoryID { get; set; }

    public string UserCategory { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? CreatedBy_FK { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public int? ModifiedBy_FK { get; set; }

    public bool IsDeleted { get; set; }

    public int? UserCategoryOrganizationID_FK { get; set; }

    public bool? EnableGeoFencing { get; set; }
}