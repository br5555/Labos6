
namespace MyLibrary
{
    partial class FormMain
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
            this.dataGridViewPopisKnjiga = new System.Windows.Forms.DataGridView();
            this.buttonExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPopisKnjiga)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewPopisKnjiga
            // 
            this.dataGridViewPopisKnjiga.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewPopisKnjiga.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewPopisKnjiga.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPopisKnjiga.Location = new System.Drawing.Point(12, 26);
            this.dataGridViewPopisKnjiga.Name = "dataGridViewPopisKnjiga";
            this.dataGridViewPopisKnjiga.RowHeadersWidth = 51;
            this.dataGridViewPopisKnjiga.RowTemplate.Height = 24;
            this.dataGridViewPopisKnjiga.Size = new System.Drawing.Size(731, 385);
            this.dataGridViewPopisKnjiga.TabIndex = 0;
            // 
            // buttonExit
            // 
            this.buttonExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonExit.Location = new System.Drawing.Point(618, 426);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(125, 41);
            this.buttonExit.TabIndex = 1;
            this.buttonExit.Text = "&Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // FormMain
            // 
            this.AcceptButton = this.buttonExit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 470);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.dataGridViewPopisKnjiga);
            this.Name = "FormMain";
            this.Text = "My Library";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPopisKnjiga)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewPopisKnjiga;
        private System.Windows.Forms.Button buttonExit;
    }
}

