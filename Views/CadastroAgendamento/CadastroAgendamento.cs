namespace reserva_salas_csharp.Views
{
    public class CadastroAgendamento : Form
    {
        private Panel panel1;
        private Button buttonSave;
        private Label labelTurnoDesc3;
        private Label labelTurnoDesc;
        private ComboBox comboBoxTurno;
        private Label labelTurno;
        private RichTextBox richTextBoxObs;
        private Label labelObs;
        private ComboBox comboBoxSala;
        private Label labelSala;
        private DateTimePicker dateTimePickerData;
        private Label labelData;
        private Button buttonCancel;
        private Label titulo;
        private Label labelSalaIndisponivel;
        private CheckBox checkBoxHigienizacao;
        private Models.Usuario usuario;
        private ComboBox comboBoxFuncionario;
        private DateTime? data;
        private int? turno;
        private int? sala;
        
        public CadastroAgendamento(Form formularioAnterior, Models.Usuario user, DateTime? data, int? turno, int? sala)
        {
            this.data = data;
            this.turno = turno;
            this.sala = sala;
            InitializeComponent(formularioAnterior, user);
        }

        public void InitializeComponent(Form formularioAnterior, Models.Usuario user)
        {
            this.usuario = user;
            panel1 = new Panel();
            comboBoxTurno = new ComboBox();
            labelTurno = new Label();
            buttonSave = new Button();
            buttonCancel = new Button();
            titulo = new Label();
            labelData = new Label();
            dateTimePickerData = new DateTimePicker();
            labelSala = new Label();
            comboBoxSala = new ComboBox();
            labelObs = new Label();
            richTextBoxObs = new RichTextBox();
            labelSalaIndisponivel = new Label();
            checkBoxHigienizacao = new CheckBox();
            comboBoxFuncionario = new ComboBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLightLight;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(richTextBoxObs);
            panel1.Controls.Add(labelObs);
            panel1.Controls.Add(comboBoxSala);
            panel1.Controls.Add(labelSala);
            panel1.Controls.Add(labelSalaIndisponivel);
            panel1.Controls.Add(dateTimePickerData);
            panel1.Controls.Add(checkBoxHigienizacao);
            panel1.Controls.Add(comboBoxFuncionario);
            panel1.Controls.Add(labelData);
            panel1.Controls.Add(buttonCancel);
            panel1.Controls.Add(buttonSave);
            panel1.Controls.Add(comboBoxTurno);
            panel1.Controls.Add(labelTurno);
            panel1.ForeColor = Color.FromArgb(127, 103, 186);
            panel1.Location = new Point(12, 24);
            panel1.Name = "panel1";
            panel1.Size = new Size(457, 377);
            panel1.TabIndex = 1;
            // 
            // comboBoxTurno
            // 
            comboBoxTurno.FormattingEnabled = true;
            comboBoxTurno.Location = new Point(12, 126);
            comboBoxTurno.Name = "comboBoxTurno";
            comboBoxTurno.Size = new Size(153, 28);
            comboBoxTurno.TabIndex = 11;
            comboBoxTurno.DataSource = Controllers.Turno.GetAllTurnos().ToArray();
            comboBoxTurno.DisplayMember = "Descricao";
            comboBoxTurno.ValueMember = "Id";
            comboBoxTurno.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxTurno.SelectedIndexChanged += comboBoxSala_SelectedIndexChanged;
            if (this.turno != null){
                int index = comboBoxTurno.FindStringExact(this.turno.ToString());
                comboBoxTurno.SelectedIndex = index;
            }
            
            // 
            // labelTurno
            // 
            labelTurno.AutoSize = true;
            labelTurno.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            labelTurno.ForeColor = Color.Black;
            labelTurno.Location = new Point(12, 103);
            labelTurno.Name = "labelTurno";
            labelTurno.Size = new Size(47, 20);
            labelTurno.TabIndex = 10;
            labelTurno.Text = "Turno";
            // 
            // buttonSave
            // 
            buttonSave.BackColor = Color.FromArgb(193, 167, 255);
            buttonSave.Cursor = Cursors.Hand;
            buttonSave.FlatAppearance.BorderSize = 0;
            buttonSave.FlatStyle = FlatStyle.Flat;
            buttonSave.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            buttonSave.ForeColor = SystemColors.ControlText;
            buttonSave.Location = new Point(223, 331);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(110, 35);
            buttonSave.TabIndex = 3;
            buttonSave.Text = "Salvar";
            buttonSave.Enabled = true;
            buttonSave.UseVisualStyleBackColor = false;
            buttonSave.Click += (sender, e) => buttonSave_Click(formularioAnterior);
            // 
            // buttonCancel
            // 
            buttonCancel.BackColor = Color.FromArgb(255, 194, 109);
            buttonCancel.Cursor = Cursors.Hand;
            buttonCancel.FlatAppearance.BorderSize = 0;
            buttonCancel.FlatStyle = FlatStyle.Flat;
            buttonCancel.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            buttonCancel.ForeColor = SystemColors.ControlText;
            buttonCancel.Location = new Point(339, 331);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(110, 35);
            buttonCancel.TabIndex = 12;
            buttonCancel.Text = "Cancelar";
            buttonCancel.UseVisualStyleBackColor = false;
            buttonCancel.Click += (sender, e) => button1_Click_1(formularioAnterior);
            // 
            // titulo
            // 
            titulo.AutoSize = true;
            titulo.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            titulo.ForeColor = Color.Black;
            titulo.Location = new Point(35, 9);
            titulo.Name = "titulo";
            titulo.Size = new Size(215, 23);
            titulo.TabIndex = 13;
            titulo.Text = "Novo Agendamento";
            // 
            // labelData
            // 
            labelData.AutoSize = true;
            labelData.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            labelData.ForeColor = Color.Black;
            labelData.Location = new Point(12, 30);
            labelData.Name = "labelData";
            labelData.Size = new Size(45, 20);
            labelData.TabIndex = 13;
            labelData.Text = "Data";
            // 
            // dateTimePickerData
            // 
            dateTimePickerData.Location = new Point(12, 53);
            dateTimePickerData.Name = "dateTimePickerData";
            dateTimePickerData.Size = new Size(294, 27);
            dateTimePickerData.TabIndex = 14;
            if (this.data != null)
                dateTimePickerData.Value = (DateTime)this.data;
            else 
                dateTimePickerData.Value = DateTime.Now;
            dateTimePickerData.ValueChanged += comboBoxSala_SelectedIndexChanged;
            // 
            // labelSala
            // 
            labelSala.AutoSize = true;
            labelSala.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            labelSala.ForeColor = Color.Black;
            labelSala.Location = new Point(403, 103);
            labelSala.Name = "labelSala";
            labelSala.Size = new Size(39, 20);
            labelSala.TabIndex = 15;
            labelSala.Text = "Sala";
            // 
            // comboBoxSala
            // 
            comboBoxSala.FormattingEnabled = true;
            comboBoxSala.Location = new Point(223, 126);
            comboBoxSala.Name = "comboBoxSala";
            comboBoxSala.Size = new Size(219, 28);
            comboBoxSala.TabIndex = 16;
            comboBoxSala.DataSource = 
                Controllers.Sala.GetAllSalas().ToArray();
            comboBoxSala.DisplayMember = "numeroSala";
            comboBoxSala.ValueMember = "Id";
            comboBoxSala.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxSala.SelectedIndexChanged += comboBoxSala_SelectedIndexChanged;
            if (this.sala != null){
                int index = comboBoxSala.FindStringExact(this.sala.ToString());
                comboBoxSala.SelectedIndex = index;
            }
            // 
            // labelObs
            // 
            labelObs.AutoSize = true;
            labelObs.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            labelObs.ForeColor = Color.Black;
            labelObs.Location = new Point(12, 190);
            labelObs.Name = "labelObs";
            labelObs.Size = new Size(109, 20);
            labelObs.TabIndex = 17;
            labelObs.Text = "Observações";
            // 
            // checkBoxHigienizacao
            // 
            checkBoxHigienizacao.AutoSize = true;
            checkBoxHigienizacao.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            int margemDireita = 10;
            int x = dateTimePickerData.Location.X + dateTimePickerData.Width + margemDireita;
            int y = dateTimePickerData.Location.Y;
            checkBoxHigienizacao.Location = new Point(x, y);
            checkBoxHigienizacao.Name = "checkBoxHigienizacao";
            checkBoxHigienizacao.Size = new Size(104, 21);
            checkBoxHigienizacao.TabIndex = 19;
            checkBoxHigienizacao.Text = "Higienização";
            checkBoxHigienizacao.UseVisualStyleBackColor = true;
            checkBoxHigienizacao.CheckedChanged += checkBoxHigienizacao_CheckedChanged;
            if (this.usuario.TipoUsuarioId != 1)
                checkBoxHigienizacao.Visible = false;
            //
            // comboBox 
            //
            comboBoxFuncionario.FormattingEnabled = true;
            comboBoxFuncionario.Location = new Point(12, 126);
            comboBoxFuncionario.Font = new Font("Century Gothic", 7F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxFuncionario.Name = "comboBoxFuncionario";
            comboBoxFuncionario.Location = new Point(x, y + 25);
            comboBoxFuncionario.Size = new Size(120, 8);
            comboBoxFuncionario.TabIndex = 11;
            comboBoxFuncionario.DataSource = Controllers.Funcionario.mostrarAllFunc().ToArray();
            comboBoxFuncionario.DisplayMember = "Nome";
            comboBoxFuncionario.ValueMember = "Id";
            comboBoxFuncionario.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxFuncionario.Visible = checkBoxHigienizacao.Checked;
            // 
            // richTextBoxObs
            // 
            richTextBoxObs.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBoxObs.Location = new Point(12, 213);
            richTextBoxObs.Name = "richTextBoxObs";
            richTextBoxObs.Size = new Size(430, 80);
            richTextBoxObs.TabIndex = 18;
            richTextBoxObs.Text = "";
            // 
            // labelSalaIndisponivel
            // 
            labelSalaIndisponivel.AutoSize = true;
            labelSalaIndisponivel.BackColor = SystemColors.Info;
            labelSalaIndisponivel.ForeColor = SystemColors.InfoText;
            labelSalaIndisponivel.Font = new Font("Segoe UI", 9);
            labelSalaIndisponivel.Padding = new Padding(5);
            labelSalaIndisponivel.Location = new Point(309, 157);
            labelSalaIndisponivel.Name = "labelSalaIndisponivel";
            labelSalaIndisponivel.Size = new Size(133, 20);
            labelSalaIndisponivel.TabIndex = 14;
            labelSalaIndisponivel.Text = "Selecione uma sala!";
            labelSalaIndisponivel.Visible = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(481, 413);
            ControlBox = false;
            Controls.Add(titulo);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "Form1";
            this.StartPosition = FormStartPosition.CenterScreen;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private void checkBoxHigienizacao_CheckedChanged(object? sender, EventArgs e)
        {
            comboBoxFuncionario.Visible = checkBoxHigienizacao.Checked;
            comboBoxFuncionario.Refresh();
        }

        private void comboBoxSala_SelectedIndexChanged(object sender, EventArgs e)
        {
            string salaId = comboBoxSala.SelectedValue.ToString();
            string turnoId = comboBoxTurno.SelectedValue.ToString();
            DateTime dateTime = dateTimePickerData.Value;
            var agendamentos = Controllers.Agendamento.GetAgendamentosBySalaTurnoData(salaId, turnoId, dateTime);
            var higienizacoes = Controllers.Higienizacao.GetHigienizacoesBySalaTurnoData(salaId, turnoId, dateTime);
            
            if (agendamentos != null || higienizacoes != null)
            {
                labelSalaIndisponivel.Visible = true;
                labelSalaIndisponivel.Text = "Sala indisponível!";
                labelSalaIndisponivel.BackColor = Color.Red;
                labelSalaIndisponivel.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
                labelSalaIndisponivel.ForeColor = Color.Transparent;
                labelSalaIndisponivel.Refresh();
                buttonSave.Enabled = false;
                buttonSave.Refresh();
            } 
            else 
            {
                labelSalaIndisponivel.Visible = false;
                labelSalaIndisponivel.Refresh();
                buttonSave.Enabled = true;
                buttonSave.Refresh();
            }
        }

        private void button1_Click_1(Form formularioAnterior)
        {
            DialogResult dialogResult = MessageBox.Show("Deseja cancelar o cadastro?", "Cancelar", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
                formularioAnterior.Activate();
            }
        }

        private void buttonSave_Click(Form formularioAnterior)
        {
            if (checkBoxHigienizacao.Checked)
            {
                Controllers.Higienizacao.CriarHigienizazao(
                    Convert.ToInt32(comboBoxSala.SelectedValue).ToString(),
                    Convert.ToInt32(comboBoxTurno.SelectedValue).ToString(),
                    Models.Funcionario.GetByIdfunc(Convert.ToInt32(comboBoxFuncionario.SelectedValue)).Id.ToString(),
                    richTextBoxObs.Text,
                    dateTimePickerData.Value.ToString()
                );
                MessageBox.Show("Higienização cadastrada com sucesso!");
            } else {
                Controllers.Agendamento.CadastrarAgendamento(
                    richTextBoxObs.Text, 
                    dateTimePickerData.Value.ToString(), 
                    usuario.Id.ToString(),
                    Convert.ToInt32(comboBoxTurno.SelectedValue).ToString(), 
                    Convert.ToInt32(comboBoxSala.SelectedValue).ToString()
                );
                MessageBox.Show("Agendamento cadastrado com sucesso!");
            }
            formularioAnterior.Activate();
            this.Close();
        }
    }
}