using Deliverable2.Helpers;
using Deliverable2.Scoring;

var flipResult = 0;

var player = new Player();
var scoreFlip = new ScoreFlip();
var flipRandom = new Random();


player.SetPlayersName();
player.GameInvite();

if (player.answer == "yes")
{    
    for (var i = 1; i <= 5; i++)
    {
        player.GetPlayersChoice();

        flipResult = flipRandom.Next(2);

        scoreFlip.ScoreCoinFlip(i, flipResult, player);
    }

}
else 
{
    Console.WriteLine($"You are a coward { player.name }!");
}

