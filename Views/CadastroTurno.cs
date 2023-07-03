using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.VisualBasic.ApplicationServices;
using reserva_salas_csharp.Models;

namespace reserva_salas_csharp.Views
{
    public class CadastroTurno : Form
    {
        private Label titulo;
        private Label lblNomeTurno;
        private Panel panel1;

        private TextBox txtNomeTurno;
        private TextBox txtMensagem;

        private Button btnCancelar;
        private Button btnSalvar;
        
         public CadastroTurno(int id, Form formularioAnterior)
          {
              InitializeComponent(id, formularioAnterior);
          }

      public void InitializeComponent(int id, Form formularioAnterior)
      {
          
          this.titulo = new Label();
          this.lblNomeTurno = new Label();
          this.txtNomeTurno = new TextBox();
          this.btnSalvar = new Button();
          this.btnCancelar = new Button();
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
            titulo.Text = "Cadastro de Turnos";

            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            
            panel1.Controls.Add(txtNomeTurno);

            panel1.Controls.Add(titulo);
            panel1.Controls.Add(lblNomeTurno);
 

            panel1.ForeColor = Color.FromArgb(127, 103, 186);
            panel1.Location = new Point(12, 23);
            panel1.Name = "panel1";
            panel1.Size = new Size(550, 420);
            panel1.TabIndex = 1;
            // 
            // label2
            // 
            lblNomeTurno.AutoSize = true;
            lblNomeTurno.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblNomeTurno.ForeColor = Color.Black;
            lblNomeTurno.Location = new Point(10, 70);
            lblNomeTurno.Name = "lblNomeTurno";
            lblNomeTurno.Size = new Size(170, 20);
            lblNomeTurno.TabIndex = 2;
            lblNomeTurno.Text = "Turno";

            // 
            // textBox1
            // 
            txtNomeTurno.Location = new Point(10, 90);
            txtNomeTurno.Name = "txtNomeTurno";
            txtNomeTurno.Size = new Size(90, 20);
            txtNomeTurno.TabIndex = 10;


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
                  Controllers.Turno.CadastrarTurno(this.txtNomeTurno.Text);
                   MessageBox.Show("Andar Cadastrado com sucesso");
                   this.Close();
        
                } else {
                  Controllers.Turno.Alterarturno(id, this.txtNomeTurno.Text);
                   MessageBox.Show("Alterado registro do andar com sucesso");
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
              Models.Turno turno = Controllers.Turno.GetTurnos(id);
              this.txtNomeTurno.Text = turno.descricao;

            }

            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.Location = new Point(200, 270);
            this.btnSalvar.Size = new Size(100, 25);
            this.btnSalvar.Font = new Font("Arial", 11, FontStyle.Bold);
            this.btnSalvar.Click += (sender, e) =>
            {
                if (id == 0)
                {
                    Controllers.Turno.CadastrarTurno(this.txtNomeTurno.Text);
                    MessageBox.Show("Item cadastrado com sucesso");
                    this.Close();
                    formularioAnterior.Activate();
                }
                else {
                    Controllers.Turno.Alterarturno(id, this.txtNomeTurno.Text);
                    MessageBox.Show("Item alterado com sucesso");
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

            this.Text = "Cadastro de Turnos";
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