using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolProject
{
    class Card
    {
        public Card(int _ID,bool _state,string _FirstName,string _LastName,int _Class,char _ClassModiFyer)
        {
            ID = _ID;
            state = _state;
            FirstName = _FirstName;
            LastName = _LastName;
            Class = _Class;
            ClassModifyer = _ClassModiFyer;

        }
        public int ID{ get; private set; }
        public bool state { get; private set; }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public int Class { get; private set; }
        public char ClassModifyer { get; private set; }
    }
}
