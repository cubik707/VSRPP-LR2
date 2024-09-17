using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LR2
{
    public partial class Form1 : Form
    {
        //для выбора цвета
        private Color currentColor = Color.Black;
        //хранение объектов
        private List<Rectangle> drawnObjects = new List<Rectangle>();
        //хранение удаленных объектов
        private Stack<List<Rectangle>> undoStack = new Stack<List<Rectangle>>();


        public Form1()
        {
            InitializeComponent();
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void delete_Click(object sender, EventArgs e)
        {

        }

        private void Redo_Click(object sender, EventArgs e)
        {

        }
    }
}

public class Shape
{
    private int x;
    private int y;
    private Color color;

    public Shape(int x, int y, Color color)
    {
        this.x = x;
        this.y = y;
        this.color = color;
    }

    public void Draw(Graphics g)
    {
        using (Brush brush = new SolidBrush(color))
        {
            // Рисуем число 17 с центром в (x, y)
            string text = "17";
            Font font = new Font("Arial", 30, FontStyle.Bold);
            SizeF textSize = g.MeasureString(text, font);
            g.DrawString(text, font, brush, x - textSize.Width / 2, y - textSize.Height / 2);
        }
    }
}