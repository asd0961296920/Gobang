using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 棋子
{
    public partial class Form1 : Form
    {
        /*
                     ~~~程式執行流程說明~~~
           開啟程式後，點擊再線與線之間的交叉點後會按照plic.cs中的方法來設定並新增一個棋子的基本參數，預設是黑棋，棋子有黑白兩種顏色
           如果滑鼠點擊在線與線之間的交叉點之外的部分，則不會發生任何事情，如果滑鼠點擊已經放置棋子的位置，也不會發生任何事情
           點擊產生棋子之後，程式會透過Game.cs中事先寫好的函數來檢查，以下棋的位置為起點，往四面八方檢查相同顏色的棋子總數有沒有５個
           如果有的話則跳出對話方塊顯示哪方獲勝，如果周圍都沒有相同顏色的棋子連成一線並達到５顆則遊戲繼續進行，棋子的顏色交換
          
           

        */

        private bod r = new bod();
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private Game Game = new Game();



        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            //按下滑鼠後所執行的
            plic pu = Game.plic(e.X, e.Y);


            if (pu != null)
            {
                this.Controls.Add(pu);
                if (Game.tv == type.BLACK)
                    label1.Text = "黑棋的回合";
                else if (Game.tv == type.WHITE)
                    label1.Text = "白棋的回合";


                if (Game.TR == type.BLACK)
                {

                    MessageBox.Show("黑色獲勝");
                    Application.Exit();
                }
                else if (Game.TR == type.WHITE)
                {
                    MessageBox.Show("白色獲勝");
                    Application.Exit();
                }

            }

        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (Game.can(e.X, e.Y)==true)
            {
                this.Cursor = Cursors.Hand;
            }
            else
            {
                this.Cursor = Cursors.Default;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
         
        }

        private void 遊戲說明ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("遊戲規則:\n遊戲開始後，由黑子先下，黑子下完輪到白子\n在某一方相同顏色棋子在連成一線並達到五顆時結束，達成條件者勝利\n本遊戲需要兩個人玩\np.s:跟電腦下的模式還沒開發出來XDD");
        }

        private void 關於ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("本遊戲由\n林冠廷\n單獨開發");
        }
    }
}
