<html>
    <head>
    <meta charset="utf-8"/>
    <title> cursophp2
        
    </title>
    </head>
    <body>
    
    <?php
    //area de teste
    //a308 ate a310
   echo 'utilizando a tag padrão'; 
    ?>
    <br/>
    <?= 'utilizando a tag de impressão'; ?>
    <br/>
    <? echo 'utilizando tag curta'; ?>
    <br/>
    <?php
//a311 saida de dados com echo e print
    echo 'comando echo';
   
?>
<br/>
<?php
 print "comando print";

?>

<?php
//a312 funcionamento do php diferenças entre paginas estaticas e dinamicas

// a principal diferença entre as duas é que a pagina estatica nao usa servidor portanto nao
// e tratada com um servidor mas sim de uma forma simples
// ja a pagina dinamica tem o conceito mais complexo porque utiliza servidores para tratamento de dados
// que usamos no site com isso tudo a pagina dinamica tem mais etapadas de processamento do que o pagina estatica

//foto para esclarecer a aula 
//https://photos.fife.usercontent.google.com/pw/AP1GczPaqIULUh2f3Gz9gszNpGZpbzZdD1Jvi7meg2RPam_UwFZA1W8HU1W4=w1024-h572-s-no-gm?authuser=0

//a313 comentários

# comentário shell 
//comentario de 1 linha
/* 
comentarios de varias linhas 
*/
?>

<!--comentário em html (fica exposto para o usuario-->
<?php 
// a314 variaveis 

//variaveis em php devem iniciar com a tag $ e não podem conter espaços nem caracters especiais 
// as variaveis em php nao devem ser especificadas no momento da declaração apenas no momento da inserção de dados

//php diferencia letras maiusculas  e minusculas Nome e Variavel e variavel pro php são 2 variaveis diferentes


?>
<br>
<br>
<br>
<?php
echo 
'
315. Variáveis - Prática (string, int, float e boolean)
';
/*
anotações:
o retorno da variavel bool é 1 se o retorno for true e vazio se for false

*/ 

//instaciamento de variaveis 

//string
$nome315 = 'jorge sant ana';

//int
$idade315 = 29;

//float
$peso315 = 82.5;

//boolean (true or false) true = 1 e false (vazio)
$fumante315 = true;
?>

<h1>ficha cadastral</h1>
<br>
<!-- tem que instancia a tag php pra poder invocar a variavel -->
<p>Nome: <?= $nome315 ?></p>
<p>Idade: <?= $idade315 ?></p>
<p>Peso: <?= $peso315 ?></p>
<p>Fumante: <?= $fumante315 ?></p>
<!--a316 mudando dados das variaveis-->

<!--317 concatenação-->

<?php 
echo 
'
317. concatenação
'; ?>

<br>
<br>

<?php
/*a contatenação é a a função de juntar 1 ou mais
variaveis dentro de uma frase estatica 
tambem da pra usar aspas duplas e essa ultima não precisa adicionar ponto pra instanciar a
variavel */

$nome317 = 'Gabriel';
$idade317=21 ;  
echo 'olá '. $nome317. " tenha uma boa tarde! voce tem  $idade317 anos";

?>

<?php 
/*a318 variaveis constantes

variaveis constantes sao variaveis que seus valores não podem ser alterados muitas vezes so uma vez
*/
define('bd_url','endereco_bd_dev');
define('bd_usuario','usuario_dev');
define('bd_senha','senha_dev');

echo bd_url . '<br />';
echo bd_usuario. '<br />';
echo bd_senha . '<br />';
/*caso tente alterar o valor de algumas dessas variaveis denovo ira resultar em um erro */
?>
    </body>
</html>
