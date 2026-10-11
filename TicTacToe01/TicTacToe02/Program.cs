using System;

int[] box = {1, 2, 3, 4, 5, 6, 7, 8, 9};
bool[] comma = new bool[9];
bool[] extraction = new bool[9];
bool[] circle = new bool[9];
int playCount = 0;
int completCount = 0;

while (playCount < 10)
{
    Console.Clear();
    Console.WriteLine("=== 틱택토 게임 · 1단계 ===");
    Console.WriteLine("두 사람이 X와 O를 번갈아 놓습니다. X가 먼저 시작합니다.");
    Console.WriteLine();
    Console.WriteLine("위치번호:");
    Console.WriteLine("1 | 2 | 3");
    Console.WriteLine("---------");
    Console.WriteLine("4 | 5 | 6");
    Console.WriteLine("---------");
    Console.WriteLine("7 | 8 | 9");
    Console.WriteLine();
    Console.WriteLine("현재 보드:");
    Console.WriteLine($"{box[0]} | {box[1]} | {box[2]}");
    Console.WriteLine("---------");
    Console.WriteLine($"{box[3]} | {box[4]} | {box[5]}");
    Console.WriteLine("---------");
    Console.WriteLine($"{box[6]} | {box[7]} | {box[8]}");
    Console.WriteLine();

    Console.WriteLine("플레이어 X의 차례입니다.");
    Console.Write("위치를 선택하세요 (1~9): ");
    int number = int.Parse(Console.ReadLine());

    Console.WriteLine("플레이어 O의 차례입니다.");
    Console.Write("위치를 선택하세요 (1~9): ");
    int number2 = int.Parse(Console.ReadLine());

}