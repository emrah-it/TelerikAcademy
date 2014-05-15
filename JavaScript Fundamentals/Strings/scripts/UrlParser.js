function showResult(){
    var input = document.getElementById("inputString").value;
    var result = htmlParser(input);
    var output = "protocol: " + result.protocol+ "<br/>"+ "server: " + result.server + "<br/>" + "resourse: " + result.resourse;
    document.getElementById("result").innerHTML = output;
}


function htmlParser(text) {
    var parser = document.createElement('a');
    parser.href = text;
    var protocol = String(parser.protocol);
    protocol = protocol.substr(0, protocol.length - 1);

    return{
        protocol: protocol,
        server: parser.host,
        resourse: parser.pathname
    }
}