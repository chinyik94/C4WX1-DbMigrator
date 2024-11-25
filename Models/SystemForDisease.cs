﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace C4WX1_DbMigrator.Models;

public partial class SystemForDisease
{
    public int SystemID { get; set; }

    public string System { get; set; }

    public bool IsSystemUsed { get; set; }

    public bool IsDeleted { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? CreatedBy_FK { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public int? ModifiedBy_FK { get; set; }

    public int? GroupCode { get; set; }

    public virtual ICollection<CarePlanDetail> CarePlanDetails { get; set; } = new List<CarePlanDetail>();

    public virtual ICollection<Disease> Diseases { get; set; } = new List<Disease>();
}