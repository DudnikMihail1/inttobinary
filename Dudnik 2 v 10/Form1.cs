using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dudnik_2_v_10
{
    public partial class Form1 : Form
    {
        #region move & shadow

        [DllImport("dwmapi.dll")]
        public static extern int DwmExtendFrameIntoClientArea(IntPtr hWnd, ref MARGINS pMarInset);

        [DllImport("dwmapi.dll")]
        public static extern int DwmSetWindowAttribute(IntPtr hwnd, int attr, ref int attrValue, int attrSize);

        [DllImport("dwmapi.dll")]
        public static extern int DwmIsCompositionEnabled(ref int pfEnabled);

        private bool m_aeroEnabled = false;
        private const int CS_DROPSHADOW = 0x00020000;
        private const int WM_NCPAINT = 0x0085;
        private const int WM_ACTIVATEAPP = 0x001C;

        public struct MARGINS
        {
            public int leftWidth;
            public int rightWidth;
            public int topHeight;
            public int bottomHeight;
        }

        private const int WM_NCHITTEST = 0x84;
        private const int HTCLIENT = 0x1;
        private const int HTCAPTION = 0x2;

        protected override CreateParams CreateParams
        {
            get
            {
                m_aeroEnabled = CheckAeroEnabled();

                CreateParams cp = base.CreateParams;
                if (!m_aeroEnabled)
                    cp.ClassStyle |= CS_DROPSHADOW;

                return cp;
            }
        }

        private bool CheckAeroEnabled()
        {
            if (Environment.OSVersion.Version.Major >= 6)
            {
                int enabled = 0;
                DwmIsCompositionEnabled(ref enabled);
                return (enabled == 1) ? true : false;
            }
            return false;
        }

        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_NCPAINT:
                    if (m_aeroEnabled)
                    {
                        var v = 2;
                        DwmSetWindowAttribute(this.Handle, 2, ref v, 4);
                        MARGINS margins = new MARGINS()
                        {
                            bottomHeight = 0,
                            leftWidth = 0,
                            rightWidth = 0,
                            topHeight = 1
                        };
                        DwmExtendFrameIntoClientArea(this.Handle, ref margins);

                    }
                    break;
                default:
                    break;
            }
            base.WndProc(ref m);

            if (m.Msg == WM_NCHITTEST && (int)m.Result == HTCLIENT)
                m.Result = (IntPtr)HTCAPTION;

        }
        Point LastPoint;
        public void mouse_dwn(MouseEventArgs e)
        {
            LastPoint = new Point(e.X, e.Y);
        }
        public void mouse_mv(MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - LastPoint.X;
                this.Top += e.Y - LastPoint.Y;
            }
        }
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            mouse_mv(e);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mouse_dwn(e);
        }

        private void Title_MouseMove(object sender, MouseEventArgs e)
        {
            mouse_mv(e);
        }

        private void Title_MouseDown(object sender, MouseEventArgs e)
        {
            mouse_dwn(e);
        }
        #endregion
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            strt_end.Start();
        }
        public int strt_or_end;
        private void strt_end_Tick(object sender, EventArgs e)
        {
            if (strt_or_end == 0)
            {
                if (Opacity == 1)
                {
                    strt_end.Stop();
                }
                else
                {
                    Opacity += .2;
                }
            }
            else
            {
                if (Opacity == 1)
                {
                    Opacity -= .2;
                }
                else
                {
                    strt_end.Stop();
                    Application.Exit();
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            strt_or_end = 1;
            strt_end.Start();
        }

        private void convert_btn_Click(object sender, EventArgs e)
        {
            if (tentotwo.Checked)
            {
                try
                {
                    int i = Convert.ToInt32(textBox.Text);
                    textBox1.Text = Convert.ToString(i, 2);
                    Size = MaximumSize;
                }
                catch
                {
                    MessageBox.Show("Введите число.");
                }
            }
            if (twototen.Checked)
            {
                Size = MaximumSize;
                try
                {
                    int i = Convert.ToInt32(textBox.Text, 2);
                    textBox1.Text = Convert.ToString(i);
                    Size = MaximumSize;
                }
                catch
                {
                    MessageBox.Show("Введите число в ввиде двоичной системы счисления.");
                }
            }
        }
    }
}
