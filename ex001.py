<!DOCTYPE html>
<html lang="pt-br">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="stylesheet" href="./style.css">
    <title>Document</title>
</head>
<body>

    <h1 id="p1">Calculadora da Pati</h1>
    <h6></h6>
    <h3>Valor 1:</h3> <input class="caixa-de-texto" type="text" placeholder="número inteiro" id="campo1">
    <h3>Valor 2:</h3> <input class="caixa-de-texto" placeholder="número inteiro"  type="text" id="campo2">
		<h3>Operação:</h3> <input class="caixa-de-texto" type="text" placeholder="+ - * /" id="campo3">

    <br>
    <button class="botao" onclick="calcular()">calcular</button>
    <h4>Resultado:</h4> <p class="resultado" id="recebe"></p>

    <script src="index.js"></script>

</body>
</html>
