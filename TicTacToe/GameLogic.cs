using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    internal class GameLogic
    {
        public static void checkWinner(/*string[] gameeField, string firstPlayerSymbol*/ )
        {
            string[] gameField = { "O", "O", "O", "3", "X", "O", "X", "7", "8" };
            string winner = "";
            int[][] succesfullCombo = { new int[] { 0, 1, 2 }, new int[] { 3, 4, 5 }, new int[] { 6, 7, 8 },
                                new int[] { 0, 3, 6 }, new int[] { 1, 4, 7 }, new int[] { 2, 5, 8 },
                                new int[] { 0, 4, 8 }, new int[] { 2, 4, 6 } };
            for (int i = 0; i < succesfullCombo.Length; i++)
            {
                if (gameField[succesfullCombo[i][0]] == gameField[succesfullCombo[i][1]] &&
    gameField[succesfullCombo[i][1]] == gameField[succesfullCombo[i][2]])
                {
                    winner = gameField[succesfullCombo[i][0]];
                    break;
                }
            }
            MessageBox.Show(winner);
            //return winner;
        }
    }
}
