using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.VisualBasic.ApplicationServices;
using reserva_salas_csharp.Models;

namespace reserva_salas_csharp.Views
{
    public class CadatroFunc : Form
    {
        private Label label1;
        private Panel panel1;
        private Label label3;
        private Label label2;

        private ComboBox comboBox1;
        private DateTimePicker dateTimePicker1;
        private MaskedTextBox maskedTextBox1;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Button button1;
        private Button button2;
        private PictureBox showPass;
        private ToolTip toolTip1;
        private ToolTip toolTip2;

        public CadatroFunc()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            label1 = new Label();
            panel1 = new Panel();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            maskedTextBox1 = new MaskedTextBox();
            button1 = new Button();
            button2 = new Button();
            dateTimePicker1 = new DateTimePicker();
            comboBox1 = new ComboBox();
      
            showPass = new PictureBox();
            toolTip1 = new ToolTip();
            toolTip2 = new ToolTip();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(31, 9);
            label1.Name = "label1";
            label1.Size = new Size(244, 27);
            label1.TabIndex = 0;
            label1.Text = "Cadastro de Funcionario";
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
          
 
            panel1.Controls.Add(dateTimePicker1);
            panel1.Controls.Add(maskedTextBox1);
       
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(showPass);
            panel1.ForeColor = Color.FromArgb(127, 103, 186);
            panel1.Location = new Point(12, 23);
            panel1.Name = "panel1";
            panel1.Size = new Size(773, 516);
            panel1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(18, 95);
            label2.Name = "label2";
            label2.Size = new Size(53, 20);
            label2.TabIndex = 2;
            label2.Text = "Nome";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(367, 95);
            label3.Name = "label3";
            label3.Size = new Size(93, 20);
            label3.TabIndex = 3;
            label3.Text = "Sobrenome";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(18, 174);
            label4.Name = "label4";
            label4.Size = new Size(37, 20);
            label4.TabIndex = 4;
            label4.Text = "CPF";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(172, 174);
            label5.Name = "label5";
            label5.Size = new Size(160, 20);
            label5.TabIndex = 5;
            label5.Text = "Data de Nascimento";
            // 
            // label6
       
            // textBox1
            // 
            textBox1.Location = new Point(18, 120);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(314, 27);
            textBox1.TabIndex = 9;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(367, 120);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(314, 27);
            textBox2.TabIndex = 10;
            // 
            // textBox5
            // 
        

            // 
            // textBox3
          
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Cursor = Cursors.IBeam;
            maskedTextBox1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            maskedTextBox1.Location = new Point(18, 197);
            maskedTextBox1.Culture = new System.Globalization.CultureInfo("en-US");
            maskedTextBox1.Mask = "999.999.999-99";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.TabStop = false;
            maskedTextBox1.Size = new Size(105, 27);
            maskedTextBox1.TabIndex = 15;
            // 
            // textBox4
            // 
            
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(193, 167, 255);
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(531, 545);
            button1.Name = "button1";
            button1.Size = new Size(119, 42);
            button1.TabIndex = 2;
            button1.Text = "Salvar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += new EventHandler((sender, e) => this.CadastrarButtonClick(textBox1.Text, textBox2.Text, maskedTextBox1.Text, dateTimePicker1.Value));
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(255, 194, 109);
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.ControlText;
            button2.Location = new Point(665, 545);
            button2.Name = "button2";
            button2.Size = new Size(119, 42);
            button2.TabIndex = 3;
            button2.Text = "Cancelar";
            button2.UseVisualStyleBackColor = false;
            button2.Click += new EventHandler((sender, e) => this.CancelarButtonClick());
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(172, 197);
            dateTimePicker1.MaxDate = new DateTime(2023, 6, 17, 17, 20, 20, 0);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(314, 27);
            dateTimePicker1.TabIndex = 18;
            dateTimePicker1.Value = new DateTime(2023, 6, 17, 0, 0, 0, 0);
            // 
            // comboBox1
            // 
           
            //
            // pictureBox1
            //
        
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(796, 612);
            ControlBox = false;
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private void CancelarButtonClick()
        {
            DialogResult dialogResult = MessageBox.Show("Deseja cancelar o cadastro?", "Cancelar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes) this.Close();
        }

        private void CadastrarButtonClick(string nome, string sobrenome, string cpf, DateTime dataNascimento)
        {
        
            Controllers.Funcionario.cadastraFuncionario(
                nome, 
                sobrenome, 
                cpf, 
                dataNascimento.ToString("dd/MM/yyyy")
                
            );

            MessageBox.Show("Funcionario cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

       
    }
}