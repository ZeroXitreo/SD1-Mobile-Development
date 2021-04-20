namespace Exam.Model
{
    public class Program
    {
        public Program(string programName, string programInfo)
        {
            ProgramName = programName;
            ProgramInfo = programInfo;
        }

        public string ProgramName { get; }
        public string ProgramInfo { get; }
    }
}