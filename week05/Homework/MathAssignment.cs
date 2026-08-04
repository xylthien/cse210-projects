public class MathAssignment : Assignment
{
    private string _textbookSection;
    private string _problems;

    public MathAssignment(string studentName, string topic, string textbookSection, string problems)
    {
        _textbookSection = textbookSection;
        _problems = problems;
        SetStudentName(studentName);
        SetTopic(topic);
    }

    public string GetHomeworkList()
    {
        return $"Section {_textbookSection} Problems {_problems}";
    }
}