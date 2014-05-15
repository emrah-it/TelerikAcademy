function showResult(){
    var current = "  'Telerik'  ";
    current += ' "Telerik" ';
    current += "\"Telerik\"";


    var other = "<br />" +  "  'Telerik' <br /> \" ' \"Telerik\" '  <br /> \"\\\"Telerik\\\"" ;
    document.getElementById("result").innerHTML = current + other;
}