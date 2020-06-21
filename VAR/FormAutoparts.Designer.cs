namespace VAR
{
    partial class FormAutoparts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAutoparts));
            this.listViewAutoparts = new System.Windows.Forms.ListView();
            this.IdAutoparts = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Category = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NameAutoparts = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AutoBrand = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Manufacturer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Supplier = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.labelCategory = new System.Windows.Forms.Label();
            this.labelAutoBrand = new System.Windows.Forms.Label();
            this.labelNameAutoparts = new System.Windows.Forms.Label();
            this.textBoxNameAutoparts = new System.Windows.Forms.TextBox();
            this.textBoxManufacturer = new System.Windows.Forms.TextBox();
            this.labelManufacturer = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonDel = new System.Windows.Forms.Button();
            this.textBoxAutoBrand = new System.Windows.Forms.TextBox();
            this.comboBoxSuppliers = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxCategory = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Logo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // listViewAutoparts
            // 
            this.listViewAutoparts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.IdAutoparts,
            this.Category,
            this.NameAutoparts,
            this.AutoBrand,
            this.Manufacturer,
            this.Supplier});
            this.listViewAutoparts.Font = new System.Drawing.Font("Open Sans Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listViewAutoparts.FullRowSelect = true;
            this.listViewAutoparts.GridLines = true;
            this.listViewAutoparts.HideSelection = false;
            this.listViewAutoparts.Location = new System.Drawing.Point(300, 12);
            this.listViewAutoparts.MultiSelect = false;
            this.listViewAutoparts.Name = "listViewAutoparts";
            this.listViewAutoparts.Size = new System.Drawing.Size(579, 327);
            this.listViewAutoparts.TabIndex = 68;
            this.listViewAutoparts.UseCompatibleStateImageBehavior = false;
            this.listViewAutoparts.View = System.Windows.Forms.View.Details;
            this.listViewAutoparts.SelectedIndexChanged += new System.EventHandler(this.listViewAutoparts_SelectedIndexChanged);
            // 
            // IdAutoparts
            // 
            this.IdAutoparts.Text = "Код запчасти";
            this.IdAutoparts.Width = 80;
            // 
            // Category
            // 
            this.Category.Text = "Категория";
            this.Category.Width = 109;
            // 
            // NameAutoparts
            // 
            this.NameAutoparts.Text = "Название ";
            this.NameAutoparts.Width = 151;
            // 
            // AutoBrand
            // 
            this.AutoBrand.Text = "Марка машины";
            this.AutoBrand.Width = 118;
            // 
            // Manufacturer
            // 
            this.Manufacturer.Text = "Производитель";
            this.Manufacturer.Width = 120;
            // 
            // Supplier
            // 
            this.Supplier.Text = "Поставщик";
            // 
            // labelCategory
            // 
            this.labelCategory.AutoSize = true;
            this.labelCategory.BackColor = System.Drawing.Color.Transparent;
            this.labelCategory.Font = new System.Drawing.Font("Open Sans Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCategory.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelCategory.Location = new System.Drawing.Point(12, 95);
            this.labelCategory.Name = "labelCategory";
            this.labelCategory.Size = new System.Drawing.Size(102, 22);
            this.labelCategory.TabIndex = 66;
            this.labelCategory.Text = "Категория*";
            this.labelCategory.Click += new System.EventHandler(this.labelOrder_Click);
            // 
            // labelAutoBrand
            // 
            this.labelAutoBrand.AutoSize = true;
            this.labelAutoBrand.BackColor = System.Drawing.Color.Transparent;
            this.labelAutoBrand.Font = new System.Drawing.Font("Open Sans Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAutoBrand.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelAutoBrand.Location = new System.Drawing.Point(12, 192);
            this.labelAutoBrand.Name = "labelAutoBrand";
            this.labelAutoBrand.Size = new System.Drawing.Size(137, 22);
            this.labelAutoBrand.TabIndex = 69;
            this.labelAutoBrand.Text = "Марка машины";
            // 
            // labelNameAutoparts
            // 
            this.labelNameAutoparts.AutoSize = true;
            this.labelNameAutoparts.BackColor = System.Drawing.Color.Transparent;
            this.labelNameAutoparts.Font = new System.Drawing.Font("Open Sans Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNameAutoparts.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelNameAutoparts.Location = new System.Drawing.Point(12, 144);
            this.labelNameAutoparts.Name = "labelNameAutoparts";
            this.labelNameAutoparts.Size = new System.Drawing.Size(174, 22);
            this.labelNameAutoparts.TabIndex = 71;
            this.labelNameAutoparts.Text = "Название запчасти*";
            // 
            // textBoxNameAutoparts
            // 
            this.textBoxNameAutoparts.Font = new System.Drawing.Font("Open Sans Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxNameAutoparts.Location = new System.Drawing.Point(16, 169);
            this.textBoxNameAutoparts.Name = "textBoxNameAutoparts";
            this.textBoxNameAutoparts.Size = new System.Drawing.Size(264, 24);
            this.textBoxNameAutoparts.TabIndex = 72;
            // 
            // textBoxManufacturer
            // 
            this.textBoxManufacturer.Font = new System.Drawing.Font("Open Sans Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxManufacturer.Location = new System.Drawing.Point(16, 266);
            this.textBoxManufacturer.Name = "textBoxManufacturer";
            this.textBoxManufacturer.Size = new System.Drawing.Size(264, 24);
            this.textBoxManufacturer.TabIndex = 74;
            // 
            // labelManufacturer
            // 
            this.labelManufacturer.AutoSize = true;
            this.labelManufacturer.BackColor = System.Drawing.Color.Transparent;
            this.labelManufacturer.Font = new System.Drawing.Font("Open Sans Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelManufacturer.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelManufacturer.Location = new System.Drawing.Point(12, 241);
            this.labelManufacturer.Name = "labelManufacturer";
            this.labelManufacturer.Size = new System.Drawing.Size(148, 22);
            this.labelManufacturer.TabIndex = 73;
            this.labelManufacturer.Text = "Производитель*";
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.Black;
            this.buttonAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAdd.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAdd.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonAdd.Location = new System.Drawing.Point(34, 382);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(200, 44);
            this.buttonAdd.TabIndex = 75;
            this.buttonAdd.Text = "Создать";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.BackColor = System.Drawing.Color.Black;
            this.buttonEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonEdit.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonEdit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonEdit.Location = new System.Drawing.Point(342, 382);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(200, 44);
            this.buttonEdit.TabIndex = 76;
            this.buttonEdit.Text = "Изменить";
            this.buttonEdit.UseVisualStyleBackColor = false;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonDel
            // 
            this.buttonDel.BackColor = System.Drawing.Color.Black;
            this.buttonDel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDel.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonDel.Location = new System.Drawing.Point(647, 382);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(200, 44);
            this.buttonDel.TabIndex = 77;
            this.buttonDel.Text = "Удалить";
            this.buttonDel.UseVisualStyleBackColor = false;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // textBoxAutoBrand
            // 
            this.textBoxAutoBrand.Font = new System.Drawing.Font("Open Sans Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxAutoBrand.Location = new System.Drawing.Point(16, 217);
            this.textBoxAutoBrand.Name = "textBoxAutoBrand";
            this.textBoxAutoBrand.Size = new System.Drawing.Size(264, 24);
            this.textBoxAutoBrand.TabIndex = 78;
            // 
            // comboBoxSuppliers
            // 
            this.comboBoxSuppliers.Font = new System.Drawing.Font("Open Sans Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxSuppliers.FormattingEnabled = true;
            this.comboBoxSuppliers.Location = new System.Drawing.Point(16, 318);
            this.comboBoxSuppliers.Name = "comboBoxSuppliers";
            this.comboBoxSuppliers.Size = new System.Drawing.Size(264, 25);
            this.comboBoxSuppliers.TabIndex = 80;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Open Sans Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(12, 293);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 22);
            this.label1.TabIndex = 79;
            this.label1.Text = "Поставщик*";
            // 
            // textBoxCategory
            // 
            this.textBoxCategory.Font = new System.Drawing.Font("Open Sans Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxCategory.Location = new System.Drawing.Point(16, 120);
            this.textBoxCategory.Name = "textBoxCategory";
            this.textBoxCategory.Size = new System.Drawing.Size(264, 24);
            this.textBoxCategory.TabIndex = 81;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Open Sans Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(132, 350);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(641, 22);
            this.label2.TabIndex = 82;
            this.label2.Text = "! при изменении любой записи необходимо повторно выбирать поставщика";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Logo
            // 
            this.Logo.Image = global::VAR.Properties.Resources.Лого1;
            this.Logo.Location = new System.Drawing.Point(12, 12);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(268, 68);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Logo.TabIndex = 1;
            this.Logo.TabStop = false;
            // 
            // FormAutoparts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(894, 438);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxCategory);
            this.Controls.Add(this.comboBoxSuppliers);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxAutoBrand);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textBoxManufacturer);
            this.Controls.Add(this.labelManufacturer);
            this.Controls.Add(this.textBoxNameAutoparts);
            this.Controls.Add(this.labelNameAutoparts);
            this.Controls.Add(this.labelAutoBrand);
            this.Controls.Add(this.listViewAutoparts);
            this.Controls.Add(this.labelCategory);
            this.Controls.Add(this.Logo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAutoparts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Данные об автозапчастях";
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.ListView listViewAutoparts;
        private System.Windows.Forms.ColumnHeader IdAutoparts;
        private System.Windows.Forms.ColumnHeader Category;
        private System.Windows.Forms.ColumnHeader NameAutoparts;
        private System.Windows.Forms.ColumnHeader AutoBrand;
        private System.Windows.Forms.Label labelCategory;
        private System.Windows.Forms.Label labelAutoBrand;
        private System.Windows.Forms.Label labelNameAutoparts;
        private System.Windows.Forms.TextBox textBoxNameAutoparts;
        private System.Windows.Forms.TextBox textBoxManufacturer;
        private System.Windows.Forms.Label labelManufacturer;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.ColumnHeader Manufacturer;
        private System.Windows.Forms.TextBox textBoxAutoBrand;
        private System.Windows.Forms.ColumnHeader Supplier;
        private System.Windows.Forms.ComboBox comboBoxSuppliers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxCategory;
        private System.Windows.Forms.Label label2;
    }
}