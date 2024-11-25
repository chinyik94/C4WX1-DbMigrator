﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace C4WX1_DbMigrator.Models;

public partial class Intervention
{
    public int InterventionID { get; set; }

    public int DiseaseID_FK { get; set; }

    public string InterventionInfo { get; set; }

    public bool IsDeleted { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? CreatedBy_FK { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public int? ModifiedBy_FK { get; set; }

    public virtual Disease DiseaseID_FKNavigation { get; set; }

    public virtual ICollection<CarePlanSub> CarePlanSubID_FKs { get; set; } = new List<CarePlanSub>();
}