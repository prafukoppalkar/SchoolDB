
namespace SchoolDB
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
            this.Btn_DOBQuery = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_ClassrroomDetails = new System.Windows.Forms.Button();
            this.Btn_displayStudentsInClassroom1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_DOBQuery
            // 
            this.Btn_DOBQuery.Location = new System.Drawing.Point(44, 75);
            this.Btn_DOBQuery.Name = "Btn_DOBQuery";
            this.Btn_DOBQuery.Size = new System.Drawing.Size(107, 57);
            this.Btn_DOBQuery.TabIndex = 0;
            this.Btn_DOBQuery.Text = "DOBQuery";
            this.Btn_DOBQuery.UseVisualStyleBackColor = true;
            this.Btn_DOBQuery.Click += new System.EventHandler(this.Btn_DOBQuery_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(212, 54);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(524, 348);
            this.dataGridView1.TabIndex = 1;
            // 
            // btn_ClassrroomDetails
            // 
            this.btn_ClassrroomDetails.Location = new System.Drawing.Point(12, 168);
            this.btn_ClassrroomDetails.Name = "btn_ClassrroomDetails";
            this.btn_ClassrroomDetails.Size = new System.Drawing.Size(164, 56);
            this.btn_ClassrroomDetails.TabIndex = 2;
            this.btn_ClassrroomDetails.Text = "ClassroomDetails";
            this.btn_ClassrroomDetails.UseVisualStyleBackColor = true;
            this.btn_ClassrroomDetails.Click += new System.EventHandler(this.btn_ClassrroomDetails_Click);
            // 
            // Btn_displayStudentsInClassroom1
            // 
            this.Btn_displayStudentsInClassroom1.Location = new System.Drawing.Point(44, 261);
            this.Btn_displayStudentsInClassroom1.Name = "Btn_displayStudentsInClassroom1";
            this.Btn_displayStudentsInClassroom1.Size = new System.Drawing.Size(107, 56);
            this.Btn_displayStudentsInClassroom1.TabIndex = 3;
            this.Btn_displayStudentsInClassroom1.Text = "Classroom1Students";
            this.Btn_displayStudentsInClassroom1.UseVisualStyleBackColor = true;
            this.Btn_displayStudentsInClassroom1.Click += new System.EventHandler(this.Btn_displayStudentsInClassroom1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Btn_displayStudentsInClassroom1);
            this.Controls.Add(this.btn_ClassrroomDetails);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Btn_DOBQuery);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn_DOBQuery;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_ClassrroomDetails;
        private System.Windows.Forms.Button Btn_displayStudentsInClassroom1;
    }
}

