﻿// -----------------------------------------------------------------------
// <copyright file="NullLog.cs" company="MicroLite">
// Copyright 2012 - 2014 Project Contributors
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//    http://www.apache.org/licenses/LICENSE-2.0
//
// </copyright>
// -----------------------------------------------------------------------
namespace MicroLite.Logging
{
    using System;

    /// <summary>
    /// An implementation of ILog which does returns false for all log levels and all methods are no-op.
    /// </summary>
    internal sealed class NullLog : ILog
    {
        public bool IsDebug
        {
            get
            {
                return false;
            }
        }

        public bool IsError
        {
            get
            {
                return false;
            }
        }

        public bool IsFatal
        {
            get
            {
                return false;
            }
        }

        public bool IsInfo
        {
            get
            {
                return false;
            }
        }

        public bool IsWarn
        {
            get
            {
                return false;
            }
        }

        public void Debug(string message)
        {
        }

        public void Debug(string message, params string[] formatArgs)
        {
        }

        public void Error(string message)
        {
        }

        public void Error(string message, Exception exception)
        {
        }

        public void Error(string message, params string[] formatArgs)
        {
        }

        public void Fatal(string message)
        {
        }

        public void Fatal(string message, Exception exception)
        {
        }

        public void Fatal(string message, params string[] formatArgs)
        {
        }

        public void Info(string message)
        {
        }

        public void Info(string message, params string[] formatArgs)
        {
        }

        public void Warn(string message)
        {
        }

        public void Warn(string message, params string[] formatArgs)
        {
        }
    }
}