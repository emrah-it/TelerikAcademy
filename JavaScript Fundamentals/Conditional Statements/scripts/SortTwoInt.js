function SortAndShow(){
    var first, second, temp, output, outputString;
    output = document.getElementById('result');
    first = document.getElementById('firstInput').value - 0;
    second = document.getElementById('secondInput').value - 0;

    if(second > first)
    {
        temp = first;
        first = second;
        second = temp;
    }
    var ele = document.createElement("p");
    ele.innerHTML = "Bigger is " + first  + " Smaller is " + second;
    output.appendChild(ele);
}