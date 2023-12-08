using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace File_and_Directory_Managment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitializeListView();
            AppDomain.CurrentDomain.UnhandledException += CurrentDomain_UnhandledException;
        }

        private void InitializeListView()
        {
            lstFiles.View = View.Details;
            lstFiles.Columns.Add("Name", 200);
            lstFiles.Columns.Add("Type", 100);
            lstFiles.Columns.Add("Creation Date", 150);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RefreshFileList(Directory.GetFileSystemEntries(Environment.CurrentDirectory));
        }

        private void btnMove_Click(object sender, EventArgs e)
        {
            string selectedPath = GetSelectedPath();

            if (!string.IsNullOrEmpty(selectedPath))
            {
                try
                {
                    string destinationPath = txtDestinationPath.Text;

                    if (!string.IsNullOrEmpty(destinationPath))
                    {
                        string destinationFullPath = Path.Combine(destinationPath, Path.GetFileName(selectedPath));

                        if (!File.Exists(destinationFullPath) && !Directory.Exists(destinationFullPath))
                        {
                            File.Move(selectedPath, destinationFullPath);
                            RefreshFileList(Directory.GetFileSystemEntries(Environment.CurrentDirectory));
                            MessageBox.Show("File moved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("A file or directory with the same name already exists in the destination folder.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Enter a valid destination path", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error moving the file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Select a file or directory to move", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCreateFile_Click(object sender, EventArgs e)
        {
            string fileName = txtFileName.Text;

            if (!string.IsNullOrEmpty(fileName))
            {
                try
                {
                    File.Create(fileName);
                    RefreshFileList(Directory.GetFileSystemEntries(Environment.CurrentDirectory));
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error creating the file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Enter a file name", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCreateDirectory_Click(object sender, EventArgs e)
        {
            string directoryName = txtFileName.Text;

            if (!string.IsNullOrEmpty(directoryName))
            {
                try
                {
                    Directory.CreateDirectory(directoryName);
                    RefreshFileList(Directory.GetFileSystemEntries(Environment.CurrentDirectory));
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error creating the directory: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Enter a directory name", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string selectedPath = GetSelectedPath();

            if (!string.IsNullOrEmpty(selectedPath))
            {
                try
                {
                    if (File.Exists(selectedPath))
                    {
                        File.Delete(selectedPath);
                    }
                    else if (Directory.Exists(selectedPath))
                    {
                        Directory.Delete(selectedPath, true);
                    }

                    RefreshFileList(Directory.GetFileSystemEntries(Environment.CurrentDirectory));
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error deleting: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Select a file or directory to delete", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {

        }

        private void btnOpenDirectory_Click(object sender, EventArgs e)
        {
            string selectedPath = GetSelectedPath();

            if (!string.IsNullOrEmpty(selectedPath) && Directory.Exists(selectedPath))
            {
                System.Diagnostics.Process.Start(selectedPath);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchPattern = txtFileName.Text;

            try
            {
                string[] matchingFiles;

                if (!string.IsNullOrEmpty(searchPattern))
                {
                    matchingFiles = Directory.GetFiles(Environment.CurrentDirectory, searchPattern);
                }
                else
                {
                    matchingFiles = Directory.GetFileSystemEntries(Environment.CurrentDirectory);
                }

                RefreshFileList(matchingFiles);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error searching: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private string GetSelectedPath()
        {
            if (lstFiles.SelectedItems.Count > 0)
            {
                return lstFiles.SelectedItems[0].Text;
            }
            return string.Empty;
        }

        private void RefreshFileList(string[] entries)
        {
            lstFiles.Items.Clear();

            foreach (string entry in entries)
            {
                FileInfo fileInfo = new FileInfo(entry);

                // Skip files with specific extensions or names
                if (IsExcludedFile(fileInfo.Name))
                {
                    continue;
                }

                ListViewItem item = new ListViewItem(fileInfo.Name);
                item.SubItems.Add(fileInfo.Attributes.HasFlag(FileAttributes.Directory) ? "Directory" : "File");
                item.SubItems.Add(fileInfo.CreationTime.ToString("yyyy-MM-dd HH:mm:ss"));
                lstFiles.Items.Add(item);
            }
        }

        private bool IsExcludedFile(string fileName)
        {
            // Add conditions to exclude files by extension or name
            string[] excludedExtensions = { ".config", ".pdb", ".exe" };

            foreach (string extension in excludedExtensions)
            {
                if (fileName.EndsWith(extension, StringComparison.OrdinalIgnoreCase))
                {
                    return true;
                }
            }

            return false;
        }

    }
}