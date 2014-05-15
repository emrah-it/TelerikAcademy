function ShowDigitName() {
    var first,  output;
    output = document.getElementById('result');
    first = document.getElementById('input').value - 0;
    switch (first) {
        case 0:
            output.innerHTML = "Zero";
            break;
        case 1:
            output.innerHTML = "One";
            break;
        case 2:
            output.innerHTML = "Two";
            break;
        case 3:
            output.innerHTML = "Tree";
            break;
        case 4:
            output.innerHTML = "Four";
            break;
        case 5:
            output.innerHTML = "Five";
            break;
        case 6:
            output.innerHTML = "Six";
            break;
        case 7:
            output.innerHTML = "Seven";
            break;
        case 8:
            output.innerHTML = "Eight";
            break;
        case 9:
            output.innerHTML = "Nine";
            break;
    }
}