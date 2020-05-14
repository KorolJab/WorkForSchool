using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolProject
{
    class Turnstile
    {
        //состояние(открытое/закрытое)
        public bool state;
        public void OpenGate()
        {
            //открывает турникет

        }
        public void CloseGate()
        {
            //зарывает турникет

        }
          //включает турникет
        public void turnOnTurnstile()
        {
            
            state = true;
        }
        //выключает турникет

        public void turnOffTurnstile()
        {
            state = false;

        }
    }
}
