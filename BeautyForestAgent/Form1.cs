using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BeautyForestAgent
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void VisibleChange(bool visi)
        {
            this.Visible = visi;  //창
            this.notiTray.Visible = !visi;  //트레이 아이콘
        }

        private void BtnTray_Click(object sender, EventArgs e)
        {
            VisibleChange(false);  //버튼 클릭 시 창 숨기기
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;  //X버튼 클릭시 종료되는 것을 취소함
            VisibleChange(false);
        }

        private void 폼보이기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VisibleChange(true);
        }

        private void 종료ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.notiTray.Visible = false;
            Application.ExitThread(); //모두 종료
        }

        private void NotiTray_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            VisibleChange(true);
        }
    }
}
