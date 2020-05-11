namespace CST_117_MilestoneProject
{
    partial class Form1
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
            this.tb_example = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.buttonRestockAll = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.labelSearch = new System.Windows.Forms.Label();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.buttonRestock = new System.Windows.Forms.Button();
            this.labelAddError = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_example
            // 
            this.tb_example.ForeColor = System.Drawing.Color.Black;
            this.tb_example.Location = new System.Drawing.Point(32, 34);
            this.tb_example.Name = "tb_example";
            this.tb_example.Size = new System.Drawing.Size(432, 96);
            this.tb_example.TabIndex = 0;
            this.tb_example.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Current Items In Inventory";
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(197, 198);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(161, 20);
            this.textBoxSearch.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Search for item by name or price:";
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(378, 194);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(75, 23);
            this.buttonSearch.TabIndex = 5;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // buttonRestockAll
            // 
            this.buttonRestockAll.Location = new System.Drawing.Point(333, 136);
            this.buttonRestockAll.Name = "buttonRestockAll";
            this.buttonRestockAll.Size = new System.Drawing.Size(75, 23);
            this.buttonRestockAll.TabIndex = 6;
            this.buttonRestockAll.Text = "Restock All";
            this.buttonRestockAll.UseVisualStyleBackColor = true;
            this.buttonRestockAll.Click += new System.EventHandler(this.buttonRestockAll_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(82, 136);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 7;
            this.buttonAdd.Text = "Add Item";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // labelSearch
            // 
            this.labelSearch.AutoSize = true;
            this.labelSearch.Location = new System.Drawing.Point(197, 225);
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.Size = new System.Drawing.Size(0, 13);
            this.labelSearch.TabIndex = 8;
            // 
            // buttonRemove
            // 
            this.buttonRemove.Location = new System.Drawing.Point(197, 136);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(98, 23);
            this.buttonRemove.TabIndex = 9;
            this.buttonRemove.Text = "Remove Item";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // buttonRestock
            // 
            this.buttonRestock.Location = new System.Drawing.Point(197, 241);
            this.buttonRestock.Name = "buttonRestock";
            this.buttonRestock.Size = new System.Drawing.Size(75, 23);
            this.buttonRestock.TabIndex = 10;
            this.buttonRestock.Text = "Restock?";
            this.buttonRestock.UseVisualStyleBackColor = true;
            this.buttonRestock.Visible = false;
            this.buttonRestock.Click += new System.EventHandler(this.buttonRestock_Click);
            // 
            // labelAddError
            // 
            this.labelAddError.AutoSize = true;
            this.labelAddError.Location = new System.Drawing.Point(79, 171);
            this.labelAddError.Name = "labelAddError";
            this.labelAddError.Size = new System.Drawing.Size(0, 13);
            this.labelAddError.TabIndex = 11;
            this.labelAddError.Click += new System.EventHandler(this.label3_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(200, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Sort By Price";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 295);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelAddError);
            this.Controls.Add(this.buttonRestock);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.labelSearch);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonRestockAll);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_example);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox tb_example;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Button buttonRestockAll;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label labelSearch;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.Button buttonRestock;
        private System.Windows.Forms.Label labelAddError;
        private System.Windows.Forms.Button button1;
    }
}

