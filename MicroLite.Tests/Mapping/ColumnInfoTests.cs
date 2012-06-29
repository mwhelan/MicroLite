﻿namespace MicroLite.Tests.Mapping
{
    using System;
    using MicroLite.Mapping;
    using NUnit.Framework;

    /// <summary>
    /// Unit Tests for the <see cref="ColumnInfo"/> class.
    /// </summary>
    [TestFixture]
    public class ColumnInfoTests
    {
        [Test]
        public void ConstructorSetsPropertyValues()
        {
            var columnName = "Name";
            var isIdentifier = true;
            var propertyInfo = typeof(Customer).GetProperty("Name");

            var columnInfo = new ColumnInfo(columnName, propertyInfo, isIdentifier);

            Assert.AreEqual(columnName, columnInfo.ColumnName);
            Assert.AreEqual(isIdentifier, columnInfo.IsIdentifier);
            Assert.AreEqual(propertyInfo, columnInfo.PropertyInfo);
        }

        [Test]
        public void ConstructorThrowsArgumentNullExceptionForNullColumnName()
        {
            var exception = Assert.Throws<ArgumentNullException>(
                () => new ColumnInfo(columnName: null, propertyInfo: null, isIdentifier: false));

            Assert.AreEqual("columnName", exception.ParamName);
        }

        [Test]
        public void ConstructorThrowsArgumentNullExceptionForNullPropertyInfo()
        {
            var exception = Assert.Throws<ArgumentNullException>(
                () => new ColumnInfo(columnName: "Name", propertyInfo: null, isIdentifier: false));

            Assert.AreEqual("propertyInfo", exception.ParamName);
        }

        private class Customer
        {
            public Customer()
            {
            }

            public string Name
            {
                get;
                set;
            }
        }
    }
}