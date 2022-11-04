namespace QL_TTNoiThat.View
{
    partial class DSHangHoa
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
            this.dgvDSHH = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSHH)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDSHH
            // 
            this.dgvDSHH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSHH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDSHH.Location = new System.Drawing.Point(0, 0);
            this.dgvDSHH.Name = "dgvDSHH";
            this.dgvDSHH.Size = new System.Drawing.Size(691, 345);
            this.dgvDSHH.TabIndex = 0;
            // 
            // DSHangHoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 345);
            this.Controls.Add(this.dgvDSHH);
            this.Name = "DSHangHoa";
            this.Text = "DSHangHoa";
            this.Load += new System.EventHandler(this.DSHangHoa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSHH)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDSHH;
    }
}