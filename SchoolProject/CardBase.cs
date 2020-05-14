using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace SchoolProject
{
    class CardBase
    {
        //конструктор
        public CardBase()
        {
            Base = new List<Card>();
        }
        List<Card> Base;
        //проверка карты
        public bool CheckCard(int ID)
        {
            bool result=false;
            for (int i = 0; i < Base.Count; i++)
            {
                if (Base[i].ID == ID)
                {
                    result = Base[i].state;
                }
            }
            return result;
        }
        //добавляет карту
        public void AddCard(Card newCard)
        {
            Base.Add(newCard);
        }
        //удаляет ккарту
        public void DeleteCard(int ID)
        {
            for(int i=0; i<Base.Count;i++)
            {
                if(Base[i].ID==ID)
                {
                    Base.RemoveAt(i); 
                }
            }
        }
        //меняет переменные карты
        public void updateCard()
        {
          
        }
      
    }
}
