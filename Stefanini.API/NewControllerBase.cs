using Stefanini.Application.Common;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using System;

namespace Stefanini.API
{
    public class NewControllerBase : ControllerBase
    {
        public NewControllerBase()
        {
        }

        [NonAction]
        public IActionResult ArgumentExceptionHandling(Exception ex)
        {
            var response = new ExceptionHandlingResponse();
            response.Error = ex.Message;
            return BadRequest(response);
        }

        [NonAction]
        public IActionResult ExceptionHandling(Exception ex)
        {
            var response = new ExceptionHandlingResponse();
            response.Error = ex.Message;
            return StatusCode((int)HttpStatusCode.InternalServerError, response);
        }

        [NonAction]
        public IActionResult AuthenticationExceptionHandling(Exception ex)
        {
            var response = new ExceptionHandlingResponse();
            response.Error = string.Empty;
            return StatusCode((int)HttpStatusCode.Unauthorized, response);
        }
    }
    public class ExceptionHandlingResponse : BaseResponse
    {
        public ExceptionHandlingResponse()
        {
            this.Success = false;
        }
    }
}
