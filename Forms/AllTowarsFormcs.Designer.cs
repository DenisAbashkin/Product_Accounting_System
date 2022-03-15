namespace Abashkin_Denis_MDM_171_333
{
    partial class AllTowarsFormcs
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
            this.AllTowarsView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.AllTowarsView)).BeginInit();
            this.SuspendLayout();
            // 
            // AllTowarsView
            // 
            this.AllTowarsView.AllowUserToAddRows = false;
            this.AllTowarsView.AllowUserToDeleteRows = false;
            this.AllTowarsView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.AllTowarsView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AllTowarsView.Location = new System.Drawing.Point(12, 12);
            this.AllTowarsView.Name = "AllTowarsView";
            this.AllTowarsView.ReadOnly = true;
            this.AllTowarsView.Size = new System.Drawing.Size(976, 476);
            this.AllTowarsView.TabIndex = 1;
            // 
            // AllTowarsFormcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1000, 500);
            this.Controls.Add(this.AllTowarsView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AllTowarsFormcs";
            this.Text = "AllTowarsFormcs";
            ((System.ComponentModel.ISupportInitialize)(this.AllTowarsView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView AllTowarsView;
    }
}