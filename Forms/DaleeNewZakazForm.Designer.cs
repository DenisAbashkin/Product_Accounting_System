namespace Abashkin_Denis_MDM_171_333
{
    partial class DaleeNewZakaz
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.DaleeZakazView = new System.Windows.Forms.DataGridView();
            this.TowarLbl = new System.Windows.Forms.Label();
            this.WeightLbl = new System.Windows.Forms.Label();
            this.WholesailLbl = new System.Windows.Forms.Label();
            this.RetailLbl = new System.Windows.Forms.Label();
            this.DaleeAddZakazButton = new System.Windows.Forms.Button();
            this.OrpacksBox = new System.Windows.Forms.TextBox();
            this.dateTimePickerDaleeZakaz = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DaleeZakazView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Название продукта";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Вес";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Оптовая цена";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(12, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Розничная цена";
            // 
            // DaleeZakazView
            // 
            this.DaleeZakazView.AllowUserToAddRows = false;
            this.DaleeZakazView.AllowUserToDeleteRows = false;
            this.DaleeZakazView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DaleeZakazView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DaleeZakazView.Location = new System.Drawing.Point(313, 47);
            this.DaleeZakazView.Name = "DaleeZakazView";
            this.DaleeZakazView.ReadOnly = true;
            this.DaleeZakazView.Size = new System.Drawing.Size(475, 277);
            this.DaleeZakazView.TabIndex = 1;
            this.DaleeZakazView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DaleeZakazView_CellClick);
            // 
            // TowarLbl
            // 
            this.TowarLbl.AutoSize = true;
            this.TowarLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TowarLbl.ForeColor = System.Drawing.Color.Green;
            this.TowarLbl.Location = new System.Drawing.Point(174, 47);
            this.TowarLbl.Name = "TowarLbl";
            this.TowarLbl.Size = new System.Drawing.Size(13, 16);
            this.TowarLbl.TabIndex = 0;
            this.TowarLbl.Text = "-";
            // 
            // WeightLbl
            // 
            this.WeightLbl.AutoSize = true;
            this.WeightLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WeightLbl.ForeColor = System.Drawing.Color.Green;
            this.WeightLbl.Location = new System.Drawing.Point(174, 74);
            this.WeightLbl.Name = "WeightLbl";
            this.WeightLbl.Size = new System.Drawing.Size(13, 16);
            this.WeightLbl.TabIndex = 0;
            this.WeightLbl.Text = "-";
            // 
            // WholesailLbl
            // 
            this.WholesailLbl.AutoSize = true;
            this.WholesailLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WholesailLbl.ForeColor = System.Drawing.Color.Green;
            this.WholesailLbl.Location = new System.Drawing.Point(174, 102);
            this.WholesailLbl.Name = "WholesailLbl";
            this.WholesailLbl.Size = new System.Drawing.Size(13, 16);
            this.WholesailLbl.TabIndex = 0;
            this.WholesailLbl.Text = "-";
            // 
            // RetailLbl
            // 
            this.RetailLbl.AutoSize = true;
            this.RetailLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RetailLbl.ForeColor = System.Drawing.Color.Green;
            this.RetailLbl.Location = new System.Drawing.Point(174, 129);
            this.RetailLbl.Name = "RetailLbl";
            this.RetailLbl.Size = new System.Drawing.Size(13, 16);
            this.RetailLbl.TabIndex = 0;
            this.RetailLbl.Text = "-";
            // 
            // DaleeAddZakazButton
            // 
            this.DaleeAddZakazButton.Location = new System.Drawing.Point(15, 380);
            this.DaleeAddZakazButton.Name = "DaleeAddZakazButton";
            this.DaleeAddZakazButton.Size = new System.Drawing.Size(233, 58);
            this.DaleeAddZakazButton.TabIndex = 2;
            this.DaleeAddZakazButton.Text = "Далее";
            this.DaleeAddZakazButton.UseVisualStyleBackColor = true;
            this.DaleeAddZakazButton.Click += new System.EventHandler(this.DaleeAddZakazButton_Click);
            // 
            // OrpacksBox
            // 
            this.OrpacksBox.Location = new System.Drawing.Point(313, 13);
            this.OrpacksBox.Name = "OrpacksBox";
            this.OrpacksBox.Size = new System.Drawing.Size(213, 20);
            this.OrpacksBox.TabIndex = 3;
            // 
            // dateTimePickerDaleeZakaz
            // 
            this.dateTimePickerDaleeZakaz.CustomFormat = "";
            this.dateTimePickerDaleeZakaz.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDaleeZakaz.Location = new System.Drawing.Point(15, 354);
            this.dateTimePickerDaleeZakaz.Name = "dateTimePickerDaleeZakaz";
            this.dateTimePickerDaleeZakaz.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerDaleeZakaz.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(249, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Кол-во";
            // 
            // DaleeNewZakaz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dateTimePickerDaleeZakaz);
            this.Controls.Add(this.OrpacksBox);
            this.Controls.Add(this.DaleeAddZakazButton);
            this.Controls.Add(this.DaleeZakazView);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.RetailLbl);
            this.Controls.Add(this.WholesailLbl);
            this.Controls.Add(this.WeightLbl);
            this.Controls.Add(this.TowarLbl);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Name = "DaleeNewZakaz";
            this.Text = "DaleeNewZakaz";
            ((System.ComponentModel.ISupportInitialize)(this.DaleeZakazView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView DaleeZakazView;
        private System.Windows.Forms.Label TowarLbl;
        private System.Windows.Forms.Label WeightLbl;
        private System.Windows.Forms.Label WholesailLbl;
        private System.Windows.Forms.Label RetailLbl;
        private System.Windows.Forms.Button DaleeAddZakazButton;
        private System.Windows.Forms.TextBox OrpacksBox;
        private System.Windows.Forms.DateTimePicker dateTimePickerDaleeZakaz;
        private System.Windows.Forms.Label label5;
    }
}