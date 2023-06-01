using System;
using System.Drawing;
using System.Windows.Forms;

namespace Views 
{
    public class CadastroTurno : Form
    {
      private Label titulo;
      private Label lblNomeTurno;
      private TextBox txtNomeTurno;

      private TextBox txtMensagem;

      private Button btnSalvar;
      private Button btnCancelar;

      public CadastroTurno(int id)
      {
          InitializeComponent(id);
      }

      public void InitializeComponent(int id)
      {
          
          this.titulo = new Label();
          this.lblNomeTurno = new Label();
          this.txtNomeTurno = new TextBox();
          this.btnSalvar = new Button();
          this.btnCancelar = new Button();


          this.titulo.Text = "Cadastro de Turno";
          this.titulo.Location = new Point(0, 10);
          this.titulo.Size = new Size(170, 20);
          this.titulo.TextAlign = ContentAlignment.MiddleCenter;
          this.titulo.Font = new Font("Arial", 12, FontStyle.Bold);

          this.lblNomeTurno.Text = "Turno";
          this.lblNomeTurno.Location = new Point(10, 70);
          this.lblNomeTurno.Size = new Size(170, 20);
          this.lblNomeTurno.Font = new Font("Arial", 10, FontStyle.Bold);

          this.txtNomeTurno.Location = new Point(10, 90);
          this.txtNomeTurno.Size = new Size(150, 20);
          this.txtNomeTurno.Font = new Font("Arial", 11, FontStyle.Bold);

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
                }
                else {
                    Controllers.Turno.Alterarturno(id, this.txtNomeTurno.Text);
                    MessageBox.Show("Item alterado com sucesso");
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
            this.Controls.Add(this.lblNomeTurno);
            this.Controls.Add(this.txtNomeTurno);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnCancelar);

            this.Text = "Cadastro de Turno";
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