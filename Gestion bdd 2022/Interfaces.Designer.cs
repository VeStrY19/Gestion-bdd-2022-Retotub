
namespace Gestion_bdd_2022
{
    partial class Interfaces
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Interfaces));
            this.label1 = new System.Windows.Forms.Label();
            this.button_consulter_agent = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 331);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(502, 48);
            this.label1.TabIndex = 2;
            this.label1.Text = "RETOTUB réalise, fabrique et distribue des systèmes d’étaiement,\r\nde sécurité et " +
    "d’échafaudage haut de gamme.\r\nRETOTUB s’engage aussi pour : Le service, l’innova" +
    "tion et la normalisation.";
            // 
            // button_consulter_agent
            // 
            this.button_consulter_agent.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button_consulter_agent.Image = global::Gestion_bdd_2022.Properties.Resources.account;
            this.button_consulter_agent.Location = new System.Drawing.Point(346, 873);
            this.button_consulter_agent.Name = "button_consulter_agent";
            this.button_consulter_agent.Size = new System.Drawing.Size(68, 58);
            this.button_consulter_agent.TabIndex = 6;
            this.button_consulter_agent.UseVisualStyleBackColor = true;
            this.button_consulter_agent.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button2.Image = global::Gestion_bdd_2022.Properties.Resources.Logo_oeil1;
            this.button2.Location = new System.Drawing.Point(151, 873);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(68, 58);
            this.button2.TabIndex = 5;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Gestion_bdd_2022.Properties.Resources.slogan;
            this.pictureBox2.Location = new System.Drawing.Point(100, 415);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(346, 38);
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Gestion_bdd_2022.Properties.Resources.logo_fr_removebg_preview;
            this.pictureBox1.Location = new System.Drawing.Point(182, 153);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(197, 175);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button1.Image = global::Gestion_bdd_2022.Properties.Resources._70310_removebg_preview2;
            this.button1.Location = new System.Drawing.Point(239, 873);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 58);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Interfaces
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(559, 943);
            this.Controls.Add(this.button_consulter_agent);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "Interfaces";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Interfaces";
            this.Load += new System.EventHandler(this.Interfaces_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button_consulter_agent;
    }
}