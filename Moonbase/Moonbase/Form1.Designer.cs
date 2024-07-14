namespace Moonbase
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TBlobby = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TBdescription = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TBdescription);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TBlobby);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(317, 257);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Location Information";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Room Name";
            // 
            // TBlobby
            // 
            this.TBlobby.Location = new System.Drawing.Point(23, 37);
            this.TBlobby.Name = "TBlobby";
            this.TBlobby.ReadOnly = true;
            this.TBlobby.Size = new System.Drawing.Size(267, 20);
            this.TBlobby.TabIndex = 1;
            this.TBlobby.Text = "Lobby";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Room Description";
            // 
            // TBdescription
            // 
            this.TBdescription.Location = new System.Drawing.Point(26, 81);
            this.TBdescription.Multiline = true;
            this.TBdescription.Name = "TBdescription";
            this.TBdescription.ReadOnly = true;
            this.TBdescription.Size = new System.Drawing.Size(264, 139);
            this.TBdescription.TabIndex = 3;
            this.TBdescription.Text = resources.GetString("TBdescription.Text");
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(667, 345);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Outlaws Hideaway";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TBdescription;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TBlobby;
    }
}

