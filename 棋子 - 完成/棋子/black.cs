using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;


namespace 棋子
{
    class black :plic
    {
        public black (int x,int y) : base(x, y)
        {
            this.Image = Properties.Resources.black;



        }
        public override type getype()
        {

            return type.BLACK;

        }
    }
}
