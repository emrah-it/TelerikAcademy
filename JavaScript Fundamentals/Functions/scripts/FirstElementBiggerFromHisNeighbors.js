function checkNeighboars() {
    var inputArrayAsString = document.getElementById("inputArray").value;
    var arrayAsString = inputArrayAsString.split(" ");
    var array = [];
    for (var index in arrayAsString) {
        if (arrayAsString[index] != "")
            array.push(arrayAsString[index] - 0);
    }
    var result;
    if ((result = firstElementBiggerFromNeighoars(array, index)) != -1)
        document.getElementById("result").innerHTML = "First element bigger from his neighbors is: " + result;
    else
        document.getElementById("result").innerHTML = "No Element that is bigger from his neighbors";
}

function firstElementBiggerFromNeighoars(array, index) {
    for (var index in array) {
        if (checkNeighboarsInArray(array, index - 0)) {
            return index;
        }
    }
    return -1;
}

function checkNeighboarsInArray(array, position) {
    if (position == 0) {
        if (array[position] > array[position + 1]) {
            return true;
        }
    }
    else if (position == array.length - 1) {
        if (array[position] > array[position - 1]) {
            return true;
        }
    }
    else {
        if (array[position] > array[position + 1] &&
            array[position] > array[position - 1]) {
            return true;
        }
    }
    return false;
}