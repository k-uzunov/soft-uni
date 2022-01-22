function ticTacToe(playersMoves){
    let board = [[false, false, false], [false, false, false], [false, false, false]];
    let player = ['X', 'O'];
    let currentSymbol = 0;
    let winner = false;

    function checkForWinner(board, symbol){
        for (let index = 0; index < board.length; index++) {
            
            if (board[index][0] == symbol && board[index][1] == symbol && board[index][2] == symbol) { //Check row
                return true;
            }else if (board[0][index] == symbol && board[1][index] == symbol && board[2][index] == symbol) { //Chaeck column
                return true;            
            }
        }
        if (board[0][0] == symbol && board[1][1] == symbol && board[2][2] == symbol) { //check first diagonal
            return true;
        }else if (board[0][2] == symbol && board[1][1] == symbol && board[2][0] == symbol) { //check second diagonal
            return true;
        }
        return false;
    }

    for (let i = 0; i < playersMoves.length; i++) {

        let position = playersMoves[i].split(" ").map(Number);

        //Checing if there is any empty space on the board
        if (board[0].includes(false) || board[1].includes(false) || board[2].includes(false)) {
            //Check if the chosen square is empty
            if (!board[position[0]][position[1]]) {
                board[position[0]][position[1]] = player[currentSymbol % 2];
                
                if (checkForWinner(board, player[currentSymbol%2])) {
                    winner = player[currentSymbol%2];
                    break;
                }

                currentSymbol ++;
            }else{
                console.log("This place is already taken. Please choose another!");
                continue;
            }

            //Check for winner
            if (checkForWinner(board, player[currentSymbol%2])) {
                winner = player[currentSymbol%2];
                break;
            }
        }
    }

    if (!winner) {
        console.log("The game ended! Nobody wins :(");
    }else{
        console.log(`Player ${winner} wins!`);
    }
    
    console.log(board[0].join("\t"));
    console.log(board[1].join("\t"));
    console.log(board[2].join("\t"));
}

//ticTacToe(["0 1","0 0","0 2", "2 0","1 0","1 1","1 2","2 2","2 1","0 0"]);
//ticTacToe(["0 0","0 0","1 1","0 1","1 2","0 2","2 2","1 2","2 2","2 1"]);
ticTacToe(["0 1","0 0","0 2","2 0","1 0","1 2","1 1","2 1","2 2","0 0"]);
//ticTacToe(["0 0", "0 1", "0 2", "1 0", "1 1", "1 2", "2 0"]);