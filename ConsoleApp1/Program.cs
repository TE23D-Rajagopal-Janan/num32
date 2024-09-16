int Poäng = 0; 
Console.WriteLine("Vilken Klass går jag i ");
Console.WriteLine("1)Te23C   2)TE23B  3)TE23D");
string ans1 = Console.ReadLine();
if (ans1 == "1")
{
Console.WriteLine("Fel Svar");
}
else if (ans1 == "2")
 {
    Console.WriteLine("Fel Svar");
 }
 else if (ans1 == "3")
 {
    Console.WriteLine("Korrekt");
    Poäng = Poäng +10;
 }

Console.WriteLine($"Du har {Poäng} Poäng");
Console.WriteLine("Hur gammal är Jag");
Console.WriteLine("1)16 2)17 3)18");
string ans2 = Console.ReadLine();
if (ans2 == "1")
{
   Console.WriteLine("fel svar"); 
}
else if (ans2 == "2")
{
   Console.WriteLine("Rätt svar");
   Poäng = Poäng +10; 
} 
else if (ans2 == "3")
{
   Console.WriteLine("Fel svar");
}

Console.WriteLine($"Du har {Poäng} Poäng");
Console.WriteLine("När är jag född");
Console.WriteLine("1)12 Maj 2)12 September 3)12 Feburary");
string ans3 = Console.ReadLine();
if (ans3 == "1")
{
   Console.WriteLine("Fel svar");
}
else if (ans3 == "2")
{
   Console.WriteLine("Fel svar");
}
else if(ans3 == "3")
{
Console.WriteLine("Rätt svar");
Console.WriteLine("Bra jobbat");
Poäng = Poäng +10;
}
Console.WriteLine("Så här bra gjorde du");
Console.WriteLine($"Du har {Poäng} Poäng");
if (Poäng == 30)
{
 Console.WriteLine ("Alla rätt Bra jobbat");
}
else if (Poäng == 20)
{
   Console.WriteLine ("men a du är ändå helt okej");
}
else if (Poäng == 10) 
{
Console.WriteLine("Katastrofalt gjort");
}
else if (Poäng == 0) 
{
Console.WriteLine("Det här är Katastrofalt");
}

Console.ReadLine();

