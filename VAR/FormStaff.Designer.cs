namespace VAR
{
    partial class FormStaff
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormStaff));
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.buttonDel = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.textBoxTelephone = new System.Windows.Forms.TextBox();
            this.labelPhone = new System.Windows.Forms.Label();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.labelLastName = new System.Windows.Forms.Label();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.listViewStaff = new System.Windows.Forms.ListView();
            this.IdStaff = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FirstLastName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Telephone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Email = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Logo = new System.Windows.Forms.PictureBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.comboBoxDepartments = new System.Windows.Forms.ComboBox();
            this.labelDepartments = new System.Windows.Forms.Label();
            this.Department = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Font = new System.Drawing.Font("Roboto Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxFirstName.Location = new System.Drawing.Point(16, 158);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(264, 22);
            this.textBoxFirstName.TabIndex = 104;
            // 
            // buttonDel
            // 
            this.buttonDel.BackColor = System.Drawing.Color.Black;
            this.buttonDel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDel.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonDel.Location = new System.Drawing.Point(645, 373);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(200, 44);
            this.buttonDel.TabIndex = 103;
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
            this.buttonEdit.Location = new System.Drawing.Point(343, 373);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(200, 44);
            this.buttonEdit.TabIndex = 102;
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
            this.buttonAdd.Location = new System.Drawing.Point(41, 373);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(200, 44);
            this.buttonAdd.TabIndex = 101;
            this.buttonAdd.Text = "Создать";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // textBoxTelephone
            // 
            this.textBoxTelephone.Font = new System.Drawing.Font("Roboto Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxTelephone.Location = new System.Drawing.Point(16, 208);
            this.textBoxTelephone.Name = "textBoxTelephone";
            this.textBoxTelephone.Size = new System.Drawing.Size(264, 22);
            this.textBoxTelephone.TabIndex = 100;
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.BackColor = System.Drawing.Color.Transparent;
            this.labelPhone.Font = new System.Drawing.Font("Open Sans Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPhone.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelPhone.Location = new System.Drawing.Point(12, 183);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(154, 22);
            this.labelPhone.TabIndex = 99;
            this.labelPhone.Text = "Номер телефона*";
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Font = new System.Drawing.Font("Roboto Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxLastName.Location = new System.Drawing.Point(16, 108);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(264, 22);
            this.textBoxLastName.TabIndex = 98;
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.BackColor = System.Drawing.Color.Transparent;
            this.labelLastName.Font = new System.Drawing.Font("Open Sans Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLastName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelLastName.Location = new System.Drawing.Point(12, 83);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(95, 22);
            this.labelLastName.TabIndex = 97;
            this.labelLastName.Text = "Фамилия*";
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.BackColor = System.Drawing.Color.Transparent;
            this.labelFirstName.Font = new System.Drawing.Font("Open Sans Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFirstName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelFirstName.Location = new System.Drawing.Point(12, 133);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(54, 22);
            this.labelFirstName.TabIndex = 96;
            this.labelFirstName.Text = "Имя*";
            // 
            // listViewStaff
            // 
            this.listViewStaff.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.IdStaff,
            this.FirstLastName,
            this.Telephone,
            this.Email,
            this.Department});
            this.listViewStaff.Font = new System.Drawing.Font("Open Sans Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listViewStaff.FullRowSelect = true;
            this.listViewStaff.GridLines = true;
            this.listViewStaff.HideSelection = false;
            this.listViewStaff.Location = new System.Drawing.Point(300, 12);
            this.listViewStaff.MultiSelect = false;
            this.listViewStaff.Name = "listViewStaff";
            this.listViewStaff.Size = new System.Drawing.Size(579, 319);
            this.listViewStaff.TabIndex = 95;
            this.listViewStaff.UseCompatibleStateImageBehavior = false;
            this.listViewStaff.View = System.Windows.Forms.View.Details;
            this.listViewStaff.SelectedIndexChanged += new System.EventHandler(this.listViewStaff_SelectedIndexChanged);
            // 
            // IdStaff
            // 
            this.IdStaff.Text = "Id сотрудника";
            this.IdStaff.Width = 80;
            // 
            // FirstLastName
            // 
            this.FirstLastName.Text = "Фамилия имя";
            this.FirstLastName.Width = 109;
            // 
            // Telephone
            // 
            this.Telephone.Text = "Номер телефона";
            this.Telephone.Width = 151;
            // 
            // Email
            // 
            this.Email.Text = "Почта";
            // 
            // Logo
            // 
            this.Logo.Image = global::VAR.Properties.Resources.Лого1;
            this.Logo.Location = new System.Drawing.Point(12, 12);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(268, 68);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Logo.TabIndex = 94;
            this.Logo.TabStop = false;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Font = new System.Drawing.Font("Roboto Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxEmail.Location = new System.Drawing.Point(16, 258);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(264, 22);
            this.textBoxEmail.TabIndex = 106;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.BackColor = System.Drawing.Color.Transparent;
            this.labelEmail.Font = new System.Drawing.Font("Open Sans Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelEmail.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelEmail.Location = new System.Drawing.Point(12, 233);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(59, 22);
            this.labelEmail.TabIndex = 105;
            this.labelEmail.Text = "Почта";
            // 
            // comboBoxDepartments
            // 
            this.comboBoxDepartments.Font = new System.Drawing.Font("Roboto Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxDepartments.FormattingEnabled = true;
            this.comboBoxDepartments.Location = new System.Drawing.Point(16, 308);
            this.comboBoxDepartments.Name = "comboBoxDepartments";
            this.comboBoxDepartments.Size = new System.Drawing.Size(264, 22);
            this.comboBoxDepartments.TabIndex = 108;
            // 
            // labelDepartments
            // 
            this.labelDepartments.AutoSize = true;
            this.labelDepartments.BackColor = System.Drawing.Color.Transparent;
            this.labelDepartments.Font = new System.Drawing.Font("Open Sans Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDepartments.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelDepartments.Location = new System.Drawing.Point(12, 283);
            this.labelDepartments.Name = "labelDepartments";
            this.labelDepartments.Size = new System.Drawing.Size(69, 22);
            this.labelDepartments.TabIndex = 107;
            this.labelDepartments.Text = "Отдел*";
            // 
            // Department
            // 
            this.Department.Text = "Отдел";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Open Sans Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(149, 341);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(589, 22);
            this.label2.TabIndex = 109;
            this.label2.Text = "! при изменении любой записи необходимо повторно выбирать отдел";
            // 
            // FormStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(892, 429);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxDepartments);
            this.Controls.Add(this.labelDepartments);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.textBoxFirstName);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textBoxTelephone);
            this.Controls.Add(this.labelPhone);
            this.Controls.Add(this.textBoxLastName);
            this.Controls.Add(this.labelLastName);
            this.Controls.Add(this.labelFirstName);
            this.Controls.Add(this.listViewStaff);
            this.Controls.Add(this.Logo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormStaff";
            this.Text = "Данные о сотрудниках";
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TextBox textBoxTelephone;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.ListView listViewStaff;
        private System.Windows.Forms.ColumnHeader IdStaff;
        private System.Windows.Forms.ColumnHeader FirstLastName;
        private System.Windows.Forms.ColumnHeader Telephone;
        private System.Windows.Forms.ColumnHeader Email;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.ComboBox comboBoxDepartments;
        private System.Windows.Forms.Label labelDepartments;
        private System.Windows.Forms.ColumnHeader Department;
        private System.Windows.Forms.Label label2;
    }
}