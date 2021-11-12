using System;
using AutoMapper;
using System.Dynamic;
using SecurWebApp.Contracts;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using SecurDataAccessLayer.Models;
using Microsoft.AspNetCore.Authorization;
using SecurDataAccessLayer.Externals.UserExternals;
using SecurDataAccessLayer.Externals.LoginExternals;
using Microsoft.AspNetCore.Authentication.JwtBearer;

namespace SecurWebApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class UsersController : ControllerBase 
    {
    }
}