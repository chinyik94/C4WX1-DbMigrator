﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace C4WX1_DbMigrator.Models;

public partial class Event
{
    public int EventID { get; set; }

    public string EventName { get; set; }

    public int EventTypeID_FK { get; set; }

    public int PeriodTypeID_FK { get; set; }

    public DateTime FromDate { get; set; }

    public DateTime ToDate { get; set; }

    public string Remarks { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? CreatedBy_FK { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public int? ModifiedBy_FK { get; set; }

    public bool IsDeleted { get; set; }

    public int? UserCategory_FK { get; set; }

    public virtual User CreatedBy_FKNavigation { get; set; }

    public virtual Code EventTypeID_FKNavigation { get; set; }

    public virtual ICollection<EventUserLog> EventUserLogs { get; set; } = new List<EventUserLog>();

    public virtual ICollection<EventUser> EventUsers { get; set; } = new List<EventUser>();

    public virtual ICollection<NotificationEvent> NotificationEvents { get; set; } = new List<NotificationEvent>();

    public virtual Code PeriodTypeID_FKNavigation { get; set; }

    public virtual UserCategory UserCategory_FKNavigation { get; set; }
}