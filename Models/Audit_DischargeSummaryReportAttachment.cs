﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace C4WX1_DbMigrator.Models;

public partial class Audit_DischargeSummaryReportAttachment
{
    public string AuditAction { get; set; }

    public DateTime ActionTime { get; set; }

    public int DischargeSummaryReportAttachmentID { get; set; }

    public int DischargeSummaryReportID_FK { get; set; }

    public string Filename { get; set; }

    public string Physical { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? CreatedBy_FK { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public int? ModifiedBy_FK { get; set; }

    public bool IsDeleted { get; set; }
}