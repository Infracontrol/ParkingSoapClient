namespace ParkingTestClient
{
    partial class TestClientForm
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
            this.textBoxUrl = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.buttonListSites = new System.Windows.Forms.Button();
            this.textBoxResponse = new System.Windows.Forms.TextBox();
            this.buttonListSigns = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxUrl
            // 
            this.textBoxUrl.Location = new System.Drawing.Point(92, 21);
            this.textBoxUrl.Name = "textBoxUrl";
            this.textBoxUrl.Size = new System.Drawing.Size(559, 22);
            this.textBoxUrl.TabIndex = 0;
            this.textBoxUrl.Text = "https://online.infracontrol.com/Areas/Parking/Services/v1/ParkingInfo.asmx";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Url";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Username";
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Location = new System.Drawing.Point(92, 49);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(306, 22);
            this.textBoxUsername.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Password";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(92, 78);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(306, 22);
            this.textBoxPassword.TabIndex = 5;
            this.textBoxPassword.UseSystemPasswordChar = true;
            // 
            // buttonListSites
            // 
            this.buttonListSites.Location = new System.Drawing.Point(535, 49);
            this.buttonListSites.Name = "buttonListSites";
            this.buttonListSites.Size = new System.Drawing.Size(115, 51);
            this.buttonListSites.TabIndex = 6;
            this.buttonListSites.Text = "List sites";
            this.buttonListSites.UseVisualStyleBackColor = true;
            this.buttonListSites.Click += new System.EventHandler(this.buttonListSites_Click);
            // 
            // textBoxResponse
            // 
            this.textBoxResponse.Location = new System.Drawing.Point(16, 132);
            this.textBoxResponse.Multiline = true;
            this.textBoxResponse.Name = "textBoxResponse";
            this.textBoxResponse.ReadOnly = true;
            this.textBoxResponse.Size = new System.Drawing.Size(634, 306);
            this.textBoxResponse.TabIndex = 7;
            // 
            // buttonListSigns
            // 
            this.buttonListSigns.Location = new System.Drawing.Point(414, 49);
            this.buttonListSigns.Name = "buttonListSigns";
            this.buttonListSigns.Size = new System.Drawing.Size(115, 51);
            this.buttonListSigns.TabIndex = 8;
            this.buttonListSigns.Text = "List signs";
            this.buttonListSigns.UseVisualStyleBackColor = true;
            this.buttonListSigns.Click += new System.EventHandler(this.buttonListSigns_Click);
            // 
            // TestClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 450);
            this.Controls.Add(this.buttonListSigns);
            this.Controls.Add(this.textBoxResponse);
            this.Controls.Add(this.buttonListSites);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxUsername);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxUrl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "TestClientForm";
            this.Text = "Parking Soap Client";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxUrl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Button buttonListSites;
        private System.Windows.Forms.TextBox textBoxResponse;
        private System.Windows.Forms.Button buttonListSigns;
    }
}

