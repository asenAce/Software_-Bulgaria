using SlumGame.GameObjects.Items;
using SlumGame.GameObjects.RolePlayers;
using SlumGame.IFaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlumGame.GameEngines
{
     public class Engine
    {
         private const int _GAMETURNS = 4;

         protected List<Characters> characterList = new List<Characters>();
         protected List<Bonus> timeOutItems;


         public virtual void Run()
         {
             //Creating the Methods
             ReadTheUserInput();
             InitializeTimeOutItems();

             for (int i = 0; i < _GAMETURNS; i++)
             {
                 foreach (var character in characterList)
                 {
                     if (character.isALive)
                     {
                         ProcessTargetSearch(character);
                     }

                 }

                 ProcessItemTimeOut(timeOutItems);
             }

             PrintGameOutCome();
         }

         //Generated the Methods
         private void PrintGameOutCome()
         {

             var charactersAlive = characterList.Where(c => c.isALive);
             var redTeamCount = charactersAlive.Count(x => x.Team == Team.Red);
             var blueTeamCount = charactersAlive.Count(x => x.Team == Team.Blue);

             if (redTeamCount == blueTeamCount)
             {
                 Console.WriteLine("Equals");
             }


             else
             {
                 string theWinningTeam;
                 theWinningTeam = redTeamCount > blueTeamCount ? "Red" : "Blue";

                 Console.WriteLine(theWinningTeam + "team is the winning");
             }


             var aLiveCharacters = characterList.Where(c => c.isALive);
             PrintCharactersStatus(aLiveCharacters);
         }

         public void ProcessItemTimeOut(List<Bonus> timeOutItems)
         {

             for (int i = 0; i < timeOutItems.Count; i++)
             {
                 timeOutItems[i].CountDown--;

                 if (timeOutItems[i].CountDown == 0)
                 {
                     var item = timeOutItems[i];
                     item.isitTimeOut = true;

                     var itemHolder = GetCharacterByItem(item);
                     itemHolder.RemoveFromInventory(item);
                     i--;
                 }
             }

         }

         protected Characters GetCharacterByItem(Item item)
         {
             return characterList.FirstOrDefault(x => x.Inventory.Contains(item));
         }

         protected void ProcessTargetSearch(Characters currentCharacter)
         {
             var availableTargets = characterList
                 .Where(t => IsWithinRange(currentCharacter.X, currentCharacter.Y, t.X, t.Y, currentCharacter.Range)).ToList();
             
             if (availableTargets.Count == 0)
             {
                 return;
             }

             var target = currentCharacter.GetTarget(availableTargets);

             if (target == null)
             {
                 return;
             }

             ProcessInteraction(currentCharacter,target);

         }

         protected void ProcessInteraction(Characters currentCharacter, Characters target)
         {
             if (currentCharacter is IHeal)
             {
                 target.HealthPoints += (currentCharacter as IHeal).HealingPoins;
             }

             else if (currentCharacter is IAttack)
             {
                 target.HealthPoints -= (currentCharacter as IAttack).AttackPoints - target.DefensePoints;

                 if (target.HealthPoints <= 0 )
                 {
                     target.isALive = false;  // is destroyed.
                 }
             }
         }

         private bool IsWithinRange(int attackerX, int attackerY, int targetX, int targetY, int range)
         {
             double distane;
             distane = Math.Sqrt((attackerX - targetX) *(attackerX - targetX) 
                       + (attackerY - targetY) * (attackerY - targetY));

             return distane <= (double)range;

         }

         public void InitializeTimeOutItems()
         {
             timeOutItems = characterList
                 .SelectMany(c => c.Inventory)
                 .Where(i => i is Bonus)
                 .Cast<Bonus>()
                 .ToList();

         }

         private void ReadTheUserInput()
         {
             //Promp the User
             Console.WriteLine("******  Slum Game *********");
             Console.WriteLine("Please write possition One : Create , Status or add" + "\nPossition Two type: mage, warrior or healer \npossition three item: axe,injection, pill shield.\nPossition Four: x .Possition Five Y.Possition Six: Team Red or Blue. ");                   
             // Declaring myVariable;
             string userInput;
             // Added by me Exept handling , what about number?
             try
             {
                 userInput = Console.ReadLine();
                 // oBject string . Method IsNullOrEmpty passing the parameters (userInput)
                 if (string.IsNullOrEmpty(userInput))
	                {
		                throw new ArgumentNullException("Incorrect");
	                }
             }
             catch (Exception)
             {

                 throw new ArgumentException("Incorrect");
             }
             

             while (userInput != string.Empty)
             {
                 string[] parameters = userInput.Split(new[] {' '},StringSplitOptions.RemoveEmptyEntries);

                 ExecuteCommand(parameters);
                 userInput = Console.ReadLine();
             }    
         }

         protected virtual void ExecuteCommand(string[] inputParams)
         {

             switch (inputParams[0])
             {
                 case "status":
                     PrintCharactersStatus(characterList);
                     break;
                     // added
                 case "create":
                     CreateCharacter(inputParams);
                     break;
                 case "add":
                     AddItem(inputParams);
                     break;
             }

         }

         protected void PrintCharactersStatus(IEnumerable<Characters> characters)
         {
             foreach (var character in characters)
             {
                 Console.WriteLine(character.ToString());
             }
         }

         protected Characters GetCharacterById(string characterId)
         {
             return characterList.FirstOrDefault(x => x.ID == characterId);
         }

         
         protected void AddItem(string[] inputParams)
         {
             string characterId;
             string itemId;
             string itemClass;

             Characters character;
             Item item;

             characterId = inputParams[1];
             character = characterList.Find(x => x.ID == characterId);

             itemClass = inputParams[2];
             itemId = inputParams[3];

             switch (itemClass)
             {
                 case "axe":
                     item = new Axe(itemId);
                     break;
                 case "shield":
                     item = new Shield(itemId);
                     break;
                 case "pill":
                     item = new Pill(itemId);
                     break;
                 case "injection":
                     item = new Injection(itemId);
                     break;
                 default:
                     break;
             }
         }

         protected virtual void CreateCharacter(string[] inputParams)
         {
             //Declaring the variables
             string iD;
             int x;
             int y;
             string type;
             Characters character;
             Team team;
             // using the possitions of the massive.
             type = inputParams[1];
             iD = inputParams[2];
             // .Method Parse() converred a string into a int 
             x = int.Parse(inputParams[3]);
             y = int.Parse(inputParams[4]);
             team = (Team)Enum.Parse(typeof(Team), inputParams[5]);

             switch (type)
             {
                 case "mage":
                     character = new Mage(iD, x, y, team);
                     break;
                 case "warrior":
                     character = new Warrior(iD, x, y, team);
                     break;
                 case "healer":
                 default:
                     character = new Healer(iD, x, y, team);
                     break;
             }

             characterList.Add(character);
         }
         

         
    }
}
