function submitNumber() {
    var number = document.getElementById("inputNumber").value - 0;
    var result = document.getElementById("result");
    if(isNaN(number)){
        result.innerHTML = "Please enter correct number";
        result.className = "wrong";
    }
    else{
        var bit = (1 << 3) & number;
        if(bit == 0){
            result.innerHTML = "Third bit is Zero";
            result.className= "correct";
        }
        else{
            result.innerHTML = "Third bit is One";
            result.className= "correct";

        }
    }
}