/*
create class TicTacToe that will enable you to write a complete app to play the game of
TicTacToe. The class contains a private 3x3 rectangular array of integers. The constructor
should initialize the empty board to all 0s. Allow two human players. Whereever the first player
moves, place a 1 in a specific square, and place a 2 wherever the second player moves. Each
move must be to an empty square. After each move, determine whether the game has been won
and whether it's a draw.

...

Player X's turn.
Player X: Enter row (0 <= row < 3): (row)
Player X: Enter column (0 <= row < 3): (column)
*/
public class TicTacToe
{
	private const int BOARDSIZE = 3; // size of the board
	private int[,] board; // board representation

	// TODO: Add code...
}



public static void Main()
{
	TicTacToe game = new TicTacToe();
	game.PrintBoard();
	game.Play();
}