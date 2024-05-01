using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Build
{
    public class WorkTimeRecord
    {
        DateTime start;
        DateTime? end;

        public WorkTimeRecord() : this(DateTime.Now, null)
        {
        }

        public WorkTimeRecord(DateTime start) : this(start, null)
        {
        }

        public WorkTimeRecord(DateTime start, DateTime? end)
        {
            this.start = start;
            this.end = end;
        }

        public TimeSpan GetDuration()
        {
            return end.GetValueOrDefault(DateTime.Now) - start;
        }
    }
}
