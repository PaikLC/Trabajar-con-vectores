using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dibujar_cosas
{

    /// <summary>
    /// Lo mismo que Point solo que con 3 dimensiones
    /// </summary>
    public struct Point3 : IEquatable<Point3>
    {
        public static readonly Point3 Empty;

        private float x;
        private float y;
        private float z;

        /// <summary>
        /// Inicializa un punto con coordenadas especificas
        /// </summary>
        /// <param name="x">Coordenada X</param>
        /// <param name="y">Coordenada Y</param>
        /// <param name="z">Coordenada Z</param>
        public Point3(float x, float y, float z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        /// <summary>
        /// Indica si esta vacio
        /// </summary>
        [Browsable(false)]
        public readonly bool IsEmpty => x == 0 && y == 0 && z == 0;

        /// <summary>
        /// Obtiene la coordenada X
        /// </summary>
        public float X
        {
            readonly get => x;
            set => x = value;
        }

        /// <summary>
        /// Obtiene la coordenada Y
        /// </summary>
        public float Y
        {
            readonly get => y;
            set => y = value;
        }

        /// <summary>
        /// Obtiene la coordenada Z
        /// </summary>
        public float Z
        {
            readonly get => z;
            set => z = value;
        }

        /// <summary>
        /// Compara si dos Point3 son iguales
        /// </summary>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <returns></returns>
        public static bool operator ==(Point3 left, Point3 right) => left.X == right.X && left.Y == right.Y && left.Z == right.Z;

        /// <summary>
        /// Compara si los dos Point3 son diferentes
        /// </summary>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <returns></returns>
        public static bool operator !=(Point3 left, Point3 right) => !(left == right);

        /// <summary>
        /// Especifica si el objeto enviado es un Point3
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override readonly bool Equals([NotNullWhen(true)] object? obj) => obj is Point3 && Equals((Point3)obj);

        /// <summary>
        /// Compara si es que el Point3 actual es igual a otro
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public readonly bool Equals(Point3 other) => this == other;

        /// <summary>
        /// Obtiene el hash (Lo coloque por si acaso)
        /// </summary>
        /// <returns>El hash code</returns>
        public override readonly int GetHashCode() => HashCode.Combine(X, Y, Z);
    }

    internal class ClsDimTres
    {
        /// <summary>
        /// Dibuja el vector en tercera dimencion
        /// </summary>
        /// <param name="pluma">El estilo con el que se dibujara</param>
        /// <param name="g">Los graficos utilizados</param>
        /// <param name="punto">El final del vector</param>
        /// <param name="centro">El inicio del vector</param>
        public void DibujarVector(Pen pluma, Graphics g ,Point3 punto, Point3 centro)
        {
            // Estilo para dar la idea del 3D
            Pen punteado = pluma;
            punteado.DashStyle = DashStyle.DashDot;
            
            //Agregamos el desface
            punto = CentroFalso(punto, centro);
            // Obtenemos Z y Y del punto
            PointF punto2 = new PointF(punto.Y, punto.Z);
            // Obtenemos Z y Y del centro
            PointF centro2 = new PointF(centro.Y, centro.Z);

            //Mostramos las lineas para darse una idea de la profundidad
            g.DrawLine(punteado, centro2, punto2);

            // Modificamos lo suficiente para mostrar en X y Y
            punto2.X += punto.X - centro.X + punto.Y;

            g.DrawLine(punteado, centro2, punto2);
        }

        /// <summary>
        /// Agrega el desface que tiene el centro
        /// </summary>
        /// <param name="cordVerd">El punto que se quiere conocer sus coordenadas falsas</param>
        /// <param name="centro">El desface</param>
        /// <returns>El punto basando sus coordenadas con un centro con desface</returns>
        private Point3 CentroFalso(Point3 cordVerd, Point3 centro)
        {
            Point3 p = new Point3();

            p.X = cordVerd.X + centro.X;
            p.Y = cordVerd.Y + centro.Y;
            p.Z = cordVerd.Z + centro.Z;

            return p;
        }
    }
}
