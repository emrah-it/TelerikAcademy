function showResult(){
    var text = document.getElementById("inputText").value;
    document.getElementById("result").innerHTML = changeTextRegion(text);
}




function changeTextRegion(text) {
    var isMach = 1;
    var resut;
    while (isMach > 0) {
        isMach = 0;
        resut = text.match(/<upcase>[^<]*<\/upcase>/);
        if (resut != null) {
            isMach++;
            var onlyText = getText(resut[0], "<upcase>", "</upcase>");
            text = text.replace(resut[0], onlyText.toUpperCase());
        }
        resut = text.match(/<lowcase>[^<]*<\/lowcase>/);
        if (resut != null) {
            isMach++;
            var onlyText = getText(resut[0], "<lowcase>", "</lowcase>");
            text = text.replace(resut[0], onlyText.toLowerCase());
        }
        resut = text.match(/<mixcase>[^<]*<\/mixcase>/);
        if (resut != null) {
            isMach++;
            var onlyText = getText(resut[0], "<mixcase>", "</mixcase>");
            onlyText = mixText(onlyText);
            text = text.replace(resut[0], onlyText);
        }
    }
    return text;

}
function getText(text, start, end){
    var newString = text.replace(start, "");
    newString = newString.replace(end, "");
    return newString;
}

function mixText(text) {
    var newText = "";
    for(var index = 0; index < text.length; index++){
        if((index % 2) == 0){
            newText += text[index].toUpperCase();
        }
        else{
            newText += text[index].toLowerCase();
        }
    }
    return newText;
}