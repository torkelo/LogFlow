﻿using System;

namespace LogFlow.Builtins.Outputs
{
	public class LineToConsoleOutput : ILogProcessor
	{
		public Result ExecuteProcess(FluentLogContext logContext, Result result)
		{
			Console.WriteLine(result.Line);
			return result;
		}
	}
}
