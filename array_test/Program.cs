//p94　体重の平均

//1週間の体重リスト　その1
float[] weights1 = {
    41.2f,
    42.5f,
    44.9f,
    43.2f,
    45.1f,
    43.2f,
    42.7f
};

float sum1 = 0.0f; //受け皿

//体重の合計
for(int i = 0; i < weights1.Length; i++)
{
    sum1 += weights1[i]; //合計
}

//体重の平均値
float average1 = sum1 / weights1.Length;
Console.WriteLine("平均値は" + average1 + "です。");



//p93のアレンジ　foreach文の使い方

//1週間の体重リスト　その2
float[] weights2 = {
    56.2f,
    56.5f,
    56.9f,
    56.2f,
    56.1f,
    56.2f,
    55.7f
};

float sum2 = 0; //初期化

//体重の合計
foreach (float value in weights2)
{
    sum2 += value;
}

//体重の平均値
float average2 = sum2 / weights2.Length;
Console.WriteLine("平均値は" + average2.ToString("F2") + "です。");