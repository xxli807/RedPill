
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Web;

namespace RedPill
{
    public class RedPill : IRedPill
    {

        public Guid WhatIsYourToken()
        {
            return new Guid("eff47728-3636-4355-82cf-fa54dc1a97be");
        }



        public long FibonacciNumber(long n)
        {

            if (n < -93 || n > 93)
            {
                throw new FaultException<ArgumentOutOfRangeException>(new ArgumentOutOfRangeException(), new FaultReason("Specified argument was out of the range of valid values"));
            }

            int AbsN = (int)(Math.Abs(n));
            var result = CalculateFibonaccinumber(AbsN);

            if (n == 0)
            {
                result = 0;
            }
            else if (n < 0)
            {
                result = AbsN % 2 == 1 ? result : (-1) * result;
            }

            return result;

        }


        private long CalculateFibonaccinumber(long n)
        {
            long start = 1;
            long result = 1;
            for (int i = 3; i <= n; i++)
            {
                result = checked(start + result);
                start = result - start;
            }

            return result;
        }




        public TriangleType WhatShapeIsThis(Int64 a, Int64 b, Int64 c)
        {
            //throw new NotImplementedException();
            if (a == null || b == null || c == null)
            {
                return TriangleType.Error;
            }

            if (a <= 0 || b <= 0 || c <= 0)
            {
                return TriangleType.Error;
            }

            if (a + b > c && b + c > a && a + c > b)
            {
                if (a == b && b == c && a == c)
                {
                    return TriangleType.Equilateral;
                }
                else if (a == b || a == c || b == c)
                {
                    return TriangleType.Isosceles;
                }
                else
                {
                    return TriangleType.Scalene;
                }
            }
            else
            {
                return TriangleType.Error;
            }


        }


        public string ReverseWords(string inputString)
        {
            //throw new NotImplementedException();
            if (inputString == null)
            {
                //return s;
                throw new FaultException<ArgumentNullException>(new ArgumentNullException(), new FaultReason("Value cannot be null."));
            }

            if (inputString == "")
            {
                return inputString;
            }

            StringBuilder sb = new StringBuilder(inputString.Length);
            for (int i = inputString.Length - 1; i >= 0; i--)
            {
                sb.Append(inputString[i]);
            }

            return sb.ToString();

        }


    }
}