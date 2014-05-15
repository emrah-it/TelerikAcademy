function FindSequence() {
    var inputArray = document.getElementById("inputSequence").value;
    var output = document.getElementById("result");

    var temp = inputArray.split(" ");
    var arrayOfNumbers = [];
    var counter = 0;
    var index;

    for (index in temp) {
        if (!isNaN(temp[index] - 0) && temp[index] != "")
            arrayOfNumbers[counter++] = temp[index] - 0;
    }

    var maxLength = Number.MIN_VALUE;
    var currentNumber;
    var nextIndex;
    var currentLength, firstIndex;

    for (index = 0; index < arrayOfNumbers.length; index++) {
        currentLength = 1;
        for (nextIndex = index + 1; nextIndex < arrayOfNumbers.length; nextIndex++) {
            if (arrayOfNumbers[nextIndex - 1] <= arrayOfNumbers[nextIndex]) {
                currentLength++;
            }
            else
                break;
        }
        if (currentLength > maxLength){
            maxLength = currentLength;
            firstIndex = index;
        }
    }
    var str= "";
        for(index = firstIndex; index < maxLength + firstIndex; index++){
            str += arrayOfNumbers[index] + " ";
        }
    output.innerHTML = "Longest Incressing sequence is: " + str;
}