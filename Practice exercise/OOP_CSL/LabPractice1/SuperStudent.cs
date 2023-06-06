using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabPractice1
{
    internal class SuperStudent : Student
    {
        public override void Output()
        {
            Console.WriteLine("{2} is a pro-{1}player, his assasin id is {0}", this.Id, this.Skill, this.Name);
        }
    }
}
