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
    var posicaox= Math.floor(Math.random() * largura) -180
    var posicaoy=Math.floor(Math.random() * altura) -180
    
    posicaox=posicaox < 0 ? 0 : posicaox
    posicaoy=posicaoy <0 ? 0 :posicaoy

    console.log(posicaox,posicaoy)
    
    var mosquito = document.createElement('img')
    mosquito.src = 'https://lh3.googleusercontent.com/pw/AM-JKLUvO_YoNMhoW6R-9_RvSEyS9tSWwolPybHPdvU1vAQVvbaKNHLY384NqWjOfGo0Yu8YCrWfxKSyjPBgJW7VJGvk0D4-mRqNJ09ASO8uo1rlnExKuz1Hqn7JyOs84jHiLmi8hbPw6b8q1-e6Pa5OIA0R=w606-h625-no?authuser=4'
    mosquito.className= 'mosquito1'
    mosquito.style.left=posicaox +'px'
    mosquito.style.top=posicaoy +'px'
    mosquito.style.position = 'absolute'


    document.body.appendChild(mosquito)
}

