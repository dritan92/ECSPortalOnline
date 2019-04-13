using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECSOnlinePortal.Controllers.Api
{
    //[Route("v1/Identity")]
    //public class LoginController : ApiController
    //{
    //    /// <summary>  
    //    /// This method contains Authorize attribute for authentication and authroization  
    //    /// </summary>  
    //    /// <returns></returns>  
    //    [HttpGet]
    //    [Authorize]
    //    [HttpPost("Login")]

    //    public HttpResponseMessage AuthenticateUser()
    //    {
    //        if (User != null)
    //        {
				//Debug.Write("AuthenticationType:" + User.Identity.AuthenticationType);
				//Debug.Write("IsAuthenticated:" + User.Identity.IsAuthenticated);
				//Debug.Write("Name:" + User.Identity.Name);
		 
				//if (User.Identity.IsAuthenticated)
				//{
				//	return Ok("Authenticated: " + User.Identity.Name);
				//}
				//else
				//{
				//	return BadRequest("Not authenticated");
				//}
    //        }
    //        else
    //        {
    //            //This code never execute as we have used Authorize attribute on action method  
    //            return Request.CreateResponse(HttpStatusCode.OK, new
    //            {
    //                status = (int)HttpStatusCode.BadRequest,
    //                isAuthenticated = false,
    //                isLibraryAdmin = false,
    //                username = ""
    //            });
    //        }
    //    }
    //}
}