﻿using System.Security.Cryptography;
using System.Text;

namespace Shop.BackApp.Helpers
{
    public static class PasswordHasherHelper
    {
        public static string ComputeHash(string password, string salt)
        {
            using var sha256 = SHA256.Create();
            var passwordSaltPepper = $"{password}{salt}";
            var byteValue = Encoding.UTF8.GetBytes(passwordSaltPepper);
            var byteHash = sha256.ComputeHash(byteValue);
            var hash = Convert.ToBase64String(byteHash);
            return hash;
        }

        public static string GenerateSalt()
        {
            using var rng = RandomNumberGenerator.Create();
            var byteSalt = new byte[16];
            rng.GetBytes(byteSalt);
            var salt = Convert.ToBase64String(byteSalt);
            return salt;
        }
    }
}
