function submitNumber() {
    var x = document.getElementById("inputX").value - 0;
    var y = document.getElementById("inputY").value - 0;
    var resultOutput = document.getElementById("result");

    var xCenter = 1;
    var yCenter = 1;
    var radius = 3;
    var top = 1;
    var left = -1;
    var width = 6;
    var height = 2;
    var leftX = left;
    var rightX = left + (width - 1);
    var upY = top;
    var downY = top - height;
    if (Math.pow((x - xCenter), 2) + Math.pow((y - yCenter), 2) <= Math.pow(radius, 2))
    {
        if (!(leftX <= x && x <= rightX && upY >= y && y >= downY)) {
            resultOutput.className = "correct";
            resultOutput.innerHTML = "it is In Circle and out of rectangle";
            return;
        }
        resultOutput.className = "wrong";
        resultOutput.innerHTML = "it is In Circle and in rectangle";
        return;
    }

    resultOutput.className = "wrong";
    resultOutput.innerHTML = "it is out of Circle";
    return;
}