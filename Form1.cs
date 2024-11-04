using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Triangle_V.A_TARpv23
{
    public partial class Form1 : Form
    {
        Button btn;
        TextBox txtA, txtB, txtC;
        TableLayoutPanel tbl;
        public Form1()
        {
            this.Height = 400;
            this.Width = 800;
            this.Text = "Работа с треугольником";
            tbl = new TableLayoutPanel();
            tbl.Dock = DockStyle.Fill;

            btn = new Button();
            btn.AutoSize = true;
            btn.Text = "Запуск";
            btn.BackColor = Color.LightCyan;
            btn.Font = new Font("Arial", 28, FontStyle.Italic);
            btn.Cursor= Cursors.Hand;
            btn.FlatAppearance.BorderColor = Color.LightBlue;
            btn.FlatAppearance.BorderSize = 10;
            btn.FlatStyle = FlatStyle.Flat;
            btn.Location = new Point(550, 40);
            Controls.Add(btn);
            btn.Click += Btn_Click;

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

            //Proportsioonide paigaldamine Row'le ja Columnile
            tbl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15));
            tbl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 85));
            tbl.RowStyles.Add(new RowStyle(SizeType.Percent, 90));
            tbl.RowStyles.Add(new RowStyle(SizeType.Percent, 10));

            this.Controls.Add(tbl);
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            Triangle triangle = new Triangle(10, 20, 30);
            
        }
    }
}
