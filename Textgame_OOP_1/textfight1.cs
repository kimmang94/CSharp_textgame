using System;

//class 를 따로만들어 가져올경우 namespace 는 같아야
namespace Csharp
{
     class textfight1
    {
        
        static void Main(string[] args)
        {
            Game game = new Game();

            while (true)
            {
                game.Process();
            }
        }
    }
}
