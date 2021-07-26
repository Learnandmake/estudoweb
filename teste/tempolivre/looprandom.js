function loop()
 {
    console.log("vamos contar ate o infinito");
    var numero=0;
    var contagem=0;
    while (contagem<=100)
    {
        numero=math.random();
        console.logo(numero);
        contagem++;
        if(numero==100)
        {console.log("o infinito acaba aqui!");}
    }
}
loop();