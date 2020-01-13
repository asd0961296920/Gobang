using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace 棋子
{
    class bod
    {
        //棋盤邊界到線
        private static readonly int o=75;
        //判定範圍半徑
        private static readonly int n = 15;
        //線根線之間距離
        private static readonly int c = 75;
        public static readonly int GG = 9;

        private static readonly Point h = new Point(-1, -1);
      
        private Point pass = h;
        public Point PASS { get {return pass; } }
        private plic[,] rrr = new plic[9, 9];
        public type Tgg(int nonex,int noney)
        {
            if (rrr[nonex, noney] == null)
                return type.NODE;
            else
            return rrr[nonex, noney].getype();
        }

        public bool Tool(int x,int y)
        {
            //找出最近的點
            Point none = FD(x, y);
            //如果沒有棋子 回傳false
            if (none == h)
                return false;

            //如果有的話 檢查有沒有棋子存在
            if (rrr[none.X, none.Y] != null)
                return false;

            return true;

        }

        public plic aplic (int x,int y ,type ddd)
        {
            //找出最近的點
            Point none = FD(x, y);
            //如果沒有棋子 回傳false
            if (none == h)
                return null;

            //如果有的話 檢查有沒有棋子存在
            Point ww = TTT(none);
            if (rrr[none.X, none.Y] != null)
                return null;
            if (ddd == type.BLACK)
                rrr[none.X, none.Y] = new black(ww.X,ww.Y );
            else if(ddd==type.WHITE)
                rrr[none.X, none.Y] = new white(ww.X, ww.Y);

            //紀錄最後下子的位置
            pass = none;

            return rrr[none.X, none.Y];


        }
    
     public Point TTT (Point none)
        {
            Point re = new Point();
            re.X = none.X * c + o;
            re.Y = none.Y * c + o;
            return re;


        }
        public Point FD (int x,int y )
        {
            int ndx = YES(x);

            if (ndx == -1 || ndx>=GG)
                return h;
            int nndy = YES(y);
            if (nndy == -1 || nndy >=GG)
                return h;

            return new Point(ndx, nndy);
        }

        private int YES(int a)
        {
            a -= o;
            int e = a / c;
            int d = a % c;
            if (d <= n)
                return e;
            else if (d >= c - n)
                return e + 1;
            else return -1;
        }
    }
}
