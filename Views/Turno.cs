using System;
using System.Drawing;
using System.Windows.Forms;

namespace Views
{
  public class Turno : Form
  {

    private Label titulo;
    private Label lblNome;
    private TextBox txtNome;
    private Button btnSalvar;
    private Button btnCancelar;
    private ListView lista;
    private Button btnEditar;
    private Button btnExcluir;


    public Turno()
    {
      InitializeComponent();
    }

    public void InitializeComponent()
    {
      this.titulo = new Label();
      this.lista = new ListView();
      this.btnSalvar = new Button();
      this.btnEditar = new Button();
      this.btnExcluir = new Button();
      this.btnCancelar = new Button();

      this.titulo.Text = "Lista de Turnos";
      this.titulo.Location = new Point(10, 10);
      this.titulo.Size = new Size(280, 30);
      this.titulo.TextAlign = ContentAlignment.MiddleCenter;
      this.titulo.Font = new Font("Arial", 20, FontStyle.Bold);

      this.lista.Location = new Point(10, 50);
      this.lista.Size = new Size(590, 400);
      this.lista.View = View.Details;
      this.lista.FullRowSelect = true;
      this.lista.GridLines = true;
      this.lista.Columns.Add("Id", 50);
      this.lista.Columns.Add("Descrição", 100);

      this.LoadList();

      this.btnSalvar.Text = "Incluir";
      this.btnSalvar.Location = new Point(10, 450);
      this.btnSalvar.Size = new Size(90, 30);
      this.btnSalvar.Font = new Font("Arial", 12, FontStyle.Bold);
      this.btnSalvar.Click += (sender, e) =>
      {
        new CadastroTurno(0);
        this.LoadList();
      };

      this.btnEditar.Text = "Editar";
      this.btnEditar.Location = new Point(110, 450);
      this.btnEditar.Size = new Size(90, 30);
      this.btnEditar.Font = new Font("Arial", 12, FontStyle.Bold);
      this.btnEditar.Click += (sender, e) =>
      {
        new CadastroTurno(
          int.Parse(this.lista.SelectedItems[0].Text)
        );
        this.LoadList();
      };

      this.btnExcluir.Text = "Excluir";
      this.btnExcluir.Location = new Point(210, 450);
      this.btnExcluir.Size = new Size(90, 30);
      this.btnExcluir.Font = new Font("Arial", 12, FontStyle.Bold);
      this.btnExcluir.Click += (sender, e) =>
      {
        DialogResult result = MessageBox.Show(
          "Deseja realmente excluir o turno?",
          "Excluir Turno",
          MessageBoxButtons.YesNo,
          MessageBoxIcon.Question
        );

        if (result == DialogResult.No) return;

        Controllers.Turno.ExcluirTurno(
          this.lista.SelectedItems[0].Text
        );

        this.LoadList();

      };

      this.btnCancelar.Text = "Voltar";
      this.btnCancelar.Location = new Point(310, 450);
      this.btnCancelar.Size = new Size(90, 30);
      this.btnCancelar.Font = new Font("Arial", 12, FontStyle.Bold);
      this.btnCancelar.Click += (sender, e) => this.Close();

      this.Controls.Add(this.titulo);
      this.Controls.Add(this.lista);
      this.Controls.Add(this.btnSalvar);
      this.Controls.Add(this.btnEditar);
      this.Controls.Add(this.btnExcluir);
      this.Controls.Add(this.btnCancelar);

      this.Text = "Turnos";
      this.Size = new Size(750, 600);
      this.StartPosition = FormStartPosition.CenterScreen;
      this.FormBorderStyle = FormBorderStyle.FixedSingle;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.ShowIcon = false;
      this.ShowInTaskbar = false;
      this.TopMost = true;

      this.ShowDialog();

    }

    private void LoadList()
    {
      this.lista.Items.Clear();

      foreach (Models.Turno turno in Controllers.Turno.GetAllTurnos())
      {
        ListViewItem item = new ListViewItem(turno.id.ToString());
        item.SubItems.Add(turno.descricao.ToString());
        this.lista.Items.Add(item);
      }
    }
  }
}