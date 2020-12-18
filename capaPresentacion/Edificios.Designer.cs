namespace capaPresentacion
{
    partial class Edificios
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtEdificio = new System.Windows.Forms.TextBox();
            this.txtAula = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DATAedificio = new System.Windows.Forms.DataGridView();
            this.DATAaulas = new System.Windows.Forms.DataGridView();
            this.cbEdificio = new System.Windows.Forms.ComboBox();
            this.cbAula = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.EdificioEditar = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.AulaEditar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DATAedificio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DATAaulas)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EdificioEditar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AulaEditar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(332, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Edificios";
            // 
            // txtEdificio
            // 
            this.txtEdificio.BackColor = System.Drawing.Color.Coral;
            this.txtEdificio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEdificio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEdificio.Location = new System.Drawing.Point(52, 127);
            this.txtEdificio.Name = "txtEdificio";
            this.txtEdificio.Size = new System.Drawing.Size(203, 15);
            this.txtEdificio.TabIndex = 2;
            this.txtEdificio.Text = "Edificio";
            // 
            // txtAula
            // 
            this.txtAula.BackColor = System.Drawing.Color.Coral;
            this.txtAula.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAula.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAula.Location = new System.Drawing.Point(52, 183);
            this.txtAula.Name = "txtAula";
            this.txtAula.Size = new System.Drawing.Size(203, 15);
            this.txtAula.TabIndex = 3;
            this.txtAula.Text = "Aula";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(235, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "______________________________________";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(235, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "______________________________________";
            // 
            // DATAedificio
            // 
            this.DATAedificio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DATAedificio.Location = new System.Drawing.Point(617, 155);
            this.DATAedificio.Name = "DATAedificio";
            this.DATAedificio.Size = new System.Drawing.Size(222, 117);
            this.DATAedificio.TabIndex = 11;
            this.DATAedificio.Visible = false;
            // 
            // DATAaulas
            // 
            this.DATAaulas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DATAaulas.Location = new System.Drawing.Point(617, 155);
            this.DATAaulas.Name = "DATAaulas";
            this.DATAaulas.Size = new System.Drawing.Size(222, 117);
            this.DATAaulas.TabIndex = 12;
            this.DATAaulas.Visible = false;
            // 
            // cbEdificio
            // 
            this.cbEdificio.FormattingEnabled = true;
            this.cbEdificio.Location = new System.Drawing.Point(676, 315);
            this.cbEdificio.Name = "cbEdificio";
            this.cbEdificio.Size = new System.Drawing.Size(104, 21);
            this.cbEdificio.TabIndex = 13;
            this.cbEdificio.Visible = false;
            this.cbEdificio.SelectedIndexChanged += new System.EventHandler(this.cbEdificio_SelectedIndexChanged);
            // 
            // cbAula
            // 
            this.cbAula.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAula.FormattingEnabled = true;
            this.cbAula.Location = new System.Drawing.Point(676, 342);
            this.cbAula.Name = "cbAula";
            this.cbAula.Size = new System.Drawing.Size(104, 21);
            this.cbAula.TabIndex = 14;
            this.cbAula.Visible = false;
            this.cbAula.SelectedIndexChanged += new System.EventHandler(this.cbAula_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(633, 97);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(206, 52);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(6, 29);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(67, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Edificio";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.Location = new System.Drawing.Point(154, 29);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(50, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Aula";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(37, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "Buscar para Modificar";
            // 
            // txtID
            // 
            this.txtID.BackColor = System.Drawing.Color.Coral;
            this.txtID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(676, 281);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(203, 15);
            this.txtID.TabIndex = 16;
            this.txtID.Text = "ID";
            this.txtID.Enter += new System.EventHandler(this.txtID_Enter);
            this.txtID.Leave += new System.EventHandler(this.txtID_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(673, 299);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "__________________";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox4.Image = global::capaPresentacion.Properties.Resources.icons8_edificio_64;
            this.pictureBox4.Location = new System.Drawing.Point(290, 127);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(33, 33);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 20;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::capaPresentacion.Properties.Resources.icons8_aula_512;
            this.pictureBox2.Location = new System.Drawing.Point(290, 183);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(33, 33);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 19;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click_1);
            // 
            // EdificioEditar
            // 
            this.EdificioEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EdificioEditar.Image = global::capaPresentacion.Properties.Resources.icons8_editar_64;
            this.EdificioEditar.Location = new System.Drawing.Point(794, 315);
            this.EdificioEditar.Name = "EdificioEditar";
            this.EdificioEditar.Size = new System.Drawing.Size(33, 33);
            this.EdificioEditar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.EdificioEditar.TabIndex = 18;
            this.EdificioEditar.TabStop = false;
            this.EdificioEditar.Visible = false;
            this.EdificioEditar.Click += new System.EventHandler(this.pictureBox3_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::capaPresentacion.Properties.Resources.icons8_edificio_64;
            this.pictureBox1.Location = new System.Drawing.Point(276, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // AulaEditar
            // 
            this.AulaEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AulaEditar.Image = global::capaPresentacion.Properties.Resources.icons8_editar_64;
            this.AulaEditar.Location = new System.Drawing.Point(794, 336);
            this.AulaEditar.Name = "AulaEditar";
            this.AulaEditar.Size = new System.Drawing.Size(33, 33);
            this.AulaEditar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.AulaEditar.TabIndex = 21;
            this.AulaEditar.TabStop = false;
            this.AulaEditar.Visible = false;
            this.AulaEditar.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // Edificios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Coral;
            this.ClientSize = new System.Drawing.Size(960, 381);
            this.Controls.Add(this.AulaEditar);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.EdificioEditar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cbAula);
            this.Controls.Add(this.cbEdificio);
            this.Controls.Add(this.DATAaulas);
            this.Controls.Add(this.DATAedificio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAula);
            this.Controls.Add(this.txtEdificio);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Edificios";
            this.Text = "Edificios";
            this.Load += new System.EventHandler(this.Edificios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DATAedificio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DATAaulas)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EdificioEditar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AulaEditar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtEdificio;
        private System.Windows.Forms.TextBox txtAula;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView DATAedificio;
        private System.Windows.Forms.DataGridView DATAaulas;
        private System.Windows.Forms.ComboBox cbEdificio;
        private System.Windows.Forms.ComboBox cbAula;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox EdificioEditar;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox AulaEditar;
    }
}