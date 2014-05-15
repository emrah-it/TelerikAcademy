function ShowSign(){
    var first, second, temp, output, outputString;
    output = document.getElementById('result');
    input = document.getElementById('input').value - 0;

    if(input > 0){
        output.innerHTML = "Number is positive";
    }
    else if(input < 0){
        output.innerHTML = "Number is negative";
    }
    else{
        output.innerHTML = "Number is Zero";
    }
}