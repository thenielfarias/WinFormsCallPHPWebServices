
namespace WinFormsCallPHPWebServices2
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btCallWebService = new System.Windows.Forms.Button();
            this.dtServiceResult = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtServiceResult)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(67, 20);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(222, 20);
            this.txtName.TabIndex = 1;
            // 
            // btCallWebService
            // 
            this.btCallWebService.Location = new System.Drawing.Point(295, 18);
            this.btCallWebService.Name = "btCallWebService";
            this.btCallWebService.Size = new System.Drawing.Size(98, 23);
            this.btCallWebService.TabIndex = 2;
            this.btCallWebService.Text = "Call Web Service";
            this.btCallWebService.UseVisualStyleBackColor = true;
            this.btCallWebService.Click += new System.EventHandler(this.btCallWebService_Click);
            // 
            // dtServiceResult
            // 
            this.dtServiceResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtServiceResult.Location = new System.Drawing.Point(34, 56);
            this.dtServiceResult.Name = "dtServiceResult";
            this.dtServiceResult.Size = new System.Drawing.Size(604, 211);
            this.dtServiceResult.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 398);
            this.Controls.Add(this.dtServiceResult);
            this.Controls.Add(this.btCallWebService);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dtServiceResult)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btCallWebService;
        private System.Windows.Forms.DataGridView dtServiceResult;
    }
}

