using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            TicTacToe game = new TicTacToe();
            game.PrintBoard();
            game.Play();
        }
    }
}

public class TicTacToe
{
    private const int BOARDSIZE = 3; // size of the board
    private int[,] board; // board representation

    board = [BOARDSIZE, BOARDSIZE];

    private int _row;
    private int _column;

    // TODO: ADD CODE LOL
    public void PrintBoard()
    {
        Console.WriteLine("PRINTING THE BOARD. YAYYYY");

        // TODO: (A million years later) not hard-code this board
        Console.WriteLine(" ------- ------- ------");
        Console.WriteLine("|       |       |      |");
        Console.WriteLine("|       |       |      |");
        Console.WriteLine("|       |       |      |");
        Console.WriteLine(" ------- ------- ------");
        Console.WriteLine("|       |       |      |");
        Console.WriteLine("|       |       |      |");
        Console.WriteLine("|       |       |      |");
        Console.WriteLine(" ------- ------- ------");
        Console.WriteLine("|       |       |      |");
        Console.WriteLine("|       |       |      |");
        Console.WriteLine("|       |       |      |");
        Console.WriteLine(" ------- ------- ------");

    }

    public void Play()
    {
        Console.WriteLine("YAYYYYY, TIME TO PLAYYYY");

        // Console.WriteLine("Player " + + "'s turn");
    }

    public int RowPosition
    {
        get
        {
            return _row;
        }
        set
        {
            _row = value;
        }
    }

    public int ColumnPosition
    {
        get
        {
            return _column;
        }
        set
        {
            _column = value;
        }
    }

    // public int Board
    // {
    //     get
    //     {
    //         return _board;
    //     }
    //     set
    //     {
    //         _board = [BOARDSIZE, BOARDSIZE];
    //     }
    // }
}

public class Player
{
    private bool _turn;
    private 
}