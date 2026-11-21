using Microsoft.Win32;
using System.Reflection;
using System.Runtime.CompilerServices;
using Wolf_Island.Core;
using Wolf_Island.App.View.TUI;

namespace Wolf_Island.App
{
    internal class Program
    {
        static void Main(string[] args)
        {

            TUIGameRender gameUI;
            Game game;
            try
            {
                (gameUI, game) = SetupAndStart();


                uint frames = 1000;
                while (true)
                {
                    gameUI.Render(game.GetObjectStyleGameSnapshot());
                    Thread.Sleep((int)frames);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static (TUIGameRender, Game) SetupAndStart()
        {
            uint width;
            uint height;
            do
            {
                Console.Write("Input field Width: ");
            } while (!uint.TryParse(Console.ReadLine(), out width));
            do
            {
                Console.Write("Input field Height: ");
            } while (!uint.TryParse(Console.ReadLine(), out height));
            //width = 20;  // default 
            //height = 20; // default 

            string configsPath = Path.Combine(AppContext.BaseDirectory, "Configs");

            var game = new Game(
                fieldWidth: width,
                fieldHeight: height,
                settingJsonlocation: configsPath
            );

            TUIGameRender gameUI = new(width, height);

            var amounts = game.GetEntitiesRegistry();

            foreach (var key in amounts.Keys.ToList())
            {
                if (key != "Remains")
                {
                    uint value;
                    do
                    {
                        Console.Write($"Input field {key} amount: ");
                    } while (!uint.TryParse(Console.ReadLine(), out value));
                    amounts[key] = value;
                    //amounts[key] = 5;
                }

            }
            game.Start(amounts);
            gameUI.Clear();

            return (gameUI, game);

        }
    }
}