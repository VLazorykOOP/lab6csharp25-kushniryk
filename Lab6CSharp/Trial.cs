using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public interface ITrialInfo
{
    int duration { get; }
}
internal class Trial : Test, ITrialInfo, IComparable<Trial>
{
    private string trialType;
    public int duration { get; }

    public Trial(string subject, int maxScore, string trialType, int duration)
        : base(subject, maxScore)
    {
        this.trialType = trialType;
        this.duration = duration;
    }

    public override void ConductTest()
    {
        Console.WriteLine($"Conducting trial for {subject} of type {trialType} and max score {maxScore}, duration {duration} min.");
    }
    public int CompareTo(Trial? other)
    {
        if (other == null) return 1;
        return this.duration.CompareTo(other.duration);
    }

    public new IEnumerator<Test> GetEnumerator()
    {
        yield return this;
    }
}

