function Calculate(){
    var first, second, D, output, outputString, third;
    output  = document.getElementById('result');
    a = document.getElementById('firstInput').value - 0;
    b = document.getElementById('secondInput').value - 0;
    c = document.getElementById('thirdInput').value - 0;

    D = b * b - (4 * a * c);
    if (D < 0)
    {
        output.innerHTML = "No real roots";
    }
    else if (D == 0)
    {
        output.innerHTML = "One real root " + (-b / (2 * a));
    }
    else
    {
        while(output.firstChild)
            output.removeChild(output.firstChild);
        var newElement = document.createElement("p");
        newElement.innerHTML = "First root: " + (-b + Math.sqrt(D)) / (2 * a);
        output.appendChild(newElement);

        newElement = document.createElement("p");
        newElement.innerHTML = "Second root: " + (-b - Math.sqrt(D)) / (2 * a);
        output.appendChild(newElement);
    }
}