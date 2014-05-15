function showName(){
    var getNumber = document.getElementById("inputNumber").value - 0;

    document.getElementById("result").innerHTML = "Last digit as word is: " + getLastNumber(getNumber);
}
function getLastNumber(number){
    var numberAsString = number + "";
    var lastDigit = parseInt(numberAsString[numberAsString.length - 1]);
    switch (lastDigit)
    {
        case 0:
            return "Zero";
        case 1:
            return "One";
        case 2:
            return "Two";
        case 3:
            return "Tree";
        case 4:
            return "Four";
        case 5:
            return "Five";
        case 6:
            return "Six";
        case 7:
            return "Seven";
        case 8:
            return "Eight";
        case 9:
            return "Nine";
    }
}