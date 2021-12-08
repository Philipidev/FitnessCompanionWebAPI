using FitnessCompanionWebAPI.Exceptions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;

namespace FitnessCompanionWebAPI.Options.Mvc
{
    public class CustomMvcOptions
    {

        public static Action<MvcOptions> SetupAction =>
            CustomMvcOptionsSetupAction;

        private static void CustomMvcOptionsSetupAction(MvcOptions mvcOptions)
        {
            mvcOptions.Filters.Add(new ProducesResponseTypeAttribute(typeof(ErrorResponse), StatusCodes.Status401Unauthorized));
            mvcOptions.Filters.Add(new ProducesResponseTypeAttribute(typeof(ErrorResponse), StatusCodes.Status403Forbidden));
            mvcOptions.Filters.Add(new ProducesResponseTypeAttribute(typeof(ErrorResponse), StatusCodes.Status404NotFound));
            mvcOptions.Filters.Add(new ProducesResponseTypeAttribute(typeof(ErrorResponse), StatusCodes.Status500InternalServerError));

        }

    }
}
