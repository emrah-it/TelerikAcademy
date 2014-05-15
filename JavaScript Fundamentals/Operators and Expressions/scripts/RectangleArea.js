function submitNumber() {
    var width = document.getElementById("inputWidth").value - 0;
    var height = document.getElementById("inputHeight").value - 0;

    var area = width * height;

    var result = document.getElementById("result");
    result.innerHTML = area;
    result.className = "correct";
}