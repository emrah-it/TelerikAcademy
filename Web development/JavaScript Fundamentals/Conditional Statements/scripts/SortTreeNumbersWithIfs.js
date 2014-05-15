function SortNumbers(){
    var first, second, temp, output, outputString, third;
    output = document.getElementById('result');
    first = document.getElementById('firstInput').value - 0;
    second = document.getElementById('secondInput').value - 0;
    third = document.getElementById('thirdInput').value - 0;
    while(output.firstChild){
        output.removeChild(output.firstChild);
    }
    var myarray = new Array();
    if (first >second )
    {
        if(first >= third)//first is biggest
        {
            myarray[2] = first;
            if(second >= third)
            {
                myarray[1] = second;
                myarray[0] = third;
            }
            else{
                myarray[1] = third;
                myarray[0] = second;
            }
        }
        else
        {
            myarray[2] = third;
            myarray[1] = first;
            myarray[0] = second;
        }
    }
    else//second is > from first
    {
        if(second >= third)//first is biggest
        {
            myarray[2] = second;
            if(first > third)
            {
                myarray[1] = first;
                myarray[0] = third;
            }
            else{
                myarray[1] = third;
                myarray[0] = first;
            }
        }
        else
        {
            myarray[2] = third;
            myarray[1] = second;
            myarray[0] = first
        }
    }
    for(result = 0; result < myarray.length; result++)
    {
        var newElement = document.createElement("p");
        newElement.innerHTML = (result + 1) + " : " + myarray[result];
        output.appendChild(newElement);
    }
}