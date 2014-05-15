function FindBigger(){
    var biggest = document.getElementById("firstInput").value - 0;
    var next = document.getElementById("secondInput").value - 0;
    if(biggest < next){
        biggest = next;
    }
    var next = document.getElementById("thirdInput").value - 0;
    if(biggest < next){
        biggest = next;
    }
    var next = document.getElementById("fourthdInput").value - 0;
    if(biggest < next){
        biggest = next;
    }
    var next = document.getElementById("fifthInput").value - 0;
    if(biggest < next){
        biggest = next;
    }
    document.getElementById("result").innerHTML = "Biggest Number is " + biggest;
}