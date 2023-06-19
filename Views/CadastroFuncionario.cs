using System;
using System.Drawing;
using System.Windows.Forms;
using reserva_salas_csharp.Models;

namespace reserva_salas_csharp.Views 
{
    public class CadastroFunc : Form
    {
        private Label titulo;
        private Label lblNomeAndar;
        private Label lblNomeSala;
        private TextBox txtNomeSala;
        private TextBox txtNomeAndar;
        private Button btnSalvar;
        private Button btnCancelar;
        private ListView lista;
        private Button btnEditar;
        private Button btnExcluir;

        public CadastroFunc(int id)
        {
        InitializeComponent(id);
        }

        public void InitializeComponent(int id)
        {
            
            this.titulo = new Label();
            this.lblNomeSala = new Label();
            this.txtNomeSala = new TextBox();
            this.lblNomeAndar = new Label();
            this.txtNomeAndar = new TextBox();
            this.btnSalvar = new Button();
            this.btnCancelar = new Button();


            this.titulo.Text = "Cadastro de Funcionarios";
            this.titulo.Location = new Point(0, 10);
            this.titulo.Size = new Size(150, 20);
            this.titulo.TextAlign = ContentAlignment.MiddleCenter;
            this.titulo.Font = new Font("Arial", 12, FontStyle.Bold);

            this.lblNomeSala.Text = "";
            this.lblNomeSala.Location = new Point(10, 70);
            this.lblNomeSala.Size = new Size(170, 20);
            this.lblNomeSala.Font = new Font("Arial", 10, FontStyle.Bold);

            this.txtNomeSala.Location = new Point(10, 90);
            this.txtNomeSala.Size = new Size(90, 20);
            this.txtNomeSala.Font = new Font("Arial", 11, FontStyle.Bold);


            this.lblNomeAndar.Text = "N° Andar";
            this.lblNomeAndar.Location = new Point(180, 70);
            this.lblNomeAndar.Size = new Size(90, 20);
            this.lblNomeAndar.Font = new Font("Arial", 10, FontStyle.Bold);

            this.txtNomeAndar.Location = new Point(180, 90);
            this.txtNomeAndar.Size = new Size(90, 20);
            this.txtNomeAndar.Font = new Font("Arial", 11, FontStyle.Bold);

            if (id != 0)
            {
                Models.Funcionario sala = Controllers.Funcionario.mostrarFunc(id);
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
        
                } else {
                  Controllers.Sala.AlterarSala(id, this.txtNomeSala.Text, this.txtNomeAndar.Text);
                   MessageBox.Show("Alterado registro da sala com sucesso");
                   this.Close();
                }
               
                
            };

            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Location = new Point(320, 270);
            this.btnCancelar.Size = new Size(100, 25);
            this.btnCancelar.Font = new Font("Arial", 11, FontStyle.Bold);
            this.btnCancelar.Click += (sender, e) => {
                this.Close();
                // new Almoxarifado();
            };

            this.Controls.Add(this.titulo);
            this.Controls.Add(this.lblNomeSala);
            this.Controls.Add(this.txtNomeSala);
            this.Controls.Add(this.lblNomeAndar);
            this.Controls.Add(this.txtNomeAndar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnCancelar);

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