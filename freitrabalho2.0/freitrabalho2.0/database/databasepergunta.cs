using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace freitrabalho2._0.database
{
    class databasepergunta
    {
        database.entity.freitrabalhoEntities banco = new database.entity.freitrabalhoEntities();

        public void inserir(database.entity.tbpergunta pergunta)
        {
            banco.tbpergunta.Add(pergunta);
            banco.SaveChanges();
        }
        public List<entity.tbpergunta> btodos()
        {
            List<entity.tbpergunta> lista = banco.tbpergunta.ToList();
            return lista;
        }
        public entity.tbpergunta bporid(int id)
        {
            entity.tbpergunta lista = banco.tbpergunta.FirstOrDefault(t => t.idpergunta == id);
            return lista;
        }
        public int contarpergunta()
        {
            int count = banco.tbpergunta.Max(t => t.idpergunta);
            return count;
        }
        public List<entity.tbpergunta> fuf(string uf)
        {
            List<entity.tbpergunta> lista = banco.tbpergunta.Where(t => t.uf == uf).ToList();
            return lista;
        }
        public void deletar(entity.tbpergunta pergunta)
        {
            entity.tbpergunta lista = banco.tbpergunta.FirstOrDefault(t => t.idpergunta == pergunta.idpergunta);
            banco.Entry(lista).State = System.Data.Entity.EntityState.Deleted; 
            banco.SaveChanges();
        }

        public void alterar(entity.tbpergunta pergunta)
        {
            entity.tbpergunta lista = banco.tbpergunta.FirstOrDefault(t => t.idpergunta == pergunta.idpergunta);
            if (lista != null)
            {
                lista.enunciado = pergunta.enunciado;
                lista.idpergunta = lista.idpergunta;
                lista.palternativa = pergunta.palternativa;
                lista.salternativa = pergunta.salternativa;
                lista.talternativa = pergunta.talternativa;
                lista.qalternativa = pergunta.qalternativa;
                lista.uf = pergunta.uf;
                lista.resposta = pergunta.resposta;
            }
            banco.SaveChanges();
        }
    }
}
