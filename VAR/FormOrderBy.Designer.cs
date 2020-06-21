namespace VAR
{
    partial class FormOrderBy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOrderBy));
            this.Client = new System.Windows.Forms.Label();
            this.Order = new System.Windows.Forms.Label();
            this.comboBoxAutoparts = new System.Windows.Forms.ComboBox();
            this.labelManager = new System.Windows.Forms.Label();
            this.comboBoxManager = new System.Windows.Forms.ComboBox();
            this.buttonGo = new System.Windows.Forms.Button();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.comboBoxClient = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // Client
            // 
            this.Client.AutoSize = true;
            this.Client.BackColor = System.Drawing.Color.Transparent;
            this.Client.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Client.ForeColor = System.Drawing.Color.Red;
            this.Client.Location = new System.Drawing.Point(31, 186);
            this.Client.Name = "Client";
            this.Client.Size = new System.Drawing.Size(77, 22);
            this.Client.TabIndex = 123;
            this.Client.Text = "Клиент:";
            this.Client.Click += new System.EventHandler(this.Client_Click);
            // 
            // Order
            // 
            this.Order.AutoSize = true;
            this.Order.BackColor = System.Drawing.Color.Transparent;
            this.Order.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Order.ForeColor = System.Drawing.Color.Red;
            this.Order.Location = new System.Drawing.Point(31, 133);
            this.Order.Name = "Order";
            this.Order.Size = new System.Drawing.Size(64, 22);
            this.Order.TabIndex = 124;
            this.Order.Text = "Заказ:";
            // 
            // comboBoxAutoparts
            // 
            this.comboBoxAutoparts.Font = new System.Drawing.Font("Open Sans Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxAutoparts.FormattingEnabled = true;
            this.comboBoxAutoparts.Location = new System.Drawing.Point(35, 158);
            this.comboBoxAutoparts.Name = "comboBoxAutoparts";
            this.comboBoxAutoparts.Size = new System.Drawing.Size(264, 25);
            this.comboBoxAutoparts.TabIndex = 128;
            // 
            // labelManager
            // 
            this.labelManager.AutoSize = true;
            this.labelManager.BackColor = System.Drawing.Color.Transparent;
            this.labelManager.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelManager.ForeColor = System.Drawing.Color.Red;
            this.labelManager.Location = new System.Drawing.Point(31, 80);
            this.labelManager.Name = "labelManager";
            this.labelManager.Size = new System.Drawing.Size(103, 22);
            this.labelManager.TabIndex = 129;
            this.labelManager.Text = "Менеджер:";
            this.labelManager.Click += new System.EventHandler(this.labelManager_Click);
            // 
            // comboBoxManager
            // 
            this.comboBoxManager.Font = new System.Drawing.Font("Open Sans Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxManager.FormattingEnabled = true;
            this.comboBoxManager.Location = new System.Drawing.Point(35, 105);
            this.comboBoxManager.Name = "comboBoxManager";
            this.comboBoxManager.Size = new System.Drawing.Size(264, 25);
            this.comboBoxManager.TabIndex = 130;
            this.comboBoxManager.SelectedIndexChanged += new System.EventHandler(this.comboBoxManager_SelectedIndexChanged);
            // 
            // buttonGo
            // 
            this.buttonGo.BackColor = System.Drawing.Color.Black;
            this.buttonGo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonGo.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonGo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonGo.Location = new System.Drawing.Point(65, 256);
            this.buttonGo.Name = "buttonGo";
            this.buttonGo.Size = new System.Drawing.Size(200, 44);
            this.buttonGo.TabIndex = 131;
            this.buttonGo.Text = "Оформить заказ";
            this.buttonGo.UseVisualStyleBackColor = false;
            this.buttonGo.Click += new System.EventHandler(this.buttonGo_Click);
            // 
            // Logo
            // 
            this.Logo.Image = global::VAR.Properties.Resources.Лого1;
            this.Logo.Location = new System.Drawing.Point(35, 9);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(268, 68);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Logo.TabIndex = 116;
            this.Logo.TabStop = false;
            // 
            // comboBoxClient
            // 
            this.comboBoxClient.Font = new System.Drawing.Font("Open Sans Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxClient.FormattingEnabled = true;
            this.comboBoxClient.Location = new System.Drawing.Point(35, 211);
            this.comboBoxClient.Name = "comboBoxClient";
            this.comboBoxClient.Size = new System.Drawing.Size(264, 25);
            this.comboBoxClient.TabIndex = 132;
            // 
            // FormOrderBy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(339, 313);
            this.Controls.Add(this.comboBoxClient);
            this.Controls.Add(this.buttonGo);
            this.Controls.Add(this.comboBoxManager);
            this.Controls.Add(this.labelManager);
            this.Controls.Add(this.comboBoxAutoparts);
            this.Controls.Add(this.Order);
            this.Controls.Add(this.Client);
            this.Controls.Add(this.Logo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormOrderBy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Оформление заказа";
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.Label Client;
        private System.Windows.Forms.Label Order;
        private System.Windows.Forms.ComboBox comboBoxAutoparts;
        private System.Windows.Forms.Label labelManager;
        private System.Windows.Forms.ComboBox comboBoxManager;
        private System.Windows.Forms.Button buttonGo;
        private System.Windows.Forms.ComboBox comboBoxClient;
    }
}