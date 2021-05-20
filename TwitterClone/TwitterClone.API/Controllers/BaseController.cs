using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TwitterClone.API.Models;

namespace TwitterClone.API.Controllers
{
    public class BaseController : Controller
    {
        protected SuccessReturnType CreateSuccessReturnType(object data, string message, bool status)
        {
            var returnType = new SuccessReturnType();
            returnType.Data = data;
            returnType.Message = String.IsNullOrEmpty(message) ? "Success" : message;
            returnType.Status = status;
            return returnType;
        }

        protected ErrorReturnType CreateErrorReturnType(object data, string message, bool status)
        {
            var returnType = new ErrorReturnType();
            returnType.Data = data;
            returnType.Message = String.IsNullOrEmpty(message) ? "Error!" : message;
            returnType.Status = status;
            return returnType;
        }
    }
}
