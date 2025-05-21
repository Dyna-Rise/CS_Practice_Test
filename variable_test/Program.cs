//45ページ　変数の型

//整数型
int month;
month = 5; //宣言と初期化が別

int day = 22; //宣言と初期化が一緒

//単精度小数点型
float temperature_f = 26.2f;
//倍精度小数点型
double temperature_d = 26.2;

//文字列型
string week = "木曜日";

//フラグ（論理型）
bool temp_display = true;

//変数に変数を代入
//文字列と変数を連結 → 文字列として仕上る
string announce = month + "月" + day + "日は" + week + "です。";
Console.WriteLine(announce);

//条件分岐
//もしもtemp_displayがtrueなら温度情報を出す
//if(temp_display == true)
if(temp_display) //if()は()の中の情報が結果的にtrueであれば処理をする
{
    Console.Write("温度は" + temperature_f + "です。");
}

if(month == 5)
{
    Console.WriteLine("あじさいがキレイな季節です。");
}