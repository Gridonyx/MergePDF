namespace MergePDF
{
    partial class MergePDF_Win
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MergePDF_Win));
            this.dragNdrop = new System.Windows.Forms.ListBox();
            this.lblDragNDrop = new System.Windows.Forms.Label();
            this.btnOpenFiles = new System.Windows.Forms.Button();
            this.openFiles = new System.Windows.Forms.OpenFileDialog();
            this.btnMerge = new System.Windows.Forms.Button();
            this.saveFile = new System.Windows.Forms.SaveFileDialog();
            this.btnReset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dragNdrop
            // 
            this.dragNdrop.AllowDrop = true;
            this.dragNdrop.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dragNdrop.FormattingEnabled = true;
            this.dragNdrop.Location = new System.Drawing.Point(12, 83);
            this.dragNdrop.Name = "dragNdrop";
            this.dragNdrop.Size = new System.Drawing.Size(407, 186);
            this.dragNdrop.Sorted = true;
            this.dragNdrop.TabIndex = 0;
            this.dragNdrop.DragDrop += new System.Windows.Forms.DragEventHandler(this.dragNdrop_DragDrop);
            this.dragNdrop.DragEnter += new System.Windows.Forms.DragEventHandler(this.dragNdrop_DragEnter);
            // 
            // lblDragNDrop
            // 
            this.lblDragNDrop.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDragNDrop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDragNDrop.Location = new System.Drawing.Point(12, 61);
            this.lblDragNDrop.Name = "lblDragNDrop";
            this.lblDragNDrop.Size = new System.Drawing.Size(407, 20);
            this.lblDragNDrop.TabIndex = 1;
            this.lblDragNDrop.Text = "...or Drag and Drop below";
            this.lblDragNDrop.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnOpenFiles
            // 
            this.btnOpenFiles.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpenFiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenFiles.Location = new System.Drawing.Point(12, 16);
            this.btnOpenFiles.Name = "btnOpenFiles";
            this.btnOpenFiles.Size = new System.Drawing.Size(130, 32);
            this.btnOpenFiles.TabIndex = 2;
            this.btnOpenFiles.Text = "Select Files...";
            this.btnOpenFiles.UseVisualStyleBackColor = true;
            this.btnOpenFiles.Click += new System.EventHandler(this.btnOpenFiles_Click);
            // 
            // openFiles
            // 
            this.openFiles.DefaultExt = "pdf";
            this.openFiles.Filter = "PDF Files (*.pdf)|*.pdf";
            this.openFiles.Multiselect = true;
            // 
            // btnMerge
            // 
            this.btnMerge.Enabled = false;
            this.btnMerge.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMerge.Location = new System.Drawing.Point(152, 16);
            this.btnMerge.Name = "btnMerge";
            this.btnMerge.Size = new System.Drawing.Size(130, 32);
            this.btnMerge.TabIndex = 3;
            this.btnMerge.Text = "Merge";
            this.btnMerge.UseVisualStyleBackColor = true;
            this.btnMerge.Click += new System.EventHandler(this.btnMerge_Click);
            // 
            // saveFile
            // 
            this.saveFile.DefaultExt = "pdf";
            this.saveFile.Filter = "PDF Files (*.pdf)|*.pdf";
            // 
            // btnReset
            // 
            this.btnReset.Enabled = false;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(289, 16);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(130, 32);
            this.btnReset.TabIndex = 4;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // MergePDF_Win
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 287);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnMerge);
            this.Controls.Add(this.btnOpenFiles);
            this.Controls.Add(this.lblDragNDrop);
            this.Controls.Add(this.dragNdrop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MergePDF_Win";
            this.Text = "MergePDF";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox dragNdrop;
        private System.Windows.Forms.Label lblDragNDrop;
        private System.Windows.Forms.Button btnOpenFiles;
        private System.Windows.Forms.OpenFileDialog openFiles;
        private System.Windows.Forms.Button btnMerge;
        private System.Windows.Forms.SaveFileDialog saveFile;
        private System.Windows.Forms.Button btnReset;
    }
}

