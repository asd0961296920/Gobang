using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;


namespace 棋子
{
    class Game
    {
    private bod bod = new bod();
        private type tr = type.NODE;
    
       //   private type trr = new type();
        public type TR {get { return tr; } }
        public type tv = type.NODE;
        private type type = type.BLACK;
        public bool can (int x,int y)
        {
            return bod.Tool(x,y);

        }
        public plic plic (int x,int y)
        {
            plic ppp = bod.aplic(x, y, type);
                if (ppp != null)
                {

                gameplay();

                if (type == type.BLACK)
                {
                    type = type.WHITE;
                    tv = type.WHITE;
                }
                else if (type == type.WHITE)
                {
                    type = type.BLACK;
                    tv = type.BLACK;
                }
                    return ppp;

                }

            return null;
        }

        public void gameplay()
        {
      
            int ccX = bod.PASS.X;
            int ccY = bod.PASS.Y;
            //紀錄看到幾顆相同棋子
          
           
            for (int xd = -1; xd <= 1; xd++)
            {
                

                for (int yd = -1; yd <= 1; yd++)
                {

                    if (xd == 0 && yd == 0)
                        continue;
                    int cc = 1;
                    int count2 = 1;

                    while (cc < 5)
                    {
                       
                        int seeX = ccX + cc * xd;
                        int seeY = ccY + cc * yd;
                        if (seeX < 0 || seeX >= bod.GG ||
                            seeY < 0 || seeY >= bod.GG ||
                            bod.Tgg(seeX, seeY) != type)
                            break;
                        cc++;
                    }
                   
                    while (count2 < 5)
                    {
                        int targetX = ccX - count2 * xd;
                        int targetY = ccY - count2 * yd
                            ;

                        if (targetX < 0 || targetX >= bod.GG ||
                        targetY < 0 || targetY >= bod.GG ||
                        bod.Tgg(targetX, targetY) != type)
                        {
                            break;
                        }
                        count2++;
                    }

                    if (cc >= 5)
                    {
                        tr = type;
                    }
                    if (cc + count2 > 5)
                        tr = type;



                }
            }
        }

    }
}
