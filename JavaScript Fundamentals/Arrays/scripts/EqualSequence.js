function FindSequence() {
    var inputArray = document.getElementById("inputSequence").value ;
    var output = document.getElementById("result");

    var arrayOfNumbers = inputArray.split(" ");
    var index;

    var maxLength = Number.MIN_VALUE;
    var currentNumber = arrayOfNumbers[0];
    var currentLength = 0;
    var mostFreqNumber= arrayOfNumbers[0];
    for (var index in arrayOfNumbers) {
        if (currentNumber == arrayOfNumbers[index]) {
            currentLength++;
        }
        else {
            currentNumber = arrayOfNumbers[index];
            if (maxLength < currentLength) {
                maxLength = currentLength;
                mostFreqNumber = arrayOfNumbers[index - 1];
            }
            currentLength = 1;
        }
    }
    if (currentLength > maxLength) {
        maxLength = currentLength;
        mostFreqNumber = arrayOfNumbers[index - 1];
    }

    output.innerHTML = "Most frequent number is "+  mostFreqNumber + "</br>" +
    "Repeat times is " + maxLength;
}