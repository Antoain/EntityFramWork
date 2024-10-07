namespace EFDemo
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvCustomers = new System.Windows.Forms.DataGridView();
            this.btnObtenerTodos = new System.Windows.Forms.Button();
            this.btnObtenerPorID = new System.Windows.Forms.Button();
            this.txtBoxObtnerID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txbCompannyName = new System.Windows.Forms.TextBox();
            this.txbAddress = new System.Windows.Forms.TextBox();
            this.txbContactTitle = new System.Windows.Forms.TextBox();
            this.txbCustomerID = new System.Windows.Forms.TextBox();
            this.txbContactName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCustomers
            // 
            this.dgvCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomers.Location = new System.Drawing.Point(12, 29);
            this.dgvCustomers.Name = "dgvCustomers";
            this.dgvCustomers.RowHeadersWidth = 51;
            this.dgvCustomers.RowTemplate.Height = 24;
            this.dgvCustomers.Size = new System.Drawing.Size(762, 231);
            this.dgvCustomers.TabIndex = 0;
            // 
            // btnObtenerTodos
            // 
            this.btnObtenerTodos.Location = new System.Drawing.Point(211, 292);
            this.btnObtenerTodos.Name = "btnObtenerTodos";
            this.btnObtenerTodos.Size = new System.Drawing.Size(123, 23);
            this.btnObtenerTodos.TabIndex = 1;
            this.btnObtenerTodos.Text = "Cargar Todos";
            this.btnObtenerTodos.UseVisualStyleBackColor = true;
            this.btnObtenerTodos.Click += new System.EventHandler(this.btnObtenerTodos_Click);
            // 
            // btnObtenerPorID
            // 
            this.btnObtenerPorID.Location = new System.Drawing.Point(95, 321);
            this.btnObtenerPorID.Name = "btnObtenerPorID";
            this.btnObtenerPorID.Size = new System.Drawing.Size(99, 23);
            this.btnObtenerPorID.TabIndex = 2;
            this.btnObtenerPorID.Text = "Cargar por ID";
            this.btnObtenerPorID.UseVisualStyleBackColor = true;
            this.btnObtenerPorID.Click += new System.EventHandler(this.btnObtenerPorID_Click);
            // 
            // txtBoxObtnerID
            // 
            this.txtBoxObtnerID.Location = new System.Drawing.Point(95, 293);
            this.txtBoxObtnerID.Name = "txtBoxObtnerID";
            this.txtBoxObtnerID.Size = new System.Drawing.Size(100, 22);
            this.txtBoxObtnerID.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 299);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Inserte ID";
            // 
            // txbCompannyName
            // 
            this.txbCompannyName.Location = new System.Drawing.Point(523, 321);
            this.txbCompannyName.Name = "txbCompannyName";
            this.txbCompannyName.Size = new System.Drawing.Size(100, 22);
            this.txbCompannyName.TabIndex = 5;
            // 
            // txbAddress
            // 
            this.txbAddress.Location = new System.Drawing.Point(523, 405);
            this.txbAddress.Name = "txbAddress";
            this.txbAddress.Size = new System.Drawing.Size(100, 22);
            this.txbAddress.TabIndex = 6;
            // 
            // txbContactTitle
            // 
            this.txbContactTitle.Location = new System.Drawing.Point(523, 377);
            this.txbContactTitle.Name = "txbContactTitle";
            this.txbContactTitle.Size = new System.Drawing.Size(100, 22);
            this.txbContactTitle.TabIndex = 7;
            // 
            // txbCustomerID
            // 
            this.txbCustomerID.Location = new System.Drawing.Point(523, 296);
            this.txbCustomerID.Name = "txbCustomerID";
            this.txbCustomerID.Size = new System.Drawing.Size(100, 22);
            this.txbCustomerID.TabIndex = 8;
            // 
            // txbContactName
            // 
            this.txbContactName.Location = new System.Drawing.Point(523, 349);
            this.txbContactName.Name = "txbContactName";
            this.txbContactName.Size = new System.Drawing.Size(100, 22);
            this.txbContactName.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(412, 324);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Company Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(461, 411);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Address";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(436, 383);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "Contact Title";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(425, 355);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "Contact Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(425, 302);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 16);
            this.label6.TabIndex = 14;
            this.label6.Text = "Customer ID";
            // 
            // btnInsertar
            // 
            this.btnInsertar.Location = new System.Drawing.Point(643, 299);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(131, 23);
            this.btnInsertar.TabIndex = 15;
            this.btnInsertar.Text = "Insertar Client";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(643, 328);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(131, 23);
            this.btnActualizar.TabIndex = 16;
            this.btnActualizar.Text = "Actualizar Client";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(643, 357);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(131, 23);
            this.btnBorrar.TabIndex = 17;
            this.btnBorrar.Text = "Borrar Client";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnInsertar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbContactName);
            this.Controls.Add(this.txbCustomerID);
            this.Controls.Add(this.txbContactTitle);
            this.Controls.Add(this.txbAddress);
            this.Controls.Add(this.txbCompannyName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBoxObtnerID);
            this.Controls.Add(this.btnObtenerPorID);
            this.Controls.Add(this.btnObtenerTodos);
            this.Controls.Add(this.dgvCustomers);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCustomers;
        private System.Windows.Forms.Button btnObtenerTodos;
        private System.Windows.Forms.Button btnObtenerPorID;
        private System.Windows.Forms.TextBox txtBoxObtnerID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbCompannyName;
        private System.Windows.Forms.TextBox txbAddress;
        private System.Windows.Forms.TextBox txbContactTitle;
        private System.Windows.Forms.TextBox txbCustomerID;
        private System.Windows.Forms.TextBox txbContactName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnBorrar;
    }
}

