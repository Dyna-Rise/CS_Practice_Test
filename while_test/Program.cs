//P81
Console.WriteLine("通常バージョン");

int playerPosX = 5; //プレイヤーの座標
int missilePosX = 15; //ミサイルの座標

//プレイヤーとミサイルの座標が同じでない間繰り返す
while(playerPosX != missilePosX)
{
    //現在地
    Console.WriteLine("missile at " + missilePosX);
    //ミサイルが近づいてくる
    missilePosX--;
}
Console.WriteLine("HIT!");


//アレンジ ※一終わりがくるか予想がつかない（ランダム要素が強い）
Console.WriteLine("\nアレンジバージョン");
//一旦リセット
playerPosX = 5; //プレイヤーの座標
missilePosX = 15; //ミサイルの座標

//ランダムの準備
Random rand = new Random(); //ランダムの能力を持つクラスを変数randに実体化
int move; //ランダム値の受け皿

while (playerPosX < missilePosX)
{
    //現在地
    Console.WriteLine("missile at " + missilePosX);
    //毎回ランダムな値だけミサイルが近づいてくる
    move = rand.Next(1, 5); //0以上5未満(4まで)
    missilePosX　-= move;
}
Console.WriteLine("HIT!");



//p83無限ループのアレンジ
Console.WriteLine("\n無限ループのアレンジバージョン");
//一旦リセット
playerPosX = 5; //プレイヤーの座標
missilePosX = 15; //ミサイルの座標
//※randとmoveはリセット不要で使い回し

while (true) //「ずっと」に相当
{
    //現在地
    Console.WriteLine("missile at " + missilePosX);
    move = rand.Next(1, 5); //0以上5未満(4まで)
    missilePosX -= move;

    //内部で抜ける条件を判断
    if (playerPosX >= missilePosX)
    {
        break; //ループを強制的に抜ける
    }
}
Console.WriteLine("HIT!");