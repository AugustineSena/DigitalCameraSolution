// <copyright file="DBConnection.cs" company="Ma Chung University">
// Copyright © 2017 All Rights Reserved
// Malang, East Java, Indonesia
// </copyright>
// <author> Augustine Sena aka Sena </author> 
// <summary>Example program of project campus
// Using softcomputing-fuzzy database fuzzyfy digital camera data
// Bad Recommendation for Big Data</summary>

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DigitalCameraSolutionDFuzzy
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Homepage());
        }
    }
}
