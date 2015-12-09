using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LongMacro
{
    public class Command
    {
        public Keys Key;
        public String name;

        public Command(Keys keyToSend, String commandName)
        {
            this.Key = keyToSend;
            this.name = commandName;
        }
    }
}
