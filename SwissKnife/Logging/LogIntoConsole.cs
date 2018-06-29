﻿using System;

namespace SwissKnife.Logging
{
    public class LogIntoConsole : LogIntoStream
    {
        public LogIntoConsole(ILogFormatter formatter) : base(Console.Out, formatter)
        {
        }
        public LogIntoConsole() : base(Console.Out, new StandardLogFormatter())
        {
        }
    }
}