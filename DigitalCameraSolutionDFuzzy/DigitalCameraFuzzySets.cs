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
using System.Text;
using System.Threading.Tasks;

namespace DigitalCameraSolutionDFuzzy
{
    public static class DigitalCameraFuzzySets
    {
        #region PRICE 
        public static class  PRICE
        {
            public static TrapezoidMembershipFunction CHEAP = new TrapezoidMembershipFunction(0,0,10000000,30000000);
            public static TriangularMembershipFunction MEDIUM = new TriangularMembershipFunction(0,25250000,50000000);
            public static TrapezoidMembershipFunction EXPENSIVE = new TrapezoidMembershipFunction(20000000,40000000,55000000,55000000);
        }
        #endregion

        #region DATE RELEASE 
        public static class DATE_RELEASE
        {
            public static TrapezoidMembershipFunction LATTER = new TrapezoidMembershipFunction(0,0,1500,3000);
            public static TrapezoidMembershipFunction EARLIER = new TrapezoidMembershipFunction(1500,3000,7000,7000);
        }
        #endregion

        #region DIMENSION
        public static class DIMENSION
        {
            public static TrapezoidMembershipFunction SMALL = new TrapezoidMembershipFunction(0,0,200000,800000);
            public static TriangularMembershipFunction MEDIUM = new TriangularMembershipFunction(0,600000,1200000);
            public static TrapezoidMembershipFunction WIDE = new TrapezoidMembershipFunction(400000,1000000,2000000,2000000);
        }
        #endregion

        #region WEIGHT
        public static class WEIGHT
        {
            public static TrapezoidMembershipFunction LIGHT = new TrapezoidMembershipFunction(0,0,200,800);
            public static TriangularMembershipFunction INTERMEDIATE = new TriangularMembershipFunction(0,600,1200);
            public static TrapezoidMembershipFunction HEAVY = new TrapezoidMembershipFunction(600,1400,2000,2000);
        }
        #endregion

        #region SCREEN DOTS
        public static class SCREEN_DOTS
        {
            public static TrapezoidMembershipFunction LESS = new TrapezoidMembershipFunction(0,0,100000,1000000);
            public static TrapezoidMembershipFunction MORE = new TrapezoidMembershipFunction(500000,1500000,3000000,3000000);
        }
        #endregion

        #region MAX RESOLUTION
        public static class MAX_RESOLUTION
        {
            public static TrapezoidMembershipFunction LOW = new TrapezoidMembershipFunction(0,0,10000000,25000000);
            public static TriangularMembershipFunction MEDIUM = new TriangularMembershipFunction(5000000,25000000,45000000);
            public static TrapezoidMembershipFunction HIGH = new TrapezoidMembershipFunction(25000000,40000000,52000000,52000000);
        }
        #endregion

        #region EFFECTIVE PIXEL
        public static class EFFECTIVE_PIXEL
        {
            public static TrapezoidMembershipFunction LOW = new TrapezoidMembershipFunction(0,0,5,20);
            public static TriangularMembershipFunction MEDIUM = new TriangularMembershipFunction(5,15,30);
            public static TrapezoidMembershipFunction HIGH = new TrapezoidMembershipFunction(20,30,52,52);
        }
        #endregion

        #region PHOTO DETECTORS
        public static class PHOTO_DETECTORS
        {
            public static TrapezoidMembershipFunction LOW = new TrapezoidMembershipFunction(0,0,10,21);
            public static TriangularMembershipFunction MEDIUM = new TriangularMembershipFunction(15,22.5,30);
            public static TrapezoidMembershipFunction HIGH = new TrapezoidMembershipFunction(21,30,40,40);
        }
        #endregion

        #region SENSOR SIZE
        public static class SENSOR_SIZE
        {
            public static TrapezoidMembershipFunction SMALL = new TrapezoidMembershipFunction(0,0,150,250);
            public static TriangularMembershipFunction MEDIUM = new TriangularMembershipFunction(150,350,550);
            public static TrapezoidMembershipFunction WIDE = new TrapezoidMembershipFunction(400,600,1000,1000);
        }
        #endregion


    }
}
