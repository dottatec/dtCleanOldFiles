namespace dtCleanOldFiles
{
    partial class dtMainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dtTimer = new System.Windows.Forms.Timer(this.components);
            this.btIniciar = new System.Windows.Forms.Button();
            this.txtInicialPath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.maskTime = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btAgendar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dtTimer
            // 
            this.dtTimer.Interval = 1200000;
            this.dtTimer.Tick += new System.EventHandler(this.dtTimer_Tick);
            // 
            // btIniciar
            // 
            this.btIniciar.ForeColor = System.Drawing.Color.Red;
            this.btIniciar.Location = new System.Drawing.Point(348, 22);
            this.btIniciar.Name = "btIniciar";
            this.btIniciar.Size = new System.Drawing.Size(75, 23);
            this.btIniciar.TabIndex = 1;
            this.btIniciar.Text = "Iniciar";
            this.btIniciar.UseVisualStyleBackColor = true;
            this.btIniciar.Click += new System.EventHandler(this.btIniciar_Click);
            // 
            // txtInicialPath
            // 
            this.txtInicialPath.Location = new System.Drawing.Point(94, 25);
            this.txtInicialPath.Name = "txtInicialPath";
            this.txtInicialPath.Size = new System.Drawing.Size(237, 20);
            this.txtInicialPath.TabIndex = 2;
            this.txtInicialPath.Text = "G:\\teste\\t\\teste 1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Diretório Inicial:";
            // 
            // maskTime
            // 
            this.maskTime.Location = new System.Drawing.Point(94, 64);
            this.maskTime.Mask = "00:00";
            this.maskTime.Name = "maskTime";
            this.maskTime.Size = new System.Drawing.Size(37, 20);
            this.maskTime.TabIndex = 4;
            this.maskTime.Text = "0330";
            this.maskTime.ValidatingType = typeof(System.DateTime);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Executar às:";
            // 
            // btAgendar
            // 
            this.btAgendar.ForeColor = System.Drawing.Color.Red;
            this.btAgendar.Location = new System.Drawing.Point(137, 62);
            this.btAgendar.Name = "btAgendar";
            this.btAgendar.Size = new System.Drawing.Size(75, 23);
            this.btAgendar.TabIndex = 6;
            this.btAgendar.Text = "Agendar";
            this.btAgendar.UseVisualStyleBackColor = true;
            this.btAgendar.Click += new System.EventHandler(this.btAgendar_Click);
            // 
            // dtMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 104);
            this.Controls.Add(this.btAgendar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.maskTime);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtInicialPath);
            this.Controls.Add(this.btIniciar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "dtMainForm";
            this.ShowIcon = false;
            this.Text = "DTCleanOldFiles";
            this.Load += new System.EventHandler(this.dtMainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer dtTimer;
        private System.Windows.Forms.Button btIniciar;
        private System.Windows.Forms.TextBox txtInicialPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox maskTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btAgendar;
    }
}

