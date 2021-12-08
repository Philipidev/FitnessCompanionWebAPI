using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;

namespace FitnessCompanionWebAPI.Exceptions
{
    public class ErrorResponse
    {
        public int StatusCode { get; set; }
        public string Message { get; set; }

        public ErrorResponse()
        {

        }

        public ErrorResponse(string exceptionMessage, int statusCode)
        {
            this.StatusCode = statusCode;
            this.Message = exceptionMessage;
        }

        public ErrorResponse(Exception exception)
        {
            this.StatusCode = StatusCodes.Status500InternalServerError;
            this.Message = exception.Message;
        }

        public ObjectResult AsObjectResult()
        {
            return new ObjectResult(this)
            {
                StatusCode = this.StatusCode
            };
        }
    }

}
