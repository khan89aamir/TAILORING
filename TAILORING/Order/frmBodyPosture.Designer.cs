namespace TAILORING.Order
{
    partial class frmBodyPosture
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.grpStmouch = new System.Windows.Forms.GroupBox();
            this.grpShoulder = new System.Windows.Forms.GroupBox();
            this.flowStmouch = new System.Windows.Forms.FlowLayoutPanel();
            this.flowShoulder = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2.SuspendLayout();
            this.grpStmouch.SuspendLayout();
            this.grpShoulder.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::TAILORING.Properties.Resources.titlebg;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.label12);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 40);
            this.panel2.TabIndex = 316;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(11, 9);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(120, 22);
            this.label12.TabIndex = 82;
            this.label12.Text = "Body Posture";
            // 
            // grpStmouch
            // 
            this.grpStmouch.BackColor = System.Drawing.Color.Transparent;
            this.grpStmouch.Controls.Add(this.flowStmouch);
            this.grpStmouch.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpStmouch.Location = new System.Drawing.Point(38, 57);
            this.grpStmouch.Name = "grpStmouch";
            this.grpStmouch.Size = new System.Drawing.Size(750, 185);
            this.grpStmouch.TabIndex = 317;
            this.grpStmouch.TabStop = false;
            this.grpStmouch.Text = "Stmouch";
            // 
            // grpShoulder
            // 
            this.grpShoulder.BackColor = System.Drawing.Color.Transparent;
            this.grpShoulder.Controls.Add(this.flowShoulder);
            this.grpShoulder.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpShoulder.Location = new System.Drawing.Point(38, 254);
            this.grpShoulder.Name = "grpShoulder";
            this.grpShoulder.Size = new System.Drawing.Size(750, 185);
            this.grpShoulder.TabIndex = 318;
            this.grpShoulder.TabStop = false;
            this.grpShoulder.Text = "Shoulder";
            // 
            // flowStmouch
            // 
            this.flowStmouch.Location = new System.Drawing.Point(17, 20);
            this.flowStmouch.Name = "flowStmouch";
            this.flowStmouch.Size = new System.Drawing.Size(716, 159);
            this.flowStmouch.TabIndex = 0;
            // 
            // flowShoulder
            // 
            this.flowShoulder.Location = new System.Drawing.Point(16, 20);
            this.flowShoulder.Name = "flowShoulder";
            this.flowShoulder.Size = new System.Drawing.Size(716, 159);
            this.flowShoulder.TabIndex = 1;
            // 
            // frmBodyPosture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TAILORING.Properties.Resources.back;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grpShoulder);
            this.Controls.Add(this.grpStmouch);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmBodyPosture";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Body Posture";
            this.Load += new System.EventHandler(this.frmBodyPosture_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.grpStmouch.ResumeLayout(false);
            this.grpShoulder.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox grpStmouch;
        private System.Windows.Forms.FlowLayoutPanel flowStmouch;
        private System.Windows.Forms.GroupBox grpShoulder;
        private System.Windows.Forms.FlowLayoutPanel flowShoulder;
    }
}