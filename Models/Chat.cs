﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace C4WX1_DbMigrator.Models;

public partial class Chat
{
    public int ChatID { get; set; }

    public string Comment { get; set; }

    public string Attachment { get; set; }

    public string Attachment_Physical { get; set; }

    public int? ParentID_FK { get; set; }

    public int? PatientID_FK { get; set; }

    public DateTime CreatedDate { get; set; }

    public int CreatedBy_FK { get; set; }

    public bool IsDeleted { get; set; }

    public bool? Family { get; set; }

    public virtual User CreatedBy_FKNavigation { get; set; }

    public virtual ICollection<Chat> InverseParentID_FKNavigation { get; set; } = new List<Chat>();

    public virtual ICollection<NotificationChat> NotificationChats { get; set; } = new List<NotificationChat>();

    public virtual Chat ParentID_FKNavigation { get; set; }

    public virtual Patient PatientID_FKNavigation { get; set; }
}