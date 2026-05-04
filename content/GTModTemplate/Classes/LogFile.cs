using System;
using System.IO;
using UnityEngine;

namespace GTModTemplate.Classes;

/// <summary>
/// Class for writing to logs.
/// </summary>
public class LogFile
{
    private readonly StreamWriter _currentWriter;

    /// <summary>
    /// A divider used to seperate notable messages and text from other log messages.
    /// </summary>
    public const string Divider = "======================================================";

    /// <summary>
    /// Log the line into the log.
    /// </summary>
    public void Write(string text, string ending)
    {
        var fmt = $"{text}{ending}";

        _currentWriter.Write(fmt);
        Debug.Log(fmt);
    }

    /// <summary>
    /// Log the line into the log with the logLevel string.
    /// </summary>
    public void WriteLine(string text, LogLevel logLevel = LogLevel.Info) => Log($"[{logLevel} @ {Time.deltaTime}]: {text}", "\n");

    /// <summary>
    /// Log an exception to the file. This logs the message, source, and stack trace of the exception.
    /// </summary>
    public void WriteException(Exception ex)
    {
        Log($"{Divider}\nAn exception occured!", "\n");
        Log($"  Message:   {ex.Message}", "\n");
        Log($"  Source:    {ex.Source}", "\n");
        Log( "  Stack:", "\n");
        Log(ex.StackTrace.Replace("\n", "\n\t").Trim().RemoveEnd("\n"), "\n");
        Log(Divider, "\n");
    }

    // Shortcuts
    public void Write(Exception ex) => WriteException(ex);
    public void WriteLine(Exception ex) => WriteException(ex);

    /// <summary>
    /// Log an error into the log.
    /// </summary>
    public void LogError(string text) => Log($"{text}", LogLevel.Error);

    /// <summary>
    /// Log a warning into the log.
    /// </summary>
    public void LogWarning(string text) => Log($"{text}", LogLevel.Warning);

    /// <summary>
    /// Close the log and disable writing.
    /// </summary>
    public void Dispose()
    {
        _currentWriter.Dispose();
    }

    /// <summary>
    /// Create a new LogFile.
    /// </summary>
    public LogFile()
    {
        var logsPath = Path.Combine(Application.persistentDataPath, "logs");
        Directory.CreateDirectory(logsPath); // create log dir incase it doesn't exist

        _currentWriter = new StreamWriter(Path.Combine(logsPath, $"{Constants.Name}.log"));
        _currentWriter.AutoFlush = true;
    }
}