function ShowMinAndMax() {
    var sequence = document.getElementById("inputNumbers").value;
    var output = document.getElementById("result");
    var numbers = sequence.split(" ");
    var min = Number.MAX_VALUE;
    var max = Number.MIN_VALUE;
    var current;
    for (current in numbers) {
        if (numbers[current] - 0 > max) {
            max = numbers[current];
        }
        if (numbers[current]     - 0 < min) {
            min = numbers[current];
        }
    }
    while(output.firstChild){
        output.removeChild(output.firstChild);
    }
    var newP = document.createElement("p");
    newP.innerHTML = "Maximun number is: " + max;
    output.appendChild(newP);

    newP = document.createElement("p");
    newP.innerHTML = "Minimum number is: " + min;
    output.appendChild(newP);

}