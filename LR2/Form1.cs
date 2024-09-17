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
        private Color selectedColor = Color.Black;
        //хранение объектов
        private List<Shape> shapes = new List<Shape>();
        //хранение удаленных объектов
        private Stack<Shape> removedShapes = new Stack<Shape>();


        public Form1()
        {
            InitializeComponent();
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (shapes.Count > 0)
            {
                Shape shape = shapes[shapes.Count - 1];
                shapes.Remove(shape);
                removedShapes.Push(shape);
                pictureBox1.Invalidate();
            }
        }

        private void Redo_Click(object sender, EventArgs e)
        {
            if (removedShapes.Count > 0)
            {
                Shape shape = removedShapes.Pop();
                shapes.Add(shape);
                pictureBox1.Invalidate();
            }
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            // Добавляем новую фигуру в список и перерисовываем
            Shape shape = new Shape(e.X, e.Y, selectedColor);
            shapes.Add(shape);
            pictureBox1.Invalidate();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            foreach (var shape in shapes)
            {
                shape.Draw(g);
            }
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