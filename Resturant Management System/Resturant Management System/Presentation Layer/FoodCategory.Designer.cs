namespace Resturant_Management_System.Presentation_Layer
{
    partial class FoodCategory
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
            this.category_Load_DataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.categoryName_TextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.add_CategoryButton = new System.Windows.Forms.Button();
            this.update_Category_Button = new System.Windows.Forms.Button();
            this.delete_Category_Button = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.category_Load_DataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // category_Load_DataGridView
            // 
            this.category_Load_DataGridView.AllowUserToAddRows = false;
            this.category_Load_DataGridView.AllowUserToDeleteRows = false;
            this.category_Load_DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.category_Load_DataGridView.Location = new System.Drawing.Point(489, 74);
            this.category_Load_DataGridView.Name = "category_Load_DataGridView";
            this.category_Load_DataGridView.ReadOnly = true;
            this.category_Load_DataGridView.RowHeadersWidth = 51;
            this.category_Load_DataGridView.RowTemplate.Height = 24;
            this.category_Load_DataGridView.Size = new System.Drawing.Size(329, 178);
            this.category_Load_DataGridView.TabIndex = 0;
            this.category_Load_DataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.category_Load_DataGridView_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Category Name";
            // 
            // categoryName_TextBox
            // 
            this.categoryName_TextBox.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryName_TextBox.Location = new System.Drawing.Point(180, 113);
            this.categoryName_TextBox.Name = "categoryName_TextBox";
            this.categoryName_TextBox.Size = new System.Drawing.Size(242, 29);
            this.categoryName_TextBox.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.delete_Category_Button);
            this.groupBox1.Controls.Add(this.update_Category_Button);
            this.groupBox1.Controls.Add(this.add_CategoryButton);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(13, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(450, 292);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Food Category";
            // 
            // add_CategoryButton
            // 
            this.add_CategoryButton.BackColor = System.Drawing.Color.OliveDrab;
            this.add_CategoryButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.add_CategoryButton.Location = new System.Drawing.Point(42, 180);
            this.add_CategoryButton.Name = "add_CategoryButton";
            this.add_CategoryButton.Size = new System.Drawing.Size(112, 43);
            this.add_CategoryButton.TabIndex = 0;
            this.add_CategoryButton.Text = "Add";
            this.add_CategoryButton.UseVisualStyleBackColor = false;
            this.add_CategoryButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // update_Category_Button
            // 
            this.update_Category_Button.BackColor = System.Drawing.Color.OliveDrab;
            this.update_Category_Button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.update_Category_Button.Location = new System.Drawing.Point(189, 180);
            this.update_Category_Button.Name = "update_Category_Button";
            this.update_Category_Button.Size = new System.Drawing.Size(106, 43);
            this.update_Category_Button.TabIndex = 0;
            this.update_Category_Button.Text = "Update";
            this.update_Category_Button.UseVisualStyleBackColor = false;
            this.update_Category_Button.Click += new System.EventHandler(this.update_Category_Button_Click);
            // 
            // delete_Category_Button
            // 
            this.delete_Category_Button.BackColor = System.Drawing.Color.OliveDrab;
            this.delete_Category_Button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.delete_Category_Button.Location = new System.Drawing.Point(335, 180);
            this.delete_Category_Button.Name = "delete_Category_Button";
            this.delete_Category_Button.Size = new System.Drawing.Size(93, 43);
            this.delete_Category_Button.TabIndex = 0;
            this.delete_Category_Button.Text = "Delete";
            this.delete_Category_Button.UseVisualStyleBackColor = false;
            this.delete_Category_Button.Click += new System.EventHandler(this.delete_Category_Button_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(485, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "List Of Category";
            // 
            // FoodCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(847, 338);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.categoryName_TextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.category_Load_DataGridView);
            this.Controls.Add(this.groupBox1);
            this.Name = "FoodCategory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FoodCategory_FormClosing);
            this.Load += new System.EventHandler(this.FoodCategory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.category_Load_DataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView category_Load_DataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox categoryName_TextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button delete_Category_Button;
        private System.Windows.Forms.Button update_Category_Button;
        private System.Windows.Forms.Button add_CategoryButton;
        private System.Windows.Forms.Label label2;
    }
}