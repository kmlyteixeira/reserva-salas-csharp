using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace reserva_salas_csharp.Views
{
    public class CadastroUsuario : Form
    {
        private Label nomeLabel;
        private Label sobrenomeLabel;
        private Label cpfLabel;
        private Label dataNascimentoLabel;
        private Label tipoUsuarioLabel;
        private Label userNameLabel;
        private Label senhaLabel;
        private TextBox nomeTextBox;
        private TextBox sobrenomeTextBox;
        private TextBox cpfTextBox;
        private TextBox dataNascimentoTextBox;
        private ComboBox tipoUsuarioComboBox;
        private TextBox userNameTextBox;
        private TextBox senhaTextBox;
        private Button cadastrarButton;
        private Button cancelarButton;

        public CadastroUsuario()
        {
            InitializeComponent();
        }

        public void InitializeComponent()
        {
            this.nomeLabel = new Label();
            this.sobrenomeLabel = new Label();
            this.cpfLabel = new Label();
            this.dataNascimentoLabel = new Label();
            this.tipoUsuarioLabel = new Label();
            this.userNameLabel = new Label();
            this.senhaLabel = new Label();
            this.nomeTextBox = new TextBox();
            this.sobrenomeTextBox = new TextBox();
            this.cpfTextBox = new TextBox();
            this.dataNascimentoTextBox = new TextBox();
            this.tipoUsuarioComboBox = new ComboBox();
            this.userNameTextBox = new TextBox();
            this.senhaTextBox = new TextBox();
            this.cadastrarButton = new Button();
            this.cancelarButton = new Button();
            this.SuspendLayout();

            // nomeLabel
            this.nomeLabel.AutoSize = true;
            this.nomeLabel.Location = new System.Drawing.Point(267, 100);
            this.nomeLabel.Name = "nomeLabel";
            this.nomeLabel.Size = new System.Drawing.Size(43, 13);
            this.nomeLabel.TabIndex = 0;
            this.nomeLabel.Text = "Nome";

            // sobrenomeLabel
            this.sobrenomeLabel.AutoSize = true;
            this.sobrenomeLabel.Location = new System.Drawing.Point(267, 160);
            this.sobrenomeLabel.Name = "sobrenomeLabel";
            this.sobrenomeLabel.Size = new System.Drawing.Size(63, 13);
            this.sobrenomeLabel.TabIndex = 1;
            this.sobrenomeLabel.Text = "Sobrenome";

            // cpfLabel
            this.cpfLabel.AutoSize = true;
            this.cpfLabel.Location = new System.Drawing.Point(267, 220);
            this.cpfLabel.Name = "cpfLabel";
            this.cpfLabel.Size = new System.Drawing.Size(27, 13);
            this.cpfLabel.TabIndex = 2;
            this.cpfLabel.Text = "CPF";

            // dataNascimentoLabel
            this.dataNascimentoLabel.AutoSize = true;
            this.dataNascimentoLabel.Location = new System.Drawing.Point(267, 280);
            this.dataNascimentoLabel.Name = "dataNascimentoLabel";
            this.dataNascimentoLabel.Size = new System.Drawing.Size(104, 13);
            this.dataNascimentoLabel.TabIndex = 3;
            this.dataNascimentoLabel.Text = "Data de Nascimento";

            // tipoUsuarioLabel
            this.tipoUsuarioLabel.AutoSize = true;
            this.tipoUsuarioLabel.Location = new System.Drawing.Point(267, 340);
            this.tipoUsuarioLabel.Name = "tipoUsuarioLabel";
            this.tipoUsuarioLabel.Size = new System.Drawing.Size(82, 13);
            this.tipoUsuarioLabel.TabIndex = 4;
            this.tipoUsuarioLabel.Text = "Tipo de Usuário";

            // userNameLabel
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.Location = new System.Drawing.Point(267, 400);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(58, 13);
            this.userNameLabel.TabIndex = 5;
            this.userNameLabel.Text = "Username";

            // senhaLabel
            this.senhaLabel.AutoSize = true;
            this.senhaLabel.Location = new System.Drawing.Point(267, 460);
            this.senhaLabel.Name = "senhaLabel";
            this.senhaLabel.Size = new System.Drawing.Size(38, 13);
            this.senhaLabel.TabIndex = 6;
            this.senhaLabel.Text = "Senha";

            // nomeTextBox
            this.nomeTextBox.Location = new System.Drawing.Point(270, 120);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(200, 20);
            this.nomeTextBox.TabIndex = 7;

            // sobrenomeTextBox
            this.sobrenomeTextBox.Location = new System.Drawing.Point(270, 180);
            this.sobrenomeTextBox.Name = "sobrenomeTextBox";
            this.sobrenomeTextBox.Size = new System.Drawing.Size(200, 20);
            this.sobrenomeTextBox.TabIndex = 8;

            // cpfTextBox
            this.cpfTextBox.Location = new System.Drawing.Point(270, 240);
            this.cpfTextBox.Name = "cpfTextBox";
            this.cpfTextBox.Size = new System.Drawing.Size(200, 20);
            this.cpfTextBox.TabIndex = 9;

            // dataNascimentoTextBox
            this.dataNascimentoTextBox.Location = new System.Drawing.Point(270, 300);
            this.dataNascimentoTextBox.Name = "dataNascimentoTextBox";
            this.dataNascimentoTextBox.Size = new System.Drawing.Size(200, 20);
            this.dataNascimentoTextBox.TabIndex = 10;

            // tipoUsuarioComboBox
            this.tipoUsuarioComboBox.FormattingEnabled = true;
            this.tipoUsuarioComboBox.Items.AddRange(new object[] {
                "Administrador",
                "Professor",
                "Aluno"
            });
            this.tipoUsuarioComboBox.Location = new System.Drawing.Point(270, 360);
            this.tipoUsuarioComboBox.Name = "tipoUsuarioComboBox";
            this.tipoUsuarioComboBox.Size = new System.Drawing.Size(200, 21);
            this.tipoUsuarioComboBox.TabIndex = 11;

            // userNameTextBox
            this.userNameTextBox.Location = new System.Drawing.Point(270, 420);
            this.userNameTextBox.Name = "userNameTextBox";
            this.userNameTextBox.Size = new System.Drawing.Size(200, 20);
            this.userNameTextBox.TabIndex = 12;

            // senhaTextBox
            this.senhaTextBox.Location = new System.Drawing.Point(270, 480);
            this.senhaTextBox.Name = "senhaTextBox";
            this.senhaTextBox.Size = new System.Drawing.Size(200, 20);
            this.senhaTextBox.TabIndex = 13;

            // cadastrarButton
            this.cadastrarButton.Location = new System.Drawing.Point(270, 540);
            this.cadastrarButton.Name = "cadastrarButton";
            this.cadastrarButton.Size = new System.Drawing.Size(75, 23);
            this.cadastrarButton.TabIndex = 14;
            this.cadastrarButton.Text = "Cadastrar";
            this.cadastrarButton.UseVisualStyleBackColor = true;
            this.cadastrarButton.Click += new System.EventHandler(this.cadastrarButton_Click);

            // cancelarButton
            this.cancelarButton.Location = new System.Drawing.Point(395, 540);
            this.cancelarButton.Name = "cancelarButton";
            this.cancelarButton.Size = new System.Drawing.Size(75, 23);
            this.cancelarButton.TabIndex = 15;
            this.cancelarButton.Text = "Cancelar";
            this.cancelarButton.UseVisualStyleBackColor = true;
            this.cancelarButton.Click += new System.EventHandler(this.cancelarButton_Click);

            // CadastroUsuarioForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 661);
            this.Controls.Add(this.cancelarButton);
            this.Controls.Add(this.cadastrarButton);
            this.Controls.Add(this.senhaTextBox);
            this.Controls.Add(this.userNameTextBox);
            this.Controls.Add(this.tipoUsuarioComboBox);
            this.Controls.Add(this.dataNascimentoTextBox);
            this.Controls.Add(this.cpfTextBox);
            this.Controls.Add(this.sobrenomeTextBox);
            this.Controls.Add(this.nomeTextBox);
            this.Controls.Add(this.senhaLabel);
            this.Controls.Add(this.userNameLabel);
            this.Controls.Add(this.tipoUsuarioLabel);
            this.Controls.Add(this.dataNascimentoLabel);
            this.Controls.Add(this.cpfLabel);
            this.Controls.Add(this.sobrenomeLabel);
            this.Controls.Add(this.nomeLabel);
            this.Name = "CadastroUsuarioForm";
            this.Text = "Cadastro de Usuário";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private void cancelarButton_Click(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void cadastrarButton_Click(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}