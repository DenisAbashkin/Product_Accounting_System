namespace Abashkin_Denis_MDM_171_333
{
    partial class NewTowarForm
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
            this.label5 = new System.Windows.Forms.Label();
            this.TowarNameBox = new System.Windows.Forms.TextBox();
            this.WeightBox = new System.Windows.Forms.TextBox();
            this.WholesailBox = new System.Windows.Forms.TextBox();
            this.RetailBox = new System.Windows.Forms.TextBox();
            this.ExtraInfoBox = new System.Windows.Forms.RichTextBox();
            this.AddTowarButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Название товара";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label2.Location = new System.Drawing.Point(12, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Вес 1 коробки (кг.)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label3.Location = new System.Drawing.Point(12, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Оптовая цена (шт.)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label4.Location = new System.Drawing.Point(12, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(165, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Розничная цена (шт.)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label5.Location = new System.Drawing.Point(12, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(229, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Дополнительная информация";
            // 
            // TowarNameBox
            // 
            this.TowarNameBox.Location = new System.Drawing.Point(246, 13);
            this.TowarNameBox.Name = "TowarNameBox";
            this.TowarNameBox.Size = new System.Drawing.Size(271, 20);
            this.TowarNameBox.TabIndex = 1;
            // 
            // WeightBox
            // 
            this.WeightBox.Location = new System.Drawing.Point(246, 38);
            this.WeightBox.Name = "WeightBox";
            this.WeightBox.Size = new System.Drawing.Size(271, 20);
            this.WeightBox.TabIndex = 1;
            // 
            // WholesailBox
            // 
            this.WholesailBox.Location = new System.Drawing.Point(246, 62);
            this.WholesailBox.Name = "WholesailBox";
            this.WholesailBox.Size = new System.Drawing.Size(271, 20);
            this.WholesailBox.TabIndex = 1;
            // 
            // RetailBox
            // 
            this.RetailBox.Location = new System.Drawing.Point(246, 88);
            this.RetailBox.Name = "RetailBox";
            this.RetailBox.Size = new System.Drawing.Size(271, 20);
            this.RetailBox.TabIndex = 1;
            // 
            // ExtraInfoBox
            // 
            this.ExtraInfoBox.Location = new System.Drawing.Point(247, 123);
            this.ExtraInfoBox.Name = "ExtraInfoBox";
            this.ExtraInfoBox.Size = new System.Drawing.Size(270, 96);
            this.ExtraInfoBox.TabIndex = 2;
            this.ExtraInfoBox.Text = "";
            // 
            // AddTowarButton
            // 
            this.AddTowarButton.Location = new System.Drawing.Point(16, 245);
            this.AddTowarButton.Name = "AddTowarButton";
            this.AddTowarButton.Size = new System.Drawing.Size(171, 40);
            this.AddTowarButton.TabIndex = 3;
            this.AddTowarButton.Text = "Добавить";
            this.AddTowarButton.UseVisualStyleBackColor = true;
            this.AddTowarButton.Click += new System.EventHandler(this.AddTowarButton_Click);
            // 
            // NewTowarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1000, 500);
            this.Controls.Add(this.AddTowarButton);
            this.Controls.Add(this.ExtraInfoBox);
            this.Controls.Add(this.RetailBox);
            this.Controls.Add(this.WholesailBox);
            this.Controls.Add(this.WeightBox);
            this.Controls.Add(this.TowarNameBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NewTowarForm";
            this.Text = "NewTowarForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TowarNameBox;
        private System.Windows.Forms.TextBox WeightBox;
        private System.Windows.Forms.TextBox WholesailBox;
        private System.Windows.Forms.TextBox RetailBox;
        private System.Windows.Forms.RichTextBox ExtraInfoBox;
        private System.Windows.Forms.Button AddTowarButton;
    }
}