function submitNumber() {
    var inputNumber = document.getElementById("inputNumber").value - 0;
    var resultOutput = document.getElementById("result");
    if (isNaN(inputNumber)) {
        resultOutput.innerHTML = "Please enter correct number";
        resultOutput.className = "wrong";
    }
    else {
        if(inputNumber == 1 || inputNumber % 2 == 0 || inputNumber % 3 ==0
            || inputNumber % 5 == 0 || inputNumber % 7 == 0){
            resultOutput.innerHTML = "Given Number is not Prime";
            resultOutput.className = "wrong";
        }
        else{
            resultOutput.innerHTML = "Given Number is  Prime";
            resultOutput.className = "correct";
        }
    }
}