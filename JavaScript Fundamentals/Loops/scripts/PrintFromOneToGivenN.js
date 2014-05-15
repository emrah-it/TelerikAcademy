function PrintNumbers() {
    var inputN = document.getElementById("inputNumber").value - 0;
    var output = document.getElementById("result");

    if(isNaN(inputN)){
        output.innerHTML = "Please enter correct number";
    }
    else{
        var str = "";
        for(var i = 1; i<= inputN;i++){
            str +=  i + " ";
        }
        output.innerHTML = str;
    }
}