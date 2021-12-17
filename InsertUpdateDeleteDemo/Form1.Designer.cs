
namespace InsertUpdateDeleteDemo
{
    partial class frmMain
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Insert = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.Update = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.in_vendita = new System.Windows.Forms.TextBox();
            this.id_proprietario = new System.Windows.Forms.TextBox();
            this.prezzo = new System.Windows.Forms.TextBox();
            this.vani = new System.Windows.Forms.TextBox();
            this.superficie = new System.Windows.Forms.TextBox();
            this.via = new System.Windows.Forms.TextBox();
            this.id_tipo = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(811, 450);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            // 
            // Insert
            // 
            this.Insert.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Insert.Location = new System.Drawing.Point(0, 427);
            this.Insert.Name = "Insert";
            this.Insert.Size = new System.Drawing.Size(811, 23);
            this.Insert.TabIndex = 1;
            this.Insert.Text = "Insert";
            this.Insert.UseVisualStyleBackColor = true;
            this.Insert.Click += new System.EventHandler(this.Insert_Click);
            // 
            // Delete
            // 
            this.Delete.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Delete.Location = new System.Drawing.Point(0, 404);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(811, 23);
            this.Delete.TabIndex = 2;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Update
            // 
            this.Update.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Update.Location = new System.Drawing.Point(0, 381);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(811, 23);
            this.Update.TabIndex = 3;
            this.Update.Text = "Update";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.in_vendita);
            this.groupBox1.Controls.Add(this.id_proprietario);
            this.groupBox1.Controls.Add(this.prezzo);
            this.groupBox1.Controls.Add(this.vani);
            this.groupBox1.Controls.Add(this.superficie);
            this.groupBox1.Controls.Add(this.via);
            this.groupBox1.Controls.Add(this.id_tipo);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox1.Location = new System.Drawing.Point(611, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 381);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Inserimento";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(109, 248);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "in_vendita";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(109, 208);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "id_proprietario";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(109, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "prezzo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(109, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "vani";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(109, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "superficie";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(109, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "via";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(109, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "id_tipo";
            // 
            // in_vendita
            // 
            this.in_vendita.Location = new System.Drawing.Point(3, 241);
            this.in_vendita.Name = "in_vendita";
            this.in_vendita.Size = new System.Drawing.Size(100, 20);
            this.in_vendita.TabIndex = 6;
            // 
            // id_proprietario
            // 
            this.id_proprietario.Location = new System.Drawing.Point(3, 201);
            this.id_proprietario.Name = "id_proprietario";
            this.id_proprietario.Size = new System.Drawing.Size(100, 20);
            this.id_proprietario.TabIndex = 5;
            // 
            // prezzo
            // 
            this.prezzo.Location = new System.Drawing.Point(3, 162);
            this.prezzo.Name = "prezzo";
            this.prezzo.Size = new System.Drawing.Size(100, 20);
            this.prezzo.TabIndex = 4;
            // 
            // vani
            // 
            this.vani.Location = new System.Drawing.Point(3, 126);
            this.vani.Name = "vani";
            this.vani.Size = new System.Drawing.Size(100, 20);
            this.vani.TabIndex = 3;
            // 
            // superficie
            // 
            this.superficie.Location = new System.Drawing.Point(3, 91);
            this.superficie.Name = "superficie";
            this.superficie.Size = new System.Drawing.Size(100, 20);
            this.superficie.TabIndex = 2;
            // 
            // via
            // 
            this.via.Location = new System.Drawing.Point(3, 56);
            this.via.Name = "via";
            this.via.Size = new System.Drawing.Size(100, 20);
            this.via.TabIndex = 1;
            // 
            // id_tipo
            // 
            this.id_tipo.Location = new System.Drawing.Point(3, 19);
            this.id_tipo.Name = "id_tipo";
            this.id_tipo.Size = new System.Drawing.Size(100, 20);
            this.id_tipo.TabIndex = 0;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Insert);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmMain";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Insert;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox in_vendita;
        private System.Windows.Forms.TextBox id_proprietario;
        private System.Windows.Forms.TextBox prezzo;
        private System.Windows.Forms.TextBox vani;
        private System.Windows.Forms.TextBox superficie;
        private System.Windows.Forms.TextBox via;
        private System.Windows.Forms.TextBox id_tipo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

