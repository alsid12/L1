// Copyright © Microsoft Corporation.  All Rights Reserved.
// This code released under the terms of the 
// Microsoft Public License (MS-PL, http://opensource.org/licenses/ms-pl.html.)
//
//Copyright (C) Microsoft Corporation.  All rights reserved.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;
using SampleSupport;
using Task.Data;

// Version Mad01

namespace SampleQueries
{
	[Title("LINQ Module")]
	[Prefix("Linq")]
	public class LinqSamples : SampleHarness
	{

		private DataSource dataSource = new DataSource();

		[Category("Restriction Operators")]
		[Title("Where - Task 1")]
		[Description("This sample uses the where clause to find all elements of an array with a value less than 5.")]
		public void Linq1()
		{
			int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

			var lowNums =
				from num in numbers
				where num < 5
				select num;

			Console.WriteLine("Numbers < 5:");
			foreach (var x in lowNums)
			{
				Console.WriteLine(x);
			}
		}

		[Category("Restriction Operators")]
		[Title("Where - Task 2")]
		[Description("This sample return return all presented in market products")]

		public void Linq2()
		{
			var products =
				from p in dataSource.Products
				where p.UnitsInStock > 0
				select p;

			foreach (var p in products)
			{
				ObjectDumper.Write(p);
			}
		}

	    [Category("Restrictions")]
	    [Title("Task 1. For module LINQ")]
	    [Description("Returns all customers whose total orders sum exceeds X which is provided as input")]

	    public void Linq001()
	    {
	        decimal threshold = 1000;
	        threshold = Convert.ToDecimal(Console.ReadLine());
	        var poorCust =
	            from cust in dataSource.Customers
	            where cust.Orders.Sum(ord => ord.Total) < threshold
	            select new {cust.CompanyName, Total = cust.Orders.Sum(ord => ord.Total) };

	        foreach (var c in poorCust)
	        {
	            Console.WriteLine("Customer with big orders: {0}. Total order sum is {1}.", c.CompanyName, c.Total);
	        }
	    }

        [Category("Projections")]
        [Title("Task 2. Return suppliers in the same city as customers.")]
        [Description("Returns a list of customers who live in the same city as their suppliers.")]

        public void Linq002()
        {
            var CustSup =
                from supplier in dataSource.Suppliers
                from customer in dataSource.Customers
                where (supplier.City == customer.City && supplier.Country == customer.Country)
                //group customer by 
                select new {customer.CompanyName, supplier.SupplierName, customer.City, customer.Country};

            foreach (var cs in CustSup)
            {
                Console.WriteLine("Customer and supplier: {0} and {1} located at {2}, {3}", cs.CompanyName, cs.SupplierName, cs.Country, cs.City);
            }
        }

	    [Category("Grouping")]
	    [Title("Task 2.1. Return suppliers in the same city as customers.")]
	    [Description("Returns a list of customers who live in the same city as their suppliers - grouped by customer.")]
	    public void Linq003()
	    {
	        var CustSup =
	            from supplier in dataSource.Suppliers
	            from customer in dataSource.Customers
	            where (supplier.City == customer.City && supplier.Country == customer.Country)
	            group customer by supplier.SupplierName
	            into grp
	            select new {dataSource.Customers, dataSource.Suppliers};

	        foreach (var cs in CustSup)
	        {
	            Console.WriteLine("Customer and supplier: {0} and {1} are located at the same city", cs.Customers, cs.Suppliers);
	        }
	    }


    }
}
