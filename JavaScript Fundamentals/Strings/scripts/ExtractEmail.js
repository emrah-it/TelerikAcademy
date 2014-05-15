function showResult(){
    var input = document.getElementById("inputString").value;

    document.getElementById("result").innerHTML = getEmails(input).join(", ");
}
function getEmails(text){
    var arr = [];

    while(true){
        var current = text.match(/\b[a-zA-Z0-9.-]+@[a-zA-Z0-9.-]+\.[a-zA-Z0-9.-]+\b/);
        if(current){
            arr.push(current[0]);
            text = text.replace(current[0], "");
        }
        else{
            break;
        }
    }
    return arr;
}