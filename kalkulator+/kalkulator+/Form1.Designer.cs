namespace kalkulator_
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
            this.components = new System.ComponentModel.Container();
            this.txtBrojA = new System.Windows.Forms.TextBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.txtBrojB = new System.Windows.Forms.TextBox();
            this.txtIspisB = new System.Windows.Forms.TextBox();
            this.btnPlus = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBrojA
            // 
            this.txtBrojA.Location = new System.Drawing.Point(124, 64);
            this.txtBrojA.Name = "txtBrojA";
            this.txtBrojA.Size = new System.Drawing.Size(100, 20);
            this.txtBrojA.TabIndex = 0;
            // 
            // txtBrojB
            // 
            this.txtBrojB.Location = new System.Drawing.Point(124, 105);
            this.txtBrojB.Name = "txtBrojB";
            this.txtBrojB.Size = new System.Drawing.Size(100, 20);
            this.txtBrojB.TabIndex = 1;
            // 
            // txtIspisB
            // 
            this.txtIspisB.Location = new System.Drawing.Point(124, 160);
            this.txtIspisB.Name = "txtIspisB";
            this.txtIspisB.Size = new System.Drawing.Size(100, 20);
            this.txtIspisB.TabIndex = 2;
            // 
            // btnPlus
            // 
            this.btnPlus.Location = new System.Drawing.Point(293, 103);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(75, 23);
            this.btnPlus.TabIndex = 3;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.BtnPlus_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.txtIspisB);
            this.Controls.Add(this.txtBrojB);
            this.Controls.Add(this.txtBrojA);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBrojA;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.TextBox txtBrojB;
        private System.Windows.Forms.TextBox txtIspisB;
        private System.Windows.Forms.Button btnPlus;
    }
}

