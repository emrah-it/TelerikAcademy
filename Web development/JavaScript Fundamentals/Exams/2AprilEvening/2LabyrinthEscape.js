args =[
    "3 4",
    "1 3",
    "lrrd",
    "dlll",
    "rddd"];

args2 =[
    "5 8",
    "0 0",
    "rrrrrrrd",
    "rludulrd",
    "durlddud",
    "urrrldud",
    "ulllllll"];
args3 =[
    "5 8",
    "0 0",
    "rrrrrrrd",
    "rludulrd",
    "lurlddud",
    "urrrldud",
    "ulllllll"];
console.log(Solve(args));
function Solve(params){
    var arraySyze = params[0].split(' ').map(Number);
    var rows = arraySyze[0];
    var cols = arraySyze[1];

    var direction = {
        r : [0, 1],
        l : [0, -1],
        d: [1, 0],
        u: [-1, 0]
    };

    var directionsInArray= [];
    for(var i = 2; i < params.length; i++){
        directionsInArray.push(params[i]);
    }
    var field = [];
    var counter = 1;
    for(var i = 0; i < rows; i++){
        field[i] = [];
        for(var j = 0; j < cols; j++){
            field[i][j] = counter++;
        }
    }

    var sum = 0;

    var startRowCol = params[1].split(' ').map(Number);
    var currRow = startRowCol[0];
    var currCol = startRowCol[1];

    var out;
    var sumOfNumbers = 0;
    var numberOfSteps = 0;
    while(1){
        if(currRow >= 0 &&
            currCol >= 0 &&
            currRow < rows &&
            currCol < cols){
            if(field[currRow][currCol] !== 'X'){
                sumOfNumbers += field[currRow][currCol];
                field[currRow][currCol] = 'X';
                numberOfSteps++;
                var rowStep = direction[directionsInArray[currRow][currCol]][0];
                var colStep = direction[directionsInArray[currRow][currCol]][1];
                currCol += colStep;
                currRow += rowStep;
            }
            else{
                out= false;
                break;
            }
        }
        else{
            out = true;
            break;
        }
    }


    return out ? "out " + sumOfNumbers : "lost " + numberOfSteps;
}


