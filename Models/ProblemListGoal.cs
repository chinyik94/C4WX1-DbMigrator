﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace C4WX1_DbMigrator.Models;

public partial class ProblemListGoal
{
    public int ProblemListGoalID { get; set; }

    public int ProblemListID_FK { get; set; }

    public string Goal { get; set; }

    public int? Action { get; set; }

    public int? ScoreTypeID { get; set; }

    public int? OperatorID { get; set; }

    public virtual ICollection<CarePlanSubProblemListGoal> CarePlanSubProblemListGoals { get; set; } = new List<CarePlanSubProblemListGoal>();

    public virtual Code Operator { get; set; }

    public virtual ProblemList ProblemListID_FKNavigation { get; set; }

    public virtual Code ScoreType { get; set; }
}