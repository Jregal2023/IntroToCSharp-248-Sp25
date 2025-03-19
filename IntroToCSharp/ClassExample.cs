//These are libraries that are imported into C# so that they can run internal processes

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//is a place where all the classes and file belong too... similiar to a package
//what this means is that if program.cs wants to use this file it has to be part of the same namespace
namespace IntroToCSharp
{
    class Person
    {
        //keyword public means that any other class besies this one can have access to it
        //they are also private variables and functions/methods where only the class where those items
        //are located in can access it
        public int x = 7;
    }
}
