using BC = BCrypt.Net;

namespace FitnessCompanionWebAPI.Aplicacao.CriptBCrypt
{
    public static class CriptBCrypt
    {
        public static string Criptografar(string password)
        {
            string passwordHash = BC.BCrypt.HashPassword(password);

            return passwordHash;
        }

        public static bool Validar(string passwordToVerify, string password)
        {
            bool verified = BC.BCrypt.Verify(passwordToVerify, password);

            return verified;
        }
    }
}
