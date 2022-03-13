
namespace Airis {
    partial class AIAddNewWindow {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AIAddNewWindow));
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxProgrammName = new System.Windows.Forms.TextBox();
            this.txtBoxPath = new System.Windows.Forms.TextBox();
            this.txtPath = new System.Windows.Forms.Label();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name of your Programm:";
            // 
            // txtBoxProgrammName
            // 
            this.txtBoxProgrammName.Location = new System.Drawing.Point(142, 12);
            this.txtBoxProgrammName.Name = "txtBoxProgrammName";
            this.txtBoxProgrammName.Size = new System.Drawing.Size(150, 20);
            this.txtBoxProgrammName.TabIndex = 1;
            // 
            // txtBoxPath
            // 
            this.txtBoxPath.Location = new System.Drawing.Point(12, 70);
            this.txtBoxPath.Name = "txtBoxPath";
            this.txtBoxPath.Size = new System.Drawing.Size(280, 20);
            this.txtBoxPath.TabIndex = 2;
            // 
            // txtPath
            // 
            this.txtPath.AutoSize = true;
            this.txtPath.Location = new System.Drawing.Point(13, 54);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(29, 13);
            this.txtPath.TabIndex = 3;
            this.txtPath.Text = "Path";
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(641, 395);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(147, 43);
            this.btnConfirm.TabIndex = 4;
            this.btnConfirm.Text = "Bestätigen";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            this.openFileDialog.Filter = "Executables (*.exe, *.bat, *.msi)|*.exe; *.bat; *.msi|All files (*.*)|*.*";
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(299, 70);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.TabIndex = 5;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // AIAddNewWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.txtBoxPath);
            this.Controls.Add(this.txtBoxProgrammName);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AIAddNewWindow";
            this.Text = "AIAddNewWindow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxProgrammName;
        private System.Windows.Forms.TextBox txtBoxPath;
        private System.Windows.Forms.Label txtPath;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button btnBrowse;
    }
}