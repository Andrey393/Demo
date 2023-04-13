namespace Досуг
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose ( bool disposing )
        {
            if (disposing && (components != null))
            {
                components.Dispose ( );
            }
            base.Dispose ( disposing );
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent ( )
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tableLogotip = new System.Windows.Forms.TableLayoutPanel();
            this.buttonAutorized = new System.Windows.Forms.Button();
            this.labelName = new System.Windows.Forms.Label();
            this.pictureBoxLogotip = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.DataGridEvent = new System.Windows.Forms.DataGridView();
            this.Image = new System.Windows.Forms.DataGridViewImageColumn();
            this.Decription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLogotip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogotip)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridEvent)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLogotip
            // 
            this.tableLogotip.ColumnCount = 3;
            this.tableLogotip.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.28572F));
            this.tableLogotip.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 76.71429F));
            this.tableLogotip.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 209F));
            this.tableLogotip.Controls.Add(this.buttonAutorized, 2, 0);
            this.tableLogotip.Controls.Add(this.labelName, 1, 0);
            this.tableLogotip.Controls.Add(this.pictureBoxLogotip, 0, 0);
            this.tableLogotip.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLogotip.Location = new System.Drawing.Point(0, 0);
            this.tableLogotip.Name = "tableLogotip";
            this.tableLogotip.RowCount = 1;
            this.tableLogotip.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLogotip.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLogotip.Size = new System.Drawing.Size(835, 100);
            this.tableLogotip.TabIndex = 0;
            // 
            // buttonAutorized
            // 
            this.buttonAutorized.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonAutorized.Location = new System.Drawing.Point(628, 3);
            this.buttonAutorized.Name = "buttonAutorized";
            this.buttonAutorized.Size = new System.Drawing.Size(204, 94);
            this.buttonAutorized.TabIndex = 0;
            this.buttonAutorized.Text = "Авторизация";
            this.buttonAutorized.UseVisualStyleBackColor = true;
            this.buttonAutorized.Click += new System.EventHandler(this.buttonAutorized_Click);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelName.Location = new System.Drawing.Point(148, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(474, 100);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "Главное окно";
            this.labelName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBoxLogotip
            // 
            this.pictureBoxLogotip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxLogotip.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxLogotip.Location = new System.Drawing.Point(3, 3);
            this.pictureBoxLogotip.Name = "pictureBoxLogotip";
            this.pictureBoxLogotip.Size = new System.Drawing.Size(139, 94);
            this.pictureBoxLogotip.TabIndex = 2;
            this.pictureBoxLogotip.TabStop = false;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75.86685F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.13315F));
            this.tableLayoutPanel2.Controls.Add(this.DataGridEvent, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 100);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(835, 523);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // DataGridEvent
            // 
            this.DataGridEvent.AllowUserToAddRows = false;
            this.DataGridEvent.AllowUserToDeleteRows = false;
            this.DataGridEvent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridEvent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Image,
            this.Decription});
            this.DataGridEvent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGridEvent.Location = new System.Drawing.Point(3, 3);
            this.DataGridEvent.Name = "DataGridEvent";
            this.DataGridEvent.ReadOnly = true;
            this.DataGridEvent.Size = new System.Drawing.Size(627, 517);
            this.DataGridEvent.TabIndex = 0;
            // 
            // Image
            // 
            this.Image.HeaderText = "Image";
            this.Image.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Image.Name = "Image";
            this.Image.ReadOnly = true;
            // 
            // Decription
            // 
            this.Decription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Decription.DefaultCellStyle = dataGridViewCellStyle1;
            this.Decription.HeaderText = "Decription";
            this.Decription.Name = "Decription";
            this.Decription.ReadOnly = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 623);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLogotip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(737, 662);
            this.Name = "MainForm";
            this.Text = "Главное окно";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tableLogotip.ResumeLayout(false);
            this.tableLogotip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogotip)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridEvent)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLogotip;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.DataGridView DataGridEvent;
        private System.Windows.Forms.Button buttonAutorized;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.PictureBox pictureBoxLogotip;
        private System.Windows.Forms.DataGridViewImageColumn Image;
        private System.Windows.Forms.DataGridViewTextBoxColumn Decription;
    }
}

