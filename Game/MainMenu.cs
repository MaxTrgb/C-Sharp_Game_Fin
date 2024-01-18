using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace C_CLASS25._11._2
{
    class MainMenu
    {
        ChoseHeroMenu chooseHeros = new ChoseHeroMenu();

        public void runMenu()
        {
            ConsoleKeyInfo menuChoice;

            while (true)
            {
                Console.Clear();

                PrintManger.mainMenuIntro();

                menuChoice = Console.ReadKey();

                if (menuChoice.KeyChar != '3')
                {
                    menuChoices(menuChoice);
                }
                else
                {
                    break;
                }
            }
        }
        private void menuChoices(ConsoleKeyInfo menuChoice)
        {
            if (menuChoice.KeyChar == '1')
            {
                chooseHeros.chooseHeroMenu();
            }
            else if (menuChoice.KeyChar == '2')
            {
                StatisticsManager.runStatistics();
            }
            else
            {
                PrintManger.invalidChoice();
            }
        }

    }
}