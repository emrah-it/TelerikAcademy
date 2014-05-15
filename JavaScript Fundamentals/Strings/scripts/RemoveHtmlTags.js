function showResult(){
    var inputString = document.getElementById("inputString").value;
    document.getElementById("result").innerHTML = getOnlyTextFromHtml(inputString);
}

function getOnlyTextFromHtml(htmlText) {
    var array = new Array();
    var output = "";
    for (var index = 0; index < htmlText.length; index++) {
        if (htmlText[index] == '<') {
            array.push('<');
        }
        else if (htmlText[index] == '>') {
            array.pop();
        }
        else if (array.length == 0) {
            output += htmlText[index];
        }
    }
    return output;
}