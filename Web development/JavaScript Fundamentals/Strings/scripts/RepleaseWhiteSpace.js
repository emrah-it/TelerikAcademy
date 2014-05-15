function showResult(){
    var input = document.getElementById("inputString").value;
var result;
    document.getElementById("result").innerHTML = repleace(input);
    document.getElementById("specialResult").innerHTML = repleace(input);
}

function repleace(text){
    var output;
    do{
        var isMatch = false;
        var currentResult = text.match(/ /);
        if(currentResult){
            isMatch = true;
            text = text.replace(" ", "&nbsp;");
        }
    }while(isMatch);
    return text;
}
