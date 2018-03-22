using Godot;
using System;
using NLog;

public class Log : Node
{
    // Creates a singleton logger object
    private static Logger logger = LogManager.GetCurrentClassLogger();

    /// <summary>
    /// C# scripts can just use the Logger object directly
    /// </summary>
    public Logger Logger
    {
        get
        {
            return logger;
        }
    }

    #region GDScript Helper functions
    // GDScript doesn't appear to be able to use the Logger object,
    // but helper functions like this appear to work.
    public void Trace(string msg)
    {
        logger.Trace(msg);
    }
    public void Debug(string msg)
    {
        logger.Debug(msg);
    }
    public void Info(string msg)
    {
        logger.Info(msg);
    }
    public void Warn(string msg)
    {
        logger.Warn(msg);
    }
    public void Error(string msg)
    {
        logger.Error(msg);
    }
    public void Fatal(string msg)
    {
        logger.Fatal(msg);
    }
    #endregion
}