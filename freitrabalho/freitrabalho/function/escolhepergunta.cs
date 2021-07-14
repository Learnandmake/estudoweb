using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace freitrabalho.function
{
    class escolhepergunta
    {
        public database.entity.tbpergunta escolherpergunta()
        {
            bussines.bussinespergunta bpergunta = new bussines.bussinespergunta();

            int limite = bpergunta.maximopergunta();
            var rand = new Random();
            int id = 0;
            for (int ctr = 0; ctr <= 1; ctr++)
             id = Convert.ToInt32(( rand.Next(0, limite)));

            database.entity.tbpergunta pergunta = bpergunta.bporid(id);
            while (pergunta == null)
            { 
                for (int ctr = 0; ctr <= 1; ctr++)
                    id = Convert.ToInt32((rand.Next(0, limite)));
                   pergunta = bpergunta.bporid(id);
            }
            return pergunta;
        }
    }
}
