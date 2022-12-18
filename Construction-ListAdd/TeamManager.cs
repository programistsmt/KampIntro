using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Construction_ListAdd
{
    public class TeamManager
    {
        TeamMate newplayerx = new TeamMate();
        //public TeamManager()
        //{
        //    newplayer1= new TeamMate(); 
        //}
        public void TeamList(List<TeamMate> x)
        {
            foreach (var p in x)
            {
                Console.WriteLine(p.NameSurname + " " + p.Age + " " + p.Number);
            }
            
            
         }

        public void TeamAdd() 
        {

            newplayerx.NameSurname = Console.ReadLine();
            newplayerx.Age=Convert.ToInt32(Console.ReadLine());
            newplayerx.Number = Convert.ToInt32(Console.ReadLine());

         }
         public TeamMate Item // bu metotu yukardaki metotdaki değeri geri main classa döndürmek için kullanıyoruz.
        {
            get { return newplayerx; }  
        }
    
    }

}
