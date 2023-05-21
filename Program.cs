﻿string frase, cebolinha;

Console.Write("Digite uma frase: ");
frase = Console.ReadLine()!;

cebolinha = frase
.Replace("r", "l")
.Replace("R", "L");

Console.WriteLine(cebolinha);