using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolProject
{
    class DressingRoom
    {
       
        protected Dictionary<int, bool> hooks;
        public DressingRoom(int countOfSpots)
        {
            
            for (int i = 1; i <= countOfSpots; i++)
            {
                hooks.Add(i, true);
            }
        }
        public void UnblockSpot(int spotNumber)
        {
            hooks[spotNumber] = true;
        }
        public void BlockSpot(int spotNumber)
        {
            hooks[spotNumber] = false;
        }
        public bool CheckSpot(int spotNumber)
        {
            return hooks[spotNumber];
        } 
        private bool checkFreePlaces()
        {
            int i = 0;
            bool result=false;
            while(i<hooks.Count&&!result)
            {

                if(hooks[i]==true)
                {
                    result = true;
                    
                }
                i++;
            }
            
            return result;
        }
        
    }
}
