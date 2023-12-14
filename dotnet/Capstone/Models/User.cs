﻿using System.Text.Json.Serialization;

namespace Capstone.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string Username { get; set; }
        //TODO if using JsonIgnore, we need to update the returning object
        //[JsonIgnore]
        public string PasswordHash { get; set; }
        //[JsonIgnore]
        public string Salt { get; set; }
        public string Role { get; set; }
    }

    /// <summary>
    /// Model of user data to return upon successful login
    /// </summary>
    public class ReturnUser
    {
        public int UserId { get; set; }
        public string Username { get; set; }
        public string Role { get; set; }
    }

    /// <summary>
    /// Model to return upon successful login (user data + token)
    /// </summary>
    public class LoginResponse
    {
        public ReturnUser User { get; set; }
        public string Token { get; set; }
    }

    /// <summary>
    /// Model to accept login parameters
    /// </summary>
    public class LoginUser
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }

    /// <summary>
    /// Model to accept registration parameters
    /// </summary>
    public class RegisterUser
    {
        //TODO add some decorators to this RegisterUser class
        public string Username { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public string Role { get; set; }
    }
}
