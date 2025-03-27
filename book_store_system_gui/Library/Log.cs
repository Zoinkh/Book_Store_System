using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace book_store_system_gui.Library
{
    public class Log
    {
        DateTime currentTim;
        public static void Logger(string message, string filePath = "log.txt")
        {
            try
            {
                string logEntry = $"{DateTime.Now:yyyy-MM-dd HH:mm:ss.fff}_{message}"; // Format: DateTime_message
                File.AppendAllText(filePath, logEntry + Environment.NewLine); // Append to file with newline
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error writing to log file: {ex.Message}");
            }
        }
    }
}
