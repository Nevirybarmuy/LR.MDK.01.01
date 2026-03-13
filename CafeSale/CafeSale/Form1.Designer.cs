namespace CafeSale
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
            this.listBoxDrinks = new System.Windows.Forms.ListBox();
            this.panelCharts = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // listBoxDrinks
            // 
            this.listBoxDrinks.FormattingEnabled = true;
            this.listBoxDrinks.Location = new System.Drawing.Point(163, 189);
            this.listBoxDrinks.Name = "listBoxDrinks";
            this.listBoxDrinks.Size = new System.Drawing.Size(180, 108);
            this.listBoxDrinks.TabIndex = 0;
            this.listBoxDrinks.SelectedIndexChanged += new System.EventHandler(this.listBoxDrinks_SelectedIndexChanged);
            // 
            // panelCharts
            // 
            this.panelCharts.Location = new System.Drawing.Point(378, 189);
            this.panelCharts.Name = "panelCharts";
            this.panelCharts.Size = new System.Drawing.Size(200, 108);
            this.panelCharts.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelCharts);
            this.Controls.Add(this.listBoxDrinks);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListBox listBoxDrinks;
        private System.Windows.Forms.Panel panelCharts;
    }
}