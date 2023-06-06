namespace NICETrigger
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
            this.labelAction = new System.Windows.Forms.Label();
            this.textBoxOutput = new System.Windows.Forms.TextBox();
            this.timerToExit = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // labelAction
            // 
            this.labelAction.AutoSize = true;
            this.labelAction.BackColor = System.Drawing.SystemColors.Control;
            this.labelAction.Location = new System.Drawing.Point(12, 9);
            this.labelAction.Name = "labelAction";
            this.labelAction.Size = new System.Drawing.Size(37, 13);
            this.labelAction.TabIndex = 0;
            this.labelAction.Text = "Action";
            this.labelAction.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelAction.Click += new System.EventHandler(this.labelAction_Click);
            // 
            // textBoxOutput
            // 
            this.textBoxOutput.Location = new System.Drawing.Point(57, 9);
            this.textBoxOutput.Name = "textBoxOutput";
            this.textBoxOutput.Size = new System.Drawing.Size(520, 20);
            this.textBoxOutput.TabIndex = 1;
            this.textBoxOutput.TextChanged += new System.EventHandler(this.textBoxOutput_TextChanged);
            // 
            // timerToExit
            // 
            this.timerToExit.Tick += new System.EventHandler(this.timerToExit_Tick);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(589, 36);
            this.Controls.Add(this.textBoxOutput);
            this.Controls.Add(this.labelAction);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "NICE Trigger";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxOutput;
        private System.Windows.Forms.Label labelAction;
        private System.Windows.Forms.Timer timerToExit;
    }
}

