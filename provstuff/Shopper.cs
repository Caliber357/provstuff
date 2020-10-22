using System;

namespace provstuff
{
    public class Shopper
    {
        private int interest = 0;
        private bool haveBook = false;
        private Random rng = new Random();
        public void itemInterest(){
            interest = rng.Next(0,6);
            if(haveBook == true){
                System.Console.WriteLine("have that shit");
            }
            else{
                if(interest == 0){
                System.Console.WriteLine("fuck that book");
            }
            else{
            System.Console.WriteLine(interest);
            }
            }
            
        }
        public bool bookOwnage(){
            int YesNo = rng.Next(1,11);
            if(YesNo == 1){
                haveBook = true;
            }
            else{
                haveBook = false;
            }
            return haveBook;
        }


    }
}
