using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Button = System.Windows.Forms.Button;
using TextBox = System.Windows.Forms.TextBox;

namespace Quiz_TabControl
{
    public partial class Form1 : Form
    {
        TabControl tabControl1 = new TabControl();
        TabPage tabPage1 = new TabPage();
        TabPage tabPage2;
        Label label1 = new Label();
        Label label2 = new Label();
        Label label3 = new Label();

        RadioButton radioButton1 = new RadioButton();
        RadioButton radioButton2 = new RadioButton();
        public RadioButton radioButton3 = new RadioButton();
        RadioButton radioButton4 = new RadioButton();
        RadioButton radioButton5 = new RadioButton();
        public RadioButton radioButton6 = new RadioButton();

        GroupBox groupBox1 = new GroupBox();
        GroupBox groupBox2 = new GroupBox();

        public CheckBox checkBox1 = new CheckBox();
        public CheckBox checkBox2 = new CheckBox();
        public CheckBox checkBox3 = new CheckBox();
        public CheckBox checkBox4 = new CheckBox();

        Button myButton = new Button();

        ///
        Label label1N = new Label();
        Label label2N = new Label();
        Label label3N = new Label();

        public RadioButton radioButton1N = new RadioButton();
        RadioButton radioButton2N = new RadioButton();
        RadioButton radioButton3N = new RadioButton();
        RadioButton radioButton4N = new RadioButton();
        RadioButton radioButton5N = new RadioButton();
        public RadioButton radioButton6N = new RadioButton();

        GroupBox groupBox1N = new GroupBox();
        GroupBox groupBox2N = new GroupBox();

        public CheckBox checkBox1N = new CheckBox();
        public CheckBox checkBox2N = new CheckBox();
        public CheckBox checkBox3N = new CheckBox();
        public CheckBox checkBox4N = new CheckBox();

        Button myButtonN = new Button();
        //
        TabPage tabPage3;
        Label label1S = new Label();
        Label label2S = new Label();
        Label label3S = new Label();

        public RadioButton radioButton1S = new RadioButton();
        RadioButton radioButton2S = new RadioButton();
        RadioButton radioButton3S = new RadioButton();
        RadioButton radioButton4S = new RadioButton();
        public RadioButton radioButton5S = new RadioButton();
        RadioButton radioButton6S = new RadioButton();

        GroupBox groupBox1S = new GroupBox();
        GroupBox groupBox2S = new GroupBox();

        public CheckBox checkBox1S = new CheckBox();
        public CheckBox checkBox2S = new CheckBox();
        public CheckBox checkBox3S = new CheckBox();
        public CheckBox checkBox4S = new CheckBox();

        Button myButtonS = new Button();
        public Form1()
        {
            InitializeComponent();

            tabControl1.Location = new System.Drawing.Point(10, 10);
            tabControl1.Size = new System.Drawing.Size(800, 900);

            tabPage1.Text = "Биология";

            #region Первый вопрос
            label1.Location = new Point(10, 10);
            label1.AutoSize = false;
            label1.Size = new Size(600, 20);
            label1.Text = "1. Какое из следующих утверждений о птицах является правильным?";
            label1.Font = new Font("Segoe UI", 10, FontStyle.Bold);

            groupBox1.Location = new Point(10, 30);
            groupBox1.Size = new Size(600, 100);

            radioButton1.Text = "Все птицы могут летать";
            radioButton2.Text = "Птицы могут не иметь крыльев";
            radioButton3.Text = "Птицы - это группа животных с перьями и двумя ногами";
            radioButton1.Location = new Point(10, 10);
            radioButton2.Location = new Point(10, 40);
            radioButton3.Location = new Point(10, 70);
            radioButton1.Size = new Size(600, 20);
            radioButton2.Size = new Size(600, 20);
            radioButton3.Size = new Size(600, 20);
            radioButton1.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            radioButton2.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            radioButton3.Font = new Font("Segoe UI", 9, FontStyle.Bold);

            groupBox1.Controls.Add(radioButton1);
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton3);

            tabPage1.Controls.Add(groupBox1);
            tabPage1.Controls.Add(label1);
            #endregion

            #region Второй вопрос
            label2.Location = new Point(10, 150);
            label2.AutoSize = false;
            label2.Size = new Size(600, 20);
            label2.Text = "2. Какой из следующих органов является частью нервной системы?";
            label2.Font = new Font("Segoe UI", 10, FontStyle.Bold);

            groupBox2.Location = new Point(10, 170);
            groupBox2.Size = new Size(600, 100);
            radioButton4.Text = "Сердце";
            radioButton5.Text = "Желудок";
            radioButton6.Text = "Мозг";
            radioButton4.Location = new Point(10, 10);
            radioButton5.Location = new Point(10, 40);
            radioButton6.Location = new Point(10, 70);
            radioButton4.Size = new Size(600, 20);
            radioButton5.Size = new Size(600, 20);
            radioButton6.Size = new Size(600, 20);
            radioButton4.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            radioButton5.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            radioButton6.Font = new Font("Segoe UI", 9, FontStyle.Bold);


            groupBox2.Controls.Add(radioButton4);
            groupBox2.Controls.Add(radioButton5);
            groupBox2.Controls.Add(radioButton6);

            tabPage1.Controls.Add(groupBox2);
            tabPage1.Controls.Add(label2);
            #endregion

            #region Третий вопрос с чекитами

            label3.Location = new Point(10, 280);
            label3.AutoSize = false;
            label3.Size = new Size(600, 20);
            label3.Text = "3. Какие из следующих органов человека участвуют в дыхании?";
            label3.Font = new Font("Segoe UI", 10, FontStyle.Bold);

            checkBox1.Text = "Легкие";
            checkBox2.Text = "Диафрагма";
            checkBox3.Text = "Сердце";
            checkBox4.Text = "Почки";

            checkBox1.Location = new Point(20, 310);
            checkBox2.Location = new Point(20, 335);
            checkBox3.Location = new Point(20, 360);
            checkBox4.Location = new Point(20, 385);
            checkBox1.Size = new Size(200, 20);
            checkBox2.Size = new Size(200, 20);
            checkBox3.Size = new Size(200, 20);
            checkBox4.Size = new Size(200, 20);
            checkBox1.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            checkBox2.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            checkBox3.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            checkBox4.Font = new Font("Segoe UI", 9, FontStyle.Bold);

            tabPage1.Controls.Add(checkBox1);
            tabPage1.Controls.Add(checkBox2);
            tabPage1.Controls.Add(checkBox3);
            tabPage1.Controls.Add(checkBox4);
            tabPage1.Controls.Add(label3);
            #endregion

            #region Добавление кнопки

            myButton.Location = new Point(480, 380);
            myButton.Size = new Size(100, 50);
            myButton.Text = "Дальше";
            myButton.BackColor = Color.LightGreen;
            myButton.Font = new Font("Segoe UI", 10, FontStyle.Bold);

            myButton.Click += new EventHandler(myButton_Click);

            tabPage1.Controls.Add(myButton);

            #endregion

            tabControl1.TabPages.Add(tabPage1);
            this.Controls.Add(tabControl1);



        }
        public bool RadioButton3Checked
        {
            get { return radioButton3.Checked; }
        }
        public bool RadioButton6Checked
        {
            get { return radioButton6.Checked; }
        }
        private void myButton_Click(object sender, EventArgs e)
        {
            tabPage2 = new TabPage();
            tabPage2.Text = "География";
            tabControl1.TabPages.Add(tabPage2);
            tabControl1.SelectedTab = tabPage2;

            #region Первый вопрос
            label1N.Location = new Point(10, 10);
            label1N.AutoSize = false;
            label1N.Size = new Size(600, 20);
            label1N.Text = "4. Какой из этих океанов самый большой по площади?";
            label1N.Font = new Font("Segoe UI", 10, FontStyle.Bold);

            groupBox1N.Location = new Point(10, 30);
            groupBox1N.Size = new Size(600, 100);

            radioButton1N.Text = "Тихий океан";
            radioButton2N.Text = "Атлантический океан";
            radioButton3N.Text = "Индийский океан";
            radioButton1N.Location = new Point(10, 10);
            radioButton2N.Location = new Point(10, 40);
            radioButton3N.Location = new Point(10, 70);
            radioButton1N.Size = new Size(600, 20);
            radioButton2N.Size = new Size(600, 20);
            radioButton3N.Size = new Size(600, 20);
            radioButton1N.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            radioButton2N.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            radioButton3N.Font = new Font("Segoe UI", 9, FontStyle.Bold);

            groupBox1N.Controls.Add(radioButton1N);
            groupBox1N.Controls.Add(radioButton2N);
            groupBox1N.Controls.Add(radioButton3N);

            tabPage2.Controls.Add(groupBox1N);
            tabPage2.Controls.Add(label1N);
            #endregion

            #region Второй вопрос
            label2N.Location = new Point(10, 150);
            label2N.AutoSize = false;
            label2N.Size = new Size(600, 20);
            label2N.Text = "5. Какая из этих стран не расположена в Европе?";
            label2N.Font = new Font("Segoe UI", 10, FontStyle.Bold);

            groupBox2N.Location = new Point(10, 170);
            groupBox2N.Size = new Size(600, 100);
            radioButton4N.Text = "Швеция";
            radioButton5N.Text = "Чехия";
            radioButton6N.Text = "Казахстан";
            radioButton4N.Location = new Point(10, 10);
            radioButton5N.Location = new Point(10, 40);
            radioButton6N.Location = new Point(10, 70);
            radioButton4N.Size = new Size(600, 20);
            radioButton5N.Size = new Size(600, 20);
            radioButton6N.Size = new Size(600, 20);
            radioButton4N.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            radioButton5N.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            radioButton6N.Font = new Font("Segoe UI", 9, FontStyle.Bold);


            groupBox2N.Controls.Add(radioButton4N);
            groupBox2N.Controls.Add(radioButton5N);
            groupBox2N.Controls.Add(radioButton6N);

            tabPage2.Controls.Add(groupBox2N);
            tabPage2.Controls.Add(label2N);
            #endregion

            #region Третий вопрос с чекитами

            label3N.Location = new Point(10, 280);
            label3N.AutoSize = false;
            label3N.Size = new Size(600, 20);
            label3N.Text = "6. Какие из этих государств являются островами?";
            label3N.Font = new Font("Segoe UI", 10, FontStyle.Bold);

            checkBox1N.Text = "Новая Зеландия";
            checkBox2N.Text = "Ямайка";
            checkBox3N.Text = "Нидерланды";
            checkBox4N.Text = "Мадагаскар";

            checkBox1N.Location = new Point(20, 310);
            checkBox2N.Location = new Point(20, 335);
            checkBox3N.Location = new Point(20, 360);
            checkBox4N.Location = new Point(20, 385);
            checkBox1N.Size = new Size(200, 20);
            checkBox2N.Size = new Size(200, 20);
            checkBox3N.Size = new Size(200, 20);
            checkBox4N.Size = new Size(200, 20);
            checkBox1N.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            checkBox2N.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            checkBox3N.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            checkBox4N.Font = new Font("Segoe UI", 9, FontStyle.Bold);

            tabPage2.Controls.Add(checkBox1N);
            tabPage2.Controls.Add(checkBox2N);
            tabPage2.Controls.Add(checkBox3N);
            tabPage2.Controls.Add(checkBox4N);
            tabPage2.Controls.Add(label3N);
            #endregion

            #region Добавление кнопки

            myButtonN.Location = new Point(480, 380);
            myButtonN.Size = new Size(100, 50);
            myButtonN.Text = "Дальше";
            myButtonN.BackColor = Color.LightGreen;
            myButtonN.Font = new Font("Segoe UI", 10, FontStyle.Bold);

            myButtonN.Click += new EventHandler(myButton_ClickN);

            tabPage2.Controls.Add(myButtonN);

            #endregion
        }
        private void myButton_ClickN(object sender, EventArgs e)
        {
            tabPage3 = new TabPage();
            tabPage3.Text = "История";
            tabControl1.TabPages.Add(tabPage3);
            tabControl1.SelectedTab = tabPage3;

            #region Первый вопрос
            label1S.Location = new Point(10, 10);
            label1S.AutoSize = false;
            label1S.Size = new Size(600, 20);
            label1S.Text = "7. Кто из императоров был известен как \"Македонский Александр\"?";
            label1S.Font = new Font("Segoe UI", 10, FontStyle.Bold);

            groupBox1S.Location = new Point(10, 30);
            groupBox1S.Size = new Size(600, 100);

            radioButton1S.Text = "Александр I";
            radioButton2S.Text = "Александр II";
            radioButton3S.Text = "Александр III";
            radioButton1S.Location = new Point(10, 10);
            radioButton2S.Location = new Point(10, 40);
            radioButton3S.Location = new Point(10, 70);
            radioButton1S.Size = new Size(600, 20);
            radioButton2S.Size = new Size(600, 20);
            radioButton3S.Size = new Size(600, 20);
            radioButton1S.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            radioButton2S.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            radioButton3S.Font = new Font("Segoe UI", 9, FontStyle.Bold);

            groupBox1S.Controls.Add(radioButton1S);
            groupBox1S.Controls.Add(radioButton2S);
            groupBox1S.Controls.Add(radioButton3S);

            tabPage3.Controls.Add(groupBox1S);
            tabPage3.Controls.Add(label1S);
            #endregion

            #region Второй вопрос
            label2S.Location = new Point(10, 150);
            label2S.AutoSize = false;
            label2S.Size = new Size(600, 20);
            label2S.Text = "8. Какое событие привело к началу Первой мировой войны?";
            label2S.Font = new Font("Segoe UI", 10, FontStyle.Bold);

            groupBox2S.Location = new Point(10, 170);
            groupBox2S.Size = new Size(600, 100);
            radioButton4S.Text = "Атака на Перл-Харбор";
            radioButton5S.Text = "Убийство Архидука Франц-Фердинанда в Сараево";
            radioButton6S.Text = "Завоевание Германией Польши";
            radioButton4S.Location = new Point(10, 10);
            radioButton5S.Location = new Point(10, 40);
            radioButton6S.Location = new Point(10, 70);
            radioButton4S.Size = new Size(600, 20);
            radioButton5S.Size = new Size(600, 20);
            radioButton6S.Size = new Size(600, 20);
            radioButton4S.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            radioButton5S.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            radioButton6S.Font = new Font("Segoe UI", 9, FontStyle.Bold);


            groupBox2S.Controls.Add(radioButton4S);
            groupBox2S.Controls.Add(radioButton5S);
            groupBox2S.Controls.Add(radioButton6S);

            tabPage3.Controls.Add(groupBox2S);
            tabPage3.Controls.Add(label2S);
            #endregion

            #region Третий вопрос с чекитами

            label3S.Location = new Point(10, 280);
            label3S.AutoSize = false;
            label3S.Size = new Size(600, 20);
            label3S.Text = "9. Какие события привели к окончанию Холодной войны?";
            label3S.Font = new Font("Segoe UI", 10, FontStyle.Bold);

            checkBox1S.Text = "Распад СССР";
            checkBox2S.Text = "Падение Берлинской стены";
            checkBox3S.Text = "Новые политические лидеры в США и СССР";
            checkBox4S.Text = "Изменение мировой экономической ситуации";

            checkBox1S.Location = new Point(20, 310);
            checkBox2S.Location = new Point(20, 335);
            checkBox3S.Location = new Point(20, 360);
            checkBox4S.Location = new Point(20, 385);
            checkBox1S.Size = new Size(200, 20);
            checkBox2S.Size = new Size(200, 20);
            checkBox3S.Size = new Size(300, 20);
            checkBox4S.Size = new Size(300, 20);
            checkBox1S.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            checkBox2S.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            checkBox3S.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            checkBox4S.Font = new Font("Segoe UI", 9, FontStyle.Bold);

            tabPage3.Controls.Add(checkBox1S);
            tabPage3.Controls.Add(checkBox2S);
            tabPage3.Controls.Add(checkBox3S);
            tabPage3.Controls.Add(checkBox4S);
            tabPage3.Controls.Add(label3S);
            #endregion

            #region Добавление кнопки

            myButtonS.Location = new Point(480, 380);
            myButtonS.Size = new Size(100, 50);
            myButtonS.Text = "Результат";
            myButtonS.BackColor = Color.LightGreen;
            myButtonS.Font = new Font("Segoe UI", 10, FontStyle.Bold);

            myButtonS.Click += new EventHandler(myButton_ClickS);

            tabPage3.Controls.Add(myButtonS);

            #endregion
        }
        private void myButton_ClickS(object sender, EventArgs e)
        {
            int countRight = 0;
            if (radioButton3.Checked)
            {
                countRight++;
            }
            if (radioButton6.Checked)
            {
                countRight++;
            }
            if (radioButton6N.Checked)
            {
                countRight++;
            }
            if (radioButton1N.Checked)
            {
                countRight++;
            }
            if (radioButton1S.Checked)
            {
                countRight++;
            }
            if (radioButton5S.Checked)
            {
                countRight++;
            }
            if ((checkBox1.Checked && checkBox2.Checked) && (!checkBox3.Checked && !checkBox4.Checked))
            {
                countRight++;
            }
            if ((checkBox2N.Checked && checkBox4N.Checked) && (!checkBox1N.Checked && !checkBox3N.Checked))
            {
                countRight++;
            }
            if (checkBox1S.Checked && checkBox2S.Checked && checkBox3S.Checked && checkBox4S.Checked)
            {
                countRight++;
            }
            Form2 form2 = new Form2(countRight);
           //form2.countRight2 = countRight; 
            form2.ShowDialog();
            if (DialogResult.Cancel == form2.DialogResult)
            {
                form2.Close();
            }
        }
    }
}
