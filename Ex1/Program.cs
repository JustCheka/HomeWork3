Console.WriteLine("Введите пятизначное число");
string num = Console.ReadLine();

string num1 = "";

for (int i = num.Length - 1; i >= 0; i--){
    num1 += num[i];
}

if (int.Parse(num1) == int.Parse(num)) Console.WriteLine("Да");
else Console.WriteLine("Нет");