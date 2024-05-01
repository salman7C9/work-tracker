namespace Build
{
    public class WorkTimeRecord
    {
        public DateTime start { get; set; }
        public DateTime? end { get; set; }
        public TimeSpan duration { get => end.GetValueOrDefault(DateTime.Now) - start; }

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

        public override string ToString()
        {
            return $"({start}, {(end.HasValue ? end.ToString() : "-")})";
        }
    }
}
