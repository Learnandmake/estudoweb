using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace freidesafioconsole
{
    class Chatintensivo
    {
        int lidas = 0;
        string nome;

        public void Entrar(string nome)
        {
            this.nome = nome;
        }

        public string ListarProximasMensagens()
        {
            System.Net.WebClient rest = new System.Net.WebClient();
            rest.Encoding = Encoding.UTF8;

            string resposta = rest.DownloadString("http://localhost:5000/api/Chat/Listar/" + lidas);

            var r = Newtonsoft.Json.JsonConvert.DeserializeObject<List<string>>(resposta);
            lidas += r.Count;

            StringBuilder mensagens = new StringBuilder();
            foreach (var item in r)
            {
                mensagens.Append(item + "\n");
            }

            return mensagens.ToString();
        }

        public void Inserir(string mensagem)
        {
            System.Net.WebClient rest = new System.Net.WebClient();
            rest.Encoding = Encoding.UTF8;

            string resposta = rest.UploadString("http://localhost:5000/api/Chat/Inserir/" + nome + ":" + mensagem, string.Empty);
        }
    }

}
