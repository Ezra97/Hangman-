namespace hagmandb
{
    partial class postwinforms
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
            this.components = new System.ComponentModel.Container();
            this.label_title = new System.Windows.Forms.Label();
            this.label_entername = new System.Windows.Forms.Label();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.button_confirm = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.scoreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.highscoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hangmandbsDataSet = new hagmandb.hangmandbsDataSet();
            this.highscoresTableAdapter = new hagmandb.hangmandbsDataSetTableAdapters.highscoresTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.highscoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hangmandbsDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label_title
            // 
            this.label_title.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_title.Location = new System.Drawing.Point(-2, 25);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(433, 129);
            this.label_title.TabIndex = 0;
            // 
            // label_entername
            // 
            this.label_entername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_entername.Location = new System.Drawing.Point(12, 195);
            this.label_entername.Name = "label_entername";
            this.label_entername.Size = new System.Drawing.Size(103, 26);
            this.label_entername.TabIndex = 1;
            this.label_entername.Text = "Please enter name:";
            this.label_entername.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(201, 201);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(206, 20);
            this.textBox_name.TabIndex = 2;
            // 
            // button_confirm
            // 
            this.button_confirm.Location = new System.Drawing.Point(136, 285);
            this.button_confirm.Name = "button_confirm";
            this.button_confirm.Size = new System.Drawing.Size(75, 23);
            this.button_confirm.TabIndex = 3;
            this.button_confirm.Text = "confirm";
            this.button_confirm.UseVisualStyleBackColor = true;
            this.button_confirm.Click += new System.EventHandler(this.addscore);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.scoreDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.highscoresBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(-2, 167);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(444, 336);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.Visible = false;
            // 
            // scoreDataGridViewTextBoxColumn
            // 
            this.scoreDataGridViewTextBoxColumn.DataPropertyName = "score";
            this.scoreDataGridViewTextBoxColumn.HeaderText = "score";
            this.scoreDataGridViewTextBoxColumn.Name = "scoreDataGridViewTextBoxColumn";
            this.scoreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // highscoresBindingSource
            // 
            this.highscoresBindingSource.DataMember = "highscores";
            this.highscoresBindingSource.DataSource = this.hangmandbsDataSet;
            // 
            // hangmandbsDataSet
            // 
            this.hangmandbsDataSet.DataSetName = "hangmandbsDataSet";
            this.hangmandbsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // highscoresTableAdapter
            // 
            this.highscoresTableAdapter.ClearBeforeFill = true;
            // 
            // postwinforms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 646);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button_confirm);
            this.Controls.Add(this.textBox_name);
            this.Controls.Add(this.label_entername);
            this.Controls.Add(this.label_title);
            this.Name = "postwinforms";
            this.Text = "postwinforms";
            this.Load += new System.EventHandler(this.postwinforms_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.highscoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hangmandbsDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.Label label_entername;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.Button button_confirm;
        private System.Windows.Forms.DataGridView dataGridView1;
        private hangmandbsDataSet hangmandbsDataSet;
        private System.Windows.Forms.BindingSource highscoresBindingSource;
        private hangmandbsDataSetTableAdapters.highscoresTableAdapter highscoresTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn scoreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
    }
}