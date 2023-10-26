public class MathAssignment : Assignment 
{
    private string section;
    private string questionNumbers;

    public MathAssignment(string studentName, string topic, string selection, string Questions) 
        : base(studentName, topic) 
    {
        section = selection;
        questionNumbers = Questions;
    }

    public string GetHomework()
    {
        return($"Section - {section} Questions - {questionNumbers}");
    }
}