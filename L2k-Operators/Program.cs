using L2k_Operators;

var m1 = new M(10);
var m2 = new M(10, 20, 30, 20, 10);

Console.WriteLine(m1);
Console.WriteLine(m2);
var m3 = m1 + m2;
Console.WriteLine(m3);
Console.WriteLine(-m3);

M m4 = (M)3;
Console.WriteLine(m4);// 0, 0, 0,

int[] m = m4;

int[] k = new int[]{ 1, 2, 4 };
var m5 = m3 + k;

//Console.WriteLine($"{Counter.Count}");// 0
//Counter c1 = new Counter();
//Console.WriteLine($"{c1.Id}/{Counter.Count}");// 0/1 
//Counter c2 = new Counter();
//Console.WriteLine($"{c1.Id}/{Counter.Count}");// 0/2
//Console.WriteLine($"{Counter.IdCount(c2)}");// 1/2