using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.VisualBasic.ApplicationServices;
using reserva_salas_csharp.Models;

namespace reserva_salas_csharp.Views
{
    public class CadastroSala : Form
    {
        private Label titulo;
        private Label lblNomeSala;
        private Label lblNomeAndar; 
        private Panel panel1;
        private TextBox txtNomeSala;
        private TextBox txtNomeAndar;
        private Button btnCancelar;
        private Button btnSalvar;
        
        public CadastroSala(int id, Form formularioAnterior)
        {
            InitializeComponent(id, formularioAnterior);
        }

        public void InitializeComponent(int id, Form formularioAnterior)
        {
            panel1 = new Panel();
            titulo = new Label();
            lblNomeSala = new Label();
            lblNomeAndar = new Label();
            txtNomeSala = new TextBox();
            txtNomeAndar = new TextBox();
            btnCancelar = new Button();
            btnSalvar = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            titulo.AutoSize = true;
            titulo.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            titulo.Location = new Point(12, 20);
            titulo.Name = "titulo";
            titulo.Size = new Size(50, 20);
            titulo.TabIndex = 0;
            titulo.Text = "Cadastro de Salas";

            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            
            panel1.Controls.Add(txtNomeSala);
            panel1.Controls.Add(txtNomeAndar);

            panel1.Controls.Add(titulo);
            panel1.Controls.Add(lblNomeAndar);
            panel1.Controls.Add(lblNomeSala);

            panel1.ForeColor = Color.FromArgb(127, 103, 186);
            panel1.Location = new Point(12, 23);
            panel1.Name = "panel1";
            panel1.Size = new Size(550, 420);
            panel1.TabIndex = 1;
            // 
            // label2
            // 
            lblNomeSala.AutoSize = true;
            lblNomeSala.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblNomeSala.ForeColor = Color.Black;
            lblNomeSala.Location = new Point(10, 70);
            lblNomeSala.Name = "lblNomeSala";
            lblNomeSala.Size = new Size(170, 20);
            lblNomeSala.TabIndex = 2;
            lblNomeSala.Text = "N° Salas";
            // 
            // label3
            // 
            lblNomeAndar.AutoSize = true;
            lblNomeAndar.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblNomeAndar.ForeColor = Color.Black;
            lblNomeAndar.Location = new Point(180, 70);
            lblNomeAndar.Name = "lblNomeAndar";
            lblNomeAndar.Size = new Size(90, 20);
            lblNomeAndar.TabIndex = 3;
            lblNomeAndar.Text = "N° Andar";

            // 
            // textBox1
            // 
            txtNomeSala.Location = new Point(10, 90);
            txtNomeSala.Name = "txtNomeSala";
            txtNomeSala.Size = new Size(90, 20);
            txtNomeSala.TabIndex = 10;

            // 
            // textBox2
            // 
            txtNomeAndar.Location = new Point(180, 90);
            txtNomeAndar.Name = "txtNomeAndar";
            txtNomeAndar.Size = new Size(90, 20);
            txtNomeAndar.TabIndex = 10;


            // 
            // button1
            // 
            btnSalvar.BackColor = Color.FromArgb(193, 167, 255);
            btnSalvar.Cursor = Cursors.Hand;
            btnSalvar.FlatAppearance.BorderSize = 0;
            btnSalvar.FlatStyle = FlatStyle.Flat;
            btnSalvar.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnSalvar.Location = new Point(531, 545);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(119, 42);
            btnSalvar.TabIndex = 2;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = false;
            btnSalvar.Click += new EventHandler((sender, e) => 
            {

                if (id == 0)
                {
                  Controllers.Sala.CadastrarSala(this.txtNomeSala.Text, this.txtNomeAndar.Text);
                   MessageBox.Show("Sala Cadastrada com sucesso");
                   this.Close();
        
                } else {
                  Controllers.Sala.AlterarSala(id, this.txtNomeSala.Text, this.txtNomeAndar.Text);
                   MessageBox.Show("Alterado registro da sala com sucesso");
                   this.Close();
                }
            }
            );
           
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(400, 400);
            ControlBox = false;
            Controls.Add(btnSalvar);
            Controls.Add(btnCancelar);
            Controls.Add(titulo);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();


             if (id != 0)
            {
                Models.Sala sala = Controllers.Sala.GetSalas(id);
                this.txtNomeSala.Text =  sala.numeroSala.ToString();
                this.txtNomeAndar.Text = sala.numeroAndar.ToString();

            }

            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.Location = new Point(200, 270);
            this.btnSalvar.Size = new Size(100, 25);
            this.btnSalvar.Font = new Font("Arial", 11, FontStyle.Bold);
            this.btnSalvar.Click += (sender, e) =>
            {
                if (id == 0)
                {
                    Controllers.Sala.CadastrarSala(this.txtNomeSala.Text, this.txtNomeAndar.Text);
                    MessageBox.Show("Sala Cadastrada com sucesso");
                    this.Close();
                    formularioAnterior.Activate();
                } else {
                    Controllers.Sala.AlterarSala(id, this.txtNomeSala.Text, this.txtNomeAndar.Text);
                    MessageBox.Show("Alterado registro da sala com sucesso");
                    this.Close();
                    formularioAnterior.Activate();
                }
            };

            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Location = new Point(320, 270);
            this.btnCancelar.Size = new Size(100, 25);
            this.btnCancelar.Font = new Font("Arial", 11, FontStyle.Bold);
            this.btnCancelar.Click += (sender, e) => 
            {
                DialogResult dialogResult = MessageBox.Show("Deseja cancelar o cadastro?", "Cancelar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                this.Close();
                formularioAnterior.Activate();
            };

            this.Text = "Cadastro de Salas";
            this.Size = new Size(500, 350);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.TopMost = true;
            this.Visible = false;
            this.ShowDialog();
        }
     
    }
}