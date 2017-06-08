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
    public class TriangularMembershipFunction 
    {
        double _x1, _x2, _x3;

        /// <summary>
        /// Default constructor
        /// </summary>
        public TriangularMembershipFunction()
        { }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="x1">Point 1</param>
        /// <param name="x2">Point 2</param>
        /// <param name="x3">Point 3</param>
        public TriangularMembershipFunction(double x1, double x2, double x3)
        {
            if (!(x1 <= x2 && x2 <= x3))
            {
                throw new ArgumentException();
            }

            _x1 = x1;
            _x2 = x2;
            _x3 = x3;
        }

        /// <summary>
        /// Point 1
        /// </summary>
        public double X1
        {
            get { return _x1; }
            set { _x1 = value; }
        }

        /// <summary>
        /// Point 2
        /// </summary>
        public double X2
        {
            get { return _x2; }
            set { _x2 = value; }
        }

        /// <summary>
        /// Point 3
        /// </summary>
        public double X3
        {
            get { return _x3; }
            set { _x3 = value; }
        }

        /// <summary>
        /// Evaluate value of the membership function
        /// </summary>
        /// <param name="x">Argument (x axis value)</param>
        /// <returns></returns>
        public double GetValue(double x)
        {
            double result = 0;

            if (x == _x1 && x == _x2)
            {
                result = 1.0;
            }
            else if (x == _x2 && x == _x3)
            {
                result = 1.0;
            }
            else if (x <= _x1 || x >= _x3)
            {
                result = 0;
            }
            else if (x == _x2)
            {
                result = 1;
            }
            else if ((x > _x1) && (x < _x2))
            {

                result = (x / (_x2 - _x1)) - (_x1 / (_x2 - _x1));
            }
            else
            {
                result = (-x / (_x3 - _x2)) + (_x3 / (_x3 - _x2));
            }

            return result;
        }

        /// <summary>
        /// Approximately converts to normal membership function
        /// </summary>
        /// <returns></returns>
        public NormalMembershipFunction ToNormalMF()
        {
            double b = _x2;
            double sigma25 = (_x3 - _x1) / 2.0;
            double sigma = sigma25 / 2.5;
            return new NormalMembershipFunction(b, sigma);
        }
    }
    public class TrapezoidMembershipFunction
    {
        double _x1, _x2, _x3, _x4;


        /// <summary>
        /// Constructor
        /// </summary>
        public TrapezoidMembershipFunction()
        { }


        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="x1">Point 1</param>
        /// <param name="x2">Point 2</param>
        /// <param name="x3">Point 3</param>
        /// <param name="x4">Point 4</param>
        public TrapezoidMembershipFunction(double x1, double x2, double x3, double x4)
        {
            if (!(x1 <= x2 && x2 <= x3 && x3 <= x4))
            {
                throw new ArgumentException();
            }

            _x1 = x1;
            _x2 = x2;
            _x3 = x3;
            _x4 = x4;
        }

        /// <summary>
        /// Point 1
        /// </summary>
        public double X1
        {
            get { return _x1; }
            set { _x1 = value; }
        }

        /// <summary>
        /// Point 2
        /// </summary>
        public double X2
        {
            get { return _x2; }
            set { _x2 = value; }
        }

        /// <summary>
        /// Point 3
        /// </summary>
        public double X3
        {
            get { return _x3; }
            set { _x3 = value; }
        }

        /// <summary>
        /// Point 4
        /// </summary>
        public double X4
        {
            get { return _x4; }
            set { _x4 = value; }
        }

        /// <summary>
        /// Evaluate value of the membership function
        /// </summary>
        /// <param name="x">Argument (x axis value)</param>
        /// <returns></returns>
        public double GetValue(double x)
        {
            double result = 0;

            if (x == _x1 && x == _x2)
            {
                result = 1.0;
            }
            else if (x == _x3 && x == _x4)
            {
                result = 1.0;
            }
            else if (x <= _x1 || x >= _x4)
            {
                result = 0;
            }
            else if ((x >= _x2) && (x <= _x3))
            {
                result = 1;
            }
            else if ((x > _x1) && (x < _x2))
            {
                result = (x / (_x2 - _x1)) - (_x1 / (_x2 - _x1));
            }
            else
            {
                result = (-x / (_x4 - _x3)) + (_x4 / (_x4 - _x3));
            }

            return result;
        }
    }
    public class NormalMembershipFunction 
    {
        double _b = 0.0, _sigma = 1.0;

        /// <summary>
        /// Constructor
        /// </summary>
        public NormalMembershipFunction()
        { }


        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="b">Parameter b (center of MF)</param>
        /// <param name="sigma">Sigma</param>
        public NormalMembershipFunction(double b, double sigma)
        {
            _b = b;
            _sigma = sigma;
        }

        /// <summary>
        /// Parameter b (center of MF)
        /// </summary>
        public double B
        {
            get { return _b; }
            set { _b = value; }
        }

        /// <summary>
        /// Sigma
        /// </summary>
        public double Sigma
        {
            get { return _sigma; }
            set { _sigma = value; }
        }

        /// <summary>
        /// Evaluate value of the membership function
        /// </summary>
        /// <param name="x">Argument (x axis value)</param>
        /// <returns></returns>
        public double GetValue(double x)
        {
            return Math.Exp(-(x - _b) * (x - _b) / (2.0 * _sigma * _sigma));
        }
    }
}
