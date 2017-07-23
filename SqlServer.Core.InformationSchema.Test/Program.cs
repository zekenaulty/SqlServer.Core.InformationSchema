using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace SqlServer.Core.InformationSchema.Test
{
    class Program
    {
        /// <summary>
        /// These tests are read only, but the do require a database.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //change this connection string to a valid connection string to run your tests
            using (var db = new SchemaDbContext(@"Data Source=ZEKE-GPC-2016\SQLEXPRESS;Initial Catalog=AdventureWorks;uid=aw;pwd=1234;"))
            {

                Console.BufferHeight = 3000;
                Console.BufferWidth = 3000;

                var serviceProvider = db.GetInfrastructure<IServiceProvider>();
                var loggerFactory = serviceProvider.GetService<ILoggerFactory>();
                loggerFactory.AddProvider(new SqlLoggerProvider());

                var dbType = db.GetType();
                var dbProperties = dbType.GetProperties().OrderBy(pi => pi.Name).ToArray();
                for(int i = 0; i < dbProperties.Length; i++)
                {
                    Console.Clear();

                    var oe = dbProperties[i].GetValue(db);
                    try
                    {
                        //if this fails move on to the next property
                        var q = (IQueryable<object>)oe;
                        var list = q.ToList();

                        Console.WriteLine();

                        if (list.Count > 0)
                        {
                            var et = list[0].GetType();
                            var p = et.GetProperties();

                            for (int j = 0; j < list.Count; j++)
                            {
                                for (int k = 0; k < p.Length; k++)
                                {
                                    Console.Write($"{p[k].Name}: {p[k].GetValue(list[j])}");
                                    if (k < p.Length - 1)
                                        Console.Write(", ");
                                }
                                Console.Write("\r\n");
                            }

                            Console.WriteLine("\r\nPress enter to continue.");
                            Console.ReadLine();
                        }
                        else
                        {
                            Console.WriteLine("No data! Press enter to continue;");
                            Console.ReadLine();
                        }
                    }
                    catch(Exception)
                    {
                        //nothing to see here
                    }
                    
                }
            }
        }
    }

}