var input = [
    '6 7 3',
    '0 0',
    '2 2',
    '-2 2',
    '3 -1'];
console.log(Solve(input));

function Solve(arg) {
    var arraySyzeAndJumps = arg[0].split(' ').map(Number);
    var field = [];
    var counter = 1;
    var rows = arraySyzeAndJumps[0];
    var cols = arraySyzeAndJumps[1];
    for (var i = 0; i < rows; i++) {
        field[i] = [];
        for (var j = 0; j < cols; j++) {
            field[i][j] = counter++;
        }
    }

    var startRowCol = arraySyzeAndJumps = arg[1].split(' ').map(Number);
    var currentRow = startRowCol[0];
    var currentCol = startRowCol[1];

    var allJumps = getJumps(arg, 2);

    var currentJump = 0;

    var jumpCounter = 0;
    var sumOfPoints = 0;

    while (true) {
        if (currentCol >= 0 && currentRow >= 0 &&
            currentCol < cols &&
            currentRow < rows) {
            if (field[currentRow][currentCol] !== 'X') {
                jumpCounter++;
                sumOfPoints += field[currentRow][currentCol];

                field[currentRow][currentCol] = 'X';

                currentRow += allJumps[currentJump][0];
                currentCol += allJumps[currentJump][1];
                currentJump++;
                currentJump %= (allJumps.length - 0);
            }
            else {
                escaped = false;
                break;
            }
        }
        else {
            escaped = true;
            break;
        }

    }
    return escaped ? 'escaped ' + sumOfPoints : 'caught ' + jumpCounter;

    function getJumps(array, startIndex) {
        var jumps = [];

        for (var i = startIndex; i < array.length; i++) {
            jumps.push(array[i].split(' ').map(Number));
        }

        return jumps;
    }

}