using System;
using System.Security.Cryptography.X509Certificates;

public class WritingAssignment : Assignment
{
    private string _title;

    public WritingAssignment(string title, string name, string topic) : base(name, topic)
    {
        _title = title;
    }

    public string GetWritingInformation()
    {
        string studentName = GetStudentName();
        return $"{_title} by {studentName}";
    }
}