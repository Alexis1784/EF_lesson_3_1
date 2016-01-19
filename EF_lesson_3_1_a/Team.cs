using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_lesson_3_1_a
{
    class Team
    {
        public Team (string Name)
        { this.Name = Name; }
        public int Id { get; set; }
        public string Name { get; set; } // название команды
        public string Coach { get; set; } // тренер
    }
}
