﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace C4WX1_DbMigrator.Models;

public partial class APIAccessKey
{
    public int APIAccessKeyID { get; set; }

    public string TokenCode { get; set; }

    public string AccessKey { get; set; }

    public DateTime ExpiryDate { get; set; }

    public DateTime CreatedDate { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public int? UserId_FK { get; set; }

    public virtual Type TokenCodeNavigation { get; set; }
}