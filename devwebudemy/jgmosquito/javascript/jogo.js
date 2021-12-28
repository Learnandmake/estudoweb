var altura=0
var largura=0

function ajustartamanhopalcojogo()
{
  altura=window.innerHeight
  largura=window.innerWidth
  console.log(altura,largura)
}

ajustartamanhopalcojogo();

function posicaorandomica()
{

    if(document.getElementById('mosquito'))
    {
        document.getElementById('mosquito').remove()
    }
    var posicaox= Math.floor(Math.random() * largura) -90
    var posicaoy=Math.floor(Math.random() * altura) -90
    
    posicaox=posicaox < 0 ? 0 : posicaox
    posicaoy=posicaoy <0 ? 0 :posicaoy

    console.log(posicaox,posicaoy)
    
    var mosquito = document.createElement('img')
    mosquito.src = 'https://lh3.googleusercontent.com/pw/AM-JKLUvO_YoNMhoW6R-9_RvSEyS9tSWwolPybHPdvU1vAQVvbaKNHLY384NqWjOfGo0Yu8YCrWfxKSyjPBgJW7VJGvk0D4-mRqNJ09ASO8uo1rlnExKuz1Hqn7JyOs84jHiLmi8hbPw6b8q1-e6Pa5OIA0R=w606-h625-no?authuser=4'
    mosquito.className= tamanhoaleatorio() +' ' +ladoaleatorio()
    mosquito.style.left=posicaox +'px'
    mosquito.style.top=posicaoy +'px'
    mosquito.style.position = 'absolute'
    mosquito.id=' mosquito'

    document.body.appendChild(mosquito)

    console.log(tamanhoaleatorio())
}

function tamanhoaleatorio()
{
    var classe = Math.floor(Math.random()* 3)
switch(classe)
{
    case 0:
    
    return 'mosquito1'

    case 1:
    
        return 'mosquito2'
    case 2:
            
    return 'mosquito3'
}
}

function ladoaleatorio()
{
    var classe = Math.floor(Math.random()*2)
    
    switch(classe)
    {
        case 0:
            return 'ladoa'
        
        case 1:
            return 'ladob'
    }
}