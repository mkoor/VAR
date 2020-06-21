namespace VAR
{
    partial class FormGlavnaya
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGlavnaya));
            this.labelHello = new System.Windows.Forms.Label();
            this.buttonOrderBy = new System.Windows.Forms.Button();
            this.buttonAutoparts = new System.Windows.Forms.Button();
            this.buttonSuppliers = new System.Windows.Forms.Button();
            this.buttonClients = new System.Windows.Forms.Button();
            this.buttonOrders = new System.Windows.Forms.Button();
            this.buttonManager = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.Logo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // labelHello
            // 
            this.labelHello.AutoSize = true;
            this.labelHello.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelHello.Location = new System.Drawing.Point(50, 9);
            this.labelHello.Name = "labelHello";
            this.labelHello.Size = new System.Drawing.Size(147, 23);
            this.labelHello.TabIndex = 1;
            this.labelHello.Text = "Здравствуйте, ";
            this.labelHello.Click += new System.EventHandler(this.label1_Click);
            // 
            // buttonOrderBy
            // 
            this.buttonOrderBy.BackColor = System.Drawing.Color.Black;
            this.buttonOrderBy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonOrderBy.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOrderBy.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonOrderBy.Location = new System.Drawing.Point(24, 131);
            this.buttonOrderBy.Name = "buttonOrderBy";
            this.buttonOrderBy.Size = new System.Drawing.Size(268, 44);
            this.buttonOrderBy.TabIndex = 12;
            this.buttonOrderBy.Text = "Оформление заказа";
            this.buttonOrderBy.UseVisualStyleBackColor = false;
            this.buttonOrderBy.Click += new System.EventHandler(this.buttonOrderBy_Click);
            // 
            // buttonAutoparts
            // 
            this.buttonAutoparts.BackColor = System.Drawing.Color.Red;
            this.buttonAutoparts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAutoparts.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAutoparts.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonAutoparts.Location = new System.Drawing.Point(24, 194);
            this.buttonAutoparts.Name = "buttonAutoparts";
            this.buttonAutoparts.Size = new System.Drawing.Size(268, 44);
            this.buttonAutoparts.TabIndex = 13;
            this.buttonAutoparts.Text = "Данные об автозапчастях";
            this.buttonAutoparts.UseVisualStyleBackColor = false;
            this.buttonAutoparts.Click += new System.EventHandler(this.buttonAutoparts_Click);
            // 
            // buttonSuppliers
            // 
            this.buttonSuppliers.BackColor = System.Drawing.Color.Red;
            this.buttonSuppliers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSuppliers.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSuppliers.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonSuppliers.Location = new System.Drawing.Point(24, 244);
            this.buttonSuppliers.Name = "buttonSuppliers";
            this.buttonSuppliers.Size = new System.Drawing.Size(268, 44);
            this.buttonSuppliers.TabIndex = 14;
            this.buttonSuppliers.Text = "Данные о поставщиках";
            this.buttonSuppliers.UseVisualStyleBackColor = false;
            this.buttonSuppliers.Click += new System.EventHandler(this.buttonSuppliers_Click);
            // 
            // buttonClients
            // 
            this.buttonClients.BackColor = System.Drawing.Color.Red;
            this.buttonClients.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonClients.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonClients.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonClients.Location = new System.Drawing.Point(24, 294);
            this.buttonClients.Name = "buttonClients";
            this.buttonClients.Size = new System.Drawing.Size(268, 44);
            this.buttonClients.TabIndex = 15;
            this.buttonClients.Text = "Данные о клиентах";
            this.buttonClients.UseVisualStyleBackColor = false;
            this.buttonClients.Click += new System.EventHandler(this.buttonClients_Click);
            // 
            // buttonOrders
            // 
            this.buttonOrders.BackColor = System.Drawing.Color.Red;
            this.buttonOrders.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonOrders.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOrders.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonOrders.Location = new System.Drawing.Point(24, 344);
            this.buttonOrders.Name = "buttonOrders";
            this.buttonOrders.Size = new System.Drawing.Size(268, 44);
            this.buttonOrders.TabIndex = 16;
            this.buttonOrders.Text = "Данные о заказах";
            this.buttonOrders.UseVisualStyleBackColor = false;
            this.buttonOrders.Click += new System.EventHandler(this.buttonOrders_Click);
            // 
            // buttonManager
            // 
            this.buttonManager.BackColor = System.Drawing.Color.Red;
            this.buttonManager.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonManager.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonManager.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonManager.Location = new System.Drawing.Point(24, 394);
            this.buttonManager.Name = "buttonManager";
            this.buttonManager.Size = new System.Drawing.Size(268, 55);
            this.buttonManager.TabIndex = 17;
            this.buttonManager.Text = "Данные о менеджерах и администраторах";
            this.buttonManager.UseVisualStyleBackColor = false;
            this.buttonManager.Click += new System.EventHandler(this.buttonStaff_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.Black;
            this.buttonExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonExit.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonExit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonExit.Location = new System.Drawing.Point(92, 468);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(123, 44);
            this.buttonExit.TabIndex = 19;
            this.buttonExit.Text = "Выйти";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // Logo
            // 
            this.Logo.Image = global::VAR.Properties.Resources.Лого1;
            this.Logo.Location = new System.Drawing.Point(24, 42);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(268, 68);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Logo.TabIndex = 0;
            this.Logo.TabStop = false;
            // 
            // FormGlavnaya
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(314, 524);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonManager);
            this.Controls.Add(this.buttonOrders);
            this.Controls.Add(this.buttonClients);
            this.Controls.Add(this.buttonSuppliers);
            this.Controls.Add(this.buttonAutoparts);
            this.Controls.Add(this.buttonOrderBy);
            this.Controls.Add(this.labelHello);
            this.Controls.Add(this.Logo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormGlavnaya";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Главная";
            this.Load += new System.EventHandler(this.FormGlavnaya_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.Label labelHello;
        private System.Windows.Forms.Button buttonOrderBy;
        private System.Windows.Forms.Button buttonAutoparts;
        private System.Windows.Forms.Button buttonSuppliers;
        private System.Windows.Forms.Button buttonClients;
        private System.Windows.Forms.Button buttonOrders;
        private System.Windows.Forms.Button buttonManager;
        private System.Windows.Forms.Button buttonExit;
    }
}