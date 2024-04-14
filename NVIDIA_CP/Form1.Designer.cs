namespace NVIDIA_CP2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Display = new Button();
            Settings3D = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // Display
            // 
            Display.Location = new Point(12, 183);
            Display.Name = "Display";
            Display.Size = new Size(94, 29);
            Display.TabIndex = 0;
            Display.Text = "Display";
            Display.UseVisualStyleBackColor = true;
            // 
            // Settings3D
            // 
            Settings3D.Location = new Point(12, 93);
            Settings3D.Name = "Settings3D";
            Settings3D.Size = new Size(94, 29);
            Settings3D.TabIndex = 1;
            Settings3D.Text = "3D Settings";
            Settings3D.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 30F);
            label1.Location = new Point(242, 59);
            label1.Name = "label1";
            label1.Size = new Size(270, 67);
            label1.TabIndex = 2;
            label1.Text = "Bem Vindo";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(Settings3D);
            Controls.Add(Display);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Display;
        private Button Settings3D;
        private Label label1;
    }
}
