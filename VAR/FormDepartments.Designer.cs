namespace VAR
{
    partial class FormDepartments
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDepartments));
            this.textBoxPersons = new System.Windows.Forms.TextBox();
            this.buttonDel = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.textBoxDirector = new System.Windows.Forms.TextBox();
            this.labelDirector = new System.Windows.Forms.Label();
            this.textBoxNameDepartments = new System.Windows.Forms.TextBox();
            this.labelNameDepartments = new System.Windows.Forms.Label();
            this.labelPersons = new System.Windows.Forms.Label();
            this.listViewDepartments = new System.Windows.Forms.ListView();
            this.IdDepatments = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NameDepartment = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Persons = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Director = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Logo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxPersons
            // 
            this.textBoxPersons.Font = new System.Drawing.Font("Roboto Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPersons.Location = new System.Drawing.Point(16, 158);
            this.textBoxPersons.Name = "textBoxPersons";
            this.textBoxPersons.Size = new System.Drawing.Size(264, 22);
            this.textBoxPersons.TabIndex = 93;
            this.textBoxPersons.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPersons_TextChanged);
            // 
            // buttonDel
            // 
            this.buttonDel.BackColor = System.Drawing.Color.Black;
            this.buttonDel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDel.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonDel.Location = new System.Drawing.Point(658, 245);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(200, 44);
            this.buttonDel.TabIndex = 92;
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
            this.buttonEdit.Location = new System.Drawing.Point(351, 245);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(200, 44);
            this.buttonEdit.TabIndex = 91;
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
            this.buttonAdd.Location = new System.Drawing.Point(41, 245);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(200, 44);
            this.buttonAdd.TabIndex = 90;
            this.buttonAdd.Text = "Создать";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // textBoxDirector
            // 
            this.textBoxDirector.Font = new System.Drawing.Font("Roboto Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxDirector.Location = new System.Drawing.Point(16, 208);
            this.textBoxDirector.Name = "textBoxDirector";
            this.textBoxDirector.Size = new System.Drawing.Size(264, 22);
            this.textBoxDirector.TabIndex = 89;
            // 
            // labelDirector
            // 
            this.labelDirector.AutoSize = true;
            this.labelDirector.BackColor = System.Drawing.Color.Transparent;
            this.labelDirector.Font = new System.Drawing.Font("Open Sans Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDirector.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelDirector.Location = new System.Drawing.Point(12, 183);
            this.labelDirector.Name = "labelDirector";
            this.labelDirector.Size = new System.Drawing.Size(186, 22);
            this.labelDirector.TabIndex = 88;
            this.labelDirector.Text = "Руководитель отдела";
            // 
            // textBoxNameDepartments
            // 
            this.textBoxNameDepartments.Font = new System.Drawing.Font("Roboto Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxNameDepartments.Location = new System.Drawing.Point(16, 108);
            this.textBoxNameDepartments.Name = "textBoxNameDepartments";
            this.textBoxNameDepartments.Size = new System.Drawing.Size(264, 22);
            this.textBoxNameDepartments.TabIndex = 87;
            // 
            // labelNameDepartments
            // 
            this.labelNameDepartments.AutoSize = true;
            this.labelNameDepartments.BackColor = System.Drawing.Color.Transparent;
            this.labelNameDepartments.Font = new System.Drawing.Font("Open Sans Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNameDepartments.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelNameDepartments.Location = new System.Drawing.Point(12, 83);
            this.labelNameDepartments.Name = "labelNameDepartments";
            this.labelNameDepartments.Size = new System.Drawing.Size(157, 22);
            this.labelNameDepartments.TabIndex = 86;
            this.labelNameDepartments.Text = "Название отдела*";
            this.labelNameDepartments.Click += new System.EventHandler(this.labelNameAutoparts_Click);
            // 
            // labelPersons
            // 
            this.labelPersons.AutoSize = true;
            this.labelPersons.BackColor = System.Drawing.Color.Transparent;
            this.labelPersons.Font = new System.Drawing.Font("Open Sans Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPersons.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelPersons.Location = new System.Drawing.Point(12, 133);
            this.labelPersons.Name = "labelPersons";
            this.labelPersons.Size = new System.Drawing.Size(260, 22);
            this.labelPersons.TabIndex = 85;
            this.labelPersons.Text = "Количество человек в отделе*";
            this.labelPersons.Click += new System.EventHandler(this.labelPersons_Click);
            // 
            // listViewDepartments
            // 
            this.listViewDepartments.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.IdDepatments,
            this.NameDepartment,
            this.Persons,
            this.Director});
            this.listViewDepartments.Font = new System.Drawing.Font("Open Sans Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listViewDepartments.FullRowSelect = true;
            this.listViewDepartments.GridLines = true;
            this.listViewDepartments.HideSelection = false;
            this.listViewDepartments.Location = new System.Drawing.Point(300, 12);
            this.listViewDepartments.MultiSelect = false;
            this.listViewDepartments.Name = "listViewDepartments";
            this.listViewDepartments.Size = new System.Drawing.Size(579, 218);
            this.listViewDepartments.TabIndex = 84;
            this.listViewDepartments.UseCompatibleStateImageBehavior = false;
            this.listViewDepartments.View = System.Windows.Forms.View.Details;
            this.listViewDepartments.SelectedIndexChanged += new System.EventHandler(this.listViewDepartments_SelectedIndexChanged);
            // 
            // IdDepatments
            // 
            this.IdDepatments.Text = "Id отдела";
            this.IdDepatments.Width = 80;
            // 
            // NameDepartment
            // 
            this.NameDepartment.Text = "Название";
            this.NameDepartment.Width = 109;
            // 
            // Persons
            // 
            this.Persons.Text = "Кол-во чел.";
            this.Persons.Width = 151;
            // 
            // Director
            // 
            this.Director.Text = "Руководитель";
            // 
            // Logo
            // 
            this.Logo.Image = global::VAR.Properties.Resources.Лого1;
            this.Logo.Location = new System.Drawing.Point(12, 12);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(268, 68);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Logo.TabIndex = 82;
            this.Logo.TabStop = false;
            // 
            // FormDepartments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(902, 303);
            this.Controls.Add(this.textBoxPersons);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textBoxDirector);
            this.Controls.Add(this.labelDirector);
            this.Controls.Add(this.textBoxNameDepartments);
            this.Controls.Add(this.labelNameDepartments);
            this.Controls.Add(this.labelPersons);
            this.Controls.Add(this.listViewDepartments);
            this.Controls.Add(this.Logo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormDepartments";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Данные об отделах";
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxPersons;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TextBox textBoxDirector;
        private System.Windows.Forms.Label labelDirector;
        private System.Windows.Forms.TextBox textBoxNameDepartments;
        private System.Windows.Forms.Label labelNameDepartments;
        private System.Windows.Forms.Label labelPersons;
        private System.Windows.Forms.ListView listViewDepartments;
        private System.Windows.Forms.ColumnHeader IdDepatments;
        private System.Windows.Forms.ColumnHeader NameDepartment;
        private System.Windows.Forms.ColumnHeader Persons;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.ColumnHeader Director;
    }
}