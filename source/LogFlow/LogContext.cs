﻿namespace LogFlow
{
	public class LogContext
	{
		public LogContext(string logType) : this(logType, new StateStorage(logType)) { }

		public LogContext(string logType, IStateStorage storage)
		{
			LogType = logType;
			Storage = storage;
		}

		public string LogType { get; private set; }
		public IStateStorage Storage { get; private set; }
	}
}