using System;
using TicTacToe02;

int PlayCount = 0;

while (PlayCount < 10)
{
    Console.Clear();
    PlayBoard.ShowBox();

    Console.WriteLine("플레이어 X의 차례입니다.");
    Console.Write("위치를 선택하세요 (1~9): ");
    int number = int.Parse(Console.ReadLine()) -1;

    Console.WriteLine("플레이어 O의 차례입니다.");
    Console.Write("위치를 선택하세요 (1~9): ");
    int number2 = int.Parse(Console.ReadLine()) -1;
}