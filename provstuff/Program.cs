using System;

namespace provstuff
{
    class Program
    {
        static Shopper person = new Shopper();
        
        static void Main(string[] args)
        {
        bool gameEnd = false;

            while(gameEnd == false){
            Book books = new Book();
            if(books.isCursed == true){
                gameEnd = true;
            }
            else{
                
            }
            }
            Console.ReadLine();
        }
    }
}
