function ShowNumber(){
    var number = document.getElementById("input").value - 0;
        var output = document.getElementById("result");

    units = [ "Zero", "One", "Two", "Tree", "Four", "Five", "Six", "Seven", "Eight", "Nine" ];
    firstTens = ["Ten", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen" ];
    tens = [ "", "", "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety" ];

    if (number < 10) {
        output.innerHTML = units[number];
    }
    else if (number >= 10 && number < 20) {
        output.innerHTML =  firstTens[number % 10] ;
    }
    else if (number >= 20) {
        output.innerHTML =  ShowText(number);
    }
}
function ShowText(number)
{
    var result = "";
    var numberInString = number.toString();
    if (number < 100)
    {
        result += tens[parseInt(numberInString[0].toString())];
        if (parseInt((numberInString[1].ToString())) != 0)
        {
            result += " ";
            result += units[parseInt(numberInString[1].toString())].toLowerCase();
        }
    }
    else if (number >= 100)
    {
        result += units[parseInt(numberInString[0])];
        result += " hundred";
        if ((number % 100) == 0)
        {
            return;
        }
        else if ((number % 100) > 0 && (number % 100) < 10)
        {
            result += " and ";
            result += units[parseInt(numberInString[2].toString())].toLowerCase();
        }
        else if ((number % 100) > 9 && (number % 100) < 20)
        {
            result += " and ";
            result += firstTens[parseInt(numberInString[2].toString())].toLowerCase();
        }
        else
        {
            result += " ";
            result += tens[parseInt(numberInString[1].toString())].toLowerCase();
            result += " ";
            result += units[parseInt(numberInString[2].toString())].toLowerCase();
        }
    }
    return result;
}