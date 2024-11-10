using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Triangle_V.A_TARpv23
{
    public partial class Form2 : Form
    {
        Label lblA, lblB, lblC, lblAlpha;
        PictureBox pbox;
        Button btn, btnxml;
        TextBox txtA, txtB, txtC, txtAlpha;

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        ListView listView1;
        public Form2()
        {
            this.Height = 410;
            this.Width = 800;
            this.Text = "Работа с треугольником";
            this.BackColor = Color.DeepSkyBlue;

            listView1 = new ListView();
            listView1.Location = new Point(10, 10);
            listView1.Font = new Font("Arial", 10);
            listView1.Width = 400;
            listView1.Height = 200;
            listView1.View = View.Details;
            listView1.Columns.Add("Поле", 150);
            listView1.Columns.Add("Значение", 200);
            Controls.Add(listView1);

            lblA = new Label();
            lblA.Text = "Сторона A : ";
            lblA.Font = new Font("Arial", 10, FontStyle.Bold);
            lblA.ForeColor = Color.DeepPink;
            lblA.AutoSize = true;
            lblA.Location = new Point(50, 250);
            Controls.Add(lblA);

            lblB = new Label();
            lblB.Text = "Сторона B : ";
            lblB.Font = new Font("Arial", 10, FontStyle.Bold);
            lblB.ForeColor = Color.DeepPink;
            lblB.AutoSize = true;
            lblB.Location = new Point(50, 280);
            Controls.Add(lblB);

            lblC = new Label();
            lblC.Text = "Сторона C : ";
            lblC.Font = new Font("Arial", 10, FontStyle.Bold);
            lblC.ForeColor = Color.DeepPink;
            lblC.AutoSize = true;
            lblC.Location = new Point(50, 310);
            Controls.Add(lblC);

            lblAlpha = new Label();
            lblAlpha.Text = "Угол Alpha : ";
            lblAlpha.Font = new Font("Arial", 10, FontStyle.Bold);
            lblAlpha.ForeColor = Color.DeepPink;
            lblAlpha.AutoSize = true;
            lblAlpha.Location = new Point(50, 340);
            Controls.Add(lblAlpha);

            btn = new Button();
            btn.AutoSize = true;
            btn.Text = "Запуск";
            btn.BackColor = Color.DeepPink;
            btn.Font = new Font("Arial", 15, FontStyle.Italic);
            btn.Cursor = Cursors.Hand;
            btn.FlatAppearance.BorderColor = Color.DodgerBlue;
            btn.FlatAppearance.BorderSize = 5;
            btn.FlatStyle = FlatStyle.Flat;
            btn.Location = new Point(500, 40);
            Controls.Add(btn);
            btn.Click += Btn_Click;

            btnxml = new Button();
            btnxml.AutoSize = true;
            btnxml.Text = "Сохранить в xml файл";
            btnxml.BackColor = Color.DeepPink;
            btnxml.Font = new Font("Arial", 15, FontStyle.Italic);
            btnxml.Cursor = Cursors.Hand;
            btnxml.FlatAppearance.BorderColor = Color.DodgerBlue;
            btnxml.FlatAppearance.BorderSize = 5;
            btnxml.FlatStyle = FlatStyle.Flat;
            btnxml.Location = new Point(500, 90);
            Controls.Add(btnxml);
            btnxml.Click += Btnxml_Click;

            txtA = new TextBox();
            txtA.Location = new Point(150, 250);
            txtA.Font = new Font("Arial", 10);
            txtA.Width = 100;
            txtA.Height = 50;
            Controls.Add(txtA);

            txtB = new TextBox();
            txtB.Location = new Point(150, 280);
            txtB.Font = new Font("Arial", 10);
            txtB.Width = 100;
            txtB.Height = 50;
            Controls.Add(txtB);

            txtC = new TextBox();
            txtC.Location = new Point(150, 310);
            txtC.Font = new Font("Arial", 10);
            txtC.Width = 100;
            txtC.Height = 50;
            Controls.Add(txtC);

            txtAlpha = new TextBox();
            txtAlpha.Location = new Point(150, 340);
            txtAlpha.Font = new Font("Arial", 10);
            txtAlpha.Width = 100;
            txtAlpha.Height = 50;
            Controls.Add(txtAlpha);

            //pbox-picturebox
            pbox = new PictureBox();
            pbox.Size = new Size(350, 350);
            pbox.Location = new Point(410, 90);
            pbox.SizeMode = PictureBoxSizeMode.Zoom;
            Controls.Add(pbox);
        }

        private void Btnxml_Click(object sender, EventArgs e)
        {
            // Проверяем, что все поля заполнены
            if (txtA.Text == "" || txtB.Text == "" || txtC.Text == "" || txtAlpha.Text == "")
            {
                MessageBox.Show("Ошибка! Заполните все поля!");
                return;
            }

            double a = Convert.ToDouble(txtA.Text);
            double b = Convert.ToDouble(txtB.Text);
            double c = Convert.ToDouble(txtC.Text);
            double alpha = Convert.ToDouble(txtAlpha.Text);

            // Создаем или открываем XML файл
            var xmlDocument = new System.Xml.XmlDocument();

            // Если файл существует, загружаем его, иначе создаем новый корневой элемент
            if (System.IO.File.Exists("kolmnurgad.xml"))
            {
                xmlDocument.Load("kolmnurgad.xml");
            }
            else
            {
                var root = xmlDocument.CreateElement("Triangles");
                xmlDocument.AppendChild(root);
            }

            // Создаем элемент для нового треугольника
            var triangleElement = xmlDocument.CreateElement("Triangle");

            var külgA = xmlDocument.CreateElement("Сторона А");
            külgA.InnerText = a.ToString();
            triangleElement.AppendChild(külgA);

            var külgB = xmlDocument.CreateElement("Сторона B");
            külgB.InnerText = b.ToString();
            triangleElement.AppendChild(külgB);

            var külgC = xmlDocument.CreateElement("Сторона C");
            külgC.InnerText = c.ToString();
            triangleElement.AppendChild(külgC);

            var NurkAlfa = xmlDocument.CreateElement("Угол Альфа");
            NurkAlfa.InnerText = alpha.ToString();
            triangleElement.AppendChild(NurkAlfa);

            // Добавляем новый треугольник в корневой элемент
            xmlDocument.DocumentElement.AppendChild(triangleElement);

            xmlDocument.Save("kolmnurgad.xml");

            MessageBox.Show("Треугольник сохранен в XML!");
        }
    

        private void Btn_Click(object sender, EventArgs e)
        {
            double a, b, c, alpha;
            a = Convert.ToDouble(txtA.Text);
            b = Convert.ToDouble(txtB.Text);
            c = Convert.ToDouble(txtC.Text);
            alpha = Convert.ToDouble(txtAlpha.Text);
            Triangle triangle = new Triangle(a, b, c, alpha);
            listView1.Items.Clear();
            listView1.Items.Add("Сторона a");
            listView1.Items.Add("Сторона b");
            listView1.Items.Add("Сторона c");
            listView1.Items.Add("Угол Alpha");
            listView1.Items.Add("Периметр");
            listView1.Items.Add("Площадь");
            listView1.Items.Add("Полупериметр");
            listView1.Items.Add("Существует?");
            listView1.Items.Add("Спецификатор");
            listView1.Items[0].SubItems.Add(triangle.outputA());
            listView1.Items[1].SubItems.Add(triangle.outputB());
            listView1.Items[2].SubItems.Add(triangle.outputC());
            listView1.Items[3].SubItems.Add(triangle.outputAlpha());
            listView1.Items[4].SubItems.Add(Convert.ToString(triangle.Perimeter()));
            listView1.Items[5].SubItems.Add(Convert.ToString(triangle.Surface()));
            listView1.Items[6].SubItems.Add(Convert.ToString(triangle.PoolPerimeeter()));
            if (triangle.ExistTriangle)
            {
                listView1.Items[7].SubItems.Add("Существует");
            }
            else
            {
                listView1.Items[7].SubItems.Add("Не существует");
            }

            // Задаем картинку в PictureBox в зависимости от типа треугольника
            if (triangle.ExistTriangle)
            {
                // Определяем тип треугольника
                switch (triangle.TriangleType)
                {
                    case "Võrdkülgne":
                        listView1.Items[8].SubItems.Add("Равносторонний");
                        pbox.Image = Image.FromFile(@"..\..\ravnostoronij.jpg"); // Картинка для равностороннего треугольника
                        break;
                    case "Võrdhaarne":
                        listView1.Items[9].SubItems.Add("Равнобедренный");
                        pbox.Image = Image.FromFile(@"..\..\Triangle.png"); // Картинка для равнобедренного треугольника
                        break;
                    case "Skaleeni kolmnurk":
                        listView1.Items[10].SubItems.Add("Разносторонний");
                        pbox.Image = Image.FromFile(@"..\..\triangle4.jpg"); // Картинка для разностороннего треугольника
                        break;
                    default:
                        pbox.Image = null; // Если не определен тип треугольника
                        break;
                }
            }
            else
            {
                pbox.Image = null; // Если треугольник не существует
            }
            pbox.Invalidate(); // Обновляем PictureBox, чтобы отобразить новую картинку}
        }
    }
}