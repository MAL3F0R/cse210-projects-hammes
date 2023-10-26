public class WritingAssignment : Assignment
{
private string title;

    public WritingAssignment(string studentName, string topic, string name)
        : base(studentName, topic)
    {
        title = name;
    }

    public string GetWritingInformation()
    {
        string studentName = GetName();
        return($"{title} by {studentName}");
    }
}
