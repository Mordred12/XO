using System;
using System.Drawing;
using System.Media;
using System.Windows.Forms;


namespace XO3
{
    public partial class XO : Form
    {
        public byte[] ban = new byte[9];
        public bool turn = false;
        public byte crest = 0;
        public byte nol = 0;

        public void Draw(ref byte cell, int x1 , int y1, int x2, int y2)
        {
            Graphics field = container.CreateGraphics();
            Pen seraPen = new Pen(Color.FromArgb(255, 84, 84, 84), 5);
            Pen redPen = new Pen(Color.FromArgb(255, 205, 180, 121), 5);
            if (cell == 0)
            {
                if (turn == false)
                {
                    field.DrawLine(seraPen, x1, y1, x2, y2);
                    field.DrawLine(seraPen, x1, y2, x2, y1);
                    cell = 1;
                }
                else
                {
                    field.DrawEllipse(redPen, x1, y1, 120, 120);
                    cell = 2;
                }
                if (turn)
                {
                    turn = false;
                }
                else
                {
                    turn = true;
                }
            }
        }
        public void Win(int x1, int y1, int x2, int y2)
        {
            Graphics field = container.CreateGraphics();
            Pen blackPen = new Pen(Color.FromArgb(255, 128, 94, 73), 5);
            field.DrawLine(blackPen, x1, y1, x2, y2);
            End();
            if (turn != false)
            {
                crest++;
                crestic.Text = $"X-{crest}";
                res.Text = "Win X";
                res.ForeColor = Color.Blue;

            }
            else
            {
                nol++;
                nolic.Text = $"O-{nol}";
                res.Text = "Win O";
                res.ForeColor = Color.Red;
            }
            SoundPlayer sound = new SoundPlayer("brain-fart.wav");
            sound.Play();

        }

        public void Reb()
        {

            ban[0] = 0;
            ban[1] = 0;
            ban[2] = 0;
            ban[3] = 0;
            ban[4] = 0;
            ban[5] = 0;
            ban[6] = 0;
            ban[7] = 0;
            ban[8] = 0;
            turn = false;
            res.Text = "Ход X";
            res.ForeColor = Color.Blue;
            res.Font = new Font("Verdana", 10, FontStyle.Regular);
        }
        public void End()
        {
            ban[0] = 1;
            ban[1] = 2;
            ban[2] = 3;
            ban[3] = 4;
            ban[4] = 5;
            ban[5] = 6;
            ban[6] = 7;
            ban[7] = 8;
            ban[8] = 9;
        }
        public XO()
        {
            InitializeComponent();
            
            crestic.Font = new Font("Verdana", 10, FontStyle.Regular);
            nolic.Font = new Font("Verdana", 10, FontStyle.Regular);


        }

        private void container_Click(object sender, EventArgs e)
        {
            Graphics field = container.CreateGraphics();
            Pen blackPen = new Pen(Color.FromArgb(255, 128, 94, 73), 5);
            Pen seraPen = new Pen(Color.FromArgb(255, 84, 84, 84), 5);
            Pen redPen = new Pen(Color.FromArgb(255, 205, 180, 121), 5);
            int x, y;
            Point p = container.PointToClient(Cursor.Position);
            x = p.X;
            y = p.Y;
            
            if (x <= 140 && y <= 140)
            {
                Draw(ref ban[0], 10, 10, 130, 130);
            }
            if (x >= 140 && x <= 280 && y <= 140)
            {
                Draw(ref ban[1], 150, 10, 270, 130);
            }
            if (x >= 280 && x <= 420 && y <= 140)
            {
                Draw(ref ban[2], 290, 10, 410, 130);
            }
            
            if (x >= 0 && x <= 140 && y >= 140 && y <= 280)
            {
                Draw(ref ban[3], 10, 150, 130, 270);
            }
            if (x >= 140 && x <= 280 && y >= 140 && y <= 280)
            {
                Draw(ref ban[4], 150, 150, 270, 270);

            }
            if (x >= 280 && x <= 420 && y >= 140 && y <= 280)
            {
                Draw(ref ban[5], 290, 150, 410, 270);
            }
            if (x >= 0 && x <= 140 && y >= 280 && y <= 420)
            {
                Draw(ref ban[6], 10, 290, 130, 410);
            }
            if (x >= 140 && x <= 280 && y >= 280 && y <= 420)
            {
                Draw(ref ban[7], 150, 290, 270, 410);
            }
            if (x >= 280 && x <= 420 && y >= 280 && y <= 420)
            {
                Draw(ref ban[8], 290, 290, 410, 410);
                    
            }
            if (turn == false)
            {
                
                res.Text = "Ход X";
                res.ForeColor = Color.Blue;
            }
            else
            {
                res.Text = "Ход O";
                res.ForeColor = Color.Red;
            }

            /*Первая линия горизонт*/
            if (ban[0] == ban[1] && ban[1] == ban[2] && ban[0]!=0)
            {
                Win(10, 70, 410, 70);
            }

            /*Вторая линия горизонт*/
            if (ban[3] == ban[4] && ban[4] == ban[5] && ban[3] != 0)
            {
                Win(10, 210, 410, 210);
            }

            /*Третья линия горизонт*/
            if (ban[6] == ban[7] && ban[7] == ban[8] && ban[6] != 0)
            {
                Win(10, 350, 410, 350);
            }

            /*Первая линия вертикальная*/
            if (ban[0] == ban[3] && ban[3] == ban[6] && ban[0] != 0)
            {
                Win(70, 10, 70, 410);
            }

            /*Вторая линия вертикальная*/
            if (ban[1] == ban[4] && ban[4] == ban[7] && ban[1] != 0)
            {
                Win(210, 10, 210, 410);
            }

            /*Третья линия вертикальная*/
            if (ban[2] == ban[5] && ban[5] == ban[8] && ban[2] != 0)
            {
                Win(350, 10, 350, 410);
            }

            /* / линия верх-левое до низ-право*/
            if (ban[0] == ban[4] && ban[4] == ban[8] && ban[0] != 0)
            {
                Win(10, 10, 410, 410);
            }

            /* / линия верх-право до низ-лево*/
            if (ban[2] == ban[4] && ban[4] == ban[6] && ban[2] != 0)
            {
                Win(410, 10, 10, 410);
            }

        }

        private void stg_Click(object sender, EventArgs e)
        {
            
            Graphics field = container.CreateGraphics();
            field.Clear(Color.White);
            Reb();
            Pen blackPen = new Pen(Color.FromArgb(255, 128, 94, 73), 5); 
            field.DrawLine(blackPen, 140, 0, 140, 420);
            field.DrawLine(blackPen, 280, 0, 280, 420);
            field.DrawLine(blackPen, 0, 140, 420, 140);
            field.DrawLine(blackPen, 0, 280, 420, 280);
            SoundPlayer sound = new SoundPlayer("nachalo.wav");
            sound.Play();

        }

        private void XO_Load(object sender, EventArgs e)
        {
            
        }
    }
}