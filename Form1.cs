using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conway_s_Game_of_Life
{
    public partial class Conways_Game_of_Life : Form
    {
        private int longUniv = 35;
        private int Tpixel = 10;
        int[,] celulas;
    
        public Conways_Game_of_Life()
        {
            InitializeComponent();
            celulas = new int[longUniv,longUniv];
        }
        public void PintarPixel(Bitmap bmp,int x,int y,Color color)
        {
            for (int i = 0; i < Tpixel; i++ )
                for (int j = 0; j < Tpixel; j++)
                {
                    bmp.SetPixel(i + (x * Tpixel) , j + (y * Tpixel) , color);
                }
           
        }

        public void pintarCel()
        {
            Bitmap bmp = new Bitmap(Picture_Life.Width,Picture_Life.Height);

            for (int i = 0; i < longUniv; i++)
                for (int j = 0; j < longUniv; j++)
                {
                    if (celulas[i, j] == 0)
                        PintarPixel(bmp, i, j, Color.White);
                    else
                        PintarPixel(bmp,i,j,Color.Black);
                }
            Picture_Life.Image = bmp;
        }

        public void juego_vida()
        {
            int[,] celulaTemp = new int[longUniv,longUniv];
            for (int x = 0; x < longUniv; x++)
                for (int y = 0; y < longUniv; y++)
                {
                    if (celulas[x, y] == 0)
                       celulaTemp[x,y]= Reglas(x, y, false);
                    else
                       celulaTemp[x, y] = Reglas(x, y, true);
                }
            celulas = celulaTemp;
        }

        public int Reglas(int x,int y,bool Estado)
        {
            int VecinasVivas = 0;
            if (x > 0 && y > 0)
                if (celulas[x - 1, y - 1] == 1)
                    VecinasVivas++;
            if (y > 0)
                if (celulas[x, y - 1] == 1)
                    VecinasVivas++;
            if (x > longUniv-1 && y > 0)
                if (celulas[x + 1, y - 1] == 1)
                    VecinasVivas++;
            if (x > 0)
                if (celulas[x - 1, y] == 1)
                    VecinasVivas++;
            if (x < longUniv - 1)
                if (celulas[x + 1, y ] == 1)
                    VecinasVivas++;
            if (x > 0 && y < longUniv - 1)
                if (celulas[x - 1, y + 1] == 1)
                    VecinasVivas++;
            if (y < longUniv - 1)
                if (celulas[x, y + 1] == 1)
                    VecinasVivas++;
            if (x < longUniv - 1 && y < longUniv - 1)
                if (celulas[x + 1, y + 1] == 1)
                    VecinasVivas++;
            if (Estado)
                return (VecinasVivas == 2 || VecinasVivas == 3) ? 1 : 0;
            else
                return VecinasVivas == 3 ? 1 : 0;
        }
        private void RANDOM_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            for (int x = 0; x < longUniv; x++)
                for (int y = 0; y < longUniv; y++)
                    celulas[x, y] = r.Next(0, 2);
            pintarCel();
        }

        private void PauseB_Click(object sender, EventArgs e)
        {
            Tiempo.Enabled = false;
        }

        private void StartB_Click(object sender, EventArgs e)
        {
            Tiempo.Enabled = true; 
        }

        private void Tiempo_Tick(object sender, EventArgs e)
        {
            juego_vida();
            pintarCel();
        }
    }
}
