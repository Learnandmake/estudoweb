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

//cadastra despesas
function cadastrardespesa(){
//variaveis
 let ano = document.getElementById('ano')
 let mes = document.getElementById('mes')
 let dia = document.getElementById('dia')
 let tipo = document.getElementById('tipo')
 let descricao = document.getElementById('descricao')
 let valor = document.getElementById('valor')

// instancia o objeto despesa 
let depesains = new despesa (ano.value, mes.value, dia.value,tipo.value, descricao.value, valor.value)

console.log(depesains)
}