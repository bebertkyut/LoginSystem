using System;
using System.Security.Cryptography.X509Certificates;

namespace LoginSystem.Model;

public class LoginRequestModel
{
    public string UserName { get; set; }
    public string Password { get; set; }
    
}