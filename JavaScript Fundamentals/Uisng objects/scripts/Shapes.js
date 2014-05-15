function Line(x1, y1, x2, y2) {
    this.xStart = x1;
    this.yStart = y1;
    this.xEnd = x2;
    this.yEnd = y2;

}
Line.prototype.lineLenght = function () {
    return Math.sqrt(Math.pow((this.xStart - this.xEnd), 2) + Math.pow((this.yStart - this.xEnd), 2));
}
function Triangle(sideA, sideB, sideC){
    this.sideA = sideA;
    this.sideB = sideB;
    this.sideC = sideC;
}
Triangle.prototype.canSformTriangle = function(){
    if(this.sideA.lineLenght + this.sideB.lineLenght > this.sideC.lineLenght &&
        this.sideA.lineLenght + this.sideC.lineLenght > this.sideB.lineLenght &&
        this.sideC.lineLenght + this.sideB.lineLenght > this.sideA.lineLenght){
        return true;
    }
    return false;
}

function checkCanBeATringle(){
    var sideA, sideB, sideC;

    sideA = getLine("inputA");
    sideB = getLine("inputB");
    sideC = getLine("inputC");

    var tringle = new Triangle(sideA, sideB, sideC);

    if(tringle.canSformTriangle())
        document.getElementById("result").innerHTML = "Can be a triangle";
    else{
        document.getElementById("result").innerHTML = "Can not be a triangle";
    }

}
function getLine(idOfInput){
    var lineInString, twoPoints,startPoint, endPoint;
    lineInString = document.getElementById(idOfInput).value;
    twoPoints = lineInString.split(",");
    startPoint = twoPoints[0].split(" ");
    endPoint = twoPoints[1].split(" ");
    return new Line(startPoint[0] - 0, startPoint[1] - 0,
            endPoint[0] - 0, endPoint[1] - 0);

}

function showLenght() {
    var createPoint = getLine("line");

    document.getElementById("result").innerHTML = "Line length is: " + createPoint.lineLenght();
}

