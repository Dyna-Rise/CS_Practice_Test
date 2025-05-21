int count = 10;
Console.WriteLine("現在の回数" + count);
count++; //インクリメント
Console.WriteLine("インクリメント後　現在の回数" + count);
count--; //デクリメント
Console.WriteLine("インクリメント後　現在の回数" + count);


//P75　単純な繰り返し
Console.WriteLine("\n連続攻撃！");
for (int i = 0; i < count; i++)
{
    Console.WriteLine("攻撃" + (i + 1) + "回目");
}

//P76　1番からの点呼
Console.WriteLine("\n点呼！");
for (int i = 1; i < 4; i++)
{
    Console.WriteLine(i + "番！");
}

//P79　カウントダウン
Console.WriteLine("\nカウントダウン！");
for (int i = 3; i > 0; i--)
{
    Console.WriteLine(i);
}
Console.WriteLine("スタート!");