
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
            this.SuspendLayout();
            // 
            // btnAddFiltr
            // 
            this.btnAddFiltr.Location = new System.Drawing.Point(813, 27);
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
            this.cbFilters.Location = new System.Drawing.Point(283, 48);
            this.cbFilters.Name = "cbFilters";
            this.cbFilters.Size = new System.Drawing.Size(222, 28);
            this.cbFilters.TabIndex = 1;
            this.cbFilters.SelectedIndexChanged += new System.EventHandler(this.cbFilters_SelectedIndexChanged);
            // 
            // tbFilterValue
            // 
            this.tbFilterValue.Location = new System.Drawing.Point(555, 48);
            this.tbFilterValue.Name = "tbFilterValue";
            this.tbFilterValue.Size = new System.Drawing.Size(222, 27);
            this.tbFilterValue.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(283, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Виберіть категорію ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(555, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Введіть назву фільтра";
            // 
            // btnFilterName
            // 
            this.btnFilterName.Location = new System.Drawing.Point(813, 96);
            this.btnFilterName.Name = "btnFilterName";
            this.btnFilterName.Size = new System.Drawing.Size(167, 48);
            this.btnFilterName.TabIndex = 5;
            this.btnFilterName.Text = "Додати категорію";
            this.btnFilterName.UseVisualStyleBackColor = true;
            this.btnFilterName.Click += new System.EventHandler(this.btnFilterName_Click);
            // 
            // tbFilterName
            // 
            this.tbFilterName.Location = new System.Drawing.Point(283, 114);
            this.tbFilterName.Name = "tbFilterName";
            this.tbFilterName.Size = new System.Drawing.Size(222, 27);
            this.tbFilterName.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(283, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(237, 23);
            this.label3.TabIndex = 7;
            this.label3.Text = "Введіть назву нової категорії";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 555);
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
    }
}

