using Shop.BackApp.Middleware.Exceptions;
using System.Security.Cryptography;
using System.Text;

namespace Shop.BackApp.Helpers;

public static class JwtHelper
{
    public static string Encrypt(string plainText, string passPhrase)
    {
        byte[] iv = new byte[16];
        byte[] array;

        using (Aes aes = Aes.Create())
        {
            aes.Key = Encoding.UTF8.GetBytes(passPhrase);
            aes.Mode = CipherMode.CBC;
            aes.Padding = PaddingMode.PKCS7;
            aes.IV = iv;

            ICryptoTransform encryptor = aes.CreateEncryptor(aes.Key, aes.IV);

            using (MemoryStream memoryStream = new MemoryStream())
            {
                using (CryptoStream cryptoStream = new CryptoStream((Stream)memoryStream, encryptor, CryptoStreamMode.Write))
                {
                    using (StreamWriter streamWriter = new StreamWriter((Stream)cryptoStream))
                    {
                        streamWriter.Write(plainText);
                    }

                    array = memoryStream.ToArray();
                }
            }
        }

        return Convert.ToBase64String(array);
    }

    public static string Decrypt(string cipherText, string passPhrase)
    {
        byte[] iv = new byte[16];
        byte[] buffer = Convert.FromBase64String(cipherText);

        using (Aes aes = Aes.Create())
        {
            aes.Key = Encoding.UTF8.GetBytes(passPhrase);
            aes.Mode = CipherMode.CBC;
            aes.Padding = PaddingMode.PKCS7;
            aes.IV = iv;

            ICryptoTransform decryptor = aes.CreateDecryptor(aes.Key, aes.IV);

            using (MemoryStream memoryStream = new MemoryStream(buffer))
            {
                using (CryptoStream cryptoStream = new CryptoStream((Stream)memoryStream, decryptor, CryptoStreamMode.Read))
                {
                    using (StreamReader streamReader = new StreamReader((Stream)cryptoStream))
                    {
                        return streamReader.ReadToEnd();
                    }
                }
            }
        }
    }
}

public class ParamsForRefreshTokenHelper
{
    public DateTime RefreshTokenExpirationDate {  get; set; }
    public string AccessToken {  get; set; }
    public Guid UserId { get; set; }
    public string RefreshSecret { get; set; }

    public string GenerateRefreshToken()
    {
        var plainText = string.Format("{0};{1};{2}", AccessToken, RefreshTokenExpirationDate.ToBinary(), UserId);
        var refreshToken = JwtHelper.Encrypt(plainText, RefreshSecret);

        return refreshToken;
    }

    public ParamsForRefreshTokenHelper DecryptRefreshToken(string refreshToken)
    {
        try
        {
            var palinText = JwtHelper.Decrypt(refreshToken, RefreshSecret);

            var palinTextArr = palinText.Split(';');

            AccessToken = palinTextArr[0];
            RefreshTokenExpirationDate = DateTime.FromBinary(long.Parse(palinTextArr[1]));
            UserId = Guid.Parse(palinTextArr[2]);

            return this;
        }
        catch (Exception ex)
        {
            throw new CustomException("Invalid refresh token!");
        }
    }
} 
