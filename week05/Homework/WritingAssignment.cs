public class WritingAssignment : Assignment
{
    private string _title;

    public WritingAssignment(string studentName, string title)
    {
        _title = title;
        SetStudentName(studentName);
    }

    public string GetWritingInformation()
    {
        return $"{_title} by {GetStudentName()}";
    }
}