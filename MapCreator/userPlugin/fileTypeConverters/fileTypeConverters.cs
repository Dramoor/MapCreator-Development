using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Formats.Tar;
using FileTypeConverter;

namespace MapCreator.userPlugin
{
    public partial class fileTypeConverters : Form
    {
        MUL2UOPConverter conv;
        private int m_Total, m_Success;

        public fileTypeConverters()
        {
            conv = new MUL2UOPConverter();
            InitializeComponent();
        }

        private string FixPath1(string file)
        {
            return (file == null) ? null : Path.Combine(mul2uopConverter_textBox01_mulLocation.Text, file);
        }

        private string FixPath2(string file)
        {
            return (file == null) ? null : Path.Combine(uop2mulConverter_textBox01_uopLocation.Text, file);
        }

        /// MUL To BMP
        private void mul2bmpConverter_searchButton01_compiledFacetLocation_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "map files (map?.mul)|map?.mul";
            DialogResult result = dialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                mul2bmpConverter_textBox01_compiledFacetLocation.Text = dialog.FileName;
            }
        }

        private void mul2bmpConverter_searchButton02_radarcolFileLocation_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "radarcol.mul|radarcol.mul";
            DialogResult result = dialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                mul2bmpConverter_textBox02_radarcolFileLocation.Text = dialog.FileName;
            }
        }

        private unsafe void mul2bmpConverter_convertFacet2BitmapButton_Click(object sender, EventArgs e)
        {
            if (mul2bmpConverter_textBox01_compiledFacetLocation.Text.Length == 0 || mul2bmpConverter_textBox02_radarcolFileLocation.Text.Length == 0 || mul2bmpConverter_textBox03_mapDimensions_width.Text.Length == 0 || mul2bmpConverter_textBox04_mapDimensions_height.Text.Length == 0)
            {
                MessageBox.Show("Please Locate Your Map.mul And Radarcol.mul Before Proceeding...");
            }
            else
            {
                SaveFileDialog dialog = new SaveFileDialog();
                dialog.Filter = "*.bmp|*.bmp";
                DialogResult result = dialog.ShowDialog();
                if (result == DialogResult.OK)
                {
                    string output = dialog.FileName;
                    try
                    {
                        int mapWidth = Int32.Parse(mul2bmpConverter_textBox03_mapDimensions_width.Text);
                        int mapHeight = Int32.Parse(mul2bmpConverter_textBox04_mapDimensions_height.Text);
                        Bitmap bitmap = new Bitmap(mapWidth, mapHeight);
                        BitmapData bd = bitmap.LockBits(new Rectangle(0, 0, mapWidth, mapHeight), ImageLockMode.WriteOnly, PixelFormat.Format16bppRgb555);

                        ushort[] colors = new RadarColReader(mul2bmpConverter_textBox02_radarcolFileLocation.Text).Colors;
                        ushort[] tiles = new MapReader(mul2bmpConverter_textBox01_compiledFacetLocation.Text, mapWidth, mapHeight).Tiles;

                        // TODO: Load and make use of MapDif, Statics and StaticsDif

                        ushort* bdPtr = (ushort*)bd.Scan0;

                        for (int i = 0; i < tiles.Length; i++)
                            bdPtr[i] = colors[tiles[i]];

                        bitmap.UnlockBits(bd);
                        bitmap.Save(output);
                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show(exception.ToString());
                    }
                }
            }
        }

        private void sToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();

            facetBuilder facetBuilderForm = new facetBuilder();
            facetBuilderForm.Show();
        }

        private void sToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            communityCredits communityCreditsForm = new communityCredits();
            communityCreditsForm.Show();
        }


        ///MUL To UOP
        private void mul2uopConverter_searchButton01_mulLocation_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog()
            {
                SelectedPath = this.mul2uopConverter_textBox01_mulLocation.Text
            };
            if (folderBrowserDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.mul2uopConverter_textBox01_mulLocation.Text = folderBrowserDialog.SelectedPath;
            }
        }

        private void mul2uopConverter_textBox01_mulLocation_Load(object sender, EventArgs e)
        {
            this.mul2uopConverter_textBox01_mulLocation.Text = Directory.GetCurrentDirectory();
        }

        private void PackMUL2UOP(string inFile, string inIdx, string outFile, MUL2UOP type, int typeIndex)
        {
            try
            {
                statusInfoText.Text = inFile;

                Refresh();
                inFile = FixPath1(inFile);

                if (!File.Exists(inFile))
                    return;

                outFile = FixPath1(outFile);

                if (File.Exists(outFile))
                {
                    return;
                }

                inIdx = FixPath1(inIdx);
                ++m_Total;

                conv.ToUOP(inFile, inIdx, outFile, type, typeIndex);
                ++m_Success;

            }
            catch (Exception e)
            {
                MessageBox.Show("An error occured while performing the action");
            }
        }

        private void mul2uopConverter_convertFacet2UOPButton_Click(object sender, EventArgs e)
        {
            if (mul2uopConverter_textBox01_mulLocation.Text == string.Empty || mul2uopConverter_textBox01_mulLocation.Text == null)
            {
                MessageBox.Show(" ERROR: You Must Specify The Location Path\n Of The [.mul] Files You Want Converted!");
                return;
            }

            if (mul2uopConverter_custom255Selection.Checked)
            {
                for (int i = 0; i <= 255; ++i)
                {
                    string map = String.Format("map{0}", i);

                    PackMUL2UOP(map + ".mul", null, map + "LegacyMUL.uop", MUL2UOP.MapLegacyMUL, i);
                    PackMUL2UOP(map + "x.mul", null, map + "xLegacyMUL.uop", MUL2UOP.MapLegacyMUL, i);
                }

                statusInfoText.Text = string.Format("Done ({0}/{1} files converted)", m_Success, m_Total);
            }
            else if (mul2uopConverter_original6Selection.Checked)
            {
                for (int i = 0; i <= 5; ++i)
                {
                    string map = String.Format("map{0}", i);

                    PackMUL2UOP(map + ".mul", null, map + "LegacyMUL.uop", MUL2UOP.MapLegacyMUL, i);
                    PackMUL2UOP(map + "x.mul", null, map + "xLegacyMUL.uop", MUL2UOP.MapLegacyMUL, i);
                }


                statusInfoText.Text = string.Format("Done ({0}/{1} files extracted)", m_Success, m_Total);
            }
            else if (mul2uopConverter_custom255Selection.Checked == false || mul2uopConverter_original6Selection.Checked == false)
            {
                MessageBox.Show("   ERROR: Please Select A Facet Allowance Type Before This Program Can Proceed!\n");
                return;
            }
        }


        ///UOP To MUL
        private void uop2mulConverter_searchButton01_uopLocation_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog()
            {
                SelectedPath = this.uop2mulConverter_textBox01_uopLocation.Text
            };
            if (folderBrowserDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.uop2mulConverter_textBox01_uopLocation.Text = folderBrowserDialog.SelectedPath;
            }
        }

        private void uop2mulConverter_textBox01_uopLocation_Load(object sender, EventArgs e)
        {
            this.uop2mulConverter_textBox01_uopLocation.Text = Directory.GetCurrentDirectory();
        }

        private void PackUOP2MUL(string inFile, string outIdx, string outFile, MUL2UOP type, int typeIndex)
        {
            try
            {
                statusInfoText.Text = inFile;
                Refresh();
                inFile = FixPath2(inFile);

                if (!File.Exists(inFile))
                {
                    return;
                }

                outFile = FixPath2(outFile);

                if (File.Exists(outFile))
                {
                    return;
                }

                outIdx = FixPath2(outIdx);
                ++m_Total;

                conv.FromUOP(inFile, outFile, outIdx, type, typeIndex);
                ++m_Success;
            }
            catch (Exception e)
            {
                MessageBox.Show($"An error occurred while performing the action.\r\n{e.Message}");
            }
        }

        private void uop2mulConverter_convertFacet2MULButton_Click(object sender, EventArgs e)
        {
            if (uop2mulConverter_textBox01_uopLocation.Text == string.Empty || uop2mulConverter_textBox01_uopLocation.Text == null)
            {
                MessageBox.Show(" ERROR: You Must Specify The Location Path\n Of The [.mul] Files You Want Converted!");
                return;
            }

            if (uop2mulConverter_custom255Selection.Checked)
            {
                for (int i = 0; i <= 255; ++i)
                {
                    string map = String.Format("map{0}", i);

                    PackUOP2MUL(map + "LegacyMUL.uop", map + ".mul", null, MUL2UOP.MapLegacyMUL, i);
                    PackUOP2MUL(map + "xLegacyMUL.uop", map + "x.mul", null, MUL2UOP.MapLegacyMUL, i);
                }

                statusInfoText.Text = string.Format("Done ({0}/{1} files extracted)", m_Success, m_Total);
            }

            else if (uop2mulConverter_original6Selection.Checked)
            {
                for (int i = 0; i <= 5; ++i)
                {
                    string map = String.Format("map{0}", i);

                    PackUOP2MUL(map + "LegacyMUL.uop", map + ".mul", null, MUL2UOP.MapLegacyMUL, i);
                    PackUOP2MUL(map + "xLegacyMUL.uop", map + "x.mul", null, MUL2UOP.MapLegacyMUL, i);
                }

                statusInfoText.Text = string.Format("Done ({0}/{1} files extracted)", m_Success, m_Total);
            }
            else if (uop2mulConverter_custom255Selection.Checked == false || uop2mulConverter_original6Selection.Checked == false)
            {
                MessageBox.Show("   ERROR: Please Select A Facet Allowance Type Before This Program Can Proceed!\n");
                return;
            }
        }
    }
}
