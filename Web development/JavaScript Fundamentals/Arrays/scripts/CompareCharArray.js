function CompareArrays() {
    var firstInput = document.getElementById("firstArray").value;
    var secondInput = document.getElementById("secondArray").value;
    var output = document.getElementById("result");
    var i;
    var firstArray = firstInput.split(" ");
    var secondArray = secondInput.split(" ");

    var length = firstArray.length < secondArray.length ? firstArray.length : secondArray.length;

    for (i = 0; i < length; i++) {
        if (firstArray[i] == secondArray[i])
            continue;
        else if (firstArray[i] > secondArray[i]) {
            output.innerHTML = "Biggset array is </br>" + firstArray.join(", ");
            return;
        }
        else {
            output.innerHTML = "Biggset array is </br>" + secondArray.join(", ");
            return;
        }
    }
    if (firstArray.length == secondArray.length)
        output.innerHTML = "Two arrays are equal";
    else{
        var shortString = length == firstArray.length? firstArray: secondArray;


        output.innerHTML = "Two array is equal but this is shorter than other: " + shortString.join(", ");
    }

}