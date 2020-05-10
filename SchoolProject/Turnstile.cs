using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolProject
{
    class Turnstile
    {
        //состояние(открытое/закрытое)
        public bool state;
        //открыть турникет
        public void OpenGate()
        {
            state = true;
        }
        //зарыть турникет
        public void CloseGate()
        {
            state = false;
        }
    }
}
