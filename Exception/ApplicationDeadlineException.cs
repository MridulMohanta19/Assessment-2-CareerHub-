﻿using System;

public class ApplicationDeadlineException : Exception
{
    public ApplicationDeadlineException(string message) : base(message) { }
}