String tresfios;
Console.ForegroundColor=ConsoleColor.Green;
Console.Write("Cebolinha:");
Console.ResetColor();
Console.WriteLine("DIGITE UMA FRASE QUE O CEBOLINHA FALARIA");
Console.ForegroundColor=ConsoleColor.DarkBlue;
Console.WriteLine("SUA FRASE :");
Console.ResetColor();
tresfios=Console.ReadLine()!;
Console.Write($"{tresfios}".Replace("r","l"));

Console.WriteLine();
Console.ForegroundColor=ConsoleColor.Red;
Console.WriteLine("Pressione algum botão para ir para a outra etapada da atividade...");
Console.ResetColor();
Console.ReadKey(true);
Console.WriteLine();

//outra variavel da atividade
Console.ForegroundColor=ConsoleColor.Green;
Console.Write("Cebolinha:");
Console.ResetColor();
Console.Write(" Olá, eu sou o Cebolinha, poderia me ajudar a fazer uma atividade?".Replace("r","l"));
Thread.Sleep(2000);
Console.ResetColor();
Console.ForegroundColor=ConsoleColor.Green;
Console.WriteLine();
Console.WriteLine();
Thread.Sleep(2000);
Console.Write("Cebolinha:");
Console.ResetColor();
Console.WriteLine(" voce vai precisar imitar tudo o que eu falar".Replace("r","l"));
Console.WriteLine();
Console.ReadKey(true);
Console.WriteLine("Eu: Ta bom");
Console.WriteLine();
Console.ForegroundColor=ConsoleColor.Green;
Thread.Sleep(2000);
Console.Write("Cebolinha:");
Console.ResetColor();
Console.Write(" Eu troco as letras, nao falo bem, mas meus amigos nao troco por ninguem".Replace("r","l"));
Console.WriteLine();
Console.WriteLine();
Console.ReadKey(true);
Console.WriteLine("Eu: Eu troco as letras, não falo bem, mas meus amigos não troco por ninguém");
Console.WriteLine();
Thread.Sleep(2000);
Console.ForegroundColor=ConsoleColor.Green;
Console.Write("Cebolinha:");
Console.ResetColor();
Console.Write(" Parabens descobriu o codigo secreto".Replace("r","l"));
Console.ForegroundColor=ConsoleColor.Blue;
Console.Write(@"
+---------+
| Vinicius|
+---------+");
Console.ResetColor();