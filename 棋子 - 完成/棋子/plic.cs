using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace 棋子
{
    abstract class plic : PictureBox

    {
        //棋子的基本設定
        private int a = 50;
        public plic (int x,int y)
        {
            this.BackColor = Color.Transparent;
            this.Location = new Point(x-a/2, y-a/2);
            this.Size = new Size(a,a);
}

        public abstract type getype();

    
    }
}
