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
