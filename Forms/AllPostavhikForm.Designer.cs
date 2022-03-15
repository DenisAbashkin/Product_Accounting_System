namespace Abashkin_Denis_MDM_171_333
{
    partial class AllPostavhikForm
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
            this.AllPostavhiksView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.AllPostavhiksView)).BeginInit();
            this.SuspendLayout();
            // 
            // AllPostavhiksView
            // 
            this.AllPostavhiksView.AllowUserToAddRows = false;
            this.AllPostavhiksView.AllowUserToDeleteRows = false;
            this.AllPostavhiksView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.AllPostavhiksView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AllPostavhiksView.Location = new System.Drawing.Point(12, 12);
            this.AllPostavhiksView.Name = "AllPostavhiksView";
            this.AllPostavhiksView.ReadOnly = true;
            this.AllPostavhiksView.Size = new System.Drawing.Size(976, 476);
            this.AllPostavhiksView.TabIndex = 0;
            // 
            // AllPostavhikForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1000, 500);
            this.Controls.Add(this.AllPostavhiksView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AllPostavhikForm";
            this.Text = "AllPostavhikForm";
            ((System.ComponentModel.ISupportInitialize)(this.AllPostavhiksView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView AllPostavhiksView;
    }
}