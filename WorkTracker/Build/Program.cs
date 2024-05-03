using System.Text.Json;

namespace Build
{
    public class Program
    {

        static List<WorkTimeRecord> workTimeRecords = new List<WorkTimeRecord>();

        public static void Main(string[] args)
        {
            if (args.Length == 1)
            {
                // read records from file
                workTimeRecords = ReadWorkRecordsFromFile();

                switch (args[0])
                {
                    case "start":
                        var newWorkRecord = new WorkTimeRecord();
                        workTimeRecords.Add(newWorkRecord);
                        Console.WriteLine($"started at {newWorkRecord.start}");
                        break;
                    case "stop":
                        try
                        {
                            var lastWorkRecord = workTimeRecords.Last();
                            lastWorkRecord.end = DateTime.Now;
                            Console.WriteLine($"stopped at {lastWorkRecord.end}");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"Issue occurred while trying to fetch last work record: {ex}");
                        }
                        break;
                    default:
                        Console.WriteLine($"Invalid command '{args[0]}'");
                        break;
                }
                // write work records to file
                StoreWorkRecordsToFile(workTimeRecords);
            }
            else
            {
                Console.WriteLine(
                    "Please select if you want to start a new record " +
                    "or stop an existing record by typing 'start' or 'stop'"
                    );
            }
        }

        private static List<WorkTimeRecord> ReadWorkRecordsFromFile(String filePath = "work-records.json")
        {
            try
            {
                var jsonString = File.ReadAllText(filePath);
                List<WorkTimeRecord> workTimeRecords = JsonSerializer.Deserialize<List<WorkTimeRecord>>(jsonString)!;
                workTimeRecords.ForEach(x => Console.WriteLine(x));

                Console.WriteLine(jsonString);
                return workTimeRecords;
            } catch (JsonException ex) {
                Console.WriteLine($"Error occured while trying to read record file: {ex.Message}");
                return new List<WorkTimeRecord>();
            }
        }

        private static void StoreWorkRecordsToFile(List<WorkTimeRecord> workRecords, String filePath = "work-records.json")
        {
            string jsonString = JsonSerializer.Serialize(workRecords);
            Console.WriteLine($"writing to file '{filePath}'");

            using (StreamWriter sw = File.CreateText(filePath))
            {
                sw.WriteLine(jsonString);
            }
        }
    }
}
