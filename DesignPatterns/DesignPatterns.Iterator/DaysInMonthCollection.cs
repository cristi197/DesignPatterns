using DesignPatterns.Iterator;
using System.Collections;

class DaysInMonthCollection : IEnumerable<MonthWithDays>
{
    public IEnumerator<MonthWithDays> GetEnumerator()
    {
        return new DaysInMonthEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}
