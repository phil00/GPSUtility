using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GPSUtility
{
    public partial class frmGPS : Form
    {
        static string strGGA = "";
        static string strGSA = "";
        static string strRMC = "";
        static string strVTG = "";
        
        public frmGPS()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
            spGPS.Encoding = Encoding.UTF8;
            spGPS.StopBits = StopBits.One;
            spGPS.Parity = Parity.None;
            spGPS.BaudRate = 38400;
            try
            {
                spGPS.PortName = "COM3";
            }
            catch { }
            try
            {
                spGPS.Open();
            }
            catch { }
        }

        #region Menu
        private void cOM2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            spGPS.Close();
            try
            {
                spGPS.PortName = "COM2";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            try
            {
                spGPS.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }
        private void breakToolStripMenuItem_Click(object sender, EventArgs e)
        {
            spGPS.BreakState = !spGPS.BreakState;
        }
        private void cOM3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            spGPS.Close();
            try
            {
                spGPS.PortName = "COM3";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            try
            {
                spGPS.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }
        private void cOM1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            spGPS.Close();
            try
            {
                spGPS.PortName = "COM1";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            try
            {
                spGPS.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private void cOM4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            spGPS.Close();
            try
            {
                spGPS.PortName = "COM4";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            try
            {
                spGPS.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            spGPS.BaudRate = 150;
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            spGPS.BaudRate = 300;
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            spGPS.BaudRate = 600;
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            spGPS.BaudRate = 1200;
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            spGPS.BaudRate = 9600;
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            spGPS.BaudRate = 38400;
        }
        private void aucuneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            spGPS.Parity = Parity.None;
        }

        private void pairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            spGPS.Parity = Parity.Even;
        }

        private void impaireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            spGPS.Parity = Parity.Odd;
        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            spGPS.StopBits = StopBits.One;
        }

        private void toolStripMenuItem9_Click(object sender, EventArgs e)
        {
            spGPS.StopBits = StopBits.Two;
        }

        private void bitsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            spGPS.DataBits = 7;
        }

        private void bitsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            spGPS.DataBits = 8;
        }
        #endregion Menu

        #region Gestion GPS
        private void spGPS_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            string strReceive = spGPS.ReadLine();
            switch (strReceive.Substring(3, 3))
            {
                case "GGA":
                    strGGA = strReceive;
                    break;
                case "GSA":
                    strGSA = strReceive;
                    break;
                case "RMC":
                    strRMC = strReceive;
                    break;
                case "VTG":
                    strVTG = strReceive;
                    if (strGGA != "" && strGSA != "" && strRMC != "" && strVTG != "")
                    {
                        txtRec.Text = strGGA + strGSA + strRMC + strVTG;
                        string[] strParseData = parser(txtRec.Text);
                        txtLat.Text = strParseData[0];
                        txtLong.Text = strParseData[1];
                    }
                    strGGA = "";
                    strGSA = "";
                    strRMC = "";
                    strVTG = "";
                    break;
            }
        }

        private string[] parser(string receiveData)
        {
            string[] parseData;
            parseData = receiveData.Split(',');
            string[] retData = new string[2];
            double dblLatSec = Convert.ToDouble(parseData[2].Substring(5, 4)) / 10000.0 * 60.0;
            double dblLatPet = (dblLatSec - Convert.ToInt32(Math.Truncate(dblLatSec))) * 60.0;
            double dblLonSec = Convert.ToDouble(parseData[4].Substring(6, 4)) / 10000.0 * 60.0;
            double dblLonPet = (dblLonSec - Convert.ToInt32(Math.Truncate(dblLonSec))) * 60.0;
            retData[0] = string.Format("{0}d {1}' {2}'' {3}''' {4}", Convert.ToInt32(parseData[2].Substring(0, 2)).ToString(), parseData[2].Substring(2, 2), Convert.ToInt32(dblLatSec).ToString(), Convert.ToInt32(dblLatPet), parseData[3]);
            retData[1] = string.Format("{0}d {1}' {2}'' {3}''' {4}", Convert.ToInt32(parseData[4].Substring(0, 3)).ToString(), parseData[4].Substring(3, 2), Convert.ToInt32(dblLonSec).ToString(), Convert.ToInt32(dblLonPet), parseData[5]);
            return retData;
        }

        private void btnParse_Click(object sender, EventArgs e)
        {
            string[] strParseData = parser(txtRec.Text);
            txtLong.Text = strParseData[2];
            txtLat.Text = strParseData[4];
        }

        private void frmGPS_FormClosing(object sender, FormClosingEventArgs e)
        {
            spGPS.Close();
        }
        #endregion Gestion GPS
    }
}
