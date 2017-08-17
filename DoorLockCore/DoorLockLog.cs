﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool
//     Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;

public class DoorLockLog
{
    private string _disabled;
    private string _lockState;
    private DateTime _timeStamp;
    private string _codeAttempt;
    private string _logFilePath;

    public DoorLockLog()
    {
        Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
        _logFilePath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
        _logFilePath = Path.Combine(_logFilePath, "MyLog.txt");
        
    }
    /// <summary>
    /// Saves the log
    /// </summary>
    /// <param name="Lock"></param>
    /// <param name="codeAttempt"></param>
    internal virtual void LogState(DoorLock Lock, string codeAttempt)
	{
        _disabled = Lock.IsDisabled == true ? "Disabled" : "Enabled";
        _lockState = Lock.AttemptNumber == 1 ? "Success" : "Failure";
        _timeStamp = DateTime.Now;
        _codeAttempt = codeAttempt;
        File.AppendAllText(_logFilePath, this.ToString());
    }
    /// <summary>
    /// Returns the last logged attempt or an empty string.
    /// </summary>
    /// <returns></returns>
    public override string ToString()
    {
        //return $"{_timeStamp},{_codeAttempt},{_lockState},{_disabled}\r\n";        
        return string.Format("{0},{1},{2},{3}\r\n", _timeStamp, _codeAttempt, _lockState, _disabled);
    }

}

