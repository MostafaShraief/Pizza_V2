namespace Pizza2
{
    partial class Main_Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Menu));
            this.guna2GradientButton1 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.foxBigLabel1 = new ReaLTaiizor.Controls.FoxBigLabel();
            this.SuspendLayout();
            // 
            // guna2GradientButton1
            // 
            this.guna2GradientButton1.Animated = true;
            this.guna2GradientButton1.AutoRoundedCorners = true;
            this.guna2GradientButton1.BackColor = System.Drawing.Color.Transparent;
            this.guna2GradientButton1.BorderRadius = 21;
            this.guna2GradientButton1.CheckedState.Parent = this.guna2GradientButton1;
            this.guna2GradientButton1.CustomImages.Parent = this.guna2GradientButton1;
            this.guna2GradientButton1.FillColor = System.Drawing.Color.Transparent;
            this.guna2GradientButton1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.guna2GradientButton1.Font = new System.Drawing.Font("IOS 15 R SemiBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GradientButton1.ForeColor = System.Drawing.Color.White;
            this.guna2GradientButton1.HoverState.FillColor = System.Drawing.Color.Red;
            this.guna2GradientButton1.HoverState.FillColor2 = System.Drawing.Color.Red;
            this.guna2GradientButton1.HoverState.Font = new System.Drawing.Font("IOS 15 R SemiBold", 18.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GradientButton1.HoverState.Parent = this.guna2GradientButton1;
            this.guna2GradientButton1.Location = new System.Drawing.Point(430, 383);
            this.guna2GradientButton1.Name = "guna2GradientButton1";
            this.guna2GradientButton1.ShadowDecoration.BorderRadius = 20;
            this.guna2GradientButton1.ShadowDecoration.Color = System.Drawing.Color.Red;
            this.guna2GradientButton1.ShadowDecoration.Enabled = true;
            this.guna2GradientButton1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2GradientButton1.ShadowDecoration.Parent = this.guna2GradientButton1;
            this.guna2GradientButton1.Size = new System.Drawing.Size(135, 45);
            this.guna2GradientButton1.TabIndex = 0;
            this.guna2GradientButton1.Text = "Order";
            this.guna2GradientButton1.Click += new System.EventHandler(this.guna2GradientButton1_Click);
            // 
            // foxBigLabel1
            // 
            this.foxBigLabel1.BackColor = System.Drawing.Color.Transparent;
            this.foxBigLabel1.Font = new System.Drawing.Font("Segoe Script", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.foxBigLabel1.ForeColor = System.Drawing.Color.Red;
            this.foxBigLabel1.Line = ReaLTaiizor.Controls.FoxBigLabel.Direction.Bottom;
            this.foxBigLabel1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.foxBigLabel1.Location = new System.Drawing.Point(128, 146);
            this.foxBigLabel1.Name = "foxBigLabel1";
            this.foxBigLabel1.Size = new System.Drawing.Size(249, 48);
            this.foxBigLabel1.TabIndex = 0;
            this.foxBigLabel1.TabStop = false;
            this.foxBigLabel1.Text = "Pizza Factory";
            // 
            // Main_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Pizza2.Properties.Resources.nik_owens_40OJLYVWeeM_unsplash1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.foxBigLabel1);
            this.Controls.Add(this.guna2GradientButton1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main_Menu";
            this.Text = "Main Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton1;
        private ReaLTaiizor.Controls.FoxBigLabel foxBigLabel1;
    }
}