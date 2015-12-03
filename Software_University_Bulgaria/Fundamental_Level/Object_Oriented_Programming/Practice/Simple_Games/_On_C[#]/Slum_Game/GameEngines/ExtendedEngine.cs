using SlumGame.GameObjects.Items;
using SlumGame.GameObjects.RolePlayers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlumGame.GameEngines
{
    class ExtendedEngine : Engine
    {

        protected override void ExecuteCommand(string[] inputParams)
        {
            //data structure  massive of type strings [] ID inputParams on possition zero[0]
            // look for match "" by cases.... case one "status" if true do this<code block> call the method PrintCharactersStatus () passing the parameter
            // (characterList) which is another data structore of type generic List<> 
            // 

            switch (inputParams[0])
            {

                case "status":
                    PrintCharactersStatus(characterList);
                    break;
                case "create":
                    CreateCharacter(inputParams);
                    break;
                case "add":
                    AddItem(inputParams);
                    break;
                default:
                    break;
            }
             
        }

        protected override void CreateCharacter(string[] inputParams)
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
                    character = new Mage(iD,x,y,team);
                    break;        
                case "warrior":
                    character = new Warrior(iD,x,y,team);
                    break;
                case "healer":
                default:
                    character = new Healer(iD,x,y,team);
                    break;
            }

            characterList.Add(character);
        }

        protected new void AddItem(string[] inputParams)
        {
            string characterId;
            string itemId;
            string itemClass;

            Characters character;
            Item item;

            characterId = inputParams[1];
            character = characterList.Find(x => x.ID == characterId);

            itemClass = inputParams [2];
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



    }
}
