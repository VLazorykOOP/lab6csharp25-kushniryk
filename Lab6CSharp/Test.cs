using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


abstract class Test : IEnumerable<Test>
{
    protected string subject;
    protected int maxScore;

    public Test(string subject, int maxScore)
    {
        this.subject = subject;
        this.maxScore = maxScore;
    }

    public abstract void ConductTest();

    public IEnumerator<Test> GetEnumerator()
    {
        yield return this;
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}

