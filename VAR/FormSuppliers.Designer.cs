namespace VAR
{
    partial class FormSuppliers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSuppliers));
            this.buttonDel = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.textBoxNameSupplier = new System.Windows.Forms.TextBox();
            this.labelNameSupplier = new System.Windows.Forms.Label();
            this.listViewSuppliers = new System.Windows.Forms.ListView();
            this.IdSuppliers = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NameSupplier = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.INN = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Address = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Telephone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Logo = new System.Windows.Forms.PictureBox();
            this.textBoxINN = new System.Windows.Forms.TextBox();
            this.labelINN = new System.Windows.Forms.Label();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.labelAddress = new System.Windows.Forms.Label();
            this.textBoxTelephone = new System.Windows.Forms.TextBox();
            this.labelTelephone = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonDel
            // 
            this.buttonDel.BackColor = System.Drawing.Color.Black;
            this.buttonDel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDel.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonDel.Location = new System.Drawing.Point(543, 305);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(200, 44);
            this.buttonDel.TabIndex = 84;
            this.buttonDel.Text = "Удалить";
            this.buttonDel.UseVisualStyleBackColor = false;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.BackColor = System.Drawing.Color.Black;
            this.buttonEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonEdit.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonEdit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonEdit.Location = new System.Drawing.Point(295, 305);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(200, 44);
            this.buttonEdit.TabIndex = 83;
            this.buttonEdit.Text = "Изменить";
            this.buttonEdit.UseVisualStyleBackColor = false;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.Black;
            this.buttonAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAdd.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAdd.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonAdd.Location = new System.Drawing.Point(43, 305);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(200, 44);
            this.buttonAdd.TabIndex = 82;
            this.buttonAdd.Text = "Создать";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // textBoxNameSupplier
            // 
            this.textBoxNameSupplier.Font = new System.Drawing.Font("Roboto Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNameSupplier.Location = new System.Drawing.Point(12, 108);
            this.textBoxNameSupplier.Name = "textBoxNameSupplier";
            this.textBoxNameSupplier.Size = new System.Drawing.Size(264, 22);
            this.textBoxNameSupplier.TabIndex = 81;
            // 
            // labelNameSupplier
            // 
            this.labelNameSupplier.AutoSize = true;
            this.labelNameSupplier.BackColor = System.Drawing.Color.Transparent;
            this.labelNameSupplier.Font = new System.Drawing.Font("Open Sans Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNameSupplier.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelNameSupplier.Location = new System.Drawing.Point(8, 83);
            this.labelNameSupplier.Name = "labelNameSupplier";
            this.labelNameSupplier.Size = new System.Drawing.Size(245, 22);
            this.labelNameSupplier.TabIndex = 80;
            this.labelNameSupplier.Text = "Наименование поставщика*";
            // 
            // listViewSuppliers
            // 
            this.listViewSuppliers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.IdSuppliers,
            this.NameSupplier,
            this.INN,
            this.Address,
            this.Telephone});
            this.listViewSuppliers.Font = new System.Drawing.Font("Open Sans Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listViewSuppliers.FullRowSelect = true;
            this.listViewSuppliers.GridLines = true;
            this.listViewSuppliers.HideSelection = false;
            this.listViewSuppliers.Location = new System.Drawing.Point(300, 12);
            this.listViewSuppliers.MultiSelect = false;
            this.listViewSuppliers.Name = "listViewSuppliers";
            this.listViewSuppliers.Size = new System.Drawing.Size(478, 277);
            this.listViewSuppliers.TabIndex = 79;
            this.listViewSuppliers.UseCompatibleStateImageBehavior = false;
            this.listViewSuppliers.View = System.Windows.Forms.View.Details;
            this.listViewSuppliers.SelectedIndexChanged += new System.EventHandler(this.listViewSuppliers_SelectedIndexChanged);
            // 
            // IdSuppliers
            // 
            this.IdSuppliers.Text = "Код поставщика";
            this.IdSuppliers.Width = 62;
            // 
            // NameSupplier
            // 
            this.NameSupplier.Text = "Наименование";
            this.NameSupplier.Width = 113;
            // 
            // INN
            // 
            this.INN.Text = "ИНН";
            this.INN.Width = 88;
            // 
            // Address
            // 
            this.Address.Text = "Адрес";
            this.Address.Width = 118;
            // 
            // Telephone
            // 
            this.Telephone.Text = "Номер телефона";
            this.Telephone.Width = 120;
            // 
            // Logo
            // 
            this.Logo.Image = global::VAR.Properties.Resources.Лого1;
            this.Logo.Location = new System.Drawing.Point(12, 12);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(268, 68);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Logo.TabIndex = 78;
            this.Logo.TabStop = false;
            // 
            // textBoxINN
            // 
            this.textBoxINN.Font = new System.Drawing.Font("Roboto Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxINN.Location = new System.Drawing.Point(12, 156);
            this.textBoxINN.Name = "textBoxINN";
            this.textBoxINN.Size = new System.Drawing.Size(264, 22);
            this.textBoxINN.TabIndex = 86;
            // 
            // labelINN
            // 
            this.labelINN.AutoSize = true;
            this.labelINN.BackColor = System.Drawing.Color.Transparent;
            this.labelINN.Font = new System.Drawing.Font("Open Sans Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelINN.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelINN.Location = new System.Drawing.Point(8, 131);
            this.labelINN.Name = "labelINN";
            this.labelINN.Size = new System.Drawing.Size(56, 22);
            this.labelINN.TabIndex = 85;
            this.labelINN.Text = "ИНН*";
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Font = new System.Drawing.Font("Roboto Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAddress.Location = new System.Drawing.Point(12, 204);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(264, 22);
            this.textBoxAddress.TabIndex = 88;
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.BackColor = System.Drawing.Color.Transparent;
            this.labelAddress.Font = new System.Drawing.Font("Open Sans Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAddress.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelAddress.Location = new System.Drawing.Point(8, 179);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(170, 22);
            this.labelAddress.TabIndex = 87;
            this.labelAddress.Text = "Адрес поставщика*";
            // 
            // textBoxTelephone
            // 
            this.textBoxTelephone.Font = new System.Drawing.Font("Roboto Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTelephone.Location = new System.Drawing.Point(12, 252);
            this.textBoxTelephone.Name = "textBoxTelephone";
            this.textBoxTelephone.Size = new System.Drawing.Size(264, 22);
            this.textBoxTelephone.TabIndex = 90;
            // 
            // labelTelephone
            // 
            this.labelTelephone.AutoSize = true;
            this.labelTelephone.BackColor = System.Drawing.Color.Transparent;
            this.labelTelephone.Font = new System.Drawing.Font("Open Sans Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTelephone.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelTelephone.Location = new System.Drawing.Point(8, 227);
            this.labelTelephone.Name = "labelTelephone";
            this.labelTelephone.Size = new System.Drawing.Size(154, 22);
            this.labelTelephone.TabIndex = 89;
            this.labelTelephone.Text = "Номер телефона*";
            // 
            // FormSuppliers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(790, 366);
            this.Controls.Add(this.textBoxTelephone);
            this.Controls.Add(this.labelTelephone);
            this.Controls.Add(this.textBoxAddress);
            this.Controls.Add(this.labelAddress);
            this.Controls.Add(this.textBoxINN);
            this.Controls.Add(this.labelINN);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textBoxNameSupplier);
            this.Controls.Add(this.labelNameSupplier);
            this.Controls.Add(this.listViewSuppliers);
            this.Controls.Add(this.Logo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormSuppliers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Поставщики";
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TextBox textBoxNameSupplier;
        private System.Windows.Forms.Label labelNameSupplier;
        private System.Windows.Forms.ListView listViewSuppliers;
        private System.Windows.Forms.ColumnHeader IdSuppliers;
        private System.Windows.Forms.ColumnHeader NameSupplier;
        private System.Windows.Forms.ColumnHeader INN;
        private System.Windows.Forms.ColumnHeader Address;
        private System.Windows.Forms.ColumnHeader Telephone;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.TextBox textBoxINN;
        private System.Windows.Forms.Label labelINN;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.TextBox textBoxTelephone;
        private System.Windows.Forms.Label labelTelephone;
    }
}