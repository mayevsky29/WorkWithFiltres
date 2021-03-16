
namespace AddFiltrsInMagazine
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAddFiltr = new System.Windows.Forms.Button();
            this.cbFilters = new System.Windows.Forms.ComboBox();
            this.tbFilterValue = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnFilterName = new System.Windows.Forms.Button();
            this.tbFilterName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.btnFind = new System.Windows.Forms.Button();
            this.ColId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColImage = new System.Windows.Forms.DataGridViewImageColumn();
            this.ColName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddFiltr
            // 
            this.btnAddFiltr.Location = new System.Drawing.Point(741, 22);
            this.btnAddFiltr.Name = "btnAddFiltr";
            this.btnAddFiltr.Size = new System.Drawing.Size(167, 48);
            this.btnAddFiltr.TabIndex = 0;
            this.btnAddFiltr.Text = "Додати фільтр";
            this.btnAddFiltr.UseVisualStyleBackColor = true;
            this.btnAddFiltr.AutoSizeChanged += new System.EventHandler(this.btnAddFiltr_AutoSizeChanged);
            this.btnAddFiltr.Click += new System.EventHandler(this.btnAddFiltr_Click);
            // 
            // cbFilters
            // 
            this.cbFilters.FormattingEnabled = true;
            this.cbFilters.Location = new System.Drawing.Point(241, 43);
            this.cbFilters.Name = "cbFilters";
            this.cbFilters.Size = new System.Drawing.Size(222, 28);
            this.cbFilters.TabIndex = 1;
            this.cbFilters.SelectedIndexChanged += new System.EventHandler(this.cbFilters_SelectedIndexChanged);
            // 
            // tbFilterValue
            // 
            this.tbFilterValue.Location = new System.Drawing.Point(513, 43);
            this.tbFilterValue.Name = "tbFilterValue";
            this.tbFilterValue.Size = new System.Drawing.Size(222, 27);
            this.tbFilterValue.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(241, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Виберіть категорію ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(513, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Введіть назву фільтра";
            // 
            // btnFilterName
            // 
            this.btnFilterName.Location = new System.Drawing.Point(741, 88);
            this.btnFilterName.Name = "btnFilterName";
            this.btnFilterName.Size = new System.Drawing.Size(167, 48);
            this.btnFilterName.TabIndex = 5;
            this.btnFilterName.Text = "Додати категорію";
            this.btnFilterName.UseVisualStyleBackColor = true;
            this.btnFilterName.Click += new System.EventHandler(this.btnFilterName_Click);
            // 
            // tbFilterName
            // 
            this.tbFilterName.Location = new System.Drawing.Point(241, 109);
            this.tbFilterName.Name = "tbFilterName";
            this.tbFilterName.Size = new System.Drawing.Size(222, 27);
            this.tbFilterName.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(241, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(237, 23);
            this.label3.TabIndex = 7;
            this.label3.Text = "Введіть назву нової категорії";
            // 
            // dgvProducts
            // 
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColId,
            this.ColImage,
            this.ColName,
            this.ColPrice});
            this.dgvProducts.Location = new System.Drawing.Point(241, 214);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.RowHeadersWidth = 51;
            this.dgvProducts.RowTemplate.Height = 29;
            this.dgvProducts.Size = new System.Drawing.Size(667, 344);
            this.dgvProducts.TabIndex = 8;
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(741, 151);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(167, 48);
            this.btnFind.TabIndex = 9;
            this.btnFind.Text = "Пошук";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // ColId
            // 
            this.ColId.HeaderText = "Id";
            this.ColId.MinimumWidth = 6;
            this.ColId.Name = "ColId";
            this.ColId.Width = 50;
            // 
            // ColImage
            // 
            this.ColImage.HeaderText = "Фото";
            this.ColImage.MinimumWidth = 6;
            this.ColImage.Name = "ColImage";
            // 
            // ColName
            // 
            this.ColName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColName.HeaderText = "Назва";
            this.ColName.MinimumWidth = 6;
            this.ColName.Name = "ColName";
            // 
            // ColPrice
            // 
            this.ColPrice.HeaderText = "Ціна";
            this.ColPrice.MinimumWidth = 6;
            this.ColPrice.Name = "ColPrice";
            this.ColPrice.Width = 125;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 571);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.dgvProducts);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbFilterName);
            this.Controls.Add(this.btnFilterName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbFilterValue);
            this.Controls.Add(this.cbFilters);
            this.Controls.Add(this.btnAddFiltr);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddFiltr;
        private System.Windows.Forms.ComboBox cbFilters;
        private System.Windows.Forms.TextBox tbFilterValue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnFilterName;
        private System.Windows.Forms.TextBox tbFilterName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColId;
        private System.Windows.Forms.DataGridViewImageColumn ColImage;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPrice;
    }
}

