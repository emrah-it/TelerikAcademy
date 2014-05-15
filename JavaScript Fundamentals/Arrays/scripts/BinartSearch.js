function binaryIndexOf(searchElement, array) {


    var minIndex = 0;
    var maxIndex = array.length - 1;
    var currentIndex;
    var currentElement;

    while (minIndex <= maxIndex) {
        currentIndex = (minIndex + maxIndex) / 2 | 0;
        currentElement = array[currentIndex];

        if (currentElement < searchElement) {
            minIndex = currentIndex + 1;
        }
        else if (currentElement > searchElement) {
            maxIndex = currentIndex - 1;
        }
        else {
            return currentIndex;
        }
    }

    return -1;
}

function Search() {
    var inputArray = document.getElementById("inputSequence").value;
    var inputSearch = document.getElementById("inputSearch").value - 0;
    var output = document.getElementById("result");

    var temp = inputArray.split(" ");
    var arrayOfNumbers = [];
    var counter = 0;
    var index;

    for (index in temp) {
        if (!isNaN(temp[index] - 0) && temp[index] != "")
            arrayOfNumbers[counter++] = temp[index] - 0;
    }
    var indexOfElement = binaryIndexOf(inputSearch, arrayOfNumbers);


    if (indexOfElement == -1) {
        output.innerHTML = "Number is not found";
    }
    else {
        output.innerHTML = "Index of element is: " + indexOfElement;
    }

}
