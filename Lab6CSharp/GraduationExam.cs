using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public interface IGrExamInfo
{
    int duration { get; }
}
internal class GraduationExam : Test, IGrExamInfo, IComparable<GraduationExam>
{
    private string graduationDate;
    public int duration { get; }

    public GraduationExam(string subject, int maxScore, string graduationDate, int duration)
        : base(subject, maxScore)
    {
        this.graduationDate = graduationDate;
        this.duration = duration;
    }

    public override void ConductTest()
    {
        Console.WriteLine($"Conducting graduation exam for {subject} on {graduationDate} and max score {maxScore}, duration {duration} min.");
    }
    public int CompareTo(GraduationExam? other)
    {
        if (other == null) return 1;
        return this.duration.CompareTo(other.duration);
    }

    public new IEnumerator<Test> GetEnumerator()
    {
        yield return this;
    }
}

