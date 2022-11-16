using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Flash : Form
    {

        #region Hàm dựng
        public Flash()
        {
            InitializeComponent();
        }
        #endregion

        #region Các chức năng
        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            this.Close();
        }

        private void Flash_Load(object sender, EventArgs e)
        {
            timer1.Interval = 3000; // Mở form trong 3 giây
            timer1.Start();
        }
        #endregion
    }
}
