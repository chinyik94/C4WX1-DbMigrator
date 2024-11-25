﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace C4WX1_DbMigrator.Models;

public partial class PatientAccessLine
{
    public int PatientAccessLineID { get; set; }

    public string AccessLine { get; set; }

    public int CareReportID_FK { get; set; }

    public DateTime DateOfInsertion { get; set; }

    public string Patent { get; set; }

    public string PatentReSited { get; set; }

    public DateTime? PatentReSitedDate { get; set; }

    public string PatentSite { get; set; }

    public DateTime DateDueForChange { get; set; }

    public string AccessLineRemarks { get; set; }

    public bool IsDeleted { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? CreatedBy_FK { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public int? ModifiedBy_FK { get; set; }

    public virtual CareReport CareReportID_FKNavigation { get; set; }
}