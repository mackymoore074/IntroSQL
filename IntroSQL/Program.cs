﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.IO;
using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;
using IntroSQL;

class Program
{
    

    static void Main(string[] args)
    {
        var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();
        string connString = config.GetConnectionString("DefaultConnection");
        IDbConnection conn = new MySqlConnection(connString);

        var departmentRepo = new DepartmentRepository(conn);

        var departments = departmentRepo.GetDepartment();

        foreach(var dept in departments)
        {
            Console.WriteLine($"{dept.DepartmentID} {dept.Name}");
        }

     
    }

}