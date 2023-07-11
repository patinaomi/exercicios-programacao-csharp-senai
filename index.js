function calcular() {
  var t1 = parseInt(document.getElementById("campo1").value);
  var t2 = parseInt(document.getElementById("campo2").value);
  var t3 = document.getElementById("campo3").value;

  if (t3 == "+") {
    var total = t1 + t2;
    document.getElementById("recebe").innerHTML = total;
  } else if (t3 == "-") {
    var total = t1 - t2;
    document.getElementById("recebe").innerHTML = total;
  } else if (t3 == "*") {
    var total = t1 * t2;
    document.getElementById("recebe").innerHTML = total;
  } else if (t3 == "/") {
    var total = t1 / t2;
    document.getElementById("recebe").innerHTML = total;
  } else {
    document.getElementById("recebe").innerHTML = "Digite uma operação válida";
  }
}

// function subtrair() {
//     var t1= parseInt(document.getElementById("campo1").value);
//     var t2= parseInt(document.getElementById("campo2").value);

// }

// function multiplicar() {
//     var t1= parseInt(document.getElementById("campo1").value);
//     var t2= parseInt(document.getElementById("campo2").value);

// }

// function dividir() {
//     var t1= parseInt(document.getElementById("campo1").value);
//     var t2= parseInt(document.getElementById("campo2").value);

// }
