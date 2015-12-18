using MusicShopManager.Core.Commands;
using MusicShopManager.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MusicShopManager.Core
{
    public class Engine : IEngine
    {
        private readonly IDatabase db;
        private ICommand command;

        public Engine(IDatabase db)
        {
            this.db = db;
        }

        public void Run()
        {
            string input = Console.ReadLine();
            while(input != string.Empty)
            {
                string[] ui = input.Split(new[] { ':', ';', '[', ']' }, 
                                            StringSplitOptions.RemoveEmptyEntries);
                ui = FixedInput(ui);
                switch (ui[0])
                {
                    case "CreateMusicShop":
                        command = new CreateMusicShop(db, ui);
                        break;
                    case "CreateMicrophone":
                        command = new CreateMicrophone(db, ui);     
                        break;
                    case "CreateDrums":
                        command = new CreateDrums(db, ui);            
                        break;
                    case "CreateElectricGuitar":
                        command = new CreateElectricGuitar(db, ui);                   
                        break;
                    case "CreateAcousticGuitar":
                        command = new CreateAcousticGuitar(db, ui);                
                        break;
                    case "CreateBassGuitar":
                        command = new CreateBassGuitar(db, ui);                        
                        break;
                    case "AddArticleToShop":
                        command = new AddArticleToShop(db, ui);
                        break;
                    case "RemoveArticleFromShop":
                        command = new RemoveArticleFromShop(db, ui);
                        break;
                    case "ListArticles":
                        command = new ListArticles(db, ui);
                        break;
                    default:
                        throw new ArgumentException("Invalid command.");
                }
                try
                {
                    command.Execute();
                }
                catch (ArgumentOutOfRangeException e)
                {
                    Console.WriteLine(e.ParamName);
                }
                catch(ArgumentNullException e)
                {
                    Console.WriteLine(e.ParamName);
                }
                catch(ArgumentException e)
                {
                    Console.WriteLine(e.Message);
                }
                finally
                {
                    input = Console.ReadLine();
                }
            }
        }

        private string[] FixedInput(string[] input)
        {
            List<string> list = new List<string>();
            string[] wordsForSkip ={"name", "model", "price", "cable", "make", "color",
                                   "width", "height", "body", "fingerboard", "adapters", "frets",
                                    "case", "strings"};
            foreach (var item in input)
            {
                if(!wordsForSkip.Contains(item))
                {
                    list.Add(item);
                }
            }
            return list.ToArray();
        }
    }
}
