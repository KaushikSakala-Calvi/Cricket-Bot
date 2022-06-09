namespace TestBot.Helper
{
    static public class LogHelper
    {
        static public void LogMessage(string message)
        {
            System.Diagnostics.Trace.TraceInformation(message);
        }

        static public void LogMessage<T>(T input, string message = null)
        {
            var jsonData = Newtonsoft.Json.JsonConvert.SerializeObject(input);
            if (message != null) System.Diagnostics.Trace.TraceInformation(message);
            System.Diagnostics.Trace.TraceInformation(jsonData.ToString());
        }
    }
}
