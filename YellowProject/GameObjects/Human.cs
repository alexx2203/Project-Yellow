using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yellow_Project.Classes
{
    public abstract class Human
    {
        string Name {get; set;}
        private int _birthDay;
        string BirthMonth {get; set;}
        
        int BirthDay {
            
            get{return _birthDay;}
            set{if(value>0 && value<29){ 
                    _birthDay = value;
                }         
            }
        }

        

    }
}
