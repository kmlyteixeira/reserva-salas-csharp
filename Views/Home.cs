namespace reserva_salas_csharp.Views
{
    public class Home : Form
    {
        private Panel panel1;
        private Button buttonAddAgendamento;
        private Label labelBemVindo;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem usuáriosToolStripMenuItem;
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
        private int monthConst;

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
            usuáriosToolStripMenuItem = new ToolStripMenuItem();
            funcionárioToolStripMenuItem = new ToolStripMenuItem();
            salaToolStripMenuItem = new ToolStripMenuItem();
            turnoToolStripMenuItem = new ToolStripMenuItem();
            agendamentoToolStripMenuItem = new ToolStripMenuItem();
            novoAgendamentoToolStripMenuItem = new ToolStripMenuItem();
            meusAgendamentosToolStripMenuItem = new ToolStripMenuItem();
            pictureBoxSair = new PictureBox();
            labelSala = new Label();
            comboBoxSala = new ComboBox();
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
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(comboBoxSala);
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
            labelCalendar.Text = "junho de 2023";
            // 
            // dataGridViewCalendar
            // 
            dataGridViewCalendar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCalendar.Location = new Point(3, 46);
            dataGridViewCalendar.Name = "dataGridViewCalendar";
            dataGridViewCalendar.RowHeadersWidth = 51;
            dataGridViewCalendar.RowTemplate.Height = 29;
            dataGridViewCalendar.Size = new Size(419, 337);
            dataGridViewCalendar.TabIndex = 0;
            dataGridViewCalendar.CellContentClick += new DataGridViewCellEventHandler(dataGridViewCalendar_CellContentClick);
            dataGridViewCalendar.AutoGenerateColumns = false;
            dataGridViewCalendar.RowHeadersVisible = false;
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
            panel11.Controls.Add(labelTurnoDesc3);
            panel11.Location = new Point(109, 3);
            panel11.Name = "panel11";
            panel11.Size = new Size(155, 65);
            panel11.TabIndex = 8;
            // 
            // labelTurnoDesc3
            // 
            labelTurnoDesc3.AutoSize = true;
            labelTurnoDesc3.Font = new Font("Century Gothic", 9F, FontStyle.Italic, GraphicsUnit.Point);
            labelTurnoDesc3.ForeColor = Color.DimGray;
            labelTurnoDesc3.Location = new Point(3, 24);
            labelTurnoDesc3.Name = "labelTurnoDesc3";
            labelTurnoDesc3.Size = new Size(140, 18);
            labelTurnoDesc3.TabIndex = 7;
            labelTurnoDesc3.Text = "Horário disponível";
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
            panel9.Controls.Add(labelTurnoDesc);
            panel9.Location = new Point(109, 3);
            panel9.Name = "panel9";
            panel9.Size = new Size(155, 65);
            panel9.TabIndex = 6;
            // 
            // labelTurnoDesc
            // 
            labelTurnoDesc.AutoSize = true;
            labelTurnoDesc.Font = new Font("Century Gothic", 9F, FontStyle.Italic, GraphicsUnit.Point);
            labelTurnoDesc.ForeColor = Color.DimGray;
            labelTurnoDesc.Location = new Point(3, 23);
            labelTurnoDesc.Name = "labelTurnoDesc";
            labelTurnoDesc.Size = new Size(140, 18);
            labelTurnoDesc.TabIndex = 6;
            labelTurnoDesc.Text = "Horário disponível";
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
            // panel10
            // 
            panel10.Controls.Add(labelVerMais);
            panel10.Controls.Add(labelDescAgenda2);
            panel10.Controls.Add(labelDescAgenda);
            panel10.Location = new Point(109, 3);
            panel10.Name = "panel10";
            panel10.Size = new Size(155, 65);
            panel10.TabIndex = 7;
            // 
            // labelVerMais
            // 
            labelVerMais.AutoSize = true;
            labelVerMais.Cursor = Cursors.Hand;
            labelVerMais.Font = new Font("Century Gothic", 6F, FontStyle.Regular, GraphicsUnit.Point);
            labelVerMais.ForeColor = Color.DimGray;
            labelVerMais.Location = new Point(91, 46);
            labelVerMais.Name = "labelVerMais";
            labelVerMais.Size = new Size(59, 15);
            labelVerMais.TabIndex = 10;
            labelVerMais.Text = "Ver mais...";
            labelVerMais.Click += label9_Click;
            // 
            // labelDescAgenda2
            // 
            labelDescAgenda2.AutoSize = true;
            labelDescAgenda2.Font = new Font("Century Gothic", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            labelDescAgenda2.ForeColor = Color.Black;
            labelDescAgenda2.Location = new Point(3, 24);
            labelDescAgenda2.Name = "labelDescAgenda2";
            labelDescAgenda2.Size = new Size(128, 17);
            labelDescAgenda2.TabIndex = 9;
            labelDescAgenda2.Text = "Descrição bacana";
            // 
            // labelDescAgenda
            // 
            labelDescAgenda.AutoSize = true;
            labelDescAgenda.Font = new Font("Century Gothic", 7.8F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            labelDescAgenda.ForeColor = Color.FromArgb(127, 103, 186);
            labelDescAgenda.Location = new Point(2, 5);
            labelDescAgenda.Name = "labelDescAgenda";
            labelDescAgenda.Size = new Size(50, 16);
            labelDescAgenda.TabIndex = 8;
            labelDescAgenda.Text = "Fulano";
            // 
            // buttonTurnoAgendar2
            // 
            buttonTurnoAgendar2.BackColor = Color.FromArgb(255, 242, 130);
            buttonTurnoAgendar2.Cursor = Cursors.Hand;
            buttonTurnoAgendar2.FlatAppearance.BorderSize = 0;
            buttonTurnoAgendar2.FlatStyle = FlatStyle.Flat;
            buttonTurnoAgendar2.Font = new Font("Century Gothic", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            buttonTurnoAgendar2.ForeColor = SystemColors.ControlText;
            buttonTurnoAgendar2.Location = new Point(270, 14);
            buttonTurnoAgendar2.Name = "buttonTurnoAgendar2";
            buttonTurnoAgendar2.Size = new Size(84, 42);
            buttonTurnoAgendar2.TabIndex = 6;
            buttonTurnoAgendar2.Text = "Cancelar";
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
            toolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { usuáriosToolStripMenuItem, funcionárioToolStripMenuItem, salaToolStripMenuItem, turnoToolStripMenuItem, agendamentoToolStripMenuItem });
            toolStripMenuItem1.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            toolStripMenuItem1.Image = Image.FromFile("Views/Resources/menu.png");
            toolStripMenuItem1.ImageAlign = ContentAlignment.BottomCenter;
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(34, 24);
            // 
            // usuáriosToolStripMenuItem
            // 
            usuáriosToolStripMenuItem.Name = "usuáriosToolStripMenuItem";
            usuáriosToolStripMenuItem.Size = new Size(224, 26);
            usuáriosToolStripMenuItem.Text = "Usuário";
            usuáriosToolStripMenuItem.Click += usuáriosToolStripMenuItem_Click;
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
            comboBoxSala.Items.AddRange(Controllers.Sala.GetAllSalas()
                            .Select(s => $"Sala {s.numeroSala} - Andar {s.numeroAndar}")
                            .ToArray());
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
            ((System.ComponentModel.ISupportInitialize)pictureBoxSair).EndInit();
            ResumeLayout(false);
            PerformLayout();
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

        private void buttonCalendar2_Click()
        {
            monthConst += 1;
            dataGridViewCalendar.Rows.Clear();
            CarregaDadosGrid(monthConst);
            dataGridViewCalendar.Refresh();
        }

        private void dataGridViewCalendar_CellContentClick(object? sender, DataGridViewCellEventArgs e)
        {
            throw new NotImplementedException();
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
            throw new NotImplementedException();
        }

        private void turnoToolStripMenuItem_Click(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void salaToolStripMenuItem_Click(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void funcionárioToolStripMenuItem_Click(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void usuáriosToolStripMenuItem_Click(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void button2_Click(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void label9_Click(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}