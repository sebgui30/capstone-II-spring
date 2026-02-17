using Microsoft.EntityFrameworkCore;
using System.IdentityModel.Tokens.Jwt;
using System.Text;
using Microsoft.IdentityModel.Tokens;

public string Login(string email, string password)
{
    var user = _context.Users.Include(u => u.Role).FirstOrDefault(u => u.Email == email);

    if (user == null || !BCrypt.Net.BCrypt.Verify(password, user.PasswordHash))
        return null;

    var token = GenerateJwtToken(user);
    return token;
}