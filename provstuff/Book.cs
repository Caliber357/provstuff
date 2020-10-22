using System;

namespace provstuff
{
    public class Book
    {
        private Random rng = new Random();
        public bool isCursed = false;
        private int worth = 0;
        private int condition = 0;
        private int rare = 0;

        public void item(){
            System.Console.WriteLine("condition: " + condition + "rarity: " + rare);
            System.Console.WriteLine("do you thik its cursed?");
            string choice = Console.ReadLine();
            if(choice == "y"){
                System.Console.WriteLine("you threw the book away");
                Console.ReadLine();
            }
            else if(choice == "n"){
                itemCursed();
                if(isCursed == true){
                }
                else {
                    System.Console.WriteLine("worth" + worth);
                }
            }
        }
        public int itemWorth(){
            worth = rng.Next(0,6);
            return worth;
        }
        public int itemCondition(){
            condition = rng.Next(0,6);
            return condition;
        }
        public int rarity(){
            rare = rng.Next(0,6);
            return rare;
        }
        public bool itemCursed(){
            int YesNo = rng.Next(1,11);
            if(YesNo == 1){
                isCursed = true;
            }
            else{
                isCursed = false;
            }
            return isCursed;
        }
    }
}
