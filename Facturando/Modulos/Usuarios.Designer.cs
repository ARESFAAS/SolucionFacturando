namespace Facturando.Modulos
{
    partial class Usuarios
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
            this.dtgUsuarios = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Login = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateEvent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChangePassword = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnGuardarPassword = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnGuardarRolModulo = new System.Windows.Forms.Button();
            this.lstModulos = new System.Windows.Forms.ListBox();
            this.dtgRoles = new System.Windows.Forms.DataGridView();
            this.IdRol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgUsuarios)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgRoles)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgUsuarios
            // 
            this.dtgUsuarios.AllowUserToAddRows = false;
            this.dtgUsuarios.AllowUserToDeleteRows = false;
            this.dtgUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Login,
            this.Password,
            this.DateEvent,
            this.ChangePassword});
            this.dtgUsuarios.Location = new System.Drawing.Point(38, 29);
            this.dtgUsuarios.Name = "dtgUsuarios";
            this.dtgUsuarios.ReadOnly = true;
            this.dtgUsuarios.Size = new System.Drawing.Size(253, 120);
            this.dtgUsuarios.TabIndex = 0;
            this.dtgUsuarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgUsuarios_CellContentClick);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // Login
            // 
            this.Login.DataPropertyName = "Login";
            this.Login.HeaderText = "Login";
            this.Login.Name = "Login";
            this.Login.ReadOnly = true;
            // 
            // Password
            // 
            this.Password.DataPropertyName = "Password";
            this.Password.HeaderText = "Password";
            this.Password.Name = "Password";
            this.Password.ReadOnly = true;
            this.Password.Visible = false;
            // 
            // DateEvent
            // 
            this.DateEvent.DataPropertyName = "DateEvent";
            this.DateEvent.HeaderText = "DateEvent";
            this.DateEvent.Name = "DateEvent";
            this.DateEvent.ReadOnly = true;
            this.DateEvent.Visible = false;
            // 
            // ChangePassword
            // 
            this.ChangePassword.HeaderText = "Cambiar Contraseña";
            this.ChangePassword.Name = "ChangePassword";
            this.ChangePassword.ReadOnly = true;
            this.ChangePassword.Text = "Cambiar";
            this.ChangePassword.UseColumnTextForButtonValue = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtPassword);
            this.groupBox1.Controls.Add(this.btnGuardarPassword);
            this.groupBox1.Controls.Add(this.dtgUsuarios);
            this.groupBox1.Location = new System.Drawing.Point(29, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(338, 224);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cambiar Contraseña";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(120, 177);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.ReadOnly = true;
            this.txtPassword.Size = new System.Drawing.Size(171, 20);
            this.txtPassword.TabIndex = 2;
            // 
            // btnGuardarPassword
            // 
            this.btnGuardarPassword.Location = new System.Drawing.Point(38, 174);
            this.btnGuardarPassword.Name = "btnGuardarPassword";
            this.btnGuardarPassword.Size = new System.Drawing.Size(75, 23);
            this.btnGuardarPassword.TabIndex = 1;
            this.btnGuardarPassword.Text = "Guardar";
            this.btnGuardarPassword.UseVisualStyleBackColor = true;
            this.btnGuardarPassword.Click += new System.EventHandler(this.btnGuardarPassword_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnGuardarRolModulo);
            this.groupBox2.Controls.Add(this.lstModulos);
            this.groupBox2.Controls.Add(this.dtgRoles);
            this.groupBox2.Location = new System.Drawing.Point(29, 272);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(576, 262);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Reasignar Módulos a Roles";
            // 
            // btnGuardarRolModulo
            // 
            this.btnGuardarRolModulo.Location = new System.Drawing.Point(315, 223);
            this.btnGuardarRolModulo.Name = "btnGuardarRolModulo";
            this.btnGuardarRolModulo.Size = new System.Drawing.Size(75, 23);
            this.btnGuardarRolModulo.TabIndex = 2;
            this.btnGuardarRolModulo.Text = "Guardar";
            this.btnGuardarRolModulo.UseVisualStyleBackColor = true;
            this.btnGuardarRolModulo.Click += new System.EventHandler(this.btnGuardarRolModulo_Click);
            // 
            // lstModulos
            // 
            this.lstModulos.FormattingEnabled = true;
            this.lstModulos.Location = new System.Drawing.Point(315, 30);
            this.lstModulos.Name = "lstModulos";
            this.lstModulos.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstModulos.Size = new System.Drawing.Size(228, 186);
            this.lstModulos.TabIndex = 1;
            // 
            // dtgRoles
            // 
            this.dtgRoles.AllowUserToAddRows = false;
            this.dtgRoles.AllowUserToDeleteRows = false;
            this.dtgRoles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgRoles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdRol,
            this.Description});
            this.dtgRoles.Location = new System.Drawing.Point(38, 30);
            this.dtgRoles.Name = "dtgRoles";
            this.dtgRoles.ReadOnly = true;
            this.dtgRoles.Size = new System.Drawing.Size(253, 186);
            this.dtgRoles.TabIndex = 0;
            this.dtgRoles.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dtgRoles_RowHeaderMouseClick);
            // 
            // IdRol
            // 
            this.IdRol.DataPropertyName = "Id";
            this.IdRol.HeaderText = "Id";
            this.IdRol.Name = "IdRol";
            this.IdRol.ReadOnly = true;
            this.IdRol.Visible = false;
            // 
            // Description
            // 
            this.Description.DataPropertyName = "Description";
            this.Description.HeaderText = "Rol";
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            // 
            // Usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 560);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Usuarios";
            this.Text = "Usuarios";
            this.Load += new System.EventHandler(this.Usuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgUsuarios)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgRoles)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgUsuarios;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Login;
        private System.Windows.Forms.DataGridViewTextBoxColumn Password;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateEvent;
        private System.Windows.Forms.DataGridViewButtonColumn ChangePassword;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnGuardarPassword;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dtgRoles;
        private System.Windows.Forms.ListBox lstModulos;
        private System.Windows.Forms.Button btnGuardarRolModulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdRol;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
    }
}