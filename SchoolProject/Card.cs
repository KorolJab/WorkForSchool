using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolProject
{
    class Card
    {
        //конструктор
        public Card(int _ID,bool _state,string _FirstName,string _LastName,int _Class,char _ClassModiFyer)
        {
            ID = _ID;
            state = _state;
            FirstName = _FirstName;
            LastName = _LastName;
            Class = _Class;
            ClassModifyer = _ClassModiFyer;

        }
        //номер карты
        public int ID{ get; private set; }
        // состояние карты(рабочее/не рабочее)
        public bool state { get; private set; }
        //Имя
        public string FirstName { get; private set; }
        //фамилия
        
        public string LastName { get; private set; }
        //класс учащегося
        public int Class { get; private set; }
        //буква класса, вообще не помню почему именно чар...
        public char ClassModifyer { get; private set; }
    }
}
