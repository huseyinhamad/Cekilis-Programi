
namespace Aybey_Çekiliş
{
    partial class Main
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.labelHowMany = new System.Windows.Forms.Label();
            this.numericUpDownHowMany = new System.Windows.Forms.NumericUpDown();
            this.labelGiveAway = new System.Windows.Forms.Label();
            this.textBoxGiveAway = new System.Windows.Forms.TextBox();
            this.buttonGiveAway = new System.Windows.Forms.Button();
            this.dataGridViewGiveAwayResults = new System.Windows.Forms.DataGridView();
            this.ColumnWinnerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnGiveAway = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelGz = new System.Windows.Forms.Label();
            this.buttonClearGiveAway = new System.Windows.Forms.Button();
            this.buttonSaveGiveAway = new System.Windows.Forms.Button();
            this.buttonClearAttendance = new System.Windows.Forms.Button();
            this.labelAttendance = new System.Windows.Forms.Label();
            this.buttonAddName = new System.Windows.Forms.Button();
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.listBoxNames = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHowMany)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGiveAwayResults)).BeginInit();
            this.SuspendLayout();
            // 
            // labelHowMany
            // 
            this.labelHowMany.AutoSize = true;
            this.labelHowMany.Font = new System.Drawing.Font("Castellar", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelHowMany.Location = new System.Drawing.Point(306, 51);
            this.labelHowMany.Name = "labelHowMany";
            this.labelHowMany.Size = new System.Drawing.Size(110, 14);
            this.labelHowMany.TabIndex = 8;
            this.labelHowMany.Text = "Kaç Kişi Çekilecek:";
            // 
            // numericUpDownHowMany
            // 
            this.numericUpDownHowMany.Location = new System.Drawing.Point(422, 49);
            this.numericUpDownHowMany.Name = "numericUpDownHowMany";
            this.numericUpDownHowMany.Size = new System.Drawing.Size(49, 20);
            this.numericUpDownHowMany.TabIndex = 9;
            this.numericUpDownHowMany.ValueChanged += new System.EventHandler(this.numericUpDownHowMany_ValueChanged);
            // 
            // labelGiveAway
            // 
            this.labelGiveAway.AutoSize = true;
            this.labelGiveAway.Font = new System.Drawing.Font("Castellar", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelGiveAway.Location = new System.Drawing.Point(306, 27);
            this.labelGiveAway.Name = "labelGiveAway";
            this.labelGiveAway.Size = new System.Drawing.Size(48, 14);
            this.labelGiveAway.TabIndex = 6;
            this.labelGiveAway.Text = "Çekiliş:";
            // 
            // textBoxGiveAway
            // 
            this.textBoxGiveAway.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxGiveAway.Location = new System.Drawing.Point(360, 24);
            this.textBoxGiveAway.Name = "textBoxGiveAway";
            this.textBoxGiveAway.Size = new System.Drawing.Size(292, 20);
            this.textBoxGiveAway.TabIndex = 7;
            // 
            // buttonGiveAway
            // 
            this.buttonGiveAway.Font = new System.Drawing.Font("Castellar", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonGiveAway.Location = new System.Drawing.Point(309, 75);
            this.buttonGiveAway.Name = "buttonGiveAway";
            this.buttonGiveAway.Size = new System.Drawing.Size(343, 30);
            this.buttonGiveAway.TabIndex = 10;
            this.buttonGiveAway.Text = "Çek";
            this.buttonGiveAway.UseVisualStyleBackColor = true;
            this.buttonGiveAway.Click += new System.EventHandler(this.buttonGiveAway_Click);
            // 
            // dataGridViewGiveAwayResults
            // 
            this.dataGridViewGiveAwayResults.AllowUserToAddRows = false;
            this.dataGridViewGiveAwayResults.AllowUserToDeleteRows = false;
            this.dataGridViewGiveAwayResults.AllowUserToResizeRows = false;
            this.dataGridViewGiveAwayResults.BackgroundColor = System.Drawing.Color.Cornsilk;
            this.dataGridViewGiveAwayResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewGiveAwayResults.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnWinnerName,
            this.ColumnGiveAway});
            this.dataGridViewGiveAwayResults.Location = new System.Drawing.Point(309, 141);
            this.dataGridViewGiveAwayResults.Name = "dataGridViewGiveAwayResults";
            this.dataGridViewGiveAwayResults.ReadOnly = true;
            this.dataGridViewGiveAwayResults.Size = new System.Drawing.Size(343, 282);
            this.dataGridViewGiveAwayResults.TabIndex = 12;
            this.dataGridViewGiveAwayResults.Visible = false;
            // 
            // ColumnWinnerName
            // 
            this.ColumnWinnerName.HeaderText = "Kazanan";
            this.ColumnWinnerName.Name = "ColumnWinnerName";
            this.ColumnWinnerName.ReadOnly = true;
            this.ColumnWinnerName.Width = 150;
            // 
            // ColumnGiveAway
            // 
            this.ColumnGiveAway.HeaderText = "Kazanılan";
            this.ColumnGiveAway.Name = "ColumnGiveAway";
            this.ColumnGiveAway.ReadOnly = true;
            this.ColumnGiveAway.Width = 150;
            // 
            // labelGz
            // 
            this.labelGz.AutoSize = true;
            this.labelGz.Font = new System.Drawing.Font("Castellar", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelGz.Location = new System.Drawing.Point(306, 112);
            this.labelGz.Name = "labelGz";
            this.labelGz.Size = new System.Drawing.Size(306, 14);
            this.labelGz.TabIndex = 11;
            this.labelGz.Text = "Çekiliş Sonuçları Aşağıdadır. Kazananları Tebrik Ederiz.";
            this.labelGz.Visible = false;
            // 
            // buttonClearGiveAway
            // 
            this.buttonClearGiveAway.Font = new System.Drawing.Font("Castellar", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonClearGiveAway.Location = new System.Drawing.Point(483, 429);
            this.buttonClearGiveAway.Name = "buttonClearGiveAway";
            this.buttonClearGiveAway.Size = new System.Drawing.Size(169, 29);
            this.buttonClearGiveAway.TabIndex = 14;
            this.buttonClearGiveAway.Text = "Çekiliş Sonuçlarını Temizle";
            this.buttonClearGiveAway.UseVisualStyleBackColor = true;
            this.buttonClearGiveAway.Visible = false;
            this.buttonClearGiveAway.Click += new System.EventHandler(this.buttonClearGiveAway_Click);
            // 
            // buttonSaveGiveAway
            // 
            this.buttonSaveGiveAway.Font = new System.Drawing.Font("Castellar", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonSaveGiveAway.Location = new System.Drawing.Point(309, 429);
            this.buttonSaveGiveAway.Name = "buttonSaveGiveAway";
            this.buttonSaveGiveAway.Size = new System.Drawing.Size(162, 29);
            this.buttonSaveGiveAway.TabIndex = 13;
            this.buttonSaveGiveAway.Text = "Çekiliş Sonuçlarını Kaydet";
            this.buttonSaveGiveAway.UseVisualStyleBackColor = true;
            this.buttonSaveGiveAway.Visible = false;
            this.buttonSaveGiveAway.Click += new System.EventHandler(this.buttonSaveGiveAway_Click);
            // 
            // buttonClearAttendance
            // 
            this.buttonClearAttendance.Font = new System.Drawing.Font("Castellar", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonClearAttendance.Location = new System.Drawing.Point(22, 429);
            this.buttonClearAttendance.Name = "buttonClearAttendance";
            this.buttonClearAttendance.Size = new System.Drawing.Size(272, 30);
            this.buttonClearAttendance.TabIndex = 5;
            this.buttonClearAttendance.Text = "Bütün Katılımcıları Temizle";
            this.buttonClearAttendance.UseVisualStyleBackColor = true;
            this.buttonClearAttendance.Click += new System.EventHandler(this.buttonClearAttendance_Click);
            // 
            // labelAttendance
            // 
            this.labelAttendance.AutoSize = true;
            this.labelAttendance.Font = new System.Drawing.Font("Castellar", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelAttendance.Location = new System.Drawing.Point(19, 52);
            this.labelAttendance.Name = "labelAttendance";
            this.labelAttendance.Size = new System.Drawing.Size(70, 14);
            this.labelAttendance.TabIndex = 3;
            this.labelAttendance.Text = "Katılımcılar:";
            // 
            // buttonAddName
            // 
            this.buttonAddName.Font = new System.Drawing.Font("Castellar", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonAddName.Location = new System.Drawing.Point(224, 24);
            this.buttonAddName.Name = "buttonAddName";
            this.buttonAddName.Size = new System.Drawing.Size(70, 23);
            this.buttonAddName.TabIndex = 2;
            this.buttonAddName.Text = "Ekle";
            this.buttonAddName.UseVisualStyleBackColor = true;
            this.buttonAddName.Click += new System.EventHandler(this.buttonAddName_Click);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Castellar", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelName.Location = new System.Drawing.Point(19, 28);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(56, 14);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Katılımcı:";
            // 
            // textBoxName
            // 
            this.textBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxName.Location = new System.Drawing.Point(81, 25);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(138, 20);
            this.textBoxName.TabIndex = 1;
            // 
            // listBoxNames
            // 
            this.listBoxNames.BackColor = System.Drawing.Color.Cornsilk;
            this.listBoxNames.Font = new System.Drawing.Font("Castellar", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listBoxNames.FormattingEnabled = true;
            this.listBoxNames.ItemHeight = 14;
            this.listBoxNames.Location = new System.Drawing.Point(22, 69);
            this.listBoxNames.Name = "listBoxNames";
            this.listBoxNames.Size = new System.Drawing.Size(272, 354);
            this.listBoxNames.TabIndex = 4;
            this.listBoxNames.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBoxNames_DoubleClick);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(664, 473);
            this.Controls.Add(this.buttonClearAttendance);
            this.Controls.Add(this.labelAttendance);
            this.Controls.Add(this.buttonAddName);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.listBoxNames);
            this.Controls.Add(this.buttonSaveGiveAway);
            this.Controls.Add(this.buttonClearGiveAway);
            this.Controls.Add(this.labelGz);
            this.Controls.Add(this.dataGridViewGiveAwayResults);
            this.Controls.Add(this.buttonGiveAway);
            this.Controls.Add(this.textBoxGiveAway);
            this.Controls.Add(this.labelGiveAway);
            this.Controls.Add(this.numericUpDownHowMany);
            this.Controls.Add(this.labelHowMany);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Text = "Aybey Çekiliş";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHowMany)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGiveAwayResults)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelHowMany;
        private System.Windows.Forms.NumericUpDown numericUpDownHowMany;
        private System.Windows.Forms.Label labelGiveAway;
        private System.Windows.Forms.TextBox textBoxGiveAway;
        private System.Windows.Forms.Button buttonGiveAway;
        private System.Windows.Forms.DataGridView dataGridViewGiveAwayResults;
        private System.Windows.Forms.Label labelGz;
        private System.Windows.Forms.Button buttonClearGiveAway;
        private System.Windows.Forms.Button buttonSaveGiveAway;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnWinnerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnGiveAway;
        private System.Windows.Forms.Button buttonClearAttendance;
        private System.Windows.Forms.Label labelAttendance;
        private System.Windows.Forms.Button buttonAddName;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.ListBox listBoxNames;
    }
}

