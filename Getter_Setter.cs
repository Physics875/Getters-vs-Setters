using System;

class Program
{
	static void Main(string[] args)
	{
	    Console.Write("Enter first number: ");
		Player player = new Player(int.Parse(Console.ReadLine()));
		Console.Write("Enter second number: ");
		player.Speed = int.Parse(Console.ReadLine());
		Console.WriteLine(player.Speed);
	}
}

class Player
{
    private int speed;
    
    public Player(int s)
    {
        Speed = s;    
    }
    
    public int Speed
    {
     	get
     	{ 	return speed; } 
     	
     	set
     	{ 
     	    
		 	if (value > 100)
			{
				speed = 300;
			}		
			else
			{
				speed = value;
			}
		}
    }
}