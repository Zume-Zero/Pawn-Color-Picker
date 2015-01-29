using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{

    public partial class Form1 : Form
    {
        int _MValorX, _MValorY;
        bool MoverVentana;

        public Form1()
        {
            InitializeComponent();


            ChangeBoxText();
            textBox1.Text = RGBToPAWNConverter(pictureBox1.BackColor); 
            textBox2.Text = HexConverter(pictureBox1.BackColor);

            timer1.Enabled = true;
            timer1.Interval = 200;
            timer1.Start();

        }
     
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Opacity = 0;
            for (double i = 0; i <= 1; i += 0.1){
                this.Opacity = i;
                this.Refresh();
                System.Threading.Thread.Sleep(15);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        
        // Change pictureBox1
        private void ChangeBoxText(){
            pictureBox1.BackColor = (Color.FromArgb(hScrollBar4.Value, hScrollBar1.Value, hScrollBar2.Value, hScrollBar3.Value));
        }
        
        // RGB To PAWN Color
        private static String RGBToPAWNConverter(System.Drawing.Color c){
            return "0x" + c.R.ToString("X2") + c.G.ToString("X2") + c.B.ToString("X2") + c.A.ToString("X2");
        }

        // RGB To HEX Color
        private static String HexConverter(System.Drawing.Color c){
            return "{" + c.R.ToString("X2") + c.G.ToString("X2") + c.B.ToString("X2") + "}";
        }
       
        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            Color preview = Color.FromArgb(hScrollBar4.Value, hScrollBar1.Value, hScrollBar2.Value, hScrollBar3.Value);
            pictureBox1.BackColor = preview;

            textBox1.Text = RGBToPAWNConverter(pictureBox1.BackColor); 
            textBox2.Text = HexConverter(pictureBox1.BackColor);

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void hScrollBar2_Scroll(object sender, ScrollEventArgs e)
        {

            ChangeBoxText();
            textBox1.Text = RGBToPAWNConverter(pictureBox1.BackColor); ;
            textBox2.Text = HexConverter(pictureBox1.BackColor);

        }

        private void hScrollBar3_Scroll(object sender, ScrollEventArgs e)
        {

            ChangeBoxText();
            textBox1.Text = RGBToPAWNConverter(pictureBox1.BackColor); ;
            textBox2.Text = HexConverter(pictureBox1.BackColor);

        }

        private void hScrollBar4_Scroll(object sender, ScrollEventArgs e)
        {

            ChangeBoxText();
            textBox1.Text = RGBToPAWNConverter(pictureBox1.BackColor); 
            textBox2.Text = HexConverter(pictureBox1.BackColor);



        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random random = new Random();
            random = new Random();
            label1.ForeColor = Color.FromArgb(random.Next(0, 255), random.Next(0,255),random.Next(0,255)); 
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CloseButton_Click_1(object sender, EventArgs e)
        {
            this.Opacity = 1;
            for (double i = 1; i >= 0; i -= 0.1)
            {
                this.Opacity = i;
                this.Refresh();
                System.Threading.Thread.Sleep(15);
            }
            Application.Exit();
        }

        private void VentanaPicker1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void VentanaPicker1_MouseDown(object sender, MouseEventArgs e)
        {
            MoverVentana = true;
            _MValorX = e.X;
            _MValorY = e.Y;
        }

        private void VentanaPicker1_MouseUp(object sender, MouseEventArgs e)
        {
            MoverVentana = false;
        }

        private void VentanaPicker1_MouseMove(object sender, MouseEventArgs e)
        {
            if (MoverVentana == true)
            {
                this.SetDesktopLocation(MousePosition.X - _MValorX, MousePosition.Y - _MValorY);
            }
        }

        private void MaximizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void FormName_Click(object sender, EventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            //this.linkLabel1.LinkVisited = true;
            System.Diagnostics.Process.Start("http://forum.sa-mp.com/member.php?u=146395");
        }
    }
}
