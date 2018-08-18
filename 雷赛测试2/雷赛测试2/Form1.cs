using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using csLTDMC;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
        UInt16 CardNo, axis;
        private void Form1_Load(object sender, EventArgs e)
        {
            LTDMC.dmc_board_init();

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            LTDMC.dmc_board_close();

        }
        
        private void start_Click(object sender, EventArgs e)
        {
            LTDMC.dmc_set_profile(0, 0, 500, 5000, 0.01, 0.01, 500);
            LTDMC.dmc_pmove(0, 0, 200000, 0);


        }

        private void stop_Click(object sender, EventArgs e)
        {
            LTDMC.dmc_stop(0, 0, 0);

        }

        private void set_alm_Click_1(object sender, EventArgs e)//设置alm信号的有效电平为高电平
        {
            UInt16 enable, alm_logic, alm_action;
            for (UInt16 i = 0; i < 4; i++)
            {
                CardNo = 0;
                axis = i;
                enable = 1;
                alm_logic = 1;
                alm_action = 0;
                LTDMC.dmc_axis_io_status(0, i);
                LTDMC.dmc_set_alm_mode(CardNo, axis, enable, alm_logic, alm_action);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            short sevon = LTDMC.dmc_read_sevon_pin(CardNo, axis);
            MessageBox.Show(Convert.ToString(sevon, 10).ToUpper());


        }
        
    }
}
