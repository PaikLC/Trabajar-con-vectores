#if true
#define MOSTRAR
#else
#undef MOSTRAR
#endif

using System.Drawing.Drawing2D;

namespace Dibujar_cosas
{
    public partial class Form1 : Form
    {
        private bool Sumar = false;

        private Point cursorPos;

        /// <summary>
        /// Se supone que es 0,0 (el origen)
        /// </summary>
        /// <returns>El centro del plano</returns>
        private Point CentroPlano(Rectangle rect)
        {
            return new Point((int)((rect.Width / 2) - numX.Value), (int)((rect.Height / 2) + numY.Value));
        }

        /// <summary>
        /// Obtiene el origen del rectangulo pero en tercera dimension
        /// </summary>
        /// <param name="rect">El rectangulo a obtener su centro</param>
        /// <returns>El centro en un Point3</returns>
        private Point3 CentroPlano2(Rectangle rect)
        {
            float x = MathF.Sqrt((rect.Right ^ 2) + (rect.Bottom ^ 2));
            return new Point3(x / 2, (float)((rect.Width / 2) - numX.Value), (float)((rect.Height / 2) + numY.Value));
        }

        /// <summary>
        ///El punto en donde se quedo el vector A
        /// </summary>
        private Point FinalVectA { get; set; }
        /// <summary>
        ///El punto en donde se quedo el vector B
        /// </summary>
        private Point FinalVectB { get; set; }
        /// <summary>
        ///El punto en donde se quedo el vector C
        /// </summary>
        private Point FinalVectC { get; set; }
        /// <summary>
        ///El punto en donde se quedo el vector D
        /// </summary>
        private Point FinalVectD { get; set; }
        /// <summary>
        ///El punto en donde se quedo el vector R y tambien es se utiliza
        ///como intermediario al momento de mover los vectores
        /// </summary>
        private Point FinalVectR { get; set; }

        public Form1()
        {
            InitializeComponent();
            numX.Maximum = decimal.MaxValue;
            numX.Minimum = decimal.MinValue;
            numY.Maximum = decimal.MaxValue;
            numY.Minimum = decimal.MinValue;

        }

        /// <summary>
        /// Ajustamos el plano a la ventana
        /// </summary>
        /// <returns> Un rectangulo en donde estaran los vectores</returns>
        private Rectangle Plano()
        {
            Rectangle r = new Rectangle(0, 0, Width - (191 + 20 - 1), Height - 48);
            return r;
        }

        /// <summary>
        /// Retira el desface que tiene el centro
        /// </summary>
        /// <param name="p">El punto que se quiere conocer sus coordenadas</param>
        /// <returns>El punto basando sus coordenadas con un centro en 0,0</returns>
        private Point CentroVerdadero(Point p)
        {
            Point cordVerd = new Point();
            Point centro = CentroPlano(Plano());
            cordVerd.X = p.X - centro.X;
            cordVerd.Y = p.Y - centro.Y;
            return cordVerd;
        }

        private void DibujarPlanoCartesiano()
        {
            Graphics g = Graphics.FromHwndInternal(this.Handle);
            Pen pluma = new Pen(Brushes.Black, 1);
            Rectangle rect = Plano();

            g.DrawRectangle(pluma, rect);
            // El eje Y o Z cuando es R3
            g.DrawLine(pluma, (float)((rect.Width / 2) - numX.Value), rect.Top, (float)((rect.Width / 2) - numX.Value), rect.Bottom);
            // El eje X o Y cuando es R3
            g.DrawLine(pluma, rect.Left, (float)((rect.Bottom / 2) + numY.Value), rect.Right, (float)((rect.Bottom / 2) + numY.Value));

            //El eje X cuando es R3
            if (radbtnVolumen.Checked)
            {
                g.DrawLine(pluma, (float)(rect.Width - numX.Value + numY.Value), (float)(rect.Top), (float)(rect.Left), (float)(rect.Bottom + numY.Value - numX.Value));
            }

            g.Dispose();
            pluma.Dispose();
        }

        /// <summary>
        /// Dibuja el vector A
        /// </summary>
        private void VectorA()
        {
            Graphics g = Graphics.FromHwndInternal(this.Handle);
            Pen pluma = new Pen(Brushes.Red, 2);

            Rectangle rect = Plano();
            if (radbtnVolumen.Checked != true)
            {
                // El centro del plano
                Point centro = CentroPlano(rect);
                // En donde es a que va a llegar el vector
                Point punto = new Point();

                if (rdbtnVecOrden1.Checked)
                {
                    punto.X = centro.X;
                    punto.Y = centro.Y - Convert.ToInt32(30 * Convert.ToDouble(msktxtVectAMult.Text));
                }
                else if (rdbtnVecOrden2.Checked)
                {
                    punto.X = centro.X + Convert.ToInt32(30 * Convert.ToDouble(msktxtVectAMult.Text));
                    punto.Y = centro.Y - Convert.ToInt32(30 * Convert.ToDouble(msktxtVectAMult.Text));
                }
                g.DrawLine(pluma, centro, punto);
                FinalVectA = punto;
#if MOSTRAR
                Flecha(punto, pluma, 'A');
#endif
            }
            else
            {
                Point3 centro = CentroPlano2(rect);
                Point3 punto = ObtenerValor(msktxtVectAMult);

                ClsDimTres Dim3 = new();
                Dim3.DibujarVector(pluma, g, punto, centro);
            }

            g.Dispose();
            pluma.Dispose();
        }

        /// <summary>
        /// Dubuja el vertor B
        /// </summary>
        private void VectorB()
        {
            Graphics g = Graphics.FromHwndInternal(this.Handle);
            Pen pluma = new Pen(Brushes.Green, 2);

            Rectangle rect = Plano();
            // El centro del plano

            if (radbtnVolumen.Checked != true)
            {
                Point centro = CentroPlano(rect);
                // En donde es a que va a llegar el vector
                Point punto = new Point();
                if (rdbtnVecOrden1.Checked)
                {
                    punto.X = centro.X - Convert.ToInt32(30 * Convert.ToDouble(msktxtVectBMult.Text));
                    punto.Y = centro.Y;
                }
                else if (rdbtnVecOrden2.Checked)
                {
                    punto.X = centro.X;
                    punto.Y = centro.Y - Convert.ToInt32(30 * Convert.ToDouble(msktxtVectBMult.Text));
                }
                g.DrawLine(pluma, centro, punto);
                FinalVectB = punto;
#if MOSTRAR
                Flecha(punto, pluma, 'B');
#endif      
            }
            else
            {
                Point3 centro = CentroPlano2(rect);
                Point3 punto = ObtenerValor(msktxtVectBMult);

                ClsDimTres Dim3 = new();
                Dim3.DibujarVector(pluma, g, punto, centro);
            }
            g.Dispose();
            pluma.Dispose();
        }

        /// <summary>
        /// Dubuja el vertor B desde un centro personalizado
        /// </summary>
        private void VectorB(Point centro)
        {
            Graphics g = Graphics.FromHwndInternal(this.Handle);
            Pen pluma = new Pen(Brushes.Green, 2);

            Rectangle rect = Plano();
            // En donde es a que va a llegar el vector
            Point punto = new Point();

            if (rdbtnVecOrden1.Checked)
            {
                punto.X = centro.X - Convert.ToInt32(30 * Convert.ToDouble(msktxtVectBMult.Text));
                punto.Y = centro.Y;
            }
            else if (rdbtnVecOrden2.Checked)
            {
                punto.X = centro.X;
                punto.Y = centro.Y - Convert.ToInt32(30 * Convert.ToDouble(msktxtVectBMult.Text));
            }
            else if (radbtnVolumen.Checked)
            {
                return;
            }
            g.DrawLine(pluma, centro, punto);
            FinalVectR = punto;
#if MOSTRAR
            Flecha(punto, pluma, 'B');
#endif
            g.Dispose();
            pluma.Dispose();
        }

        /// <summary>
        /// Dibuja el vector C
        /// </summary>
        private void VectorC()
        {
            Graphics g = Graphics.FromHwndInternal(this.Handle);
            Pen pluma = new Pen(Brushes.DarkViolet, 2);

            Rectangle rect = Plano();
            if (radbtnVolumen.Checked != true)
            {
                // El centro del plano
                Point centro = CentroPlano(rect);
                // En donde es a que va a llegar el vector
                Point punto = new Point();

                if (rdbtnVecOrden1.Checked)
                {
                    punto.X = centro.X;
                    punto.Y = centro.Y + Convert.ToInt32(30 * Convert.ToDouble(msktxtVectCMult.Text));
                }
                else if (rdbtnVecOrden2.Checked)
                {
                    punto.X = centro.X - Convert.ToInt32(30 * Convert.ToDouble(msktxtVectCMult.Text));
                    punto.Y = centro.Y - Convert.ToInt32(30 * Convert.ToDouble(msktxtVectCMult.Text));
                }
                g.DrawLine(pluma, centro, punto);
                FinalVectC = punto;
#if MOSTRAR
                Flecha(punto, pluma, 'C');
#endif
            }
            else
            {
                Point3 centro = CentroPlano2(rect);
                Point3 punto = ObtenerValor(msktxtVectCMult);

                ClsDimTres Dim3 = new();
                Dim3.DibujarVector(pluma, g, punto, centro);
            }
            g.Dispose();
            pluma.Dispose();
        }

        /// <summary>
        /// Dibuja el vector C con un centro personalizado
        /// </summary>
        private void VectorC(Point centro)
        {
            Graphics g = Graphics.FromHwndInternal(this.Handle);
            Pen pluma = new Pen(Brushes.DarkViolet, 2);

            Rectangle rect = Plano();
            // En donde es a que va a llegar el vector
            Point punto = new Point();

            if (rdbtnVecOrden1.Checked)
            {
                punto.X = centro.X;
                punto.Y = centro.Y + Convert.ToInt32(30 * Convert.ToDouble(msktxtVectCMult.Text));
            }
            else if (rdbtnVecOrden2.Checked)
            {
                punto.X = centro.X - Convert.ToInt32(30 * Convert.ToDouble(msktxtVectCMult.Text));
                punto.Y = centro.Y - Convert.ToInt32(30 * Convert.ToDouble(msktxtVectCMult.Text));
            }
            else if (radbtnVolumen.Checked)
            {
                return;
            }
            g.DrawLine(pluma, centro, punto);
            FinalVectR = punto;
#if MOSTRAR
            Flecha(punto, pluma, 'C');
#endif
            g.Dispose();
            pluma.Dispose();
        }

        /// <summary>
        /// Dibuja el vectorD
        /// </summary>
        private void VectorD()
        {
            Graphics g = Graphics.FromHwndInternal(this.Handle);
            Pen pluma = new Pen(Brushes.Gold, 2);

            Rectangle rect = Plano();
            if (radbtnVolumen.Checked != true)
            {
                // El centro del plano
                Point centro = CentroPlano(rect);
                // En donde es a que va a llegar el vector
                Point punto = new Point();

                if (rdbtnVecOrden1.Checked)
                {
                    punto.X = centro.X + Convert.ToInt32(30 * Convert.ToDouble(msktxtVectDMult.Text));
                    punto.Y = centro.Y;
                }
                else if (rdbtnVecOrden2.Checked)
                {
                    punto.X = centro.X;
                    punto.Y = centro.Y + Convert.ToInt32(30 * Convert.ToDouble(msktxtVectDMult.Text));
                }
                g.DrawLine(pluma, centro, punto);
                FinalVectD = punto;
#if MOSTRAR
                Flecha(punto, pluma, 'D');
#endif
            }
            else
            {
                return;
                Point3 centro = CentroPlano2(rect);
                Point3 punto = ObtenerValor(msktxtVectDMult);

                ClsDimTres Dim3 = new();
                Dim3.DibujarVector(pluma, g, punto, centro);
            }
            g.Dispose();
            pluma.Dispose();
        }

        /// <summary>
        /// Dibuja el vector D con un centro personalizado
        /// </summary>
        private void VectorD(Point centro)
        {
            Graphics g = Graphics.FromHwndInternal(this.Handle);
            Pen pluma = new Pen(Brushes.Gold, 2);

            Rectangle rect = Plano();
            // En donde es a que va a llegar el vector
            Point punto = new Point();

            if (rdbtnVecOrden1.Checked)
            {
                punto.X = centro.X + Convert.ToInt32(30 * Convert.ToDouble(msktxtVectDMult.Text));
                punto.Y = centro.Y;
            }
            else if (rdbtnVecOrden2.Checked)
            {
                punto.X = centro.X;
                punto.Y = centro.Y + Convert.ToInt32(30 * Convert.ToDouble(msktxtVectDMult.Text));
            }
            else if (radbtnVolumen.Checked)
            {
                return;
            }
            g.DrawLine(pluma, centro, punto);
            FinalVectR = punto;
#if MOSTRAR
            Flecha(punto, pluma, 'D');
#endif
            g.Dispose();
            pluma.Dispose();
        }

        /// <summary>
        /// Dibuja el vector resultante
        /// </summary>
        private void VectorR()
        {
            Graphics g = Graphics.FromHwndInternal(this.Handle);
            Pen pluma = new Pen(Brushes.Brown, 2);

            Point centro = FinalVectR;
            Point punto = CentroPlano(Plano());

            pluma.EndCap = LineCap.ArrowAnchor;

            if (centro == punto)
            {
                return;
            }
            FinalVectR = centro;
            g.DrawLine(pluma, centro, punto);
            //Flecha(punto, pluma, 'R');
        }

        /// <summary>
        /// Dibuja la flecha y la letra del respectivo vector
        /// </summary>
        /// <param name="centro">El punto central de la flecha</param>
        /// <param name="pluma">El estilo con el que se dibuja el vector</param>
        /// <param name="vector">La letra del vector</param>
        private void Flecha(Point centro, Pen pluma, char vector) //15° de apertura... 7.5 cada lado
        {
            Graphics g = Graphics.FromHwndInternal(this.Handle);
            PointF punto = new Point();
            Font fuente = new Font("Lucida Console", 10.5f, FontStyle.Regular, GraphicsUnit.Pixel);
            if (vector == 'A')
            {
                if (rdbtnVecOrden1.Checked)
                {
                    if ((FinalVectA.Y < CentroPlano(Plano()).Y))
                    {
                        // La primer parte de la flecha
                        punto.Y = centro.Y + 20 - 2.633f;
                        punto.X = centro.X - (2 * 2.633f);
                        g.DrawLine(pluma, centro, punto);
                        // La segunda parte
                        punto.X = centro.X + 2 * 2.633f;
                    }
                    else
                    {
                        // La primer parte de la flecha
                        punto.Y = centro.Y - 20 - 2.633f;
                        punto.X = centro.X + 2 * 2.633f;
                        g.DrawLine(pluma, centro, punto);
                        // La segunda parte
                        punto.X = centro.X - 2 * 2.633f;
                    }
                }
                else if (rdbtnVecOrden2.Checked)
                {
                    if ((FinalVectA.X > CentroPlano(Plano()).X) && (FinalVectA.Y < CentroPlano(Plano()).Y))
                    {
                        // La primer parte de la flecha
                        punto.Y = centro.Y + 20 - 2.633f;
                        punto.X = centro.X - 2 * 2.633f;
                        g.DrawLine(pluma, centro, punto);
                        // La segunda parte
                        punto.X = centro.X - (8 * 2.633f);
                        punto.Y = centro.Y - 2.633f + 11;
                    }
                    else
                    {
                        // La primer parte de la flecha
                        punto.Y = centro.Y - 20 - 2.633f;
                        punto.X = centro.X + 2 * 2.633f;
                        g.DrawLine(pluma, centro, punto);
                        // La segunda parte
                        punto.X = centro.X + (8 * 2.633f);
                        punto.Y = centro.Y + 2.633f - 11;
                    }
                }
            }
            else if (vector == 'B')
            {
                if (rdbtnVecOrden1.Checked)
                {
                    if (FinalVectB.X < CentroPlano(Plano()).X)
                    {
                        // La primer parte de la flecha
                        punto.Y = centro.Y + 2 * 2.633f;
                        punto.X = centro.X + 20 - 2.633f;
                        g.DrawLine(pluma, centro, punto);
                        // La segunda parte
                        punto.Y = centro.Y - 2 * 2.633f;
                    }
                    else
                    {
                        // La primer parte de la flecha
                        punto.X = centro.X - 20 - 2.633f;
                        punto.Y = centro.Y + 2 * 2.633f;
                        g.DrawLine(pluma, centro, punto);
                        // La segunda parte
                        punto.Y = centro.Y - 2 * 2.633f;
                    }
                }
                else if (rdbtnVecOrden2.Checked)
                {
                    if (FinalVectB.Y < CentroPlano(Plano()).Y)
                    {
                        // La primer parte de la flecha
                        punto.Y = centro.Y + 20 - 2.633f;
                        punto.X = centro.X - (2 * 2.633f);
                        g.DrawLine(pluma, centro, punto);
                        // La segunda parte
                        punto.X = centro.X + 2 * 2.633f;
                    }
                    else
                    {
                        // La primer parte de la flecha
                        punto.Y = centro.Y - 20 - 2.633f;
                        punto.X = centro.X + 2 * 2.633f;
                        g.DrawLine(pluma, centro, punto);
                        // La segunda parte
                        punto.X = centro.X - 2 * 2.633f;
                    }
                    
                }
            }
            else if (vector == 'C')
            {
                if (rdbtnVecOrden1.Checked)
                {
                    if (FinalVectC.Y > CentroPlano(Plano()).Y)
                    {
                        // La primer parte de la flecha
                        punto.Y = centro.Y - 20 - 2.633f;
                        punto.X = centro.X + 2 * 2.633f;
                        g.DrawLine(pluma, centro, punto);
                        // La segunda parte
                        punto.X = centro.X - 2 * 2.633f;
                    }
                    else
                    {
                        // La primer parte de la flecha
                        punto.Y = centro.Y + 20 - 2.633f;
                        punto.X = centro.X - (2 * 2.633f);
                        g.DrawLine(pluma, centro, punto);
                        // La segunda parte
                        punto.X = centro.X + 2 * 2.633f;
                    }
                }
                else if (rdbtnVecOrden2.Checked)
                {
                    if (FinalVectC.X < CentroPlano(Plano()).X)
                    {
                        // La primer parte de la flecha
                        punto.Y = centro.Y + 20 - 2.633f;
                        punto.X = centro.X + 2 * 2.633f;
                        g.DrawLine(pluma, centro, punto);
                        // La segunda parte
                        punto.X = centro.X + (8 * 2.633f);
                        punto.Y = centro.Y - 2.633f + 11;
                    }
                    else
                    {
                        // La primer parte de la flecha
                        punto.Y = centro.Y - 20 - 2.633f;
                        punto.X = centro.X - 2 * 2.633f;
                        g.DrawLine(pluma, centro, punto);
                        // La segunda parte
                        punto.X = centro.X - (8 * 2.633f);
                        punto.Y = centro.Y + 2.633f - 11;
                    }
                }
            }
            else if (vector == 'D')
            {
                if (rdbtnVecOrden1.Checked)
                {
                    if (FinalVectD.X > CentroPlano(Plano()).X)
                    {
                        // La primer parte de la flecha
                        punto.X = centro.X - 20 - 2.633f;
                        punto.Y = centro.Y + 2 * 2.633f;
                        g.DrawLine(pluma, centro, punto);
                        // La segunda parte
                        punto.Y = centro.Y - 2 * 2.633f;
                    }
                    else
                    {
                        // La primer parte de la flecha
                        punto.Y = centro.Y + 2 * 2.633f;
                        punto.X = centro.X + 20 - 2.633f;
                        g.DrawLine(pluma, centro, punto);
                        // La segunda parte
                        punto.Y = centro.Y - 2 * 2.633f;
                    }
                }
                else if (rdbtnVecOrden2.Checked)
                {
                    if (FinalVectD.Y > CentroPlano(Plano()).Y)
                    {
                        // La primer parte de la flecha
                        punto.Y = centro.Y - 20 - 2.633f;
                        punto.X = centro.X + 2 * 2.633f;
                        g.DrawLine(pluma, centro, punto);
                        // La segunda parte
                        punto.X = centro.X - 2 * 2.633f;
                    }
                    else
                    {
                        // La primer parte de la flecha
                        punto.Y = centro.Y + 20 - 2.633f;
                        punto.X = centro.X - (2 * 2.633f);
                        g.DrawLine(pluma, centro, punto);
                        // La segunda parte
                        punto.X = centro.X + 2 * 2.633f;
                    }
                }
            }
            else if(vector == 'R')
            {
                if (FinalVectR.X >= CentroPlano(Plano()).X) // X positiva
                {
                    if (FinalVectR.Y <= CentroPlano(Plano()).Y) // Y positiva
                    {
                        punto.Y = centro.Y + (2.61f);
                        punto.X = centro.X + (19.83f);
                        g.DrawLine(pluma, centro, punto);
                        punto.Y = centro.Y + (2.61f);
                        punto.X = centro.X + (19.83f);
                    }
                    else // Y negativa
                    {
                        punto.Y = centro.Y + (2.61f);
                        punto.X = centro.X + (19.83f);
                        g.DrawLine(pluma, centro, punto);
                        punto.Y = centro.Y + (2.61f);
                        punto.X = centro.X + (19.83f);
                    }
                }
                else // X negativa
                {
                    if (FinalVectR.Y <= CentroPlano(Plano()).Y) // Y positiva
                    {
                        punto.Y = centro.Y - (2.61f);
                        punto.X = centro.X - (19.83f);
                        g.DrawLine(pluma, centro, punto);
                        punto.Y = centro.Y + (2.61f);
                        punto.X = centro.X + (19.83f);
                    }
                    else // Y negativa
                    {
                        punto.Y = centro.Y + (19.83f);
                        punto.X = centro.X - (2.61f);
                        g.DrawLine(pluma, centro, punto);
                        punto.Y = centro.Y + (19.32f);
                        punto.X = centro.X + (5.18f);
                    }
                }
            }
            g.DrawLine(pluma, centro, punto);
            g.DrawString(vector.ToString(), fuente, pluma.Brush, centro);
            
            g.Dispose();
        }

        private void SumarVectores()
        {
            VectorB(FinalVectA);
            VectorC(FinalVectR);
            VectorD(FinalVectR);
            VectorR();
        }

        private void RefrescarPlano()
        {
            Invalidate(Plano());
        }

        Point3 ObtenerValor(object sender)
        {
            string[] num;
            float[] coord = new float[3];

            if (sender == msktxtVectAMult)
            {
                num = msktxtVectAMult.Text.Split('\u002C');
            }
            else if (sender == msktxtVectBMult)
            {
                num = msktxtVectBMult.Text.Split('\u002C');
            }
            else if (sender == msktxtVectCMult)
            {
                num = msktxtVectCMult.Text.Split('\u002C');
            }
            else
            {
                num = msktxtVectDMult.Text.Split('\u002C');
            }
            //Proceso de corroboracion
            if (num.Length != 3)
            {
                return Point3.Empty;
            }
            try
            {
                for (int i = 0; i < 3; i++)
                {
                    coord[i] = Convert.ToSingle(num[i]);
                }
                return new Point3(coord[0] * 20, coord[1] * 20, coord[2] * -20);
            }
            catch
            {
                return Point3.Empty;
            }
        }

        private Point RealizarResultante()
        {
            Point resultante = new();

            if (rdbtnVecOrden1.Checked)
            {
                resultante.X = (Convert.ToInt32(msktxtVectBMult.Text) * -30) + (Convert.ToInt32(msktxtVectDMult.Text) * 30);
                resultante.Y = (Convert.ToInt32(msktxtVectAMult.Text) * 30) + (Convert.ToInt32(msktxtVectCMult.Text) * 30);
            }
            else if (rdbtnVecOrden2.Checked)
            {
                resultante.X = (Convert.ToInt32(msktxtVectAMult.Text) * 30) + (Convert.ToInt32(msktxtVectCMult.Text) * -30);
                resultante.Y = (Convert.ToInt32(msktxtVectAMult.Text) * 30) + (Convert.ToInt32(msktxtVectBMult.Text) * 30) + (Convert.ToInt32(msktxtVectCMult.Text) * 30) + (Convert.ToInt32(msktxtVectDMult.Text) * -30);
            }
            else
            {
                resultante = Point.Empty;
            }
            return resultante;
        }

        private void ObtenerResultante()
        {
            //Remplazar esas letras minusculas por la cantidad despecificada
            lblResultante.Text = lblResultante.Text.Replace("a", msktxtVectAMult.Text);
            lblResultante.Text = lblResultante.Text.Replace("b", msktxtVectBMult.Text);
            lblResultante.Text = lblResultante.Text.Replace("c", msktxtVectCMult.Text);
            lblResultante.Text = lblResultante.Text.Replace("d", msktxtVectDMult.Text);
            // Realizamos las operacipones
            lblResultado.Text = "r = " + RealizarResultante();
        }

        private void btnDibujar_Click(object sender, EventArgs e)
        {
            RefrescarPlano();
            Sumar = true;
            Form1_Load(sender, e);
            ObtenerResultante();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            // El cuadro y las lineas
            DibujarPlanoCartesiano();
            //Los vectores
            VectorA();
            VectorB();
            VectorC();
            VectorD();
            //La suma de los vectores
            if (Sumar)
            {
                SumarVectores();
            }
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            RefrescarPlano();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Sumar = false;
            RefrescarPlano();
            Form1_Load(sender, e);
        }

        private void rdbtnVecOrden1_CheckedChanged(object sender, EventArgs e)
        {
            lblResultante.Text = "r = a(0,30) + b(-30,0) + c(0,-30) +d(30,0)";
        }

        private void rdbtnVecOrden2_CheckedChanged(object sender, EventArgs e)
        {
            lblResultante.Text = "r = a(30,30) + b(0,30) + c(-30,30) +d(0,-30)";
            RefrescarPlano();
        }

        private void EnbtnMoverPlano(object sender, EventArgs e)
        {
            if (sender == btnArriba)
            {
                numY.Value -= numY.Increment;
            }
            else if (sender == btnAbajo)
            {
                numY.Value += numY.Increment;
            }
            else if (sender == btnIzquierda)
            {
                numX.Value += numX.Increment;
            }
            else if (sender == btnDerecha)
            {
                numX.Value -= numX.Increment;
            }
            else
            {
                numX.Value = 0;
                numY.Value = 0;
            }
            RefrescarPlano();
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Cursor = Cursors.Hand;
                cursorPos = e.Location;
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (Cursor == Cursors.Hand)
            {
                if (e.Location != cursorPos)
                {
                    numX.Value += (cursorPos.X - e.Location.X) * 0.5M;
                    numY.Value += (cursorPos.Y - e.Location.Y) * -0.5M;
                    cursorPos = e.Location;
                    RefrescarPlano();
                }
            }
        }

        private void radbtnVolumen_CheckedChanged(object sender, EventArgs e)
        {
            msktxtVectDMult.Enabled = !radbtnVolumen.Checked;
            msktxtVectAMult.Text = "1,1,1";
            msktxtVectBMult.Text = "1,1,1";
            msktxtVectCMult.Text = "1,1,1";
            msktxtVectDMult.Text = "0,0,0";
            RefrescarPlano();
            lblResultante.Text = "";
            lblResultante.Text = "";
        }

        /// <summary>
        /// Principalmente para corroborar los valores
        /// </summary>
        private void EnTexto3raDim(object sender, EventArgs e)
        {
            if (radbtnVolumen.Checked)
            {
                if (ObtenerValor(sender) == Point3.Empty)
                {
                    btnDibujar.Enabled = false;
                }
                else
                {
                    btnDibujar.Enabled = true;
                }
            }
            else
            {
                return;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblResultante.Text = "r = a(0,30) + b(-30,0) + c(0,-30) +d(30,0)";
            lblResultado.Text = "";
        }
    }
}