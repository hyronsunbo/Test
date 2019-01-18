using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcBook.Logics
{
    public class StringToIntLogic
    {
        public int? StringToInt(string A, string B)
        {
            if (A == null || B == null)
            {
                return null;
            }
            else
            {
                int? result = null;
                try
                {
                    var Aint = int.Parse(A);
                    var Bint = int.Parse(B);
                    if (Aint > Bint)
                    {
                        result = Aint - Bint;
                    }
                    else if (Aint == Bint)
                    {
                        result = Aint * Bint;
                    }
                    else if (Aint < Bint)
                    {
                        result = Aint + Bint;
                    }
                }
                catch (Exception e)
                {
                    result = null;
                }
                return result;
            }
        }
    }
}