
//cadastrar despesa

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

recuperartregistro()
{
    //lista despesas
    let ldespesa = Array()
//console.log("regis recuperado")
 

// recuperou id mais alto dos registros 
let id = localStorage.getItem('id')

// recuperar todas as despesas cadastradas 
// let i = 1: começo / i <= id: checagem a condição for alcançada / i++ se a condicao nao for atingida é incrementada +1 na conta do 'i'
for(let i = 1; i <= id ; i++)
{

//so recupera o json em formato de string 
//let despesa = localStorage.getItem(i)
//transforma objetos json em objetos literais
let despesa = JSON.parse(localStorage.getItem(i))

//verificar possibilidade de indices nulos

//se sim pular indice nulo 
if(despesa === null)
{
    continue
}

//insere o objeto despesa dentro do array ldespesa
ldespesa.push(despesa)
// i recupera id do obj
//console.log(i ,despesa)

}
return ldespesa
//console lod=g da lista despesas
console.log(ldespesa)


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
//captura pelo innerhtml titulo do modal
//innerhtmleplicação
//Essa propriedade fornece uma forma simples de trocar
// completamente o conteúdo de um elemento. Por exemplo,
// o conteúdo inteiro do elemento body pode ser excluído ao fazer
       
//voltando ao codigo

//captura o elemento apartir do id       / novo comteudo do id  
document.getElementById('modal_titulo').innerHTML='sucesso'
 
//mudar classe do id 
document.getElementById('modal-titulo-div').className='modal-header text-success'
    
//botao
document.getElementById('modal-btn').innerHTML='voltar'
document.getElementById('modal-btn').className ='btn btn-success'
   
//conteudo
document.getElementById('modal-conteudo').innerHTML = 'despesa cadastrada com sucesso'
// instancia do objeto
bd1.gravar(despesadb)
//dialog de sucesso
$('#registradespesa').modal('show')
//retorno do console
console.log('Dados válidos')

//apagar dados dos campos quando a inserção for concluida
ano.value = ''
mes.value = ''
dia.value = ''
tipo.value = ''
descricao.value = ''
valor.value = ''
}
 else {
    //dialog de sucesso
    //$ : seletor de elementos do jquery 
    //dentro dos parenteses entra o id da div
    //modal: usado para representar modais de bootstrap
    //show: estado do modal para 'aparecer'
    document.getElementById('modal_titulo').innerHTML='Erro'
    //mudar classe do id 
    document.getElementById('modal-titulo-div').className = 'modal-header text-danger'
  
//botao
document.getElementById('modal-btn').innerHTML='ok'
document.getElementById('modal-btn').className = 'btn btn-danger'
document.getElementById('modal-conteudo').innerHTML = 'formulario incompleto'
    $('#registradespesa').modal('show')
    console.log('Dados inválidos')
}
 //instancia do do bjeto

}

//consultar despesa
function carregalistadespesa()
{
let listapgdespesa = Array()
   listapgdespesa =  bd1.recuperartregistro()
 console.log(listapgdespesa)

//selecionando o elemento tbody da tabela
 let bodylistadespesa = document.getElementById('listabodydespesa')

 //percorrer listapgdespesa
 listapgdespesa.forEach(
   
function(d)
 {
//criar linhas tr
let linha = bodylistadespesa.insertRow()

//criar colunas td  / insere informacao/ modelo da informação
linha.insertCell(0).innerHTML= `${d.dia}/${d.mes}/${d.ano}`

//ajustar o tipo
switch(d.tipo)
{
    case'1': d.tipo = 'Alimentação'
    break
    case'2': d.tipo = 'Educação'
    break
    case'3' :d.tipo = 'Lazer'
    break
    case'4': d.tipo = 'Saúde'
    break
    case'5': d.tipo = 'Transporte'
    break
}
linha.insertCell(1).innerHTML = d.tipo

linha.insertCell(2).innerHTML = d.descricao

linha.insertCell(3).innerHTML = d.valor

 }

 )
}