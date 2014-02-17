namespace RPG.GameSystem.ExceptionLogging
{
    using System;
    using System.IO;
    using System.Text;

    /// <summary>
    /// A class for logging exceptions to a file
    /// </summary>
    public static class LoggerEngine
    {
        private const string File = "Log.txt";
        private const string LogMessage = "Error occurred when writing to the Log file!";

        /// <summary>
        /// Writes the date/time and the exception to a file.
        /// Creates a new file or appends a new line.
        /// </summary>
        /// <param name="e">Input: exception</param>
        public static void Log(Exception e)
        {
            try
            {
                var sb = new StringBuilder();
                if (System.IO.File.Exists(File))
                {
                    var writer = new StreamWriter(File, true);
                    using (writer)
                    {
                        sb.Append(DateTime.Now);
                        sb.Append(" ");
                        sb.Append(e);
                        writer.WriteLine(sb.ToString());
                    }
                }
                else
                {
                    var writer = new StreamWriter(File, false);
                    using (writer)
                    {
                        sb.Append(DateTime.Now);
                        sb.Append(" ");
                        sb.Append(e);
                        writer.WriteLine(sb.ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(LogMessage);
                Console.WriteLine(ex.Message);
            }
        }
    }
}

