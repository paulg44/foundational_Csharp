using System.IO.Compression;

Random dice = new Random();

int roll1 = dice.Next(1, 7);
int roll2 = dice.Next(1, 7);
int roll3 = dice.Next(1, 7);

// roll1 = 6;
// roll2 = 6;
// roll3 = 6;

int total = roll1 + roll2 + roll3;

Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3}");

if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
{
  if((roll1 == roll2) && (roll2 == roll3))
  {
     Console.WriteLine("You rolled triples! =^ bonus to total!");
     total += 6;
  }
  else 
  {
     Console.WriteLine("You rolled doubles! +2 bonus to total");
     total += 2;

  }
}

if(total >= 16) 
{
    Console.WriteLine("You win a new car!");
}
else if (total >= 10)
{
    Console.WriteLine("You win a new laptop");
}
else if (total ==7) 
{
    Console.WriteLine("You win a trip for two!");
}
else 
{
    Console.WriteLine("You win a kitten!");
}


// string message = "The quick brown fox jumps over the lazy dog.";
// bool result = message.Contains("dog");
// Console.WriteLine(result);

// if(message.Contains("fox"))
// {
//     Console.WriteLine("What does the fox say?");
// }

// Code challenge -- You've been asked to add a feature to your company's software. The feature is intended to improve the renewal rate of subscriptions to the software. Your task is to display a renewal message when a user logs into the software system and is notified their subscription will soon end. You'll need to add a couple of decision statements to properly add branching logic to the application to satisfy the requirements.

Random random= new Random();
int daysUntilExpiration = random.Next(12);
int discountPercentage = 0;

if( daysUntilExpiration == 0) 
{
    Console.WriteLine("Your subscription has expired.");
}
else if (daysUntilExpiration == 1)
{
    Console.WriteLine("Your subscription expires within a day!");
    discountPercentage = 20;
}
else if (daysUntilExpiration <= 5)
{
    Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days.");
    discountPercentage = 10;
}
else if(daysUntilExpiration <= 10)
{
    Console.WriteLine("Your subscription will expire soon. Renew now!");
}

if( discountPercentage > 0 )
{
    Console.WriteLine($"Renew now and save {discountPercentage}%");
}