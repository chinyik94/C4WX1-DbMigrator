﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace C4WX1_DbMigrator.Models;

public partial class UserType
{
    public int UserTypeID { get; set; }

    public string UserType1 { get; set; }

    public int UserCategoryID_FK { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? CreatedBy_FK { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public int? ModifiedBy_FK { get; set; }

    public bool IsDeleted { get; set; }

    public decimal? ManpowerRate { get; set; }

    public virtual ICollection<CareReportConfig> CareReportConfigs { get; set; } = new List<CareReportConfig>();

    public virtual ICollection<ExternalDoctor> ExternalDoctors { get; set; } = new List<ExternalDoctor>();

    public virtual UserCategory UserCategoryID_FKNavigation { get; set; }

    public virtual ICollection<MailSetting> MailSetting_FKs { get; set; } = new List<MailSetting>();

    public virtual ICollection<User> UserID_FKs { get; set; } = new List<User>();
}