using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public interface IExamInfo
{
    int duration { get; }
}
internal class Exam : Test, IExamInfo, IComparable<Exam>
{
    private string examDate;
    public int duration { get; }

    public Exam(string subject, int maxScore, string examDate, int duration)
        : base(subject, maxScore)
    {
        this.examDate = examDate;
        this.duration = duration;
    }

    public override void ConductTest()
    {
        Console.WriteLine($"Conducting exam for {subject} on {examDate} and max score {maxScore}, duration {duration} min.");
    }

    public int CompareTo(Exam? other)
    {
        if (other == null) return 1;
        return this.duration.CompareTo(other.duration);
    }

    public new IEnumerator<Test> GetEnumerator()
    {
        yield return this;
    }
}

