using System;

public class Assignment
{
    private string studentName;
    private string topic;
    
    public Assignment(string name, string subject)
    {
        studentName = name;
        topic = subject;
    }

    public string GetSummary()
    {
        return(studentName + "-" + topic);
    }
    
    public string GetTopic()
    {
        return(topic);
    }

    public string GetName()
    {
        return(studentName);
    }
}