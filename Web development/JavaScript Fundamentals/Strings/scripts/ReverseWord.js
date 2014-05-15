function reverseWord(){
    var inputString = document.getElementById("inputString").value;
    var output = document.getElementById("result");
    output.innerHTML = reverse(inputString);

}

function reverse(str){
    var newString = "";

    for(var index = 0; index < str.length; index++){
        newString = str[index] + newString;
    }

    return newString;
}