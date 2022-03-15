namespace Abashkin_Denis_MDM_171_333
{
    partial class AllZakazForm
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
            this.AllZakazView = new System.Windows.Forms.DataGridView();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SearchZakazBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SearchButton = new System.Windows.Forms.Button();
            this.SearchName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ChangeZakazButton = new System.Windows.Forms.Button();
            this.TowarNameBox = new System.Windows.Forms.TextBox();
            this.PostavhikNameBox = new System.Windows.Forms.TextBox();
            this.orPacksBox = new System.Windows.Forms.TextBox();
            this.IDBox = new System.Windows.Forms.TextBox();
            this.AddStorageButton = new System.Windows.Forms.Button();
            this.PhoneBox = new System.Windows.Forms.TextBox();
            this.dataBox = new System.Windows.Forms.TextBox();
            this.UserBox = new System.Windows.Forms.TextBox();
            this.DateHideBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.AllZakazView)).BeginInit();
            this.SuspendLayout();
            // 
            // AllZakazView
            // 
            this.AllZakazView.AllowUserToAddRows = false;
            this.AllZakazView.AllowUserToDeleteRows = false;
            this.AllZakazView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.AllZakazView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AllZakazView.Location = new System.Drawing.Point(12, 138);
            this.AllZakazView.Name = "AllZakazView";
            this.AllZakazView.ReadOnly = true;
            this.AllZakazView.Size = new System.Drawing.Size(960, 283);
            this.AllZakazView.TabIndex = 0;
            this.AllZakazView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AllZakazView_CellClick);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(458, 65);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 1;
            this.dateTimePicker1.Value = new System.DateTime(2021, 1, 1, 9, 39, 0, 0);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(748, 65);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 1;
            this.dateTimePicker2.Value = new System.DateTime(2021, 3, 30, 9, 39, 0, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(399, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "От";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(693, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "До";
            // 
            // SearchZakazBox
            // 
            this.SearchZakazBox.Location = new System.Drawing.Point(90, 28);
            this.SearchZakazBox.Name = "SearchZakazBox";
            this.SearchZakazBox.Size = new System.Drawing.Size(192, 20);
            this.SearchZakazBox.TabIndex = 3;
            this.SearchZakazBox.TextChanged += new System.EventHandler(this.SearchZakazBox_TextChanged_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(31, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Поиск";
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(297, 62);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(75, 23);
            this.SearchButton.TabIndex = 4;
            this.SearchButton.Text = "Поиск";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // SearchName
            // 
            this.SearchName.Location = new System.Drawing.Point(649, 27);
            this.SearchName.Name = "SearchName";
            this.SearchName.Size = new System.Drawing.Size(172, 20);
            this.SearchName.TabIndex = 5;
            this.SearchName.TextChanged += new System.EventHandler(this.SearchName_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(455, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(188, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Поиск кто провел заказ";
            // 
            // ChangeZakazButton
            // 
            this.ChangeZakazButton.Location = new System.Drawing.Point(12, 427);
            this.ChangeZakazButton.Name = "ChangeZakazButton";
            this.ChangeZakazButton.Size = new System.Drawing.Size(75, 23);
            this.ChangeZakazButton.TabIndex = 6;
            this.ChangeZakazButton.Text = "Изменить";
            this.ChangeZakazButton.UseVisualStyleBackColor = true;
            this.ChangeZakazButton.Click += new System.EventHandler(this.ChangeZakazButton_Click);
            // 
            // TowarNameBox
            // 
            this.TowarNameBox.Location = new System.Drawing.Point(157, 106);
            this.TowarNameBox.Name = "TowarNameBox";
            this.TowarNameBox.Size = new System.Drawing.Size(100, 20);
            this.TowarNameBox.TabIndex = 7;
            // 
            // PostavhikNameBox
            // 
            this.PostavhikNameBox.Location = new System.Drawing.Point(423, 106);
            this.PostavhikNameBox.Name = "PostavhikNameBox";
            this.PostavhikNameBox.Size = new System.Drawing.Size(138, 20);
            this.PostavhikNameBox.TabIndex = 7;
            // 
            // orPacksBox
            // 
            this.orPacksBox.Location = new System.Drawing.Point(297, 106);
            this.orPacksBox.Name = "orPacksBox";
            this.orPacksBox.Size = new System.Drawing.Size(100, 20);
            this.orPacksBox.TabIndex = 7;
            // 
            // IDBox
            // 
            this.IDBox.Location = new System.Drawing.Point(12, 106);
            this.IDBox.Name = "IDBox";
            this.IDBox.ReadOnly = true;
            this.IDBox.Size = new System.Drawing.Size(100, 20);
            this.IDBox.TabIndex = 8;
            // 
            // AddStorageButton
            // 
            this.AddStorageButton.Location = new System.Drawing.Point(852, 427);
            this.AddStorageButton.Name = "AddStorageButton";
            this.AddStorageButton.Size = new System.Drawing.Size(120, 23);
            this.AddStorageButton.TabIndex = 9;
            this.AddStorageButton.Text = "Провести заказ";
            this.AddStorageButton.UseVisualStyleBackColor = true;
            this.AddStorageButton.Click += new System.EventHandler(this.AddStorageButton_Click);
            // 
            // PhoneBox
            // 
            this.PhoneBox.Location = new System.Drawing.Point(567, 106);
            this.PhoneBox.Name = "PhoneBox";
            this.PhoneBox.ReadOnly = true;
            this.PhoneBox.Size = new System.Drawing.Size(127, 20);
            this.PhoneBox.TabIndex = 7;
            // 
            // dataBox
            // 
            this.dataBox.Location = new System.Drawing.Point(836, 106);
            this.dataBox.Name = "dataBox";
            this.dataBox.ReadOnly = true;
            this.dataBox.Size = new System.Drawing.Size(119, 20);
            this.dataBox.TabIndex = 7;
            // 
            // UserBox
            // 
            this.UserBox.Location = new System.Drawing.Point(711, 106);
            this.UserBox.Name = "UserBox";
            this.UserBox.ReadOnly = true;
            this.UserBox.Size = new System.Drawing.Size(119, 20);
            this.UserBox.TabIndex = 7;
            // 
            // DateHideBox
            // 
            this.DateHideBox.Location = new System.Drawing.Point(711, 429);
            this.DateHideBox.Name = "DateHideBox";
            this.DateHideBox.ReadOnly = true;
            this.DateHideBox.Size = new System.Drawing.Size(100, 20);
            this.DateHideBox.TabIndex = 10;
            this.DateHideBox.Visible = false;
            // 
            // AllZakazForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(984, 461);
            this.Controls.Add(this.DateHideBox);
            this.Controls.Add(this.AddStorageButton);
            this.Controls.Add(this.IDBox);
            this.Controls.Add(this.orPacksBox);
            this.Controls.Add(this.UserBox);
            this.Controls.Add(this.dataBox);
            this.Controls.Add(this.PhoneBox);
            this.Controls.Add(this.PostavhikNameBox);
            this.Controls.Add(this.TowarNameBox);
            this.Controls.Add(this.ChangeZakazButton);
            this.Controls.Add(this.SearchName);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.SearchZakazBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.AllZakazView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AllZakazForm";
            this.Text = "AllZakazForm";
            ((System.ComponentModel.ISupportInitialize)(this.AllZakazView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView AllZakazView;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox SearchZakazBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.TextBox SearchName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button ChangeZakazButton;
        private System.Windows.Forms.TextBox TowarNameBox;
        private System.Windows.Forms.TextBox PostavhikNameBox;
        private System.Windows.Forms.TextBox orPacksBox;
        private System.Windows.Forms.TextBox IDBox;
        private System.Windows.Forms.Button AddStorageButton;
        private System.Windows.Forms.TextBox PhoneBox;
        private System.Windows.Forms.TextBox dataBox;
        private System.Windows.Forms.TextBox UserBox;
        private System.Windows.Forms.TextBox DateHideBox;
    }
}