using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace freidesktop.function
{
    class sessiontwo
    {
        public double vquiz(int p1, int p2, int p3, int p4, int p5)
        {
            int total = 0;

            if (p1 == 1)
            {
                total += 1;
            }
            if (p2 == 3)
            {
                total += 1;
            }

            if (p3 == 1)
            {
                total += 1;
            }

            if (p4 == 2)
            {
                total += 1;
            }

            if (p5 == 3)
            {
                total += 1;
            }

            return total;
        }


        public double totalorcamento(int processador, int hd, int ram, int pv)
        {
            double pro1 = this.precoprocessador(processador);
            double hd1 = this.precohd(hd);
            double ram1 = this.precoram(ram);
            double pv1 = this.precopv(pv);

            double total = pro1 + hd1 + ram1 + pv1;
            return total;
        }

        private double precoprocessador(int opcao)
        {
        if(opcao == 1)
             return 300; 
        
          else  if (opcao == 2)
             return 700; 

           else if (opcao == 3)
            return 1200;

            else
            return 0;
        }

        private double precohd(int opcao)
        {
            if (opcao == 1)
                return 100;

            else if (opcao == 2)
                return 300;

            else if (opcao == 3)
                return   700;

            else
                return 0;
        }

        private double precoram(int opcao)
        {
            if (opcao == 1)
                return 200;

            else if (opcao == 2)
                return 50;

            else if (opcao == 3)
                return 70;

            else
                return 0;
        }

        private double precopv(int opcao)
        {
            if (opcao == 1)
                return 3000;

            else if (opcao == 2)
                return 1500;

            else if (opcao == 3)
                return 2000;

            else
                return 0;
        }

        //E-mail
        //
        // Certifique-se que seu GMAIL esteja habilitado para envio de e-mail.
        // https://myaccount.google.com/lesssecureapps
        //


        //
        // Variáveis de Escopo de Classe:
        // Podem ser compartilhadas entre todas as funções do objeto.
        //
        string senha;
        string emailDeEnvio;


        /// <summary>
        /// Função responsável por configurar o e-mail e senha de quem está enviando o envio.
        /// </summary>
        /// <param name="emailDeEnvio">E-mail de envio (Quem está enviando)</param>
        /// <param name="senha">Senha do e-mail de envio</param>
        public void ConfigurarCredenciais(string emailDeEnvio, string senha)
        {
            this.emailDeEnvio = emailDeEnvio;
            this.senha = senha;
        }


        /// <summary>
        /// Função responsável por enviar um e-mail a partir da configuração feita na função ConfigurarCredenciais
        /// </summary>
        /// <param name="emailPara">E-mail para enviar a mensagem</param>
        /// <param name="assunto">Assunto do e-mail</param>
        /// <param name="mensagem">Mensagem do e-mail</param>
        public void Enviar(string emailPara, string assunto, string mensagem)
        {
            Task.Factory.StartNew(() =>
            {
                System.Net.Mail.MailMessage email = new System.Net.Mail.MailMessage();

                string remetente = this.emailDeEnvio;
                string senha = this.senha;


                // Configura Remetente, Destinatário
                email.From = new System.Net.Mail.MailAddress(remetente);
                email.To.Add(emailPara);


                // Configura Assunto, Corpo e se o Corpo está em Html
                email.Subject = assunto;
                email.Body = mensagem;
                email.IsBodyHtml = true;


                // Configura os parâmetros do objeto SMTP
                System.Net.Mail.SmtpClient smtp = new System.Net.Mail.SmtpClient();
                smtp.Host = "smtp.gmail.com";
                smtp.Port = 587;

                // Atribui credenciais
                smtp.EnableSsl = true;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new System.Net.NetworkCredential(remetente, senha);


                // Envia a mensagem
                smtp.Send(email);

            });
        }

        public string Criptografar(string chave, string mensagem)
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


        public string Descriptografar(string chave, string criptografia)
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
