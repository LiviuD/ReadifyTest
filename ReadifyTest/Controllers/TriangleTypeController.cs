﻿using ReadifyTest.Code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ReadifyTest.Controllers
{
    public class TriangleTypeController : ApiController
    {
        //[CacheWebApi(Duration = 1)]
        public string Get(int a, int b, int c)
        {
            return GetTriangleType(a, b, c);
        }

        private string GetTriangleType(int a, int b, int c)
        {
            int[] lengths = new int[3] { a, b, c };

            if (a <= 0 || b <= 0 || c <= 0)
            {
                return "Error";
            }
            else if (a + b <= c || a + c <= b || b + c <= a) //A triangle is valid if sum of its two sides is greater than the third side. If three sides are a, b and c, then three conditions should be met
            {
                return "Error";
            }
            else if (lengths.Distinct().Count() == 1) //There is only one distinct value in the set, therefore all sides are of equal length
            {
                return "Equilateral";
            }
            else if (lengths.Distinct().Count() == 2) //There are only two distinct values in the set, therefore two sides are equal and one is not
            {
                return "Isosceles";
            }
            else if (lengths.Distinct().Count() == 3) // There are three distinct values in the set, therefore no sides are equal
            {
                return "Scalene";
            }
            else
            {
                return "Error";
            }
        }
    }
}