var altura= 0
var largura =0
var vidasperdidas = 1
var tempo=10

var tempocriarmosquito=1000

var nivel = window.location.search 
 var nivel1  = nivel.replace('?',' ')
 console.log(nivel1)



 if(nivel1 ==' facil')
 {
    tempocriarmosquito =  2000
 }
 
 if(nivel1 ==' normal')
 {
    tempocriarmosquito = 1500
 }
 
 if(nivel1 ==' dificil')
 {
    tempocriarmosquito = 1000
 }
 
  if(nivel1 ==' chucknorris')
 {
    tempocriarmosquito =750
 }
 

 



function ajustartamanhopalcojogo()
{
  altura=window.innerHeight
  largura=window.innerWidth
  console.log(altura,largura)
}
ajustartamanhopalcojogo()


var cronometro = setInterval (
function ()
{

tempo-=1

//innerhtml é o atributo entre as tags html
//é responsável por atribuir valores de javascript para ficar entre spam utiizamos inner html 


if(tempo<0)
{
 clearInterval(cronometro)
 clearInterval(aparecermosquito)
   location.href="../paginas/vitoria.html"
}
else
{
    document.getElementById('cronometro').innerHTML = tempo 
}
},1000)

function posicaorandomica()
{

    if(document.getElementById('mosquito'))
    { 
        document.getElementById('mosquito').remove()
        if (vidasperdidas>3)
        {
            location.href="../paginas/gameover.html"
        }
    
        else
        {
            document.getElementById('v'+ vidasperdidas).src = "https://lh3.googleusercontent.com/pw/AM-JKLWI0GYK_6Ohy1UMDqkQRbh4HOFk1ubiUWTGcgs8qKEXVqFyeS08a4DhVJJbaRGyOJ2AI5Q2gYoLDmCmMClYYZqxxLg8e6lFLhgI0ayYNrXVssa_hkO4EydQ13IgW_3VHfxUyJl0fSFMnE0hrh6Yky9N=w30-h28-no?authuser=4"   
            vidasperdidas++
        }
      
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
    mosquito.id='mosquito'
    mosquito.onclick= function()
    {
     this.remove()
    }

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