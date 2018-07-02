using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SLEAT_RTO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ercotRadioBtn.CheckedChanged += new EventHandler(radioButton_CheckedChanged);
            pjmRadioBtn.CheckedChanged += new EventHandler(radioButton_CheckedChanged);
            sppRadioBtn.CheckedChanged += new EventHandler(radioButton_CheckedChanged);
            equipmentRadioBtn.CheckedChanged += new EventHandler(radioButton_CheckedChanged);
            lineRadioBtn.CheckedChanged += new EventHandler(radioButton_CheckedChanged);
            stationRadioBtn.CheckedChanged += new EventHandler(radioButton_CheckedChanged);
        }
        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (ercotRadioBtn.Checked == true && equipmentRadioBtn.Checked == true)
                testLbl.Text = "ERCOT Equipment";
            if (ercotRadioBtn.Checked == true && lineRadioBtn.Checked == true)
                testLbl.Text = "ERCOT Line";
            if (ercotRadioBtn.Checked == true && stationRadioBtn.Checked == true)
                testLbl.Text = "ERCOT Station";

            if (pjmRadioBtn.Checked == true && equipmentRadioBtn.Checked == true)
                testLbl.Text = "PJM Equipment";
            if (pjmRadioBtn.Checked == true && lineRadioBtn.Checked == true)
                testLbl.Text = "PJM Line";
            if (pjmRadioBtn.Checked == true && stationRadioBtn.Checked == true)
                testLbl.Text = "PJM Station";

            if (sppRadioBtn.Checked == true && equipmentRadioBtn.Checked == true)
                testLbl.Text = "SPP Equipment";
            if (sppRadioBtn.Checked == true && lineRadioBtn.Checked == true)
                testLbl.Text = "SPP Line";
            if (sppRadioBtn.Checked == true && stationRadioBtn.Checked == true)
                testLbl.Text = "SPP Station";
        }
    }
}
