function showResult(){
    var text = document.getElementById("inputText").value;
    var substring = document.getElementById("inputSearch").value;

    document.getElementById("result").innerHTML = substring +  " seen in text " + countSubstrings(text, substring)+ " times";
}


function countSubstrings(inputString, substringToSearch) {
    var lastIndex = 0;

    var counter = 0;
    while (lastIndex > -1) {
        lastIndex = inputString.toLowerCase().indexOf(substringToSearch.toLowerCase(), lastIndex);
        if (lastIndex > -1) {
            counter++;
            lastIndex++;
        }
    }
    return counter;
}