using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalcolatoreDemux
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        decimal k1_v, k1_a, k2_v, k2_a;
        decimal stretch, delay;

        private void Form1_Load(object sender, EventArgs e)
        {
            k1_v = 0; k1_a = 0; k2_v = 0; k2_a = 0;
            stretch = 0; delay = 0;
        }

        private void esciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void calcola_risultato()
        {
            try
            {
                stretch = (k2_a - k1_a) / (k2_v - k1_v);
                label_stretch.Text = stretch.ToString();
            }
            catch (Exception ex)
            {
                label_stretch.Text = "0";
            }
            
            delay = (k1_v - k1_a) * 1000;           
            label_delay.Text = delay.ToString();

        }

        private void calcola_k1_v()
        {
            k1_v = k1_v_h.Value * 3600000 + k1_v_m.Value * 60000 + k1_v_s.Value * 1000 + k1_v_ms.Value;
            try
            {
                k1_v /= 1000;
            } catch(Exception ex)
            {
                k1_v = 0;
            }

            label_k1_v.Text = k1_v.ToString();
        }

        private void calcola_k1_a()
        {
            k1_a = k1_a_h.Value * 3600000 + k1_a_m.Value * 60000 + k1_a_s.Value * 1000 + k1_a_ms.Value;
            try
            {
                k1_a /= 1000;
            }
            catch (Exception ex)
            {
                k1_a = 0;
            }
            label_k1_a.Text = k1_a.ToString();
        }

        private void calcola_k2_v()
        {
            k2_v = k2_v_h.Value * 3600000 + k2_v_m.Value * 60000 + k2_v_s.Value * 1000 + k2_v_ms.Value;
            try
            {
                k2_v /= 1000;
            }
            catch (Exception ex)
            {
                k2_v = 0;
            }
            label_k2_v.Text = k2_v.ToString();
        }

        private void calcola_k2_a()
        {
            k2_a = k2_a_h.Value * 3600000 + k2_a_m.Value * 60000 + k2_a_s.Value * 1000 + k2_a_ms.Value;
            try
            {
                k2_a /= 1000;
            }
            catch (Exception ex)
            {
                k2_a = 0;
            }
            label_k2_a.Text = k2_a.ToString();
        }

        private void k1_v_h_ValueChanged(object sender, EventArgs e)
        {
            calcola_k1_v();
            calcola_risultato();
        }

        private void k1_v_m_ValueChanged(object sender, EventArgs e)
        {
            calcola_k1_v();
            calcola_risultato();
        }

        private void k1_v_s_ValueChanged(object sender, EventArgs e)
        {
            calcola_k1_v();
            calcola_risultato();
        }

        private void k1_v_ms_ValueChanged(object sender, EventArgs e)
        {
            calcola_k1_v();
            calcola_risultato();
        }

        private void k1_a_h_ValueChanged(object sender, EventArgs e)
        {
            calcola_k1_a();
            calcola_risultato();
        }

        private void k1_a_m_ValueChanged(object sender, EventArgs e)
        {
            calcola_k1_a();
            calcola_risultato();
        }

        private void k1_a_s_ValueChanged(object sender, EventArgs e)
        {
            calcola_k1_a();
            calcola_risultato();
        }

        private void k1_a_ms_ValueChanged(object sender, EventArgs e)
        {
            calcola_k1_a();
            calcola_risultato();
        }

        private void k2_v_h_ValueChanged(object sender, EventArgs e)
        {
            calcola_k2_v();
            calcola_risultato();
        }

        private void k2_v_m_ValueChanged(object sender, EventArgs e)
        {
            calcola_k2_v();
            calcola_risultato();
        }

        private void k2_v_s_ValueChanged(object sender, EventArgs e)
        {
            calcola_k2_v();
            calcola_risultato();
        }

        private void k2_v_ms_ValueChanged(object sender, EventArgs e)
        {
            calcola_k2_v();
            calcola_risultato();
        }

        private void k2_a_h_ValueChanged(object sender, EventArgs e)
        {
            calcola_k2_a();
            calcola_risultato();
        }

        private void k2_a_m_ValueChanged(object sender, EventArgs e)
        {
            calcola_k2_a();
            calcola_risultato();
        }

        private void k2_a_s_ValueChanged(object sender, EventArgs e)
        {
            calcola_k2_a();
            calcola_risultato();
        }

        private void k2_a_ms_ValueChanged(object sender, EventArgs e)
        {
            calcola_k2_a();
            calcola_risultato();
        }

        // doppio click

        private void showTooltip(Label myLabel)
        {
            Clipboard.SetText(myLabel.Text);
            Point locationOnForm = myLabel.FindForm().PointToClient(myLabel.Parent.PointToScreen(myLabel.Location));
            toolTip1.Show(myLabel.Text, this, locationOnForm.X + myLabel.Width, locationOnForm.Y, 1000);
        }

        private void label_k1_v_DoubleClick(object sender, EventArgs e)
        {
            showTooltip(sender as Label);
        }

        private void label_k1_a_DoubleClick(object sender, EventArgs e)
        {
            showTooltip(sender as Label);
        }

        private void label_k2_v_DoubleClick(object sender, EventArgs e)
        {
            showTooltip(sender as Label);
        }

        private void label_k2_a_DoubleClick(object sender, EventArgs e)
        {
            showTooltip(sender as Label);
        }

        private void label_stretch_DoubleClick(object sender, EventArgs e)
        {
            showTooltip(sender as Label);
        }

        private void label_delay_DoubleClick(object sender, EventArgs e)
        {
            showTooltip(sender as Label);
        }
    }
}
