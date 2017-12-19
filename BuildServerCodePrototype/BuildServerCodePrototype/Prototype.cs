//////////////////////////////////////////////////////////////////////////////////
// Prototype.cs - demonstration code prototype                           /////
// Language:    C++, Visual Studio 2015                                     //////
// Platform:    Dell XPS 8900, Windows 7                                    //////
// Application: Project #1, CSE681 Software Modeling and Analysis, Fall 2017 //////
// Author:      RamaTeja Repaka, Syracuse University, CST 4-187             //////
//              rrepaka@syr.edu                                             //////
//////////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildServerCodePrototype
{
    /*interface contains abstract function build project.
     * This interface will be extended by test executive  
     */

    interface Prototype
    {
        void buildproject();
    }
}
