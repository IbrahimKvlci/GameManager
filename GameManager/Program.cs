using GameManager.Abstract;
using GameManager.Concrete;
using GameManager.Entities;

internal class Program
{
    private static void Main(string[] args)
    {
        Gamer gamer = new Gamer { Name="Ibrahim",Surname="Kavalci",TcNo="12345678901",Id=1,DateOfBirth=new DateTime(2004,4,6)};
        IGamerManager gamerManager = new GamerManager(new GamerCheckManager());
        gamerManager.Save(gamer);
        IGameService gameService = new GameService();
        gameService.Add(new Game { Name="GTA 6",Id=1,Price=399});
    }
}