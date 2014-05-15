function submitNumber() {
    var output = document.getElementById("inputNumber");
    var result = document.getElementById("result");
    if (((output.value - 0) % 2) == 0) {
        result.style.display = "block";
        result.innerHTML = "Number is even";
    }
    else {
        result.style.display = "block";
        result.innerHTML = "Number is odd";
    }
}