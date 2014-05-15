function FindBiggestNumber(){
    var first, second, temp, output, outputString, third;
    output = document.getElementById('result');
    first = document.getElementById('firstInput').value - 0;
    second = document.getElementById('secondInput').value - 0;
    third = document.getElementById('thirdInput').value - 0;

    if(first > second){
        if(first > third){
            temp = first;
        }
        else{
            temp = third;
        }
    }
    else{
        if(second > third){
            temp = second;
        }
        else{
            temp = third;
        }
    }
    output.innerHTML = "Biggest number is "+ temp;
}