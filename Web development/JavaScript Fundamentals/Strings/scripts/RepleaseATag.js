function showResult(){
    var input = document.getElementById("inputString").value;
    document.getElementById("result").innerHTML = repleaseAtagWithUrl(input);
}


function repleaseAtagWithUrl(text) {
    while (true) {
        var result = text.match(/<a[\s|.]+[^>]*>/);
        if(result != null){
            var url = result[0].match(/\"(.|\s)[^\"]*\"/);
            url = url[0].substring(1, url[0].length - 1);
            url = "[URL=" + url +"]";
            text = text.replace(result[0], url);
            text = text.replace("</a>", "[/URL]");
        }
        else{
            break;
        }
    }
    return text;

}