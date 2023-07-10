namespace reserva_salas_csharp.Views
{
    public class FormVerMais : Form
    {
        private Panel panel1;
        private Button buttonOk;
        private Label titulo;
        private Label labelInfoData;
        private Label labelSala;
        private Label labelData;
        private Label labelInfoSala;
        private Label labelInfoObs;
        private Label labelInfoUsuario;
        private Label labelTurno;
        private Label labelInfoTurno;
        private Label labelObservacao;
        private Label labelUser;
        private Label labelFuncionario;
        private Label labelInfoFuncionario;
        private Models.Agendamento? agendamento;
        private Models.Higienizacao? higienizacao;
        private Form formAnterior;

        public FormVerMais(Form formAnterior, Models.Agendamento? agendamento, Models.Higienizacao? higienizacao)
        {
            this.agendamento = agendamento;
            this.higienizacao = higienizacao;
            this.formAnterior = formAnterior;
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            panel1 = new Panel();
            buttonOk = new Button();
            titulo = new Label();
            labelInfoData = new Label();
            labelInfoUsuario = new Label();
            labelInfoObs = new Label();
            labelInfoSala = new Label();
            labelData = new Label();
            labelSala = new Label();
            labelUser = new Label();
            labelObservacao = new Label();
            labelInfoTurno = new Label();
            labelTurno = new Label();
            labelInfoFuncionario = new Label();
            labelFuncionario = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLightLight;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(labelFuncionario);
            panel1.Controls.Add(labelInfoFuncionario);
            panel1.Controls.Add(labelTurno);
            panel1.Controls.Add(labelInfoTurno);
            panel1.Controls.Add(labelObservacao);
            panel1.Controls.Add(labelUser);
            panel1.Controls.Add(labelSala);
            panel1.Controls.Add(labelData);
            panel1.Controls.Add(labelInfoSala);
            panel1.Controls.Add(labelInfoObs);
            panel1.Controls.Add(labelInfoUsuario);
            panel1.Controls.Add(labelInfoData);
            panel1.Controls.Add(buttonOk);
            panel1.ForeColor = Color.FromArgb(127, 103, 186);
            panel1.Location = new Point(11, 24);
            panel1.Name = "panel1";
            panel1.Size = new Size(457, 377);
            panel1.TabIndex = 1;
            // 
            // buttonOk
            // 
            buttonOk.BackColor = Color.FromArgb(193, 167, 255);
            buttonOk.Cursor = Cursors.Hand;
            buttonOk.FlatAppearance.BorderSize = 0;
            buttonOk.FlatStyle = FlatStyle.Flat;
            buttonOk.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            buttonOk.ForeColor = SystemColors.ControlText;
            buttonOk.Location = new Point(177, 337);
            buttonOk.Name = "buttonOk";
            buttonOk.Size = new Size(110, 35);
            buttonOk.TabIndex = 3;
            buttonOk.Text = "OK";
            buttonOk.UseVisualStyleBackColor = false;
            buttonOk.Click += button2_Click;
            // 
            // titulo
            // 
            titulo.AutoSize = true;
            titulo.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            titulo.ForeColor = Color.Black;
            titulo.Location = new Point(160, 9);
            titulo.Name = "titulo";
            titulo.Size = new Size(155, 23);
            titulo.TabIndex = 13;
            if (this.agendamento != null)
                titulo.Text = "Agendamento";
            else if (this.higienizacao != null)
                titulo.Text = "Higienização";
            // 
            // labelInfoData
            // 
            labelInfoData.AutoSize = true;
            labelInfoData.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            labelInfoData.ForeColor = Color.Black;
            labelInfoData.Location = new Point(16, 37);
            labelInfoData.Name = "labelInfoData";
            labelInfoData.Size = new Size(54, 21);
            labelInfoData.TabIndex = 14;
            labelInfoData.Text = "Data";
            // 
            // labelInfoUsuario
            // 
            labelInfoUsuario.AutoSize = true;
            labelInfoUsuario.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            labelInfoUsuario.ForeColor = Color.Black;
            labelInfoUsuario.Location = new Point(16, 124);
            labelInfoUsuario.Name = "labelInfoUsuario";
            labelInfoUsuario.Size = new Size(70, 21);
            labelInfoUsuario.TabIndex = 15;
            labelInfoUsuario.Text = "Usuário";
            // 
            // labelInfoObs
            // 
            labelInfoObs.AutoSize = true;
            labelInfoObs.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            labelInfoObs.ForeColor = Color.Black;
            labelInfoObs.Location = new Point(170, 124);
            labelInfoObs.Name = "labelInfoObs";
            labelInfoObs.Size = new Size(117, 21);
            labelInfoObs.TabIndex = 16;
            labelInfoObs.Text = "Observação";
            // 
            // labelInfoSala
            // 
            labelInfoSala.AutoSize = true;
            labelInfoSala.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            labelInfoSala.ForeColor = Color.Black;
            labelInfoSala.Location = new Point(170, 37);
            labelInfoSala.Name = "labelInfoSala";
            labelInfoSala.Size = new Size(45, 21);
            labelInfoSala.TabIndex = 17;
            labelInfoSala.Text = "Sala";
            // 
            // labelData
            // 
            labelData.AutoSize = true;
            labelData.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            labelData.Location = new Point(16, 67);
            labelData.Name = "labelData";
            labelData.Size = new Size(53, 20);
            labelData.TabIndex = 18;
            labelData.Text = agendamento?.Data.ToString("dd/MM/yyyy") ?? higienizacao?.Data.ToString("dd/MM/yyyy");
            // 
            // labelSala
            // 
            labelSala.AutoSize = true;
            labelSala.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            labelSala.Location = new Point(170, 67);
            labelSala.Name = "labelSala";
            labelSala.Size = new Size(53, 20);
            labelSala.TabIndex = 19;
            Models.Sala sala = Controllers.Sala.GetSalas(agendamento?.SalaHasTurno.SalaId ?? higienizacao.idSala);
            labelSala.Text = $"{sala.numeroSala} - {sala.numeroAndar}º Andar";
            // 
            // labelUser
            // 
            labelUser.AutoSize = true;
            labelUser.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            labelUser.Location = new Point(16, 158);
            labelUser.Name = "labelUser";
            labelUser.Size = new Size(53, 20);
            labelUser.TabIndex = 20;
            if (this.agendamento != null)
            {
                Models.Usuario usuario = Controllers.Usuario.GetUsuario(agendamento?.UsuarioId.ToString());
                labelUser.Text = usuario?.Nome;
            } else {
                labelUser.Text = "Administrador";
            }
            // 
            // labelObservacao
            // 
            labelObservacao.AutoSize = true;
            labelObservacao.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            labelObservacao.Location = new Point(170, 158);
            labelObservacao.Name = "labelObservacao";
            labelObservacao.Size = new Size(53, 20);
            labelObservacao.TabIndex = 21;
            labelObservacao.Text = agendamento?.Observacao ?? higienizacao?.Observacao;
            // 
            // labelInfoTurno
            // 
            labelInfoTurno.AutoSize = true;
            labelInfoTurno.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            labelInfoTurno.ForeColor = Color.Black;
            labelInfoTurno.Location = new Point(313, 37);
            labelInfoTurno.Name = "labelInfoTurno";
            labelInfoTurno.Size = new Size(54, 21);
            labelInfoTurno.TabIndex = 22;
            labelInfoTurno.Text = "Turno";
            // 
            // labelTurno
            // 
            labelTurno.AutoSize = true;
            labelTurno.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            labelTurno.Location = new Point(313, 67);
            labelTurno.Name = "labelTurno";
            labelTurno.Size = new Size(53, 20);
            labelTurno.TabIndex = 23;
            Models.Turno turno = Controllers.Turno.GetTurnos(agendamento?.SalaHasTurno.TurnoId ?? higienizacao.idTurno);
            labelTurno.Text = turno.descricao;
            // 
            // labelInfoFuncionario
            // 
            labelInfoFuncionario.AutoSize = true;
            labelInfoFuncionario.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            labelInfoFuncionario.ForeColor = Color.Black;
            labelInfoFuncionario.Location = new Point(16, 212);
            labelInfoFuncionario.Name = "labelInfoFuncionario";
            labelInfoFuncionario.Size = new Size(104, 21);
            labelInfoFuncionario.TabIndex = 24;
            if (this.agendamento != null)
                labelInfoFuncionario.Visible = false;
            else
                labelInfoFuncionario.Visible = true;
            labelInfoFuncionario.Text = "Funcionário";
            // 
            // labelFuncionario
            // 
            labelFuncionario.AutoSize = true;
            labelFuncionario.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            labelFuncionario.Location = new Point(16, 246);
            labelFuncionario.Name = "labelFuncionario";
            labelFuncionario.Size = new Size(53, 20);
            labelFuncionario.TabIndex = 25;
            if (this.agendamento != null)
                labelFuncionario.Visible = false;
            else
            {
                labelFuncionario.Visible = true;
                Models.Funcionario funcionario = Controllers.Funcionario.mostrarAllFunc().Where(f => f.Id == higienizacao.idFuncionario).FirstOrDefault();
                labelFuncionario.Text = funcionario.Nome;
            }
            
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
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private void button2_Click(object? sender, EventArgs e)
        {
            this.Close();
            this.formAnterior.Activate();
        }
    }
}