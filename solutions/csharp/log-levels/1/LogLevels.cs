static class LogLine
{
    public static string Message(string logLine)
    {
      var splitLogLine = logLine.Split(':').Select(el => el.Trim()).ToArray();
       return splitLogLine[1];
    }

    public static string LogLevel(string logLine)
    {
        int start = logLine.IndexOf('[')+1;
        int end = logLine.IndexOf(']');
        return logLine.Substring(start,end-start).ToLower();
    }

    public static string Reformat(string logLine)
    {
var splitLogLine = logLine.Split(':').Select(el => el.Trim()).ToArray();
        return $"{Message(logLine)} ({LogLevel(logLine)})";
    }
}
