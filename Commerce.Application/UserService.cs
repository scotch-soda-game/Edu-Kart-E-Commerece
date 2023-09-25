using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using Commerce.Domain.Contracts;
using Commerce.Domain;
using Commerce.Domain.Identity;
using Commerce.Persistence.Contracts;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Commerce.Application.Dtos;

namespace Commerce.Application
{
    public class UserService
    {
    }
}
