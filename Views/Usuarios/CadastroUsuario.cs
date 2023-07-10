using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.VisualBasic.ApplicationServices;
using reserva_salas_csharp.Models;

namespace reserva_salas_csharp.Views
{
    public class CadastroUsuario : Form
    {
        private Label label1;
        private Panel panel1;
        private Label label3;
        private Label label2;
        private Label label9;
        private ComboBox comboBox1;
        private DateTimePicker dateTimePicker1;
        private TextBox textBox4;
        private MaskedTextBox maskedTextBox1;
        private TextBox textBox3;
        private TextBox textBox5;
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

        public CadastroUsuario(Form formularioAnterior)
        {
            InitializeComponent(formularioAnterior);
        }

        private void InitializeComponent(Form formularioAnterior)
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
            textBox5 = new TextBox();
            textBox3 = new TextBox();
            maskedTextBox1 = new MaskedTextBox();
            textBox4 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            dateTimePicker1 = new DateTimePicker();
            comboBox1 = new ComboBox();
            label9 = new Label();
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
            label1.Text = "Cadastro de Usuário";
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label9);
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(dateTimePicker1);
            panel1.Controls.Add(textBox4);
            panel1.Controls.Add(maskedTextBox1);
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(textBox5);
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
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(18, 329);
            label6.Name = "label6";
            label6.Size = new Size(63, 20);
            label6.TabIndex = 6;
            label6.Text = "Usuário";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(18, 401);
            label7.Name = "label7";
            label7.Size = new Size(46, 20);
            label7.TabIndex = 7;
            label7.Text = "Email";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(233, 329);
            label8.Name = "label8";
            label8.Size = new Size(54, 20);
            label8.TabIndex = 8;
            label8.Text = "Senha";
            // 
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
            textBox5.Cursor = Cursors.IBeam;
            textBox5.Location = new Point(18, 352);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(142, 27);
            textBox5.TabIndex = 13;

            // ToolType
            toolTip1.SetToolTip(textBox5, "Use somente letras e números");

            // 
            // textBox3
            // 
            textBox3.Cursor = Cursors.IBeam;
            textBox3.Location = new Point(233, 352);
            textBox3.Name = "textBox3";
            textBox3.UseSystemPasswordChar = true;
            textBox3.Size = new Size(142, 27);
            textBox3.TabIndex = 14;
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
            textBox4.Cursor = Cursors.IBeam;
            textBox4.Location = new Point(18, 424);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(357, 27);
            textBox4.TabIndex = 17;
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
            button1.Click += new EventHandler((sender, e) => this.CadastrarButtonClick(formularioAnterior, textBox1.Text, textBox2.Text, maskedTextBox1.Text, dateTimePicker1.Value, comboBox1.Text ,textBox4.Text, textBox5.Text, textBox3.Text));
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
            button2.Click += new EventHandler((sender, e) => this.CancelarButtonClick(formularioAnterior));
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
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(455, 351);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 19;
            comboBox1.Text = "Selecione";
            comboBox1.Items.AddRange(Controllers.Usuario.GetAllTiposUsuario().Select(tipo => tipo.Descricao).ToArray());
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = Color.Black;
            label9.Location = new Point(455, 329);
            label9.Name = "label9";
            label9.Size = new Size(95, 20);
            label9.TabIndex = 20;
            label9.Text = "Tipo Usuário";

            //
            // pictureBox1
            //
            showPass.Image = Image.FromFile("Views/Resources/olho.png");
            showPass.Location = new Point(377, 352);
            showPass.Name = "showPass";
            showPass.Size = new Size(25, 25);
            showPass.SizeMode = PictureBoxSizeMode.StretchImage;
            showPass.TabIndex = 21;
            showPass.TabStop = false;
            showPass.Click += new EventHandler((sender, e) => this.ShowPassClick());
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
            this.StartPosition = FormStartPosition.CenterScreen;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private void CancelarButtonClick(Form formularioAnterior)
        {
            DialogResult dialogResult = MessageBox.Show("Deseja cancelar o cadastro?", "Cancelar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes) this.Close();
            formularioAnterior.Activate();
        }

        private void CadastrarButtonClick(Form formularioAnterior, string nome, string sobrenome, string cpf, DateTime dataNascimento, string tipoUsuarioInput, string email, string userName, string senha)
        {
            Models.TipoUsuario tipoUsuario = Controllers.Usuario.GetAllTiposUsuario().FirstOrDefault(tipo => tipo.Descricao.Equals(tipoUsuarioInput));

            Controllers.Usuario.CadastrarUsuario(
                nome, 
                sobrenome, 
                cpf, 
                dataNascimento.ToString("dd/MM/yyyy"), 
                tipoUsuario, 
                email, 
                userName, 
                senha
            );

            MessageBox.Show("Usuário cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
            formularioAnterior.Activate();
        }

        private void ShowPassClick()
        {
            this.textBox3.UseSystemPasswordChar = !this.textBox3.UseSystemPasswordChar;
        }
    }
}