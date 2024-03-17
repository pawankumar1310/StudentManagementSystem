using System;
using System.Collections.Generic;

namespace StudentManagementSystem.Models;

public partial class Student
{
    public string StudentId { get; set; } = null!;

    public string Gender { get; set; } = null!;

    public string NationalIty { get; set; } = null!;

    public string PlaceofBirth { get; set; } = null!;

    public string StageId { get; set; } = null!;

    public decimal GradeId { get; set; }

    public string SectionId { get; set; } = null!;

    public string Topic { get; set; } = null!;

    public string Semester { get; set; } = null!;

    public string Relation { get; set; } = null!;

    public byte Raisedhands { get; set; }

    public byte VisItedResources { get; set; }

    public byte AnnouncementsView { get; set; }

    public byte Discussion { get; set; }

    public bool ParentAnsweringSurvey { get; set; }

    public string ParentschoolSatisfaction { get; set; } = null!;

    public string StudentAbsenceDays { get; set; } = null!;

    public byte StudentMarks { get; set; }

    public string Class { get; set; } = null!;
}
