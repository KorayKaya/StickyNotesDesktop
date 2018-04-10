using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Linq;
using System.IO;

namespace StickyNotesDesktop
{
    public partial class Form1 : Form
    {
        private const int WM_NCHITTEST = 0x84;
        private const int HT_CLIENT = 0x1;
        private const int HT_CAPTION = 0x2;
        private int startx, starty;
        private string mainText;
        private string savepath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\stickydesktopsave.txt";

        [DllImport("User32.dll")]
        static extern IntPtr FindWindow(String lpClassName, String lpWindowName);
        [DllImport("user32.dll", SetLastError = true)]
        static extern IntPtr FindWindowEx(IntPtr hwndParent, IntPtr hwndChildAfter, string lpszClass, string lpszWindow);
        [DllImport("user32.dll")]
        static extern int SetParent(IntPtr hWndChild, IntPtr hWndNewParent);

        public Form1(string text = "", int x = -1, int y = -1)
        {
            InitializeComponent();
            mainText = text;
            mainTextBox.Text = text;
            startx = x;
            starty = y;
        }
        protected override CreateParams CreateParams
        {
            get
            {
                var Params = base.CreateParams;
                Params.ExStyle |= 0x80;
                return Params;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AppDomain.CurrentDomain.ProcessExit += new EventHandler(save);

            IntPtr pWnd = FindWindow("Progman", "Program Manager");
            pWnd = FindWindowEx(pWnd, IntPtr.Zero, "SHELLDLL_DefVIew", null);
            pWnd = FindWindowEx(pWnd, IntPtr.Zero, "SysListView32", null);
            SetParent(this.Handle, pWnd);

            if (File.Exists(savepath))
            {
                string readText = File.ReadAllText(savepath);
                string[] texts = readText.Split(';');
                File.Create(savepath).Close();
                texts = texts.Take(texts.Count() - 1).ToArray();

                if (!readText.Equals(""))
                {
                    string s1 = texts[0];
                    string coordsString = s1.Substring(0, s1.IndexOf(' '));
                    string[] coords = coordsString.Split(',');
                    string text = s1.Substring(s1.IndexOf(' ') + 1);
                    mainTextBox.AppendText(text);
                    Location= new System.Drawing.Point(Int32.Parse(coords[0]), Int32.Parse(coords[1]));

                    texts = texts.Skip(1).ToArray();
                    foreach (string s in texts)
                    {
                        coordsString = s.Substring(0, s.IndexOf(' '));
                        coords = coordsString.Split(',');
                        text = s.Substring(s.IndexOf(' ') + 1);
                        newNote(text, Int32.Parse(coords[0]), Int32.Parse(coords[1]));
                    }
                }
            }

            if (startx != -1 && starty != -1)
            {
                Location = new System.Drawing.Point(startx, starty);
            }
        }

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == WM_NCHITTEST)
                m.Result = (IntPtr)(HT_CAPTION);
        }

        private void trash_button_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mainTextBox.Text = "";
                this.Close();
            }
            else if (e.Button == MouseButtons.Right)
            {
                Environment.Exit(0);
            }
        }

        private void plus_button_Click(object sender, EventArgs e)
        {
            newNote("",-1,-1);
        }

        private void newNote(string text, int x, int y)
        {
            System.Threading.Thread t = new System.Threading.Thread(() => ThreadProc(text, x, y));
            t.Start();
        }

        private void save(object sender, EventArgs e)
        {
            if (!mainText.Equals(""))
            {
                string createText = Location.X + "," + Location.Y + " " +
                    mainText + ";";

                if (File.Exists(savepath))
                {
                    string readText = File.ReadAllText(savepath);
                    string[] texts = readText.Split(';');
                    if (!texts.Contains(createText))
                    {
                        File.AppendAllText(savepath, createText);
                    }
                }
                else
                {
                    File.WriteAllText(savepath, createText);
                }
            }
        }

        private void mainTextBox_TextChanged(object sender, EventArgs e)
        {
            mainText = mainTextBox.Text;
        }

        private void Form1_DoubleClick(object sender, EventArgs e)
        {
            if (TopMost)
            {
                TopLevel = true;
                TopMost = false;
            } else
            {
                TopMost = true;
            }
        }

        public static void ThreadProc(string text,int x, int y)
        {
            Application.Run(new Form1(text,x,y));
        }
    }
}
