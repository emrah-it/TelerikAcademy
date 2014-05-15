function showResult(){
    var element = document.getElementById("inputString").value;

    document.getElementById("result").innerHTML = findPolidromes(element);
}

function findPolidromes(text){

    var arr= [];
    var currentWord = text.split(/[\s|\.|,|"|\?|\!]/);
    for(var currentIndex in currentWord){
        if(currentWord[currentIndex] != "" && currentWord[currentIndex].length > 1 && checkIsPlidrome(currentWord[currentIndex])){
            arr.push(currentWord[currentIndex]);
        }
    }
    return arr;
}

function checkIsPlidrome(word){
    var start, end;
    for(start =0, end=word.length - 1; start < end; start++, end--){
        if(word[start] != word[end]){
            return false;
        }
    }
    return true;
}