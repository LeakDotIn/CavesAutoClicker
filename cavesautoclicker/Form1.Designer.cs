
namespace tutorial_clicker
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
            this.Autoclicker = new System.Windows.Forms.Timer(this.components);
            this.btnToggle = new Siticone.UI.WinForms.SiticoneButton();
            this.Random = new System.Windows.Forms.Timer(this.components);
            this.randomTB = new Siticone.UI.WinForms.SiticoneMetroTrackBar();
            this.Binding = new System.Windows.Forms.Timer(this.components);
            this.bindBtn = new Siticone.UI.WinForms.SiticoneButton();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Autoclicker
            // 
            this.Autoclicker.Tick += new System.EventHandler(this.Autoclicker_Tick);
            // 
            // btnToggle
            // 
            this.btnToggle.CheckedState.FillColor = System.Drawing.Color.Salmon;
            this.btnToggle.CheckedState.Parent = this.btnToggle;
            this.btnToggle.CustomImages.Parent = this.btnToggle;
            this.btnToggle.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnToggle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnToggle.ForeColor = System.Drawing.Color.Salmon;
            this.btnToggle.HoveredState.Parent = this.btnToggle;
            this.btnToggle.Location = new System.Drawing.Point(17, 111);
            this.btnToggle.Name = "btnToggle";
            this.btnToggle.ShadowDecoration.Parent = this.btnToggle;
            this.btnToggle.Size = new System.Drawing.Size(375, 27);
            this.btnToggle.TabIndex = 4;
            this.btnToggle.Text = "enable";
            this.btnToggle.TextChanged += new System.EventHandler(this.btnToggle_TextChanged);
            this.btnToggle.Click += new System.EventHandler(this.btnToggle_Click);
            // 
            // Random
            // 
            this.Random.Enabled = true;
            this.Random.Interval = 150;
            this.Random.Tick += new System.EventHandler(this.Random_Tick);
            // 
            // randomTB
            // 
            this.randomTB.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.randomTB.HoveredState.Parent = this.randomTB;
            this.randomTB.Location = new System.Drawing.Point(17, 82);
            this.randomTB.Maximum = 30;
            this.randomTB.Name = "randomTB";
            this.randomTB.Size = new System.Drawing.Size(375, 23);
            this.randomTB.TabIndex = 5;
            this.randomTB.ThumbColor = System.Drawing.Color.Salmon;
            this.randomTB.Value = 10;
            this.randomTB.Scroll += new System.Windows.Forms.ScrollEventHandler(this.randomTB_Scroll);
            // 
            // Binding
            // 
            this.Binding.Enabled = true;
            this.Binding.Tick += new System.EventHandler(this.Binding_Tick);
            // 
            // bindBtn
            // 
            this.bindBtn.CheckedState.FillColor = System.Drawing.Color.Salmon;
            this.bindBtn.CheckedState.Parent = this.bindBtn;
            this.bindBtn.CustomImages.Parent = this.bindBtn;
            this.bindBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.bindBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindBtn.ForeColor = System.Drawing.Color.Salmon;
            this.bindBtn.HoveredState.Parent = this.bindBtn;
            this.bindBtn.Location = new System.Drawing.Point(17, 144);
            this.bindBtn.Name = "bindBtn";
            this.bindBtn.ShadowDecoration.Parent = this.bindBtn;
            this.bindBtn.Size = new System.Drawing.Size(106, 27);
            this.bindBtn.TabIndex = 6;
            this.bindBtn.Text = "none";
            this.bindBtn.Click += new System.EventHandler(this.bindBtn_Click);
            this.bindBtn.KeyDown += new System.Windows.Forms.KeyEventHandler(this.bindBtn_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Salmon;
            this.label1.Location = new System.Drawing.Point(12, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Caves Auto Clicker";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(404, 261);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bindBtn);
            this.Controls.Add(this.randomTB);
            this.Controls.Add(this.btnToggle);
            this.Name = "Form1";
            this.Text = "Caves Auto Clicker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer Autoclicker;
        private Siticone.UI.WinForms.SiticoneButton btnToggle;
        private System.Windows.Forms.Timer Random;
        private Siticone.UI.WinForms.SiticoneMetroTrackBar randomTB;
        private System.Windows.Forms.Timer Binding;
        private Siticone.UI.WinForms.SiticoneButton bindBtn;
        private System.Windows.Forms.Label label1;
    }
}

