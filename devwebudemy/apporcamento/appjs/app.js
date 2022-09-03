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
    // funcao para validar dados 
    validardados()
   {
    // verifica cada linha do constructo do objeto 
       for(let i in this)
       {
        //'this' faz referencia a um objeto literal em uma classe
        // 'this' se encaixa para objetos literais, funções construtora de objetos
        //'this' se encaixa em objetos baseados em classe
        //o "i" retorna os indices do array ou os atributos do objeto
        //o "i" nao retorna os valores especificamente falando
       // pega a referencia this e
        //   console.log(i , this[i])
         
        //se o form vier incompleto
     if(this[i] == undefined ||  this[i] == ''  || this [i == null])
      {
        //retorna falso
        return false
      }
      // se o formulario ficar completo ou seja nao cair no 'if'
      return true
        }

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

//invoca apartir da variavel com a instancia do objeto
// if se estiver completo e else se algum campo estiver vazio
 if(despesadb.validardados()) {
    // instancia do objeto
    bd1.gravar(despesadb)
    //dialog de sucesso
    $('#sucessogravacao').modal('show')
    console.log('Dados válidos')
} else {
    //dialog de sucesso
    //$ : seletor de elementos do jquery 
    //dentro dos parenteses entra o id da div
    //modal: usado para representar modais de bootstrap
    //show: estado do modal para 'aparecer'
    $('#errogravacao').modal('show')
    console.log('Dados inválidos')
}
 //instancia do do bjeto

}