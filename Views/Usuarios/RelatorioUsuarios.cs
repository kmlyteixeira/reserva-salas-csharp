using System;
using System.Drawing;
using System.Windows.Forms;
using reserva_salas_csharp.Models;

namespace reserva_salas_csharp.Views
{
    public class RelatorioUsuarios : Form
    {

        private Label titulo;
        private Button btnVoltar;
        private ListView lista;
        private Usuario user;


        public RelatorioUsuarios(Form formularioAnterior, Usuario user)
        {
            this.user = user;
            InitializeComponent(formularioAnterior);
        }

        public void InitializeComponent(Form formularioAnterior)
        {
            this.titulo = new Label();
            this.lista = new ListView();
            this.btnVoltar = new Button();

            this.titulo.Text = "Lista de Usuários";
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
            this.lista.Columns.Add("Nome", 100);
            this.lista.Columns.Add("Sobrenome", 100);
            this.lista.Columns.Add("CPF", 100);
            this.lista.Columns.Add("Data Nascimento", 100);
            this.lista.Columns.Add("Tipo Usuário", 100);
            this.lista.Columns.Add("Email", 100);
            this.lista.Columns.Add("UserName", 100);

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

            this.Text = "Usuários";
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

            IEnumerable<Usuario> usuarios = Controllers.Usuario.GetAllUsuarios();

            foreach (var a in usuarios)
            {
                ListViewItem item = new ListViewItem(a.Id.ToString());
                item.SubItems.Add(a.Nome);
                item.SubItems.Add(a.Sobrenome);
                item.SubItems.Add(a.CPF);
                item.SubItems.Add(a.DataNascimento);
                if (a.TipoUsuarioId == 1)
                    item.SubItems.Add("Administrador");
                else if (a.TipoUsuarioId == 2)
                    item.SubItems.Add("Usuário");
                item.SubItems.Add(a.Email);
                item.SubItems.Add(a.UserName);
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