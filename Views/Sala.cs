using System;
using System.Drawing;
using System.Windows.Forms;

namespace reserva_salas_csharp.Views
{
  public class Sala : Form
  {

    private Label titulo;
    private Label lblNome;
    private TextBox txtNome;
    private Button btnSalvar;
    private Button btnVoltar;
    private ListView lista;
    private Button btnEditar;
    private Button btnExcluir;


    public Sala(Form formularioAnterior)
    {
      InitializeComponent(formularioAnterior);
    }

    public void InitializeComponent(Form formularioAnterior)
    {
      this.titulo = new Label();
      this.lista = new ListView();
      this.btnSalvar = new Button();
      this.btnEditar = new Button();
      this.btnExcluir = new Button();
      this.btnVoltar = new Button();

      this.titulo.Text = "Lista de Salas";
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
      this.lista.Columns.Add("N° Sala", 100);
      this.lista.Columns.Add("N° Andar", 100);

      this.LoadList();

      btnSalvar.BackColor = Color.FromArgb(167, 228, 141);
      btnSalvar.Cursor = Cursors.Hand;
      btnSalvar.FlatAppearance.BorderSize = 0;
      btnSalvar.FlatStyle = FlatStyle.Flat;
      btnSalvar.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
      btnSalvar.Location = new Point(10, 450);
      btnSalvar.Name = "btnIncluir";
      btnSalvar.Size = new Size(90, 30);
      btnSalvar.TabIndex = 2;
      btnSalvar.Text = "incluir";
      btnSalvar.UseVisualStyleBackColor = false;

      this.btnSalvar.Click += (sender, e) =>
      {
        new CadastroSala(0, formularioAnterior);
        this.LoadList();
      };
       
      btnEditar.BackColor = Color.FromArgb(255,242,130);
      btnEditar.Cursor = Cursors.Hand;
      btnEditar.FlatAppearance.BorderSize = 0;
      btnEditar.FlatStyle = FlatStyle.Flat;
      btnEditar.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
      btnEditar.Location = new Point(110, 450);
      btnEditar.Name = "btnEditar";
      btnEditar.Size = new Size(90, 30);
      btnEditar.TabIndex = 2;
      btnEditar.Text = "Editar";
      btnEditar.UseVisualStyleBackColor = false;
      
      this.btnEditar.Click += (sender, e) =>
      {
        new CadastroSala(
          int.Parse(this.lista.SelectedItems[0].Text), formularioAnterior
        );
        this.LoadList();
      };

      btnExcluir.BackColor = Color.FromArgb(255, 105, 97);
      btnExcluir.Cursor = Cursors.Hand;
      btnExcluir.FlatAppearance.BorderSize = 0;
      btnExcluir.FlatStyle = FlatStyle.Flat;
      btnExcluir.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
      btnExcluir.Location = new Point(210, 450);
      btnExcluir.Name = "btnExcluir";
      btnExcluir.Size = new Size(90, 30);
      btnExcluir.TabIndex = 2;
      btnExcluir.Text = "Excluir";
      btnExcluir.UseVisualStyleBackColor = false;

      this.btnExcluir.Click += (sender, e) =>
      {
        DialogResult result = MessageBox.Show(
          "Deseja realmente excluir a sala?",
          "Excluir Sala",
          MessageBoxButtons.YesNo,
          MessageBoxIcon.Question
        );

        if (result == DialogResult.No) return;

        Controllers.Sala.ExcluirSala(
          this.lista.SelectedItems[0].Text
        );
        this.LoadList();

      };

        btnVoltar.BackColor = Color.FromArgb(190,190,190);
        btnVoltar.Cursor = Cursors.Hand;
        btnVoltar.FlatAppearance.BorderSize = 0;
        btnVoltar.FlatStyle = FlatStyle.Flat;
        btnVoltar.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
        btnVoltar.Location = new Point(310, 450);
        btnVoltar.Name = "btnVoltar";
        btnVoltar.Size = new Size(90, 30);
        btnVoltar.TabIndex = 2;
        btnVoltar.Text = "Voltar";
        btnVoltar.UseVisualStyleBackColor = false;
        btnVoltar.Click += new EventHandler((sender, e) => this.VoltarButtonClick(formularioAnterior));

        this.Controls.Add(this.titulo);
        this.Controls.Add(this.lista);
        this.Controls.Add(this.btnSalvar);
        this.Controls.Add(this.btnEditar);
        this.Controls.Add(this.btnExcluir);
        this.Controls.Add(this.btnVoltar);

        this.Text = "Salas";
        this.Size = new Size(750, 600);
        this.StartPosition = FormStartPosition.CenterScreen;
        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;

        this.MaximizeBox = false;
        this.MinimizeBox = false;
        this.ShowIcon = false;
        this.ShowInTaskbar = false;
        this.TopMost = true;

    }

    private void LoadList()
    {
      this.lista.Items.Clear();

      foreach (Models.Sala sala in Controllers.Sala.GetAllSalas())
      {
        ListViewItem item = new ListViewItem(sala.id.ToString());
        item.SubItems.Add(sala.numeroSala.ToString());
        item.SubItems.Add(sala.numeroAndar.ToString());
        this.lista.Items.Add(item);
      }
    }

    private void VoltarButtonClick(Form formularioAnterior)
    {
      this.Close();
      formularioAnterior.Activate();
    }
  }
}