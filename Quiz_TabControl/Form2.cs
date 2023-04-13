using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Label = System.Windows.Forms.Label;

namespace Quiz_TabControl
{
    public partial class Form2 : Form
    {
        public Form2(int countRight2)
        {
            InitializeComponent();
            
            Button button = new Button();
            button.DialogResult = DialogResult.Cancel;

            button.Location = new Point(120, 135);
            button.Size = new Size(90, 35);
            button.Text = "Закрыть";
            button.Font = new Font("Segoe UI", 9, FontStyle.Bold);

            Form1 form = new Form1();
           
            Label label = new Label();
            label.Text = ($"Вы ответили верно на -> {countRight2}/9 вопросов");

            label.Location = new Point(20, 50);
            label.AutoSize = false;
            label.Size = new Size(300, 20);
            
            label.Font = new Font("Segoe UI", 10, FontStyle.Bold);

            Controls.Add(button);
            Controls.Add(label);
        }
    }
}
