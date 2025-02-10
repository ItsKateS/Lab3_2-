namespace Lab3_2
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
            this.Load = new System.Windows.Forms.Button();
            this.Start = new System.Windows.Forms.Button();
            this.Box = new Emgu.CV.UI.ImageBox();
            this.Stop = new System.Windows.Forms.Button();
            this.Label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Box)).BeginInit();
            this.SuspendLayout();
            // 
            // Load
            // 
            this.Load.Location = new System.Drawing.Point(547, 453);
            this.Load.Name = "Load";
            this.Load.Size = new System.Drawing.Size(130, 50);
            this.Load.TabIndex = 0;
            this.Load.Text = "Load";
            this.Load.UseVisualStyleBackColor = true;
            this.Load.Click += new System.EventHandler(this.Load_Click);
            // 
            // Start
            // 
            this.Start.Location = new System.Drawing.Point(12, 453);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(130, 50);
            this.Start.TabIndex = 1;
            this.Start.Text = "Start";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // Box
            // 
            this.Box.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Box.Location = new System.Drawing.Point(12, 12);
            this.Box.Name = "Box";
            this.Box.Size = new System.Drawing.Size(665, 414);
            this.Box.TabIndex = 2;
            this.Box.TabStop = false;
            // 
            // Stop
            // 
            this.Stop.Location = new System.Drawing.Point(206, 453);
            this.Stop.Name = "Stop";
            this.Stop.Size = new System.Drawing.Size(130, 50);
            this.Stop.TabIndex = 3;
            this.Stop.Text = "Stop";
            this.Stop.UseVisualStyleBackColor = true;
            this.Stop.Click += new System.EventHandler(this.Stop_Click);
            // 
            // Label
            // 
            this.Label.AutoSize = true;
            this.Label.Location = new System.Drawing.Point(469, 470);
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(0, 16);
            this.Label.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 523);
            this.Controls.Add(this.Label);
            this.Controls.Add(this.Stop);
            this.Controls.Add(this.Box);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.Load);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Box)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Load;
        private System.Windows.Forms.Button Start;
        private Emgu.CV.UI.ImageBox Box;
        private System.Windows.Forms.Button Stop;
        private System.Windows.Forms.Label Label;
    }
}

