//P100のアレンジ
void Shop()
{
    Console.WriteLine("いらっしゃいませ");
}

//p103のアレンジ
void Shop_Hello(string hello)
{
    switch (hello)
    {
        case "朝":
            Console.WriteLine("おはようございます!");
            break;
        case "昼":
            Console.WriteLine("こんにちは!");
            break;
        case "夜":
            Console.WriteLine("こんばんは!");
            break;
        default:
            Console.WriteLine("恐れ入ります!");
            break;
    }
}

//p106のアレンジ
int Shop_Buy(string item) //仮の値：引数
{
    int price; //ローカル変数
    switch (item)
    {
        case "おかか":
            price =  120;
            break;
        case "こんぶ":
            price = 150;
            break;
        case "しゃけ":
            price = 180;
            break;
        default:
            price = 200;
            break;
    }

    return price; //int型を返す ※返り値
}

Shop();
Shop_Hello("昼");

string item = "おかか"; //グローバル変数
int price; //グローバル変数
price = Shop_Buy(item); //Shop_Buy(引数)メソッドの実行結果として返った数字が変数priceに代入される
Console.WriteLine(item + "のお値段は" + price + "円です！");
