function search() {
    var inputText = document.getElementById("inputText").value;
    var searchedWord = document.getElementById("inputWord").value;
    var optionCaseSensitivity = document.getElementById("sensitivity");
    var isCaseSensitive, result;
    if (optionCaseSensitivity[optionCaseSensitivity.selectedIndex].value == "sensitive") {
       result = searchInText(inputText, searchedWord, true);
    }
    else {
        result = searchInText(inputText, searchedWord);
    }
    document.getElementById("result").innerHTML = "Word occurs " + result + " times.";
}

function searchInText(text, word, insensitive) {
    insensitive = insensitive || false;
    var newText, newWord;
    if(!insensitive){
        newText = text.toLowerCase();
        newWord = word.toLowerCase();
    }
    else{
        newText = text;
        newWord = word;
    }
    var words = newText.split(/[\s|\.|,|?|!]/);

    var counter = 0;
    for(var index = 0, len = words.length; index < len; index++){
        if(words[index].length > 0){
            if(words[index] == newWord){
                counter++;
            }
        }
    }
    return counter;
}