﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace C4WX1_DbMigrator.Models;

public partial class BillingProposalService
{
    public int BillingProposalServiceID { get; set; }

    public int BillingProposalID_FK { get; set; }

    public DateTime StartDate { get; set; }

    public DateTime EndDate { get; set; }

    public decimal UnitCost { get; set; }

    public string Duration1 { get; set; }

    public string Duration2 { get; set; }

    public string ServiceDescription { get; set; }

    public int Visit { get; set; }

    public int Session { get; set; }

    public decimal Discount { get; set; }

    public DateTime CreatedDate { get; set; }

    public int CreatedBy_FK { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public int? ModifiedBy_FK { get; set; }

    public bool IsDeleted { get; set; }

    public int SessionUsed { get; set; }

    public int ServiceID_FK { get; set; }

    public virtual BillingProposal BillingProposalID_FKNavigation { get; set; }

    public virtual ServiceForBilling ServiceID_FKNavigation { get; set; }
}