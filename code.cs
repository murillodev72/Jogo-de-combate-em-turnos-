using System;
using CSharpShellCore;
namespace CombateEmTurnos{
class Classe{
public static void Main(String[] args){

int hpDoJogador = 50;
int hpDoInimigo = 60;
int ataqueDoJogador = 8;
int ataqueDoInimigo = 9;
int cura = 5;
Random random = new Random();


//turno do jogador
while(hpDoJogador > 0 && hpDoInimigo > 0)
{
Console.WriteLine("-- é seu turno! --");
Console.WriteLine("hp do jogador: "+hpDoJogador+ " hp do inimigo: "+ hpDoInimigo);
Console.WriteLine("digite (a) para atacar e (c) para se curar");
string escolhaDoJogador = Console.ReadLine();


if( escolhaDoJogador == "a")
    
{	
hpDoInimigo = hpDoInimigo -= ataqueDoJogador;
Console.WriteLine("o jogador atacou e liberou "+ ataqueDoJogador + " de dano!\n ");
}

else{
hpDoJogador += cura;
Console.WriteLine("o jogador restaurou "+cura+" do seu hp\n");
}

//turno do inimigo
if(hpDoInimigo > 0)	
{
Console.WriteLine("-- turno do inimigo --");
Console.WriteLine("hp do jogador: "+hpDoJogador+ " hp do inimigo: "+ hpDoInimigo);
int escolhaDoInimigo = random.Next(0,2);

if(escolhaDoInimigo == 0)

{
hpDoJogador -= ataqueDoInimigo;    
Console.WriteLine("o inimigo atacou e liberou "+ ataqueDoInimigo + " de dano\n");
}

else

{
hpDoInimigo += cura;   
Console.WriteLine("o inimigo restaurou "+cura+" de hp\n");

}

}




}

    }
}
    }




