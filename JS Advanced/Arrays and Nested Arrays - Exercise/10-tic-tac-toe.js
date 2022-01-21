function ticTacToe(playersMoves){
    let board = [[false, false, false], [false, false, false], [false, false, false]];
    let playerSymbols = ['X', 'O'];
    let currentSymbol = 0;
    let noWiner = true;
    let gameEnd = 9;

    for (let index = 0; index < gameEnd && index < playersMoves.length; index++) {
        const coord = playersMoves[index].split(" ").map(Number);
        
        if(!board[coord[0]][coord[1]]){
            board[coord[0]][coord[1]] = playerSymbols[currentSymbol%2];
            
        }else{
            console.log("This place is already taken. Please choose another!");
            gameEnd++;
            continue;
        }
        
        //Checking diagonals and coresponding rows for a win
        
        if((coord[0] == 0 && coord[1] == 0) || (coord[0] == 1 && coord[1] == 1) || (coord[0] == 2 && coord[1] == 2)){
            if(board[0][0] == board[1][1] && board[1][1] == board[2][2] && board[2][2] == playerSymbols[currentSymbol%2]){
                console.log(`Player ${playerSymbols[currentSymbol%2]} wins!`);
                noWiner = false;
            }
        }else if((coord[0] == 0 && coord[1] == 2) || (coord[0] == 1 && coord[1] == 1) || (coord[0] == 2 && coord[1] == 0)){
            if(board[0][2] == board[1][1] && board[1][1] == board[2][0] && board[2][0] == playerSymbols[currentSymbol%2]){
                console.log(`Player ${playerSymbols[currentSymbol%2]} wins!`);
                noWiner = false;
            }
        }

        for(let i = coord[0]; i < board.length; i++){
            if(board[i][0] === board[i][1] && board[i][1] === board[i][2] && board[i][2] === playerSymbols[currentSymbol%2]){
                console.log(`Player ${playerSymbols[currentSymbol%2]} wins!`);
                noWiner = false;
                break;

            }else if(board[0][i] === board[1][i] && board[1][i] === board[2][i] && board[2][i] === playerSymbols[currentSymbol%2]){
                console.log(`Player ${playerSymbols[currentSymbol%2]} wins!`);
                noWiner = false;
                break;
            }
        }
        
        
        if (!noWiner)
            break;

        currentSymbol++;
    }

    if (noWiner) {
        console.log("The game ended! Nobody wins :(");
    }
    console.log(board[0].join("\t"));
    console.log(board[1].join("\t"));
    console.log(board[2].join("\t"));
}

ticTacToe(["0 1","0 0","0 2", "2 0","1 0","1 1","1 2","2 2","2 1","0 0"]);
ticTacToe(["0 0","0 0","1 1","0 1","1 2","0 2","2 2","1 2","2 2","2 1"]);
//ticTacToe(["0 1","0 0","0 2","2 0","1 0","1 2","1 1","2 1","2 2","0 0"]);
//ticTacToe(["0 0", "0 0", "1 1", "0 1", "1 2", "0 2", "2 2", "1 2", "2 2", "2 1"]);