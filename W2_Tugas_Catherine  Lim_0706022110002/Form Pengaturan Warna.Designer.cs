
namespace W2_Tugas_Catherine__Lim_0706022110002
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
            this.buttonProcess = new System.Windows.Forms.Button();
            this.textBoxInputData = new System.Windows.Forms.TextBox();
            this.labelInputData = new System.Windows.Forms.Label();
            this.labelOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonProcess
            // 
            this.buttonProcess.Location = new System.Drawing.Point(51, 105);
            this.buttonProcess.Name = "buttonProcess";
            this.buttonProcess.Size = new System.Drawing.Size(76, 32);
            this.buttonProcess.TabIndex = 0;
            this.buttonProcess.Text = "Process";
            this.buttonProcess.UseVisualStyleBackColor = true;
            this.buttonProcess.Click += new System.EventHandler(this.buttonProcess_Click);
            // 
            // textBoxInputData
            // 
            this.textBoxInputData.Location = new System.Drawing.Point(51, 64);
            this.textBoxInputData.Name = "textBoxInputData";
            this.textBoxInputData.Size = new System.Drawing.Size(300, 26);
            this.textBoxInputData.TabIndex = 1;
            // 
            // labelInputData
            // 
            this.labelInputData.AutoSize = true;
            this.labelInputData.Location = new System.Drawing.Point(47, 41);
            this.labelInputData.Name = "labelInputData";
            this.labelInputData.Size = new System.Drawing.Size(89, 20);
            this.labelInputData.TabIndex = 2;
            this.labelInputData.Text = "Input Data:";
            // 
            // labelOutput
            // 
            this.labelOutput.AutoSize = true;
            this.labelOutput.Location = new System.Drawing.Point(47, 161);
            this.labelOutput.Name = "labelOutput";
            this.labelOutput.Size = new System.Drawing.Size(62, 20);
            this.labelOutput.TabIndex = 3;
            this.labelOutput.Text = "[Empty]";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 210);
            this.Controls.Add(this.labelOutput);
            this.Controls.Add(this.labelInputData);
            this.Controls.Add(this.textBoxInputData);
            this.Controls.Add(this.buttonProcess);
            this.Name = "Form1";
            this.Text = "Form Pengaturan Nama";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonProcess;
        private System.Windows.Forms.TextBox textBoxInputData;
        private System.Windows.Forms.Label labelInputData;
        private System.Windows.Forms.Label labelOutput;
    }
}

