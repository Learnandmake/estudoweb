//objeto despesa
class despesa
{
    //nao esquecer de definir parametros para o constuctor
    constructor(ano,mes,dia,tipo,descricao,valor)
    {
       this.ano = ano
       this.mes = mes
       this.dia = dia
       this.tipo = tipo
       this.descricao = descricao
       this.valor = valor
    }
}
//db para conseguir adicionar dados sem subistituir os existentes
//classe bd que vai gravar os dados
class bd{
    //funcao que adiciona um campo no objeto
    constructor()
    {
        //busca o id
        let id = localStorage.getItem('id')
        

        //se a busca for retornar vazia o id inicial sera '0'
        if(id === null)
        {
            localStorage.setItem('id',0)
        }
    }
    //funcao que determina o proximo id que vai ser 
    //atrelado aos dados inseridos posteriormente~
    getproximoid()
    {//variavel/ getitem busca um item da localstorage com base em um filtro/filtro    (se o campo filtro nao existir no objeto a busca retornara null)
        let proximoid =                                         localStorage.getItem('id');
        return parseInt(proximoid) + 1
    }
//grava as despesas no db
 gravar (d)
{   // armazenamento hd |nome|conversao em json
    // se so ultilizarmos o set item, a cada inserção de dados da despesa 
    // ira substituir o valor pre existente
    //localStorage.setItem('despesa', JSON.stringify(d))
  
  
    //chama funcao de busca o proximo id
    let id =  this.getproximoid()

    localStorage.setItem(id, JSON.stringify(d))
  
    localStorage.setItem('id',id)
}
}
let bd1 = new bd();

//cadastra despesas
function cadastrardespesa(){
//variaveis
 let ano = document.getElementById('ano')
 let mes = document.getElementById('mes')
 let dia = document.getElementById('dia')
 let tipo = document.getElementById('tipo')
 let descricao = document.getElementById('descricao')
 let valor = document.getElementById('valor')

 //instancia o objeto despesa e preenche ele com parametros
 let despesadb = new despesa (
    ano.value,
    mes.value,
    dia.value,
    tipo.value,
    descricao.value,
    valor.value
 )
 //instancia do do bjeto
bd1.gravar(despesadb)
}