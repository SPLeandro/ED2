
namespace Atendimento
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
            this.buttonGerar = new System.Windows.Forms.Button();
            this.buttonListarSenhas = new System.Windows.Forms.Button();
            this.buttonListarAtendimentos = new System.Windows.Forms.Button();
            this.buttonAdicionar = new System.Windows.Forms.Button();
            this.listViewSenhasListadas = new System.Windows.Forms.ListView();
            this.buttonChamar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxGuiche = new System.Windows.Forms.TextBox();
            this.listViewListaAtendimentos = new System.Windows.Forms.ListView();
            this.label2 = new System.Windows.Forms.Label();
            this.labelQtdeGuiches = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonGerar
            // 
            this.buttonGerar.Location = new System.Drawing.Point(75, 25);
            this.buttonGerar.Name = "buttonGerar";
            this.buttonGerar.Size = new System.Drawing.Size(75, 23);
            this.buttonGerar.TabIndex = 0;
            this.buttonGerar.Text = "Gerar";
            this.buttonGerar.UseVisualStyleBackColor = true;
            this.buttonGerar.Click += new System.EventHandler(this.buttonGerar_Click);
            // 
            // buttonListarSenhas
            // 
            this.buttonListarSenhas.Location = new System.Drawing.Point(64, 322);
            this.buttonListarSenhas.Name = "buttonListarSenhas";
            this.buttonListarSenhas.Size = new System.Drawing.Size(98, 23);
            this.buttonListarSenhas.TabIndex = 1;
            this.buttonListarSenhas.Text = "Listar senhas";
            this.buttonListarSenhas.UseVisualStyleBackColor = true;
            this.buttonListarSenhas.Click += new System.EventHandler(this.buttonListarSenhas_Click);
            // 
            // buttonListarAtendimentos
            // 
            this.buttonListarAtendimentos.Location = new System.Drawing.Point(350, 322);
            this.buttonListarAtendimentos.Name = "buttonListarAtendimentos";
            this.buttonListarAtendimentos.Size = new System.Drawing.Size(153, 23);
            this.buttonListarAtendimentos.TabIndex = 2;
            this.buttonListarAtendimentos.Text = "Listar Atendimentos";
            this.buttonListarAtendimentos.UseVisualStyleBackColor = true;
            this.buttonListarAtendimentos.Click += new System.EventHandler(this.buttonListarAtendimentos_Click);
            // 
            // buttonAdicionar
            // 
            this.buttonAdicionar.Location = new System.Drawing.Point(215, 195);
            this.buttonAdicionar.Name = "buttonAdicionar";
            this.buttonAdicionar.Size = new System.Drawing.Size(75, 23);
            this.buttonAdicionar.TabIndex = 3;
            this.buttonAdicionar.Text = "Adicionar";
            this.buttonAdicionar.UseVisualStyleBackColor = true;
            this.buttonAdicionar.Click += new System.EventHandler(this.buttonAdicionar_Click);
            // 
            // listViewSenhasListadas
            // 
            this.listViewSenhasListadas.HideSelection = false;
            this.listViewSenhasListadas.Location = new System.Drawing.Point(32, 54);
            this.listViewSenhasListadas.Name = "listViewSenhasListadas";
            this.listViewSenhasListadas.Size = new System.Drawing.Size(162, 262);
            this.listViewSenhasListadas.TabIndex = 4;
            this.listViewSenhasListadas.UseCompatibleStateImageBehavior = false;
            this.listViewSenhasListadas.View = System.Windows.Forms.View.List;
            // 
            // buttonChamar
            // 
            this.buttonChamar.Location = new System.Drawing.Point(447, 25);
            this.buttonChamar.Name = "buttonChamar";
            this.buttonChamar.Size = new System.Drawing.Size(75, 23);
            this.buttonChamar.TabIndex = 5;
            this.buttonChamar.Text = "Chamar";
            this.buttonChamar.UseVisualStyleBackColor = true;
            this.buttonChamar.Click += new System.EventHandler(this.buttonChamar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(270, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Guichê:";
            // 
            // textBoxGuiche
            // 
            this.textBoxGuiche.Location = new System.Drawing.Point(323, 22);
            this.textBoxGuiche.Name = "textBoxGuiche";
            this.textBoxGuiche.Size = new System.Drawing.Size(100, 23);
            this.textBoxGuiche.TabIndex = 7;
            // 
            // listViewListaAtendimentos
            // 
            this.listViewListaAtendimentos.HideSelection = false;
            this.listViewListaAtendimentos.Location = new System.Drawing.Point(302, 68);
            this.listViewListaAtendimentos.Name = "listViewListaAtendimentos";
            this.listViewListaAtendimentos.Size = new System.Drawing.Size(249, 248);
            this.listViewListaAtendimentos.TabIndex = 8;
            this.listViewListaAtendimentos.UseCompatibleStateImageBehavior = false;
            this.listViewListaAtendimentos.View = System.Windows.Forms.View.List;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(215, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "Qtde guichês";
            // 
            // labelQtdeGuiches
            // 
            this.labelQtdeGuiches.AutoSize = true;
            this.labelQtdeGuiches.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelQtdeGuiches.Location = new System.Drawing.Point(237, 155);
            this.labelQtdeGuiches.Name = "labelQtdeGuiches";
            this.labelQtdeGuiches.Size = new System.Drawing.Size(32, 37);
            this.labelQtdeGuiches.TabIndex = 10;
            this.labelQtdeGuiches.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 373);
            this.Controls.Add(this.labelQtdeGuiches);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listViewListaAtendimentos);
            this.Controls.Add(this.textBoxGuiche);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonChamar);
            this.Controls.Add(this.listViewSenhasListadas);
            this.Controls.Add(this.buttonAdicionar);
            this.Controls.Add(this.buttonListarAtendimentos);
            this.Controls.Add(this.buttonListarSenhas);
            this.Controls.Add(this.buttonGerar);
            this.Name = "Form1";
            this.Text = "Qtde guichês";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonGerar;
        private System.Windows.Forms.Button buttonListarSenhas;
        private System.Windows.Forms.Button buttonListarAtendimentos;
        private System.Windows.Forms.Button buttonAdicionar;
        private System.Windows.Forms.ListView listViewSenhasListadas;
        private System.Windows.Forms.Button buttonChamar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxGuiche;
        private System.Windows.Forms.ListView listViewListaAtendimentos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelQtdeGuiches;
    }
}

