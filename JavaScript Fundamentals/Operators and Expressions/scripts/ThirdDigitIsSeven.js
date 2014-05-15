function submitNumber(){
    var number = document.getElementById("inputNumber").value;
    var result = document.getElementById("result");
    if(isNaN( number - 0)){
        result.innerHTML = "It is not a number";
        result.className= "wrong";
    }
    else if(number.length < 3){
        result.innerHTML = "Entered number is too short";
        result.className= "wrong";
    }
    else{
        if("7" === number[number.length - 3]){
            result.innerHTML = "Third digit is 7";
            result.className = "correct";
        }
        else{
            result.innerHTML = "Third digit is not 7";
            result.className= "wrong";
        }
    }
}