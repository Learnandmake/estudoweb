using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace freitrabalho.function
{
    class criptografia
    {


        public string gerarmd5(string dados)
        {
            System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create();
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(dados);
            byte[] hash = md5.ComputeHash(inputBytes);
            System.Text.StringBuilder sb = new System.Text.StringBuilder();

            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("X2"));

            }
            return sb.ToString();
        }
        public string CriptografarAES(string chave, string mensagem)
        {
            // Cria objeto para criptografia AES
            System.Security.Cryptography.RijndaelManaged rijndael = new System.Security.Cryptography.RijndaelManaged();
            rijndael.Mode = System.Security.Cryptography.CipherMode.CBC;
            rijndael.KeySize = 128;

            byte[] chaveBytes;
            byte[] criptografiaBytes;
            byte[] mensagemBytes;
            string criptografia;

            // Transforma chave e mensagem em array de byts
            chaveBytes = Encoding.UTF8.GetBytes(chave);
            mensagemBytes = Encoding.UTF8.GetBytes(mensagem);

            // Realiza criptografia
            System.Security.Cryptography.ICryptoTransform cryptor = rijndael.CreateEncryptor(chaveBytes, chaveBytes);
            criptografiaBytes = cryptor.TransformFinalBlock(mensagemBytes, 0, mensagemBytes.Length);
            cryptor.Dispose();

            // Transforma criptografia em string
            criptografia = Convert.ToBase64String(criptografiaBytes);
            return criptografia;
        }


        public string DescriptografarAES(string chave, string criptografia)
        {
            // Cria objeto para criptografia AES
            System.Security.Cryptography.RijndaelManaged rijndael = new System.Security.Cryptography.RijndaelManaged();
            rijndael.Mode = System.Security.Cryptography.CipherMode.CBC;
            rijndael.KeySize = 128;

            byte[] chaveBytes;
            byte[] criptografiaBytes;
            byte[] mensagemBytes;
            string mensagem;

            // Transforma chave e mensagem em array de byts
            chaveBytes = Encoding.UTF8.GetBytes(chave);
            mensagemBytes = Convert.FromBase64String(criptografia);


            // Realiza criptografia
            System.Security.Cryptography.ICryptoTransform cryptor = rijndael.CreateDecryptor(chaveBytes, chaveBytes);
            criptografiaBytes = cryptor.TransformFinalBlock(mensagemBytes, 0, mensagemBytes.Length);
            cryptor.Dispose();

            // Transforma criptografia em string
            mensagem = Encoding.UTF8.GetString(criptografiaBytes);
            return mensagem;
        }

    }
}
