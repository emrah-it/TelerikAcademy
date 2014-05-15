function submitNumber(){
    var x = document.getElementById("inputX").value - 0;
    var y = document.getElementById("inputY").value - 0;
    var resultOutput = document.getElementById("result");
    var  xCenter = 0;
    var yCenter = 0;
    var radius = 5;
    if(isNaN(x)){
        resultOutput.innerHTML = "X is not a number";
    }
    else if(isNaN(y)){
        resultOutput.innerHTML = "Y is not a number";
    }
    if ((Math.pow((x - xCenter), 2) + Math.pow((y - yCenter), 2)) <= Math.pow(radius, 2))
    {
        resultOutput.innerHTML = "Given point is in circle";
        resultOutput.className = "correct";
        return;
    }
    resultOutput.className = "wrong";
}
