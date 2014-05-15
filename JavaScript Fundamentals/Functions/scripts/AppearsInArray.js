function count() {
    var inputArrayStr = document.getElementById("inputArray").value;
    var inputAsArray = inputArrayStr.split(" ");
    var elementToSearch = document.getElementById("inputElement").value;
    var count = countWords(inputAsArray, elementToSearch);

    document.getElementById("result").innerHTML = "This element appears " + count + " times <br />";
    UIcountWords();
}

function UIcountWords() {
    var array = [1, 2, 3, 4, 5, 6, 7, 8, 8];
    var element = 8;
    var newPTag = document.createElement("p");
    var result = countWords(array, element);
    if (result == 2) {
        newPTag.innerHTML = "Test Is Correct";
    }
    else {
        newPTag.innerHTML = "Test isn't correct";
    }
    document.getElementById("result").appendChild(newPTag);
}

function countWords(array, elementToSearch) {
    var count = 0;
    for (var index in array) {
        if (array[index] != "")
            if (array[index] == elementToSearch) {
                count++;
            }
    }
    return count;
}