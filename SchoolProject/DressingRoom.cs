using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolProject
{
    class DressingRoom
    {
        protected Dictionary<int, bool> hooks;
        private bool spotiState;
        public void UnblockSpoti()
        {
            spotiState = true;
        }
        public void BlockSpoti()
        {
            spotiState = false;
        }
        public bool CheckSpoti()
        {
           
            
                return spotiState;
           
        } 
        
    }
}
