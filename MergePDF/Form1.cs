using System;
using System.IO;
using System.Windows.Forms;
using PdfSharp.Pdf;
using PdfSharp.Pdf.IO;

namespace MergePDF
{
    public partial class MergePDF_Win : Form
    {
        public MergePDF_Win()
        {
            InitializeComponent();
        }

        private void dragNdrop_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.All;
            else
                e.Effect = DragDropEffects.None;
        }

        private void dragNdrop_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop, false);

            foreach (string file in files)
                if (Path.GetExtension(file).ToLower() == ".pdf")
                {
                    if (!dragNdrop.Items.Contains(file))
                    {
                        dragNdrop.Items.Add(file);

                        if (dragNdrop.Items.Count >= 2)
                        {
                            HandleUI(true, false);
                        }
                    }
                }
        }

        private void btnOpenFiles_Click(object sender, EventArgs e)
        {
            if (openFiles.ShowDialog() == DialogResult.OK)
            {
                foreach (string FileName in openFiles.FileNames) 
                {
                    if (!dragNdrop.Items.Contains(Path.GetFullPath(FileName)))
                    {
                        dragNdrop.Items.Add(Path.GetFullPath(FileName));
                    }
                    
                }
            }

            if (dragNdrop.Items.Count >= 2)
            {
                HandleUI(true, false);
            }
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            HandleUI(false, true);
        }

        private void btnMerge_Click(object sender, EventArgs e)
        {
            saveFile.FileName = $"{Path.GetFileNameWithoutExtension(dragNdrop.Items[0].ToString())}-Merged";
            saveFile.InitialDirectory = Path.GetDirectoryName(dragNdrop.Items[0].ToString());

            if(saveFile.ShowDialog() == DialogResult.OK)
            {
                string filepath = saveFile.FileName.ToString();

                using (PdfDocument outputPDF = new PdfDocument())
                {
                    foreach (string fileName in dragNdrop.Items)
                    {
                        using (PdfDocument inputPDF = PdfReader.Open(fileName, PdfDocumentOpenMode.Import))
                        {
                            CopyPages(inputPDF, outputPDF);
                        }
                    }

                    outputPDF.Save(filepath);
                }
            }
        }

        private void CopyPages(PdfDocument from, PdfDocument to)
        {
            for (int i = 0; i < from.PageCount; i++)
            {
                to.AddPage(from.Pages[i]);
            }
        }

        private void HandleUI(bool enableButtons, bool reset)
        {
            if (enableButtons)
            {
                btnMerge.Enabled = true;
                btnReset.Enabled = true;
            }
            else
            {
                btnMerge.Enabled = false;
                btnReset.Enabled = false;
            }

            if (reset)
            {
                dragNdrop.Items.Clear();
            }
        }
        
    }
}
