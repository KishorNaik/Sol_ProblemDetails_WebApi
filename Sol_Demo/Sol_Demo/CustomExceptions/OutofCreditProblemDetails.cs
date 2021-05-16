using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sol_Demo.CustomExceptions
{
    public class OutofCreditProblemDetails : ProblemDetails
    {
        public double Balance { get; set; }
    }
}