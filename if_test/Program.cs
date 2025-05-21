//p70の応用

//冒険プログラム

//定数 ※プログラム途中で値を変えられない 途中で崩したくない設定
const float maxHp = 10;
float currentHp = 4;

//地形の種類
//0：通常　プラマイ0
//1：回復 cure　プラス5 
//2：毒地形 poison　マイナス5
//3：罠地形 death　即死

int cure = 5;
int poison = 5;

//.NETにおけるランダムの作り方
Random rand = new Random(); //ランダムの機能をもっているクラスの実体化（randという名前で実体化）
int result = rand.Next(0,4); //0以上4未満（つまり3）の値を取得

Console.WriteLine("現在のHP：" + currentHp);

//if (result == 1)
//{
//    currentHp += cure;
//    if(currentHp > maxHp) currentHp = maxHp;
//    Console.WriteLine("回復した！HP：" + currentHp);
//}
//else if (result == 2)
//{
//    currentHp -= poison;
//    if (currentHp <= 0)
//    {
//        currentHp = 0;
//        Console.WriteLine("毒をくらった！HP：" + currentHp);
//        Console.WriteLine("死亡した！");
//    }
//    else
//    {
//        Console.WriteLine("毒をくらった！HP：" + currentHp);
//    }
//}
//else if(result == 3)
//{
//    currentHp = 0;
//    Console.WriteLine("罠にかかった！HP：" + currentHp);
//    Console.WriteLine("死亡した！");
//}
//else
//{
//    Console.WriteLine("何も起きなかった！");
//}


//改良案
string message;
string deathMessage = "";

if (result == 1)
{
    currentHp += cure;
    message = "回復した！HP：";
}
else if (result == 2)
{
    currentHp -= poison;
    message = "毒をくらった！HP：";  
}
else if (result == 3)
{
    currentHp = 0;
    message = "罠にかかった！HP：";
}
else
{
    Console.WriteLine("何も起きなかった！");
    return;
}

if (currentHp <= 0)
{
    currentHp = 0;
    deathMessage = "\n死亡した！";
}
else if (currentHp > maxHp) currentHp = maxHp;

Console.WriteLine(message + currentHp + deathMessage);