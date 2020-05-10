using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolProject
{
    class CardBase
    {
        List<Card> Base;
        //проверка карты
        public bool CheckCard()
        {
            bool result=false;
            return result;
        }
        //добавляет карту
        public void AddCard()
        {

        }
        //удаляет ккарту
        public void DeleteCard()
        {

        }
        //меняет переменные карты
        public void ChangeCard()
        {

        }
        //конструктор
        public CardBase()
        {
            Base = new List<Card>();
        }
    }
}
