function ShowMostFrequent() {
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

    var array = [];

    for(var index = 0; index < arrayOfNumbers.length; index++){
        if(array[arrayOfNumbers[index]]){
            array[arrayOfNumbers[index]]++;
        }
        else{
            array[arrayOfNumbers[index]] = 1;
        }
    }
    var number;
    var mostFrequent = Number.MIN_VALUE;
    for(index in array){
        if(mostFrequent < array[index]){
            mostFrequent = array[index];
            number = index;
        }
    }

    output.innerHTML = number+" (" + mostFrequent + " times)";
}