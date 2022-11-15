using System.Collections;

namespace JuegoDeMemoria
{
    public partial class Form1 : Form
    {
        int TamanioColumnasFilas = 4; //cuantas columnas y filas de cartas tendra 
        int Movimientos = 0; //Movimientos jugados
        int CantidadCartasVoleadas=0;
        List<string> CartasEnumeradas; //todas las cartas generadas
        List<string> CartasRevueltas;
        ArrayList CartasSeleccionadas; //almacena las cartas seleccionadas por el usario
        PictureBox CartaTemporal1; //carta 1 volteada
        PictureBox CartaTemporal2; //carta 2 volteada
        int CartaActual; // carta actual 
        public Form1()
        {
            InitializeComponent();
            iniciarJuego();
        }

        public void iniciarJuego()
        {  
            timer1.Enabled= false;
            timer1.Stop();
            label2Num.Text = "0";
            CantidadCartasVoleadas = 0;
            Movimientos = 0;
            CartasEnumeradas = new List<string>();  
            CartasRevueltas = new List<string>();
            CartasSeleccionadas = new ArrayList();
            CartaTemporal1 = new PictureBox();
            CartaTemporal2 = new PictureBox();

            for (int i = 0; i < 8; i++)
            {
                CartasEnumeradas.Add(i.ToString());
                CartasEnumeradas.Add(i.ToString());
            }
            var numeroAleatorio = new Random();
            var Resultado = CartasEnumeradas.OrderBy(i => numeroAleatorio.Next());

            foreach(string ValorCarta in Resultado)
            {
                CartasRevueltas.Add(ValorCarta);
            }

            var tablapanel = new TableLayoutPanel();
            tablapanel.RowCount = TamanioColumnasFilas;
            tablapanel.ColumnCount = TamanioColumnasFilas;

            for(int i = 0; i < TamanioColumnasFilas; i++)
            {
                var porcentaje = 150f / (float)TamanioColumnasFilas-10;
                tablapanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, porcentaje));
                tablapanel.RowStyles.Add(new RowStyle(SizeType.Percent, porcentaje));
            }

            int contadorFichas = 1;
            for(var i = 0; i < TamanioColumnasFilas; i++)
            {
                for(var j= 0; j < TamanioColumnasFilas; j++)
                {
                    var cartasJuego = new PictureBox();
                    cartasJuego.Name = String.Format("{0}", contadorFichas);
                    cartasJuego.Dock = DockStyle.Fill;
                    cartasJuego.SizeMode = PictureBoxSizeMode.StretchImage;
                    cartasJuego.Image = Properties.Resources.logo;
                    cartasJuego.Cursor = Cursors.Hand;
                    cartasJuego.Click += btnCarta_Click;
                    tablapanel.Controls.Add(cartasJuego, j, i);
                    contadorFichas++;
                }
            }
            tablapanel.Dock = DockStyle.Fill;
            panelJuego.Controls.Add(tablapanel);
            
        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            iniciarJuego();
        }

        private void btnCarta_Click(object sender, EventArgs e)
        {
            Movimientos++;
            label2Num.Text = Convert.ToString(Movimientos);
            var cartaSeleccionadaUsuario = (PictureBox)sender;

            CartaActual = Convert.ToInt32(CartasRevueltas[Convert.ToInt32(cartaSeleccionadaUsuario.Name) - 1]);
            cartaSeleccionadaUsuario.Image = RecuperarImagen(CartaActual);
            CartasSeleccionadas.Add(cartaSeleccionadaUsuario);
            
            //si realizó dos veces el evento

            if(CartasSeleccionadas.Count == 2)
            {
                CartaTemporal1= (PictureBox)CartasSeleccionadas[0];
                CartaTemporal2 = (PictureBox)CartasSeleccionadas[1];
                int car1 = Convert.ToInt32(CartasRevueltas[Convert.ToInt32(CartaTemporal1.Name) - 1]);
                int car2 = Convert.ToInt32(CartasRevueltas[Convert.ToInt32(CartaTemporal2.Name) - 1]);

                if(car1 != car2)
                {
                    timer1.Enabled = true;
                    timer1.Start();
                }
                else
                {
                    CantidadCartasVoleadas++;
                    if(CantidadCartasVoleadas > 7)
                    {
                        MessageBox.Show("El juego terminó");
                    }
                    CartaTemporal1.Enabled = false; CartaTemporal2.Enabled=false;
                    CartasSeleccionadas.Clear();
                }
            }

        }

        public Bitmap RecuperarImagen(int NumeroImagen)
        {
            Bitmap bitmap = new Bitmap(200,100);
            switch (NumeroImagen)
            {
                case 0: bitmap = Properties.Resources._10;
                    break;
                default: bitmap = (Bitmap)Properties.Resources.ResourceManager.GetObject(NumeroImagen.ToString());
                    break;
            }
            return bitmap;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int tiempo = 1;
            if(tiempo == 1)
            {
                CartaTemporal1.Image= Properties.Resources.logo;
                CartaTemporal2.Image = Properties.Resources.logo;
                CartasSeleccionadas.Clear();
                tiempo= 0;
                timer1.Stop();
            }
        }
    }
}