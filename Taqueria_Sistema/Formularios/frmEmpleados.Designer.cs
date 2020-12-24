namespace Taqueria_Sistema.Formularios
{
    partial class frmEmpleados
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtBuscar = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuCustomDataGrid1 = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtPassword = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtUsuario = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtEmail = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtTelefono = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtApellidoM = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtApellidoP = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtNombre = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::Taqueria_Sistema.Properties.Resources.cancel;
            this.pictureBox1.Location = new System.Drawing.Point(1038, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.txtBuscar);
            this.panel2.Controls.Add(this.bunifuCustomDataGrid1);
            this.panel2.Location = new System.Drawing.Point(569, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(513, 689);
            this.panel2.TabIndex = 4;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtBuscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtBuscar.HintForeColor = System.Drawing.Color.Empty;
            this.txtBuscar.HintText = "Buscar Empleado:";
            this.txtBuscar.isPassword = false;
            this.txtBuscar.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtBuscar.LineIdleColor = System.Drawing.Color.Gray;
            this.txtBuscar.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtBuscar.LineThickness = 3;
            this.txtBuscar.Location = new System.Drawing.Point(17, 71);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(370, 44);
            this.txtBuscar.TabIndex = 1;
            this.txtBuscar.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomDataGrid1
            // 
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bunifuCustomDataGrid1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle17;
            this.bunifuCustomDataGrid1.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.bunifuCustomDataGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bunifuCustomDataGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bunifuCustomDataGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle18;
            this.bunifuCustomDataGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bunifuCustomDataGrid1.DoubleBuffered = true;
            this.bunifuCustomDataGrid1.EnableHeadersVisualStyles = false;
            this.bunifuCustomDataGrid1.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.bunifuCustomDataGrid1.HeaderForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuCustomDataGrid1.Location = new System.Drawing.Point(17, 254);
            this.bunifuCustomDataGrid1.Name = "bunifuCustomDataGrid1";
            this.bunifuCustomDataGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.bunifuCustomDataGrid1.Size = new System.Drawing.Size(484, 412);
            this.bunifuCustomDataGrid1.TabIndex = 0;
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(24, 56);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(258, 35);
            this.bunifuSeparator1.TabIndex = 1;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Brown;
            this.label1.Location = new System.Drawing.Point(30, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Agregar Empleados";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.txtPassword);
            this.panel1.Controls.Add(this.txtUsuario);
            this.panel1.Controls.Add(this.txtEmail);
            this.panel1.Controls.Add(this.txtTelefono);
            this.panel1.Controls.Add(this.txtApellidoM);
            this.panel1.Controls.Add(this.txtApellidoP);
            this.panel1.Controls.Add(this.txtNombre);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.bunifuSeparator1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(563, 689);
            this.panel1.TabIndex = 3;
            // 
            // txtPassword
            // 
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPassword.HintForeColor = System.Drawing.Color.Empty;
            this.txtPassword.HintText = "Contraseña:";
            this.txtPassword.isPassword = false;
            this.txtPassword.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtPassword.LineIdleColor = System.Drawing.Color.Gray;
            this.txtPassword.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtPassword.LineThickness = 3;
            this.txtPassword.Location = new System.Drawing.Point(24, 432);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(243, 44);
            this.txtPassword.TabIndex = 8;
            this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtUsuario.HintForeColor = System.Drawing.Color.Empty;
            this.txtUsuario.HintText = "Usuario:";
            this.txtUsuario.isPassword = false;
            this.txtUsuario.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtUsuario.LineIdleColor = System.Drawing.Color.Gray;
            this.txtUsuario.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtUsuario.LineThickness = 3;
            this.txtUsuario.Location = new System.Drawing.Point(24, 380);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(243, 44);
            this.txtUsuario.TabIndex = 7;
            this.txtUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtEmail
            // 
            this.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtEmail.HintForeColor = System.Drawing.Color.Empty;
            this.txtEmail.HintText = "Correo Electrónico:";
            this.txtEmail.isPassword = false;
            this.txtEmail.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtEmail.LineIdleColor = System.Drawing.Color.Gray;
            this.txtEmail.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtEmail.LineThickness = 3;
            this.txtEmail.Location = new System.Drawing.Point(24, 328);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(243, 44);
            this.txtEmail.TabIndex = 6;
            this.txtEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtTelefono.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTelefono.HintForeColor = System.Drawing.Color.Empty;
            this.txtTelefono.HintText = "Telefono:";
            this.txtTelefono.isPassword = false;
            this.txtTelefono.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtTelefono.LineIdleColor = System.Drawing.Color.Gray;
            this.txtTelefono.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtTelefono.LineThickness = 3;
            this.txtTelefono.Location = new System.Drawing.Point(24, 276);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(4);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(243, 44);
            this.txtTelefono.TabIndex = 5;
            this.txtTelefono.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtApellidoM
            // 
            this.txtApellidoM.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtApellidoM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtApellidoM.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtApellidoM.HintForeColor = System.Drawing.Color.Empty;
            this.txtApellidoM.HintText = "Apellido Materno:";
            this.txtApellidoM.isPassword = false;
            this.txtApellidoM.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtApellidoM.LineIdleColor = System.Drawing.Color.Gray;
            this.txtApellidoM.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtApellidoM.LineThickness = 3;
            this.txtApellidoM.Location = new System.Drawing.Point(24, 224);
            this.txtApellidoM.Margin = new System.Windows.Forms.Padding(4);
            this.txtApellidoM.Name = "txtApellidoM";
            this.txtApellidoM.Size = new System.Drawing.Size(243, 44);
            this.txtApellidoM.TabIndex = 4;
            this.txtApellidoM.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtApellidoP
            // 
            this.txtApellidoP.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtApellidoP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtApellidoP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtApellidoP.HintForeColor = System.Drawing.Color.Empty;
            this.txtApellidoP.HintText = "Apellido Paterno:";
            this.txtApellidoP.isPassword = false;
            this.txtApellidoP.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtApellidoP.LineIdleColor = System.Drawing.Color.Gray;
            this.txtApellidoP.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtApellidoP.LineThickness = 3;
            this.txtApellidoP.Location = new System.Drawing.Point(24, 172);
            this.txtApellidoP.Margin = new System.Windows.Forms.Padding(4);
            this.txtApellidoP.Name = "txtApellidoP";
            this.txtApellidoP.Size = new System.Drawing.Size(243, 44);
            this.txtApellidoP.TabIndex = 3;
            this.txtApellidoP.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtNombre
            // 
            this.txtNombre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNombre.HintForeColor = System.Drawing.Color.Empty;
            this.txtNombre.HintText = "Nombre:";
            this.txtNombre.isPassword = false;
            this.txtNombre.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtNombre.LineIdleColor = System.Drawing.Color.Gray;
            this.txtNombre.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtNombre.LineThickness = 3;
            this.txtNombre.Location = new System.Drawing.Point(24, 120);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(243, 44);
            this.txtNombre.TabIndex = 2;
            this.txtNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // frmEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 688);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmEmpleados";
            this.Text = "frmEmpleados";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtNombre;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtApellidoP;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtApellidoM;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtTelefono;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtEmail;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtPassword;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtUsuario;
        private Bunifu.Framework.UI.BunifuCustomDataGrid bunifuCustomDataGrid1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtBuscar;
    }
}