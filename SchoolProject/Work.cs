using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace SchoolProject
{
    class Work
    {
        //пока не доделан но задатки конструктора уже есть
        private CardBase baseOfCards;
        private DressingRoom school;
        private Turnstile Turnes;
        public Work(int countOfSpots)
        {
            baseOfCards = new CardBase();
            school = new DressingRoom(countOfSpots);
            Turnes = new Turnstile();

        }
        public void working()
        {
            
        }
        private void giveClothes(int ID)
        {
            if(baseOfCards.CheckCard(ID))
            {

            }
            else
            {
                Console.WriteLine("Все места заняты идите домой");
             }
        }
    }
}
