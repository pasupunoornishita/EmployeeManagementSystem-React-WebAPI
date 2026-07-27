namespace EmployeeManagementAPI.Singleton
{
    public sealed class Logger
    {
        private static readonly Logger _instance =
            new Logger();

        private Logger()
        {
        }

        public static Logger Instance
        {
            get
            {
                return _instance;
            }
        }

        public void Log(string message)
        {
            Console.WriteLine(
                $"[LOG]: { message}");
        }
    }
}