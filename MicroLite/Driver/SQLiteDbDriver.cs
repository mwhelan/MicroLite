﻿// -----------------------------------------------------------------------
// <copyright file="SQLiteDbDriver.cs" company="MicroLite">
// Copyright 2012 - 2015 Project Contributors
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//    http://www.apache.org/licenses/LICENSE-2.0
//
// </copyright>
// -----------------------------------------------------------------------
namespace MicroLite.Driver
{
    using MicroLite.Characters;

    /// <summary>
    /// The implementation of <see cref="IDbDriver"/> for SQLite.
    /// </summary>
    internal sealed class SQLiteDbDriver : DbDriver
    {
        /// <summary>
        /// Initialises a new instance of the <see cref="SQLiteDbDriver" /> class.
        /// </summary>
        internal SQLiteDbDriver()
            : base(SQLiteCharacters.Instance)
        {
        }

        public override bool SupportsBatchedQueries
        {
            get
            {
                return true;
            }
        }
    }
}