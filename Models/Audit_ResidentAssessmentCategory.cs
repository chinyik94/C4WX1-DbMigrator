﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace C4WX1_DbMigrator.Models;

public partial class Audit_ResidentAssessmentCategory
{
    public string AuditAction { get; set; }

    public DateTime ActionTime { get; set; }

    public int ResidentAssessmentCategoryID { get; set; }

    public string Category1Description { get; set; }

    public string Category1Recommendation { get; set; }

    public string Category2Description { get; set; }

    public string Category2Recommendation { get; set; }

    public string Category3Description { get; set; }

    public string Category3Recommendation { get; set; }

    public string Category4Description { get; set; }

    public string Category4Recommendation { get; set; }

    public bool IsDeleted { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? CreatedBy_FK { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public int? ModifiedBy_FK { get; set; }
}