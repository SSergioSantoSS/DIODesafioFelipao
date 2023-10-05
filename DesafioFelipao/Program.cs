using System;


Console.Write("Digite o nome do herói: ");
string nome = Console.ReadLine();

Console.Write("Digite a quantidade de XP: ");
int XP = int.Parse(Console.ReadLine());

string nivel = "";

switch (XP)
{
    case var _ when XP <= 1000:
        nivel = "Ferro";
        break;
    case var _ when XP > 1000 && XP <= 2000:
        nivel = "Bronze";
        break;
    case var _ when XP > 2000 && XP <= 5000:
        nivel = "Prata";
        break;
    case var _ when XP > 5000 && XP <= 7000:
        nivel = "Ouro";
        break;
    case var _ when XP > 7000 && XP <= 8000:
        nivel = "Platina";
        break;
    case var _ when XP > 8000 && XP <= 9000:
        nivel = "Ascendente";
        break;
    case var _ when XP > 9000 && XP <= 10000:
        nivel = "Imortal";
        break;
    case var _ when XP > 10000:
        nivel = "Radiante";
        break;
}

Console.WriteLine("O Herói de nome " + nome + " está no nível " + nivel);


