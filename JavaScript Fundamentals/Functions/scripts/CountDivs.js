function countDivs(){
    var divs = document.getElementsByTagName("div").length;
    document.getElementById("result").innerHTML = "This web page have " + divs + " divs";
}