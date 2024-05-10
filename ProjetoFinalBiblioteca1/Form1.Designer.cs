namespace ProjetoFinalBiblioteca1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttonCadastroPessoa = new Button();
            buttonCadastroExemplar = new Button();
            SuspendLayout();
            // 
            // buttonCadastroPessoa
            // 
            buttonCadastroPessoa.Location = new Point(55, 78);
            buttonCadastroPessoa.Name = "buttonCadastroPessoa";
            buttonCadastroPessoa.Size = new Size(198, 23);
            buttonCadastroPessoa.TabIndex = 0;
            buttonCadastroPessoa.Text = "Cadastro Pessoa";
            buttonCadastroPessoa.UseVisualStyleBackColor = true;
            // 
            // buttonCadastroExemplar
            // 
            buttonCadastroExemplar.Location = new Point(55, 214);
            buttonCadastroExemplar.Name = "buttonCadastroExemplar";
            buttonCadastroExemplar.Size = new Size(198, 23);
            buttonCadastroExemplar.TabIndex = 1;
            buttonCadastroExemplar.Text = "Cadastro Exemplar";
            buttonCadastroExemplar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(308, 450);
            Controls.Add(buttonCadastroExemplar);
            Controls.Add(buttonCadastroPessoa);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button buttonCadastroPessoa;
        private Button buttonCadastroExemplar;
    }
}
