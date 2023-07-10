using System;
using System.Drawing;
using System.Windows.Forms;
using reserva_salas_csharp.Models;

namespace reserva_salas_csharp.Views
{
    public class RelatorioHigienizacoes : Form
    {

        private Label titulo;
        private Button btnVoltar;
        private ListView lista;
        private Usuario user;


        public RelatorioHigienizacoes(Form formularioAnterior, Usuario user)
        {
            this.user = user;
            InitializeComponent(formularioAnterior);
        }

        public void InitializeComponent(Form formularioAnterior)
        {
            this.titulo = new Label();
            this.lista = new ListView();
            this.btnVoltar = new Button();

            this.titulo.Text = "Lista de Higienizações";
            this.titulo.Location = new Point(10, 10);
            this.titulo.AutoSize = true;
            this.titulo.TextAlign = ContentAlignment.MiddleCenter;
            this.titulo.Font = new Font("Century Gothic", 20, FontStyle.Bold);

            this.lista.Location = new Point(10, 50);
            this.lista.Size = new Size(700, 400);
            this.lista.View = View.Details;
            this.lista.FullRowSelect = true;
            this.lista.GridLines = true;
            this.lista.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            this.lista.Columns.Add("Id", 50);
            this.lista.Columns.Add("Observação", 100);
            this.lista.Columns.Add("Data Higienização", 100);
            this.lista.Columns.Add("Sala", 100);
            this.lista.Columns.Add("Turno", 100);
            this.lista.Columns.Add("Funcionário", 100);

            this.LoadList();

            btnVoltar.BackColor = Color.FromArgb(190, 190, 190);
            btnVoltar.Cursor = Cursors.Hand;
            btnVoltar.FlatAppearance.BorderSize = 0;
            btnVoltar.FlatStyle = FlatStyle.Flat;
            btnVoltar.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnVoltar.Location = new Point(10, 450);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(90, 30);
            btnVoltar.TabIndex = 2;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = false;
            btnVoltar.Click += new EventHandler((sender, e) => this.VoltarButtonClick(formularioAnterior));

            this.Controls.Add(this.titulo);
            this.Controls.Add(this.lista);
            this.Controls.Add(this.btnVoltar);

            this.Text = "Higienizações";
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

            IEnumerable<Higienizacao> higienizacoes = Controllers.Higienizacao.mostrarAllHigien();

            foreach (var a in higienizacoes)
            {
                ListViewItem item = new ListViewItem(a.Id.ToString());
                item.SubItems.Add(a.Observacao);
                item.SubItems.Add(a.Data.ToString("dd/MM/yyyy"));
                item.SubItems.Add(Controllers.Sala.GetSalas(a.idSala).numeroSala.ToString());
                item.SubItems.Add(Controllers.Turno.GetTurnos(a.idTurno).descricao.ToString());
                item.SubItems.Add(Controllers.Funcionario.mostrarAllFunc().Where(f => f.Id == a.idFuncionario).FirstOrDefault().Nome.ToString());
                this.lista.Items.Add(item);
            }

            this.lista.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
        }

        private void VoltarButtonClick(Form formularioAnterior)
        {
            this.Close();
            formularioAnterior.Activate();
        }
    }
}