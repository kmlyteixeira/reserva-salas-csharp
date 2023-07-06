using Microsoft.AspNetCore.Mvc;
using reserva_salas_csharp.Controllers;

namespace reserva_salas_csharp.Views
{
    public class Home : Form
    {
        private Panel panel1;
        private Button buttonAddAgendamento;
        private Label labelBemVindo;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem usuariosToolStripMenuItem;
        private Panel panel2;
        private DataGridView dataGridViewCalendar;
        private ToolStripMenuItem funcionárioToolStripMenuItem;
        private ToolStripMenuItem salaToolStripMenuItem;
        private ToolStripMenuItem turnoToolStripMenuItem;
        private ToolStripMenuItem agendamentoToolStripMenuItem;
        private ToolStripMenuItem novoAgendamentoToolStripMenuItem;
        private ToolStripMenuItem meusAgendamentosToolStripMenuItem;
        private Label labelTurno3;
        private Label labelTurno;
        private Panel panel5;
        private Panel panel11;
        private Label labelTurnoDesc3;
        private Button buttonTurnoAgendar3;
        private Panel panel4;
        private Panel panel10;
        private Label labelVerMais;
        private Label labelDescAgenda2;
        private Label labelDescAgenda;
        private Button buttonTurnoAgendar2;
        private Label labelTurno2;
        private Panel panel3;
        private Panel panel9;
        private Label labelTurnoDesc;
        private Button buttonTurnoAgendar;
        private Label labelCalendar;
        private Button buttonCalendar2;
        private Button buttonCalendar;
        private Panel panel12;
        private PictureBox pictureBoxSair;
        private ComboBox comboBoxSala;
        private Label labelSala;
        private Label toolTipLabel;
        private int monthConst;
        private Label labelNameTurno1;
        private Label labelTurno1;
        private Label labelVerMais1;
        private Label labelVerMais2;
        private Label labelTurnoDesc2;
        private Label labelNameTurno2;
        private Label labelNameTurno;
        private Label labelVerMais3;
        private Label labelNameTurno3;
        private Form formularioAnterior;

        public Home(Models.Usuario usuario)
        {
            InitializeComponent(usuario);
        }

        private void InitializeComponent(Models.Usuario usuario)
        {
            panel1 = new Panel();
            panel2 = new Panel();
            labelCalendar = new Label();
            dataGridViewCalendar = new DataGridView();
            buttonCalendar = new Button();
            buttonCalendar2 = new Button();
            panel12 = new Panel();
            panel5 = new Panel();
            labelTurno3 = new Label();
            panel11 = new Panel();
            labelTurnoDesc3 = new Label();
            buttonTurnoAgendar3 = new Button();
            panel3 = new Panel();
            labelTurno = new Label();
            panel9 = new Panel();
            labelTurnoDesc = new Label();
            buttonTurnoAgendar = new Button();
            panel4 = new Panel();
            labelTurno2 = new Label();
            panel10 = new Panel();
            labelVerMais = new Label();
            labelDescAgenda2 = new Label();
            labelDescAgenda = new Label();
            buttonTurnoAgendar2 = new Button();
            buttonAddAgendamento = new Button();
            labelBemVindo = new Label();
            menuStrip1 = new MenuStrip();
            toolStripMenuItem1 = new ToolStripMenuItem();
            usuariosToolStripMenuItem = new ToolStripMenuItem();
            funcionárioToolStripMenuItem = new ToolStripMenuItem();
            salaToolStripMenuItem = new ToolStripMenuItem();
            turnoToolStripMenuItem = new ToolStripMenuItem();
            agendamentoToolStripMenuItem = new ToolStripMenuItem();
            novoAgendamentoToolStripMenuItem = new ToolStripMenuItem();
            meusAgendamentosToolStripMenuItem = new ToolStripMenuItem();
            pictureBoxSair = new PictureBox();
            labelSala = new Label();
            comboBoxSala = new ComboBox();
            toolTipLabel = new Label();
            labelNameTurno1 = new Label();
            labelNameTurno = new Label();
            labelTurno1 = new Label();
            labelVerMais1 = new Label();
            labelVerMais2 = new Label();
            labelTurnoDesc2 = new Label();
            labelNameTurno2 = new Label();
            labelVerMais3 = new Label();
            labelNameTurno3 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCalendar).BeginInit();
            panel12.SuspendLayout();
            panel5.SuspendLayout();
            panel11.SuspendLayout();
            panel3.SuspendLayout();
            panel9.SuspendLayout();
            panel4.SuspendLayout();
            panel10.SuspendLayout();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSair).BeginInit();
            SuspendLayout();
            this.monthConst = 6;
            formularioAnterior = this;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(comboBoxSala);
            panel1.Controls.Add(toolTipLabel);
            panel1.Controls.Add(labelSala);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(panel12);
            panel1.ForeColor = Color.FromArgb(127, 103, 186);
            panel1.Location = new Point(11, 158);
            panel1.Name = "panel1";
            panel1.Size = new Size(930, 535);
            panel1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Controls.Add(labelCalendar);
            panel2.Controls.Add(dataGridViewCalendar);
            panel2.Controls.Add(buttonCalendar);
            panel2.Controls.Add(buttonCalendar2);
            panel2.Location = new Point(22, 82);
            panel2.Name = "panel2";
            panel2.Size = new Size(425, 386);
            panel2.TabIndex = 0;
            panel2.Enabled = false;
            // 
            // labelCalendar
            // 
            labelCalendar.AutoSize = true;
            labelCalendar.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            labelCalendar.ForeColor = Color.Black;
            labelCalendar.Location = new Point(154, 15);
            labelCalendar.Name = "labelCalendar";
            labelCalendar.Size = new Size(126, 19);
            labelCalendar.TabIndex = 5;
            getLabelCalendar(this.monthConst);
            // 
            // dataGridViewCalendar
            // 
            dataGridViewCalendar.AllowUserToAddRows = false;
            dataGridViewCalendar.AllowUserToDeleteRows = false;
            dataGridViewCalendar.AllowUserToResizeColumns = false;
            dataGridViewCalendar.AllowUserToResizeRows = false;
            dataGridViewCalendar.Enabled = false;
            dataGridViewCalendar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCalendar.Location = new Point(3, 46);
            dataGridViewCalendar.Name = "dataGridViewCalendar";
            dataGridViewCalendar.RowHeadersWidth = 51;
            dataGridViewCalendar.RowTemplate.Height = 29;
            dataGridViewCalendar.Size = new Size(419, 337);
            dataGridViewCalendar.TabIndex = 0;
            dataGridViewCalendar.CellContentClick += new DataGridViewCellEventHandler(dataGridViewCalendar_CellContentClickAsync);
            dataGridViewCalendar.AutoGenerateColumns = false;
            dataGridViewCalendar.RowHeadersVisible = false;
            dataGridViewCalendar.ReadOnly = true;
            dataGridViewCalendar.ScrollBars = ScrollBars.None;
            dataGridViewCalendar.DefaultCellStyle.WrapMode = DataGridViewTriState.False; 
            dataGridViewCalendar.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCalendar.Columns.Add("Domingo", "DOM");
            dataGridViewCalendar.Columns.Add("Segunda", "SEG");
            dataGridViewCalendar.Columns.Add("Terca", "TER");
            dataGridViewCalendar.Columns.Add("Quarta", "QUA");
            dataGridViewCalendar.Columns.Add("Quinta", "QUI");
            dataGridViewCalendar.Columns.Add("Sexta", "SEX");
            dataGridViewCalendar.Columns.Add("Sabado", "SAB");
            CarregaDadosGrid(monthConst);

            // 
            // buttonCalendar
            // 
            buttonCalendar.BackColor = Color.Silver;
            buttonCalendar.Cursor = Cursors.Hand;
            buttonCalendar.FlatAppearance.BorderSize = 0;
            buttonCalendar.FlatStyle = FlatStyle.Flat;
            buttonCalendar.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            buttonCalendar.ForeColor = SystemColors.ControlText;
            buttonCalendar.Location = new Point(3, 3);
            buttonCalendar.Name = "buttonCalendar";
            buttonCalendar.Size = new Size(72, 42);
            buttonCalendar.TabIndex = 7;
            buttonCalendar.Text = "<";
            buttonCalendar.UseVisualStyleBackColor = false;
            buttonCalendar.Click += new System.EventHandler((sender, e) => this.buttonCalendar_Click());
            buttonCalendar.Enabled = false;
            // 
            // buttonCalendar2
            // 
            buttonCalendar2.BackColor = Color.Silver;
            buttonCalendar2.Cursor = Cursors.Hand;
            buttonCalendar2.FlatAppearance.BorderSize = 0;
            buttonCalendar2.FlatStyle = FlatStyle.Flat;
            buttonCalendar2.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            buttonCalendar2.ForeColor = SystemColors.ControlText;
            buttonCalendar2.Location = new Point(345, 3);
            buttonCalendar2.Name = "buttonCalendar2";
            buttonCalendar2.Size = new Size(77, 42);
            buttonCalendar2.TabIndex = 8;
            buttonCalendar2.Text = ">";
            buttonCalendar2.UseVisualStyleBackColor = false;
            buttonCalendar2.Click += new System.EventHandler((sender, e) => this.buttonCalendar2_Click());
            buttonCalendar2.Enabled = false;
            // 
            // panel12
            // 
            panel12.Controls.Add(panel5);
            panel12.Controls.Add(panel3);
            panel12.Controls.Add(panel4);
            panel12.Location = new Point(501, 82);
            panel12.Name = "panel12";
            panel12.Size = new Size(386, 386);
            panel12.TabIndex = 4;
            panel12.Enabled = false;
            // 
            // panel5
            // 
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(labelTurno3);
            panel5.Controls.Add(panel11);
            panel5.Controls.Add(buttonTurnoAgendar3);
            panel5.Location = new Point(13, 282);
            panel5.Name = "panel5";
            panel5.Size = new Size(364, 73);
            panel5.TabIndex = 3;
            // 
            // labelTurno3
            // 
            labelTurno3.AutoSize = true;
            labelTurno3.Font = new Font("Microsoft Sans Serif", 7.20000029F, FontStyle.Bold, GraphicsUnit.Point);
            labelTurno3.ForeColor = Color.Black;
            labelTurno3.Location = new Point(5, 27);
            labelTurno3.Name = "labelTurno3";
            labelTurno3.Size = new Size(92, 16);
            labelTurno3.TabIndex = 8;
            labelTurno3.Text = "18:00 - 22:00";
            // 
            // panel11
            // 
            panel11.Controls.Add(labelVerMais3);
            panel11.Controls.Add(labelNameTurno3);
            panel11.Controls.Add(labelTurnoDesc3);
            panel11.Location = new Point(109, 3);
            panel11.Name = "panel11";
            panel11.Size = new Size(155, 65);
            panel11.TabIndex = 8;
            // 
            // labelVerMais3
            // 
            labelVerMais3.AutoSize = true;
            labelVerMais3.Cursor = Cursors.Hand;
            labelVerMais3.Font = new Font("Century Gothic", 6F, FontStyle.Regular, GraphicsUnit.Point);
            labelVerMais3.ForeColor = Color.DimGray;
            labelVerMais3.Location = new Point(84, 33);
            labelVerMais3.Name = "labelVerMais3";
            labelVerMais3.Size = new Size(47, 12);
            labelVerMais3.TabIndex = 13;
            labelVerMais3.Text = "Ver mais...";
            labelVerMais3.Click += label9_Click;
            labelVerMais3.Visible = false;
            // 
            // labelTurnoDesc3
            // 
            labelTurnoDesc3.AutoSize = true;
            labelTurnoDesc3.Font = new Font("Century Gothic", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            labelTurnoDesc3.ForeColor = Color.Black;
            labelTurnoDesc3.Location = new Point(7, 17);
            labelTurnoDesc3.Name = "labelTurnoDesc3";
            labelTurnoDesc3.Size = new Size(109, 16);
            labelTurnoDesc3.TabIndex = 11;
            labelTurnoDesc3.Text = "Turno disponível";
            // 
            // labelNameTurno3
            // 
            labelNameTurno3.AutoSize = true;
            labelNameTurno3.Font = new Font("Century Gothic", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            labelNameTurno3.ForeColor = Color.FromArgb(127, 103, 186);
            labelNameTurno3.Location = new Point(6, 3);
            labelNameTurno3.Name = "labelNameTurno3";
            labelNameTurno3.Size = new Size(44, 15);
            labelNameTurno3.TabIndex = 11;
            labelNameTurno3.Text = "Fulano";
            labelNameTurno3.Visible = false;
            // 
            // buttonTurnoAgendar3
            // 
            buttonTurnoAgendar3.BackColor = Color.FromArgb(167, 228, 141);
            buttonTurnoAgendar3.Cursor = Cursors.Hand;
            buttonTurnoAgendar3.FlatAppearance.BorderSize = 0;
            buttonTurnoAgendar3.FlatStyle = FlatStyle.Flat;
            buttonTurnoAgendar3.Font = new Font("Century Gothic", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            buttonTurnoAgendar3.ForeColor = SystemColors.ControlText;
            buttonTurnoAgendar3.Location = new Point(270, 14);
            buttonTurnoAgendar3.Name = "buttonTurnoAgendar3";
            buttonTurnoAgendar3.Size = new Size(84, 42);
            buttonTurnoAgendar3.TabIndex = 7;
            buttonTurnoAgendar3.Text = "Agendar";
            buttonTurnoAgendar3.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(labelTurno);
            panel3.Controls.Add(panel9);
            panel3.Controls.Add(buttonTurnoAgendar);
            panel3.Location = new Point(13, 29);
            panel3.Name = "panel3";
            panel3.Size = new Size(364, 73);
            panel3.TabIndex = 1;
            // 
            // labelTurno
            // 
            labelTurno.AutoSize = true;
            labelTurno.Font = new Font("Microsoft Sans Serif", 7.20000029F, FontStyle.Bold, GraphicsUnit.Point);
            labelTurno.ForeColor = Color.Black;
            labelTurno.Location = new Point(5, 28);
            labelTurno.Name = "labelTurno";
            labelTurno.Size = new Size(92, 16);
            labelTurno.TabIndex = 6;
            labelTurno.Text = "08:00 - 12:00";
            // 
            // panel9
            // 
            panel9.Controls.Add(labelVerMais1);
            panel9.Controls.Add(labelTurno1);
            panel9.Controls.Add(labelNameTurno1);
            panel9.Location = new Point(109, 3);
            panel9.Name = "panel9";
            panel9.Size = new Size(155, 65);
            panel9.TabIndex = 6;
            // 
            // labelVerMais1
            // 
            labelVerMais1.AutoSize = true;
            labelVerMais1.Cursor = Cursors.Hand;
            labelVerMais1.Font = new Font("Century Gothic", 6F, FontStyle.Regular, GraphicsUnit.Point);
            labelVerMais1.ForeColor = Color.DimGray;
            labelVerMais1.Location = new Point(84, 34);
            labelVerMais1.Name = "labelVerMais1";
            labelVerMais1.Size = new Size(47, 12);
            labelVerMais1.TabIndex = 13;
            labelVerMais1.Text = "Ver mais...";
            labelVerMais1.Click += label9_Click;
            labelVerMais1.Visible = false;
            // 
            // labelTurno1
            // 
            labelTurno1.AutoSize = true;
            labelTurno1.Font = new Font("Century Gothic", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            labelTurno1.ForeColor = Color.Black;
            labelTurno1.Location = new Point(7, 17);
            labelTurno1.Name = "labelTurno1";
            labelTurno1.Size = new Size(109, 16);
            labelTurno1.TabIndex = 11;
            labelTurno1.Text = "Turno disponível";
            // 
            // labelNameTurno1
            // 
            labelNameTurno1.AutoSize = true;
            labelNameTurno1.Font = new Font("Century Gothic", 7.8F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            labelNameTurno1.ForeColor = Color.FromArgb(127, 103, 186);
            labelNameTurno1.Location = new Point(6, 3);
            labelNameTurno1.Name = "labelNameTurno1";
            labelNameTurno1.Size = new Size(44, 15);
            labelNameTurno1.TabIndex = 11;
            labelNameTurno1.Text = "Fulano";
            labelNameTurno1.Visible = false;
            // 
            // buttonTurnoAgendar
            // 
            buttonTurnoAgendar.BackColor = Color.FromArgb(167, 228, 141);
            buttonTurnoAgendar.Cursor = Cursors.Hand;
            buttonTurnoAgendar.FlatAppearance.BorderSize = 0;
            buttonTurnoAgendar.FlatStyle = FlatStyle.Flat;
            buttonTurnoAgendar.Font = new Font("Century Gothic", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            buttonTurnoAgendar.ForeColor = SystemColors.ControlText;
            buttonTurnoAgendar.Location = new Point(270, 13);
            buttonTurnoAgendar.Name = "buttonTurnoAgendar";
            buttonTurnoAgendar.Size = new Size(84, 42);
            buttonTurnoAgendar.TabIndex = 5;
            buttonTurnoAgendar.Text = "Agendar";
            buttonTurnoAgendar.UseVisualStyleBackColor = false;
            // 
            // panel4
            // 
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(labelTurno2);
            panel4.Controls.Add(panel10);
            panel4.Controls.Add(buttonTurnoAgendar2);
            panel4.Location = new Point(13, 156);
            panel4.Name = "panel4";
            panel4.Size = new Size(364, 73);
            panel4.TabIndex = 2;
            // 
            // labelTurno2
            // 
            labelTurno2.AutoSize = true;
            labelTurno2.Font = new Font("Microsoft Sans Serif", 7.20000029F, FontStyle.Bold, GraphicsUnit.Point);
            labelTurno2.ForeColor = Color.Black;
            labelTurno2.Location = new Point(5, 28);
            labelTurno2.Name = "labelTurno2";
            labelTurno2.Size = new Size(92, 16);
            labelTurno2.TabIndex = 7;
            labelTurno2.Text = "13:00 - 17:00";
            // 
            // panel10 - TURNO 2
            // 
            panel10.Controls.Add(labelVerMais2);
            panel10.Controls.Add(labelTurnoDesc2);
            panel10.Controls.Add(labelNameTurno2);
            panel10.Controls.Add(labelVerMais);
            panel10.Controls.Add(labelDescAgenda2);
            panel10.Controls.Add(labelDescAgenda);
            panel10.Location = new Point(109, 3);
            panel10.Name = "panel10";
            panel10.Size = new Size(155, 65);
            panel10.TabIndex = 7;
            // 
            // labelVerMais2
            // 
            labelVerMais2.AutoSize = true;
            labelVerMais2.Cursor = Cursors.Hand;
            labelVerMais2.Font = new Font("Century Gothic", 6F, FontStyle.Regular, GraphicsUnit.Point);
            labelVerMais2.ForeColor = Color.DimGray;
            labelVerMais2.Location = new Point(80, 34);
            labelVerMais2.Name = "labelVerMais2";
            labelVerMais2.Size = new Size(47, 12);
            labelVerMais2.TabIndex = 10;
            labelVerMais2.Text = "Ver mais...";
            labelVerMais2.Click += label9_Click;
            labelVerMais2.Visible = false;
            // 
            // labelTurnoDesc2
            // 
            labelTurnoDesc2.AutoSize = true;
            labelTurnoDesc2.Font = new Font("Century Gothic", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            labelTurnoDesc2.ForeColor = Color.Black;
            labelTurnoDesc2.Location = new Point(3, 18);
            labelTurnoDesc2.Name = "labelTurnoDesc2";
            labelTurnoDesc2.Size = new Size(109, 16);
            labelTurnoDesc2.TabIndex = 9;
            labelTurnoDesc2.Text = "Turno disponível";
            // 
            // labelNameTurno2
            // 
            labelNameTurno2.AutoSize = true;
            labelNameTurno2.Font = new Font("Century Gothic", 7.8F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            labelNameTurno2.ForeColor = Color.FromArgb(127, 103, 186);
            labelNameTurno2.Location = new Point(2, 4);
            labelNameTurno2.Name = "labelNameTurno2";
            labelNameTurno2.Size = new Size(44, 15);
            labelNameTurno2.TabIndex = 11;
            labelNameTurno2.Text = "Fulano";
            labelNameTurno2.Visible = false;
            // 
            // buttonTurnoAgendar2
            // 
            buttonTurnoAgendar2.BackColor = Color.FromArgb(167, 228, 141);
            buttonTurnoAgendar2.Cursor = Cursors.Hand;
            buttonTurnoAgendar2.FlatAppearance.BorderSize = 0;
            buttonTurnoAgendar2.FlatStyle = FlatStyle.Flat;
            buttonTurnoAgendar2.Font = new Font("Century Gothic", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            buttonTurnoAgendar2.ForeColor = SystemColors.ControlText;
            buttonTurnoAgendar2.Location = new Point(270, 14);
            buttonTurnoAgendar2.Name = "buttonTurnoAgendar2";
            buttonTurnoAgendar2.Size = new Size(84, 42);
            buttonTurnoAgendar2.TabIndex = 6;
            buttonTurnoAgendar2.Text = "Agendar";
            buttonTurnoAgendar2.UseVisualStyleBackColor = false;
            // 
            // buttonAddAgendamento
            // 
            buttonAddAgendamento.BackColor = Color.FromArgb(193, 167, 255);
            buttonAddAgendamento.Cursor = Cursors.Hand;
            buttonAddAgendamento.FlatAppearance.BorderSize = 0;
            buttonAddAgendamento.FlatStyle = FlatStyle.Flat;
            buttonAddAgendamento.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            buttonAddAgendamento.ForeColor = SystemColors.ControlText;
            buttonAddAgendamento.Location = new Point(767, 110);
            buttonAddAgendamento.Name = "buttonAddAgendamento";
            buttonAddAgendamento.Size = new Size(174, 42);
            buttonAddAgendamento.TabIndex = 3;
            buttonAddAgendamento.Text = "Novo Agendamento";
            buttonAddAgendamento.UseVisualStyleBackColor = false;
            buttonAddAgendamento.Click += button2_Click;
            // 
            // labelBemVindo
            // 
            labelBemVindo.AutoSize = true;
            labelBemVindo.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            labelBemVindo.Location = new Point(11, 70);
            labelBemVindo.Name = "labelBemVindo";
            labelBemVindo.Size = new Size(369, 27);
            labelBemVindo.TabIndex = 0;
            labelBemVindo.Text = "Seja bem vindo, " + usuario.Nome + "!";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(953, 28);
            menuStrip1.TabIndex = 4;
            menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { usuariosToolStripMenuItem, funcionárioToolStripMenuItem, salaToolStripMenuItem, turnoToolStripMenuItem, agendamentoToolStripMenuItem });
            toolStripMenuItem1.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            toolStripMenuItem1.Image = Image.FromFile("Views/Resources/menu.png");
            toolStripMenuItem1.ImageAlign = ContentAlignment.BottomCenter;
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(34, 24);
            // 
            // usuariosToolStripMenuItem
            // 
            usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            usuariosToolStripMenuItem.Size = new Size(224, 26);
            usuariosToolStripMenuItem.Text = "Usuário";
            usuariosToolStripMenuItem.Click += usuariosToolStripMenuItem_Click;
            // 
            // funcionárioToolStripMenuItem
            // 
            funcionárioToolStripMenuItem.Name = "funcionárioToolStripMenuItem";
            funcionárioToolStripMenuItem.Size = new Size(224, 26);
            funcionárioToolStripMenuItem.Text = "Funcionário";
            funcionárioToolStripMenuItem.Click += funcionárioToolStripMenuItem_Click;
            // 
            // salaToolStripMenuItem
            // 
            salaToolStripMenuItem.Name = "salaToolStripMenuItem";
            salaToolStripMenuItem.Size = new Size(224, 26);
            salaToolStripMenuItem.Text = "Sala";
            salaToolStripMenuItem.Click += salaToolStripMenuItem_Click;
            // 
            // turnoToolStripMenuItem
            // 
            turnoToolStripMenuItem.Name = "turnoToolStripMenuItem";
            turnoToolStripMenuItem.Size = new Size(224, 26);
            turnoToolStripMenuItem.Text = "Turno";
            turnoToolStripMenuItem.Click += turnoToolStripMenuItem_Click;
            // 
            // agendamentoToolStripMenuItem
            // 
            agendamentoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { novoAgendamentoToolStripMenuItem, meusAgendamentosToolStripMenuItem });
            agendamentoToolStripMenuItem.Name = "agendamentoToolStripMenuItem";
            agendamentoToolStripMenuItem.Size = new Size(224, 26);
            agendamentoToolStripMenuItem.Text = "Agendamento";
            // 
            // novoAgendamentoToolStripMenuItem
            // 
            novoAgendamentoToolStripMenuItem.Name = "novoAgendamentoToolStripMenuItem";
            novoAgendamentoToolStripMenuItem.Size = new Size(249, 26);
            novoAgendamentoToolStripMenuItem.Text = "Novo Agendamento";
            novoAgendamentoToolStripMenuItem.Click += novoAgendamentoToolStripMenuItem_Click;
            // 
            // meusAgendamentosToolStripMenuItem
            // 
            meusAgendamentosToolStripMenuItem.Name = "meusAgendamentosToolStripMenuItem";
            meusAgendamentosToolStripMenuItem.Size = new Size(249, 26);
            meusAgendamentosToolStripMenuItem.Text = "Meus Agendamentos";
            meusAgendamentosToolStripMenuItem.Click += meusAgendamentosToolStripMenuItem_Click;
            // 
            // pictureBoxSair
            // 
            pictureBoxSair.BackgroundImageLayout = ImageLayout.Center;
            pictureBoxSair.Cursor = Cursors.Hand;
            pictureBoxSair.Image = Image.FromFile("Views/Resources/sair.png");
            pictureBoxSair.Location = new Point(911, 31);
            pictureBoxSair.Name = "pictureBoxSair";
            pictureBoxSair.Size = new Size(30, 30);
            pictureBoxSair.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxSair.TabIndex = 5;
            pictureBoxSair.TabStop = false;
            pictureBoxSair.Click += pictureBox1_Click_1;
            // 
            // labelSala
            // 
            labelSala.AutoSize = true;
            labelSala.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            labelSala.ForeColor = Color.Black;
            labelSala.Location = new Point(22, 15);
            labelSala.Name = "labelSala";
            labelSala.Size = new Size(129, 20);
            labelSala.TabIndex = 10;
            labelSala.Text = "Selecione a Sala";
            // 
            // comboBoxSala
            // 
            comboBoxSala.FormattingEnabled = true;
            comboBoxSala.Location = new Point(22, 38);
            comboBoxSala.Name = "comboBoxSala";
            comboBoxSala.Size = new Size(196, 28);
            comboBoxSala.TabIndex = 11;
            comboBoxSala.DataSource = Controllers.Sala.GetAllSalas().ToArray();
            comboBoxSala.DisplayMember = "NumeroSala";
            comboBoxSala.ValueMember = "Id";
            comboBoxSala.SelectedIndexChanged += comboBoxSala_SelectedIndexChanged;
            // tooltip labelSala

            toolTipLabel.AutoSize = true;
            toolTipLabel.Visible = true;
            toolTipLabel.BackColor = SystemColors.Info;
            toolTipLabel.ForeColor = SystemColors.InfoText;
            toolTipLabel.Font = new Font("Segoe UI", 9);
            toolTipLabel.Padding = new Padding(5);
            toolTipLabel.Text = "Selecione uma sala para começar!";
            toolTipLabel.Location = new Point(comboBoxSala.Height + comboBoxSala.Width, comboBoxSala.Top);
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(953, 753);
            ControlBox = false;
            Controls.Add(pictureBoxSair);
            Controls.Add(buttonAddAgendamento);
            Controls.Add(labelBemVindo);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.None;
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCalendar).EndInit();
            panel12.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel11.ResumeLayout(false);
            panel11.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            this.Deactivate += Form1_Deactivate;
            this.Activated += Form1_Activated;
            this.StartPosition = FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)pictureBoxSair).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void Form1_Activated(object? sender, EventArgs e)
        {
            this.Enabled = true;
            this.Opacity = 1;
        }

        private void Form1_Deactivate(object? sender, EventArgs e)
        {
            this.Enabled = false;
            this.Opacity = 0.75;
        }

        private void comboBoxSala_SelectedIndexChanged(object? sender, EventArgs e)
        {
            this.toolTipLabel.Visible = false;
            this.buttonCalendar.Enabled = !string.IsNullOrEmpty(comboBoxSala.Text);
            this.buttonCalendar2.Enabled = !string.IsNullOrEmpty(comboBoxSala.Text);
            this.panel12.Enabled = !string.IsNullOrEmpty(comboBoxSala.Text);
            this.panel2.Enabled = !string.IsNullOrEmpty(comboBoxSala.Text);
            this.dataGridViewCalendar.Enabled = !string.IsNullOrEmpty(comboBoxSala.Text);
        }

        private void CarregaDadosGrid(int monthConst)
        {
            foreach (Models.CalendarData dado in Controllers.Calendar.GetCalendarData(monthConst))
            {
                dataGridViewCalendar.Rows.Add(dado.Domingo, dado.Segunda, dado.Terca, dado.Quarta, dado.Quinta, dado.Sexta, dado.Sabado);
            }
            dataGridViewCalendar.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None; 
            dataGridViewCalendar.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter; 
            dataGridViewCalendar.DefaultCellStyle.Padding = new Padding(5);
            foreach (DataGridViewColumn column in dataGridViewCalendar.Columns) column.Width = 52; 
            foreach (DataGridViewRow row in dataGridViewCalendar.Rows) row.Height = 44; 
            for (int row = 0; row < dataGridViewCalendar.Rows.Count; row++)
            {
                for (int column = 0; column < dataGridViewCalendar.Columns.Count; column++)
                {
                    DataGridViewCell cell = dataGridViewCalendar.Rows[row].Cells[column];
                    if (cell.Value?.ToString() == "0") 
                    {
                        cell.Value = "";
                        cell.Style.BackColor = Color.Silver;
                        cell.ReadOnly = true;
                    }
                }
            }

        }

        private void buttonCalendar_Click()
        {
            monthConst -= 1;
            dataGridViewCalendar.Rows.Clear();
            CarregaDadosGrid(monthConst);
            dataGridViewCalendar.Refresh();
            getLabelCalendar(monthConst);
        }

        private void buttonCalendar2_Click()
        {
            monthConst += 1;
            dataGridViewCalendar.Rows.Clear();
            CarregaDadosGrid(monthConst);
            dataGridViewCalendar.Refresh();
            getLabelCalendar(monthConst);
        }

        private void getLabelCalendar(int monthConst)
        {
            switch (monthConst)
            {
                case 6:
                {
                    labelCalendar.Text = "junho de 2023";
                    labelCalendar.Refresh();
                    break;
                }

                case 7:
                {
                    labelCalendar.Text = "julho de 2023";
                    labelCalendar.Refresh();
                    break;
                }

                case 8:
                {
                    labelCalendar.Text = "agosto de 2023";
                    labelCalendar.Refresh();
                    break;
                }
            }
        }

        private void dataGridViewCalendar_CellContentClickAsync(object? sender, DataGridViewCellEventArgs e)
        {
            int sala = Convert.ToInt32(comboBoxSala.SelectedValue);

            var cell = this.dataGridViewCalendar.CurrentCell.Value.ToString();
            DateTime data = new DateTime(2023, monthConst, Convert.ToInt32(cell));

            var agendamentoTurno1 = Agendamento.GetAgendamentosBySalaTurnoData(sala.ToString(), "1", data);
            var agendamentoTurno2 = Agendamento.GetAgendamentosBySalaTurnoData(sala.ToString(), "2", data);
            var agendamentoTurno3 = Agendamento.GetAgendamentosBySalaTurnoData(sala.ToString(), "3", data);

            if (agendamentoTurno1 != null)
            {
                agendamentoTurno1.Usuario = Usuario.GetUsuario(agendamentoTurno1.UsuarioId.ToString());

                labelVerMais1.Visible = true;
                labelTurno1.Visible = true;
                labelNameTurno1.Visible = true;

                labelNameTurno1.Text = agendamentoTurno1.Usuario.Nome;
                labelNameTurno1.Refresh();

                labelTurno1.Text = agendamentoTurno1.Observacao;
                labelTurno1.Refresh();

                buttonTurnoAgendar.Text = "Cancelar";
                buttonTurnoAgendar.BackColor = Color.FromArgb(255,242,130);
                buttonTurnoAgendar.Refresh();

            } else 
            {
                labelVerMais1.Visible = false;
                labelTurno1.Visible = true;
                labelNameTurno1.Visible = false;

                labelTurno1.Text = "Turno disponível";
                labelTurno1.Refresh();

                buttonTurnoAgendar.Text = "Agendar";
                buttonTurnoAgendar.BackColor = Color.FromArgb(167, 228, 141);
                buttonTurnoAgendar.Refresh();

            }

            if (agendamentoTurno2 != null)
            {
                labelVerMais2.Visible = true;
                labelNameTurno2.Visible = true;

                labelVerMais2.Refresh();

                labelNameTurno2.Text = agendamentoTurno2.Usuario.Nome;
                labelNameTurno2.Refresh();

                labelTurno2.Text = agendamentoTurno2.Observacao;
                labelTurno2.Refresh();

                buttonTurnoAgendar2.Text = "Cancelar";
                buttonTurnoAgendar2.BackColor = Color.FromArgb(255,242,130);
                buttonTurnoAgendar2.Refresh();
            } else 
            {
                labelVerMais2.Visible = false;
                labelNameTurno2.Visible = false;

                labelNameTurno2.Text = "Turno disponível";
                labelNameTurno2.Refresh();

                buttonTurnoAgendar2.Text = "Agendar";
                buttonTurnoAgendar2.BackColor = Color.FromArgb(167, 228, 141);
                buttonTurnoAgendar2.Refresh();
            }

            if (agendamentoTurno3 != null)
            {
                labelVerMais3.Visible = true;
                labelTurno3.Visible = true;
                labelNameTurno3.Visible = true;

                labelNameTurno3.Text = agendamentoTurno3.Usuario.Nome;
                labelNameTurno3.Refresh();

                labelTurno3.Text = agendamentoTurno3.Observacao;
                labelTurno3.Refresh();

                buttonTurnoAgendar3.Text = "Cancelar";
                buttonTurnoAgendar3.BackColor = Color.FromArgb(255, 242, 130);
                buttonTurnoAgendar3.Refresh();
            } else 
            {
                labelVerMais3.Visible = false;
                labelNameTurno3.Visible = false;

                labelNameTurno3.Text = "Turno disponível";
                labelNameTurno3.Refresh();

                buttonTurnoAgendar3.Text = "Agendar";
                buttonTurnoAgendar3.BackColor = Color.FromArgb(167, 228, 141);
                buttonTurnoAgendar3.Refresh();
            }
        }

        private void pictureBox1_Click_1(object? sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Deseja sair do sistema?", "Cancelar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes) 
            {
                this.Hide();
                new Login().Show();
            }
        }

        private void meusAgendamentosToolStripMenuItem_Click(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void novoAgendamentoToolStripMenuItem_Click(object? sender, EventArgs e)
        {
            new CadastroAgendamento(formularioAnterior).Show();
        }

        private void turnoToolStripMenuItem_Click(object? sender, EventArgs e)
        {
            new Turno(formularioAnterior).Show();
        }

        private void salaToolStripMenuItem_Click(object? sender, EventArgs e)
        {
            new Sala(formularioAnterior).Show();
        }

        private void funcionárioToolStripMenuItem_Click(object? sender, EventArgs e)
        {
            new CadatroFunc(formularioAnterior).Show();
        }

        private void usuariosToolStripMenuItem_Click(object? sender, EventArgs e)
        {
            new CadastroUsuario(formularioAnterior).Show();
        }

        private void button2_Click(object? sender, EventArgs e)
        {
            new CadastroAgendamento(formularioAnterior).Show();
        }

        private void label9_Click(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}