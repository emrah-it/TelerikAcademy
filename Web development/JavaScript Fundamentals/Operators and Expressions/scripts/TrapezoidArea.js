function submitNumber(){
    var sideA = document.getElementById("inputA").value - 0;
    var sideB = document.getElementById("inputB").value - 0;
    var sideH = document.getElementById("inputH").value - 0;
    var outputResult = document.getElementById("result");

    if(isNaN(sideA) || isNaN(sideB) || isNaN(sideH)){
        outputResult.className = "wrong";
        var resultAsString = "";
        resultAsString  += "Side "
        if(isNaN(sideA)){
            resultAsString += "A ";
        }
        if(isNaN(sideB)){
            resultAsString += "B ";
        }
        if(isNaN(sideH)){
            resultAsString += "Height ";
        }
        resultAsString  +=  "is not a number ";
        outputResult.innerHTML = resultAsString;
    }
    else{
        outputResult.innerHTML = (((sideA + sideB) / 2) * sideH);
        outputResult.className = "correct";
    }
}