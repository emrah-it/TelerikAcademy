function showName() {
    var getNumber = document.getElementById("inputNumber").value - 0;

    document.getElementById("result").innerHTML = "Reversed number is: " + reverse(getNumber);
}

function reverse(number) {

    var str = new String(number);
    var result = "";

    for(var index = str.length - 1; index >= 0 ; index--){
        result += ("" + str[index] );
    }

    return parseInt(result);
}