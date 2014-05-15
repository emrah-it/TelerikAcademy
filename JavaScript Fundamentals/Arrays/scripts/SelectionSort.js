function SortNumbers() {
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
    var innerIndex;
    for( index = 0; index < arrayOfNumbers.length; index++){
        innerIndex = index + 1;
        for(; innerIndex < arrayOfNumbers.length; innerIndex++)
        {
            if(arrayOfNumbers[index] > arrayOfNumbers[innerIndex]){
                var temp = arrayOfNumbers[index];
                arrayOfNumbers[index] = arrayOfNumbers[innerIndex];
                arrayOfNumbers[innerIndex] = temp;
            }
        }
    }
    output.innerHTML = "Sorted array is: " + arrayOfNumbers.join(", ");
}

