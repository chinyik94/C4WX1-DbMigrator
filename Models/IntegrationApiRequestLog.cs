﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace C4WX1_DbMigrator.Models;

public partial class IntegrationApiRequestLog
{
    public int IntegrationApiRequestLogID { get; set; }

    public string IntegrationSource { get; set; }

    public string FacilityId { get; set; }

    public string ResidentId { get; set; }

    public string Url { get; set; }

    public string Content { get; set; }

    public string Status { get; set; }

    public int? CreatedByID_FK { get; set; }

    public DateTime? Timestamp { get; set; }
}