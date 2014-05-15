function submitNumber(){
    var output = document.getElementById("inputNumber").value;
    var result = document.getElementById("result");
    if (((output - 0) % 5) == 0 && ((output - 0) % 7) == 0) {
        result.className = "correct";
        result.innerHTML = "Number can be divided";
    }
    else {
        result.style.display = "block";
        result.className = "wrong";
        result.innerHTML = "Number cant be divided";
    }
}