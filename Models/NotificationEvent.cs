﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace C4WX1_DbMigrator.Models;

public partial class NotificationEvent
{
    public int NotificationEventID { get; set; }

    public int NotificationId_FK { get; set; }

    public int EventID_FK { get; set; }

    public DateTime CreatedDate { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public virtual Event EventID_FKNavigation { get; set; }

    public virtual Notification NotificationId_FKNavigation { get; set; }
}