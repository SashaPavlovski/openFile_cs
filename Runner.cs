using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;


namespace _16112022
{
    internal class Runner
    {
       
        

        public void run ()
        {
            Student ofek = new Student("1");
            ofek.address = "akko";
            ofek.name = "ofek";
            ofek.save();
            ofek.load();

        }

    }
}
