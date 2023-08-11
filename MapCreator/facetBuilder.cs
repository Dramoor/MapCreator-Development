﻿using Altitude;

using Cartography;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

using Terrain;
using Transition;

using UltimaSDK;

namespace MapCreator
{
    public partial class facetBuilder : Form
    {
        private Bitmap i_Terrain;
        private ClsTerrainTable iTerrain;
        private Bitmap i_Altitude;
        private ClsAltitudeTable iAltitude;
        private buildLogger iLogger;
        private bool i_RandomStatic;

        public facetBuilder()
        {
            InitializeComponent();

            MaximizeBox = false;
            MinimizeBox = false;

            facetBuilder facetBuilderForm = this;

            base.Load += new EventHandler(facetBuilderForm.facetBuilder_Load);

            this.iTerrain = new ClsTerrainTable();
            this.iAltitude = new ClsAltitudeTable();
            this.iLogger = new buildLogger();
            this.i_RandomStatic = true;
        }

        private void facetBuilder_Load(object? sender, EventArgs e)
        {
            if (this.Visible == true)
            {
                Control fBPW = this.facetBuilder_panel_workbench;
                Thread.Sleep(25);
                fBPW.Hide();
            }

            #region Workbench Loading

            /// GroupBox: Create Facet Bitmap Files

            IEnumerator enumerator = null;

            this.iLogger.Show();

            int x = checked(this.iLogger.Location.X + 100);
            Point location = this.iLogger.Location;
            Point point = new Point(x, checked(location.Y + 100));
            this.Location = point;

            this.iTerrain.Load();
            this.iAltitude.Load();

            #region Data Directory Modification

            string str = string.Format("{0}\\MapCompiler\\Engine\\{1}", Directory.GetCurrentDirectory(), "MapInfo.xml");

            #endregion

            this.facetBuilder_panel_workbench_groupBox_createFacetBitmapFiles_label_projectFolderLocation_textBox.Text = Directory.GetCurrentDirectory();
            this.iTerrain.Display(this.facetBuilder_panel_workbench_groupBox_createFacetBitmapFiles_label_baseTerrain_comboBox);

            try
            {
                XmlDocument xmlDocument = new XmlDocument();
                xmlDocument.Load(str);
                try
                {
                    this.facetBuilder_panel_workbench_groupBox_createFacetBitmapFiles_label_facetSize_comboBox.Items.Clear();
                    try
                    {
                        enumerator = xmlDocument.SelectNodes("//Maps/Map").GetEnumerator();
                        while (enumerator.MoveNext())
                        {
                            MapInfo mapInfo = new MapInfo((XmlElement)enumerator.Current);
                            this.facetBuilder_panel_workbench_groupBox_createFacetBitmapFiles_label_facetSize_comboBox.Items.Add(mapInfo);
                        }
                    }
                    finally
                    {
                        if (enumerator is IDisposable)
                        {
                            ((IDisposable)enumerator).Dispose();
                        }
                    }
                }
                catch (Exception exception1)
                {
                    ProjectData.SetProjectError(exception1);
                    Exception exception = exception1;
                    this.iLogger.LogMessage(string.Format("XML Error:{0}", exception.Message));
                    ProjectData.ClearProjectError();
                }
            }
            catch (Exception exception2)
            {
                ProjectData.SetProjectError(exception2);
                this.iLogger.LogMessage(string.Format("Unable to find:{0}", str));
                ProjectData.ClearProjectError();
            }

            /// GroupBox: Sync Your Altitude Bitmap

            this.facetBuilder_panel_workbench_groupBox_syncYourAltitudeBitmap_label_projectFolderLocation_textBox.Text = Directory.GetCurrentDirectory();

            this.iTerrain.Load();
            this.iAltitude.Load();

            /// GroupBox: Compile Your New Facet

            this.facetBuilder_panel_workbench_groupBox_compileYourNewFacet_label_projectFolderLocation_textBox.Text = AppDomain.CurrentDomain.BaseDirectory;

            #endregion
        }

        private void facetBuilder_menuStrip_button_gettingStarted_createColorTables_Click(object sender, EventArgs e)
        {
            this.Hide();

            colorTables colorTablesForm = new colorTables();
            colorTablesForm.Show();

            iLogger.Close();
        }

        private void facetBuilder_menuStrip_button_gettingStarted_mapCreatorManual_Click(object sender, EventArgs e)
        {

        }

        private void facetBuilder_menuStrip_button_drawingTools_adobePhotoshop_Click(object sender, EventArgs e)
        {
            var path = Path.Combine("Development", "DrawingTools", "AdobePhotoshop");

            _ = Directory.CreateDirectory(path);

            _ = Process.Start("explorer.exe", path);
        }

        private void facetBuilder_menuStrip_button_drawingTools_freePaintSoftware_Click(object sender, EventArgs e)
        {
            var path = Path.Combine("Development", "DrawingTools", "FreePaintSoftware");

            _ = Directory.CreateDirectory(path);

            _ = Process.Start("explorer.exe", path);
        }

        private void facetBuilder_menuStrip_button_facetTutorials_Click(object sender, EventArgs e)
        {
            var path = Path.Combine("Development", "FacetTutorials");

            _ = Directory.CreateDirectory(path);

            _ = Process.Start("explorer.exe", path);
        }

        private void facetBuilder_menuStrip_button_userPlugins_Click(object sender, EventArgs e)
        {
            this.Hide();

            userPlugins userPluginsForm = new userPlugins();
            userPluginsForm.Show();

            iLogger.Close();
        }

        private void facetBuilder_menuStrip_button_uploadPlugin_Click(object sender, EventArgs e)
        {

        }

        private void facetBuilder_menuStrip_button_information_Click(object sender, EventArgs e)
        {
            communityCredits communityCreditsForm = new communityCredits();
            communityCreditsForm.Show();

            iLogger.Close();
        }


        private void facetBuilder_panel_workbench_selection_groupBox_createYourWorld_button_createFacetBitmapFiles_MouseEnter(object sender, EventArgs e)
        {
            facetBuilder_panel_workbench_selection_groupBox_createYourWorld_button_createFacetBitmapFiles.ForeColor = System.Drawing.Color.LimeGreen;
        }

        private void facetBuilder_panel_workbench_selection_groupBox_createYourWorld_button_createFacetBitmapFiles_Click(object sender, EventArgs e)
        {
            /// Show These Controls
            Control fBPW = this.facetBuilder_panel_workbench;
            Thread.Sleep(25);
            fBPW.Show();

            Control cFBF = this.facetBuilder_panel_workbench_groupBox_createFacetBitmapFiles;
            Thread.Sleep(25);
            cFBF.Show();

            /// Hide These Controls
            Control sYAB = this.facetBuilder_panel_workbench_groupBox_syncYourAltitudeBitmap;
            Thread.Sleep(25);
            sYAB.Hide();

            Control cYNF = this.facetBuilder_panel_workbench_groupBox_compileYourNewFacet;
            Thread.Sleep(25);
            cYNF.Hide();
        }

        private void facetBuilder_panel_workbench_selection_groupBox_createYourWorld_button_createFacetBitmapFiles_MouseLeave(object sender, EventArgs e)
        {
            facetBuilder_panel_workbench_selection_groupBox_createYourWorld_button_createFacetBitmapFiles.ForeColor = System.Drawing.Color.SlateGray;
        }

        #region GroupBox Functionality

        private void facetBuilder_panel_workbench_groupBox_createFacetBitmapFiles_button_locateProject_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog()
            {
                SelectedPath = this.facetBuilder_panel_workbench_groupBox_createFacetBitmapFiles_label_projectFolderLocation_textBox.Text
            };

            if (folderBrowserDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.facetBuilder_panel_workbench_groupBox_createFacetBitmapFiles_label_projectFolderLocation_textBox.Text = folderBrowserDialog.SelectedPath;
            }
        }

        private void facetBuilder_panel_workbench_groupBox_createFacetBitmapFiles_button_createFacetBitmapFiles_Click(object sender, EventArgs e)
        {
            byte altID;
            byte groupID;

            MapInfo selectedItem = (MapInfo)this.facetBuilder_panel_workbench_groupBox_createFacetBitmapFiles_label_facetSize_comboBox.SelectedItem;

            if (selectedItem == null)
            {
                this.iLogger.LogMessage("Error: Select a Map Type.");
            }
            else if (StringType.StrCmp(this.facetBuilder_panel_workbench_groupBox_createFacetBitmapFiles_label_facetName_textBox.Text, string.Empty, false) != 0)
            {
                string str = string.Format("{0}/{1}/Map{2}", this.facetBuilder_panel_workbench_groupBox_createFacetBitmapFiles_label_projectFolderLocation_textBox.Text, this.facetBuilder_panel_workbench_groupBox_createFacetBitmapFiles_label_facetName_textBox.Text, selectedItem.MapNumber);

                if (!Directory.Exists(str))
                {
                    Directory.CreateDirectory(str);
                }

                if (this.facetBuilder_panel_workbench_groupBox_createFacetBitmapFiles_label_baseTerrain_comboBox.SelectedItem != null)
                {
                    ClsTerrain clsTerrain = (ClsTerrain)this.facetBuilder_panel_workbench_groupBox_createFacetBitmapFiles_label_baseTerrain_comboBox.SelectedItem;
                    groupID = checked((byte)clsTerrain.GroupID);
                    altID = clsTerrain.AltID;
                }
                else
                {
                    groupID = 9;
                    altID = 66;
                }

                this.iLogger.LogMessage("Creating Terrain Image.");
                this.iLogger.StartTask();

                try
                {
                    string str1 = string.Format("{0}/{1}", str, this.facetBuilder_panel_workbench_groupBox_createFacetBitmapFiles_label_terrainBitmap_textBox.Text);
                    Bitmap palette = this.MakeTerrainBitmapFile(selectedItem.XSize, selectedItem.YSize, groupID, this.facetBuilder_panel_workbench_groupBox_createFacetBitmapFiles_label_addDungeonArea_checkBox.Checked);
                    palette.Palette = this.iTerrain.GetPalette();
                    palette.Save(str1, ImageFormat.Bmp);
                    palette.Dispose();
                }
                catch (Exception exception)
                {
                    ProjectData.SetProjectError(exception);
                    this.iLogger.LogMessage("Error: Problem creating Terrain Image.");
                    ProjectData.ClearProjectError();
                }

                //this.iLogger.EndTask();
                this.iLogger.LogTimeStamp();
                this.iLogger.LogMessage("Creating Altitude Image.");
                this.iLogger.StartTask();

                try
                {
                    string str2 = string.Format("{0}/{1}", str, this.facetBuilder_panel_workbench_groupBox_createFacetBitmapFiles_label_altitudeBitmap_textBox.Text);
                    Bitmap altPalette = this.MakeAltitudeBitmapFile(selectedItem.XSize, selectedItem.YSize, altID, this.facetBuilder_panel_workbench_groupBox_createFacetBitmapFiles_label_addDungeonArea_checkBox.Checked);
                    altPalette.Palette = this.iAltitude.GetAltPalette();
                    altPalette.Save(str2, ImageFormat.Bmp);
                    altPalette.Dispose();
                }
                catch (Exception exception2)
                {
                    ProjectData.SetProjectError(exception2);
                    Exception exception1 = exception2;
                    this.iLogger.LogMessage("Error: Problem creating Altitude Image.");
                    this.iLogger.LogMessage(exception1.Message);
                    ProjectData.ClearProjectError();
                }

                //this.iLogger.EndTask();
                this.iLogger.LogTimeStamp();
                this.iLogger.LogMessage("Done.");
            }
            else
            {
                this.iLogger.LogMessage("Error: Enter a project Name.");
            }
        }

        public Bitmap MakeTerrainBitmapFile(int xSize, int ySize, byte DefaultTerrain, bool Dungeon)
        {
            Bitmap bitmap = new Bitmap(xSize, ySize, PixelFormat.Format8bppIndexed)
            {
                Palette = this.iTerrain.GetPalette()
            };

            Rectangle rectangle = new Rectangle(0, 0, xSize, ySize);
            BitmapData bitmapDatum = bitmap.LockBits(rectangle, ImageLockMode.ReadWrite, PixelFormat.Format8bppIndexed);
            IntPtr scan0 = bitmapDatum.Scan0;
            int width = checked(bitmapDatum.Width * bitmapDatum.Height);
            byte[] defaultTerrain = new byte[checked(checked(width - 1) + 1)];

            Marshal.Copy(scan0, defaultTerrain, 0, width);

            if (!Dungeon)
            {
                int num = checked(xSize - 1);

                for (int i = 0; i <= num; i++)
                {
                    int num1 = checked(ySize - 1);

                    for (int j = 0; j <= num1; j++)
                    {
                        defaultTerrain[checked(checked(j * xSize) + i)] = DefaultTerrain;
                    }
                }
            }
            else
            {
                int num2 = checked(xSize - 1);

                for (int k = 0; k <= num2; k++)
                {
                    int num3 = checked(ySize - 1);

                    for (int l = 0; l <= num3; l++)
                    {
                        if (k <= 5119)
                        {
                            defaultTerrain[checked(checked(l * xSize) + k)] = DefaultTerrain;
                        }
                        else
                        {
                            defaultTerrain[checked(checked(l * xSize) + k)] = 19;
                        }
                    }
                }
            }

            Marshal.Copy(defaultTerrain, 0, scan0, width);
            bitmap.UnlockBits(bitmapDatum);

            return bitmap;
        }

        public Bitmap MakeAltitudeBitmapFile(int xSize, int ySize, byte DefaultAlt, bool Dungeon)
        {
            Bitmap bitmap = new Bitmap(xSize, ySize, PixelFormat.Format8bppIndexed)
            {
                Palette = this.iAltitude.GetAltPalette()
            };
            Rectangle rectangle = new Rectangle(0, 0, xSize, ySize);
            BitmapData bitmapDatum = bitmap.LockBits(rectangle, ImageLockMode.ReadWrite, PixelFormat.Format8bppIndexed);
            IntPtr scan0 = bitmapDatum.Scan0;
            int width = checked(bitmapDatum.Width * bitmapDatum.Height);
            byte[] defaultAlt = new byte[checked(checked(width - 1) + 1)];
            Marshal.Copy(scan0, defaultAlt, 0, width);
            if (!Dungeon)
            {
                int num = checked(xSize - 1);
                for (int i = 0; i <= num; i++)
                {
                    int num1 = checked(ySize - 1);
                    for (int j = 0; j <= num1; j++)
                    {
                        defaultAlt[checked(checked(j * xSize) + i)] = DefaultAlt;
                    }
                }
            }
            else
            {
                int num2 = checked(xSize - 1);
                for (int k = 0; k <= num2; k++)
                {
                    int num3 = checked(ySize - 1);
                    for (int l = 0; l <= num3; l++)
                    {
                        if (k <= 5119)
                        {
                            defaultAlt[checked(checked(l * xSize) + k)] = DefaultAlt;
                        }
                        else
                        {
                            defaultAlt[checked(checked(l * xSize) + k)] = 72;
                        }
                    }
                }
            }
            Marshal.Copy(defaultAlt, 0, scan0, width);
            bitmap.UnlockBits(bitmapDatum);
            return bitmap;
        }

        #endregion

        private void facetBuilder_panel_workbench_selection_groupBox_createYourWorld_button_syncYourAltitudeBitmap_MouseEnter(object sender, EventArgs e)
        {
            facetBuilder_panel_workbench_selection_groupBox_createYourWorld_button_syncYourAltitudeBitmap.ForeColor = System.Drawing.Color.LimeGreen;
        }

        private void facetBuilder_panel_workbench_selection_groupBox_createYourWorld_button_syncYourAltitudeBitmap_Click(object sender, EventArgs e)
        {
            /// Show These Controls
            Control fBPW = this.facetBuilder_panel_workbench;
            Thread.Sleep(25);
            fBPW.Show();

            Control sYAB = this.facetBuilder_panel_workbench_groupBox_syncYourAltitudeBitmap;
            Thread.Sleep(25);
            sYAB.Show();

            /// Hide These Controls
            Control cFBF = this.facetBuilder_panel_workbench_groupBox_createFacetBitmapFiles;
            Thread.Sleep(25);
            cFBF.Hide();

            Control cYNF = this.facetBuilder_panel_workbench_groupBox_compileYourNewFacet;
            Thread.Sleep(25);
            cYNF.Hide();
        }

        private void facetBuilder_panel_workbench_selection_groupBox_createYourWorld_button_syncYourAltitudeBitmap_MouseLeave(object sender, EventArgs e)
        {
            facetBuilder_panel_workbench_selection_groupBox_createYourWorld_button_syncYourAltitudeBitmap.ForeColor = System.Drawing.Color.SlateGray;
        }

        #region GroupBox Functionality

        private void facetBuilder_panel_workbench_groupBox_syncYourAltitudeBitmap_button_locateProject_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog()
            {
                SelectedPath = this.facetBuilder_panel_workbench_groupBox_syncYourAltitudeBitmap_label_projectFolderLocation_textBox.Text
            };
            if (folderBrowserDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.facetBuilder_panel_workbench_groupBox_syncYourAltitudeBitmap_label_projectFolderLocation_textBox.Text = folderBrowserDialog.SelectedPath;
            }
        }

        private async void facetBuilder_panel_workbench_groupBox_syncYourAltitudeBitmap_button_syncAltitudeBitmapFile_Click(object sender, EventArgs e)
        {
            Progress<int> progress = new Progress<int>(i => { facetBuilder_panel_workbench_progressBar.Value = Math.Abs(i); }); // TODO: temporary fix, i didn't get why it put -73
            Progress<string> logger = new Progress<string>(i => { iLogger.LogMessage(i); });
            Task resetProgress = new Task(() => { Thread.Sleep(1000); ((IProgress<int>)progress).Report(0); });
            await Task.Run(() => EncodeAltitudeBitmapHelper.MakeAltitudeImage(facetBuilder_panel_workbench_groupBox_syncYourAltitudeBitmap_label_projectFolderLocation_textBox.Text, facetBuilder_panel_workbench_groupBox_syncYourAltitudeBitmap_label_terrainBitmap_textBox.Text, facetBuilder_panel_workbench_groupBox_syncYourAltitudeBitmap_label_altitudeBitmap_textBox.Text, iAltitude, iTerrain, progress, logger)).ContinueWith(c => resetProgress.Start());

            /// await Task.Run(() => EncodeAltitudeBitmapHelper.MakeAltitudeImage(mainMenu_groupBox01_createYourWorld_panel02_workBench_groupBox01_syncYourAltitudeBitmap_textBox01_projectPath.Text, mainMenu_groupBox01_createYourWorld_panel02_workBench_groupBox01_syncYourAltitudeBitmap_textBox02_terrainBitmap.Text, mainMenu_groupBox01_createYourWorld_panel02_workBench_groupBox01_syncYourAltitudeBitmap_textBox03_altitudeBitmap.Text, iAltitude, iTerrain, progress, logger)).ContinueWith(c => resetProgress.Start());
        }

        #endregion

        private void facetBuilder_panel_workbench_selection_groupBox_createYourWorld_button_compileYourNewFacet_MouseEnter(object sender, EventArgs e)
        {
            facetBuilder_panel_workbench_selection_groupBox_createYourWorld_button_compileYourNewFacet.ForeColor = System.Drawing.Color.LimeGreen;
        }

        private void facetBuilder_panel_workbench_selection_groupBox_createYourWorld_button_compileYourNewFacet_Click(object sender, EventArgs e)
        {
            /// Show These Controls
            Control fBPW = this.facetBuilder_panel_workbench;
            Thread.Sleep(25);
            fBPW.Show();

            Control cYNF = this.facetBuilder_panel_workbench_groupBox_compileYourNewFacet;
            Thread.Sleep(25);
            cYNF.Show();

            /// Hide These Controls
            Control cFBF = this.facetBuilder_panel_workbench_groupBox_createFacetBitmapFiles;
            Thread.Sleep(25);
            cFBF.Hide();

            Control sYAB = this.facetBuilder_panel_workbench_groupBox_syncYourAltitudeBitmap;
            Thread.Sleep(25);
            sYAB.Hide();
        }

        private void facetBuilder_panel_workbench_selection_groupBox_createYourWorld_button_compileYourNewFacet_MouseLeave(object sender, EventArgs e)
        {
            facetBuilder_panel_workbench_selection_groupBox_createYourWorld_button_compileYourNewFacet.ForeColor = System.Drawing.Color.SlateGray;
        }

        #region GroupBox Functionality

        private void facetBuilder_panel_workbench_groupBox_compileYourNewFacet_button_locateProject_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog()
            {
                SelectedPath = this.facetBuilder_panel_workbench_groupBox_compileYourNewFacet_label_projectFolderLocation_textBox.Text
            };

            if (folderBrowserDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.facetBuilder_panel_workbench_groupBox_compileYourNewFacet_label_projectFolderLocation_textBox.Text = folderBrowserDialog.SelectedPath;
            }
        }

        private void facetBuilder_panel_workbench_groupBox_compileYourNewFacet_label_toggleFacetStatics_radioButton_on_CheckedChanged(object sender, EventArgs e)
        {
            this.i_RandomStatic = true;
            /// Form NotificationAlertOn = new NotificationAlertOn();
            /// NotificationAlertOn.Show();
            System.Media.SystemSounds.Beep.Play();
        }

        private void facetBuilder_panel_workbench_groupBox_compileYourNewFacet_label_toggleFacetStatics_radioButton_off_CheckedChanged(object sender, EventArgs e)
        {
            this.i_RandomStatic = false;
            /// Form NotificationAlertOff = new NotificationAlertOff();
            /// NotificationAlertOff.Show();
            System.Media.SystemSounds.Beep.Play();
        }

        private void facetBuilder_panel_workbench_groupBox_compileYourNewFacet_button_createFacetFiles_Click(object sender, EventArgs e)
        {
            if (Interaction.MsgBox("You are about to create the Mul Files\r\nAre you sure ?", MsgBoxStyle.YesNo, "Make UO Map") == MsgBoxResult.Yes)
            {
                facetBuilder mc_MapMake = this;
                ///CompileYourNewMap uOMapMake = this;
                ///
                new Thread(new ThreadStart(CreateFacet_mul_Files)).Start();
            }
        }

        private void CreateFacet_mul_Files()
        {
            short altID = 0;
            string str;
            byte num = 0;
            int num1;
            int num2;
            int num3;
            int num4;
            IEnumerator enumerator = null;
            TransitionTable transitionTable = new TransitionTable();
            DateTime now = DateTime.Now;
            this.iLogger.StartTask();
            this.iLogger.LogMessage("Loading Terrain Image.");
            try
            {
                // Reading Terrain.bmp (Bitmap File)
                str = string.Format("{0}\\{1}", this.facetBuilder_panel_workbench_groupBox_compileYourNewFacet_label_projectFolderLocation_textBox.Text, this.facetBuilder_panel_workbench_groupBox_compileYourNewFacet_label_terrainBitmap_textBox.Text);
                this.iLogger.LogMessage(str);
                this.i_Terrain = new Bitmap(str);
            }
            catch (Exception exception1)
            {
                ProjectData.SetProjectError(exception1);
                Exception exception = exception1;
                this.iLogger.LogMessage("Problem with Loading Terrain Image.");
                this.iLogger.LogMessage(exception.Message);
                ProjectData.ClearProjectError();
                return;
            }
            this.iLogger.LogMessage("Loading Altitude Image.");
            try
            {
                // Reading Altitude.bmp (Bitmap File)
                str = string.Format("{0}\\{1}", this.facetBuilder_panel_workbench_groupBox_compileYourNewFacet_label_projectFolderLocation_textBox.Text, this.facetBuilder_panel_workbench_groupBox_compileYourNewFacet_label_altitudeBitmap_textBox.Text);
                this.iLogger.LogMessage(str);
                this.i_Altitude = new Bitmap(str);
            }
            catch (Exception exception3)
            {
                ProjectData.SetProjectError(exception3);
                Exception exception2 = exception3;
                this.iLogger.LogMessage("Problem with Loading Altitude Image.");
                this.iLogger.LogMessage(exception2.Message);
                ProjectData.ClearProjectError();
                return;
            }
            //this.iLogger.EndTask();
            this.iLogger.LogTimeStamp();
            this.iLogger.LogMessage("Preparing Image Files.");
            this.iLogger.StartTask();
            int width = this.i_Terrain.Width;
            int height = this.i_Terrain.Height;
            Rectangle rectangle = new Rectangle(0, 0, width, height);
            BitmapData bitmapDatum = this.i_Terrain.LockBits(rectangle, ImageLockMode.ReadWrite, PixelFormat.Format8bppIndexed);
            IntPtr scan0 = bitmapDatum.Scan0;
            int width1 = checked(bitmapDatum.Width * bitmapDatum.Height);
            byte[] numArray = new byte[checked(checked(width1 - 1) + 1)];
            Marshal.Copy(scan0, numArray, 0, width1);
            BitmapData bitmapDatum1 = this.i_Altitude.LockBits(rectangle, ImageLockMode.ReadWrite, PixelFormat.Format8bppIndexed);
            IntPtr intPtr = bitmapDatum1.Scan0;
            int width2 = checked(bitmapDatum1.Width * bitmapDatum1.Height);
            byte[] numArray1 = new byte[checked(checked(width2 - 1) + 1)];
            Marshal.Copy(intPtr, numArray1, 0, width2);
            //this.iLogger.EndTask();
            this.iLogger.LogTimeStamp();
            this.iLogger.LogMessage("Creating Master Terrian Table.");
            this.iLogger.StartTask();
            MapCell[,] mapCell = new MapCell[checked(width + 1), checked(height + 1)];
            ClsAltitudeTable clsAltitudeTable = new ClsAltitudeTable();
            clsAltitudeTable.Load();
            try
            {
                int num5 = checked(width - 1);
                for (int i = 0; i <= num5; i++)
                {
                    int num6 = checked(height - 1);
                    for (int j = 0; j <= num6; j++)
                    {
                        int num7 = checked(checked(j * width) + i);
                        ClsAltitude getAltitude = clsAltitudeTable.GetAltitude(numArray1[num7]);
                        mapCell[i, j] = new MapCell(numArray[num7], getAltitude.GetAltitude);
                    }
                }
            }
            catch (Exception exception4)
            {
                ProjectData.SetProjectError(exception4);
                this.iLogger.LogMessage("Altitude image needs to be rebuilt");
                ProjectData.ClearProjectError();
                return;
            }
            this.i_Terrain.Dispose();
            this.i_Altitude.Dispose();
            this.iLogger.LogTimeStamp();
            width--;
            height--;
            int num8 = checked((int)Math.Round((double)width / 8 - 1));
            int num9 = checked((int)Math.Round((double)height / 8 - 1));
            this.iLogger.LogMessage("Load Transition Tables.");
            this.iLogger.StartTask();
            string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;

            #region Data Directory Modification

            baseDirectory = string.Concat(baseDirectory, "MapCompiler\\Engine\\Transitions\\");

            #endregion

            if (Directory.Exists(baseDirectory))
            {
                transitionTable.MassLoad(baseDirectory);
                this.iLogger.LogTimeStamp();
                this.iLogger.LogMessage("Preparing Static Tables");
                Collection[,] collections = new Collection[checked(num8 + 1), checked(num9 + 1)];
                int num10 = num8;
                for (int k = 0; k <= num10; k++)
                {
                    int num11 = num9;
                    for (int l = 0; l <= num11; l++)
                    {
                        collections[k, l] = new Collection();
                    }
                }
                this.iLogger.LogMessage("Applying Transition Tables.");
                this.iLogger.StartTask();
                this.facetBuilder_panel_workbench_progressBar.Invoke(() => { this.facetBuilder_panel_workbench_progressBar.Maximum = width; });
                ClsTerrainTable clsTerrainTable = new ClsTerrainTable();
                clsTerrainTable.Load();
                MapTile mapTile = new MapTile();
                Transition.Transition transition = new Transition.Transition();
                short[] numArray2 = new short[16];
                short num12 = checked((short)width);
                for (short m = 0; m <= num12; m = checked((short)(m + 1)))
                {
                    num1 = (m != 0 ? checked(m - 1) : width);
                    num2 = (m != width ? checked(m + 1) : 0);
                    short num13 = checked((short)height);
                    for (short n = 0; n <= num13; n = checked((short)(n + 1)))
                    {
                        num4 = (n != 0 ? checked(n - 1) : height);
                        num3 = (n != height ? checked(n + 1) : 0);
                        object[] groupID = new object[] { mapCell[num1, num4].GroupID, mapCell[m, num4].GroupID, mapCell[num2, num4].GroupID, mapCell[num1, n].GroupID, mapCell[m, n].GroupID, mapCell[num2, n].GroupID, mapCell[num1, num3].GroupID, mapCell[m, num3].GroupID, mapCell[num2, num3].GroupID };
                        string str1 = string.Format("{0:X2}{1:X2}{2:X2}{3:X2}{4:X2}{5:X2}{6:X2}{7:X2}{8:X2}", groupID);
                        try
                        {
                            transition = (Transition.Transition)(transitionTable.GetTransitionTable[str1]);

                            if (transition == null)
                            {
                                ClsTerrain terrianGroup = clsTerrainTable.TerrianGroup(mapCell[m, n].GroupID);
                                mapCell[m, n].TileID = terrianGroup.TileID;
                                mapCell[m, n].AltID = altID;
                                terrianGroup = null;
                            }
                            else
                            {
                                altID = mapCell[m, n].AltID;
                                mapTile = transition.GetRandomMapTile();
                                if (mapTile == null)
                                {
                                    ClsTerrain clsTerrain = clsTerrainTable.TerrianGroup(mapCell[m, n].GroupID);
                                    mapCell[m, n].TileID = clsTerrain.TileID;
                                    mapCell[m, n].ChangeAltID((short)clsTerrain.AltID);
                                    clsTerrain = null;
                                }
                                else
                                {
                                    MapTile mapTile1 = mapTile;
                                    mapCell[m, n].TileID = mapTile1.TileID;
                                    mapCell[m, n].ChangeAltID(mapTile1.AltIDMod);
                                    mapTile1 = null;
                                }
                                transition.GetRandomStaticTiles(m, n, altID, collections, this.i_RandomStatic);
                            }
                            if (mapCell[m, n].GroupID == 254)
                            {
                                mapCell[m, n].TileID = 1078;
                                mapCell[m, n].AltID = 0;
                            }
                        }
                        catch (Exception exception6)
                        {
                            ProjectData.SetProjectError(exception6);
                            Exception exception5 = exception6;

                            buildLogger loggerForm = this.iLogger;

                            groupID = new object[] { m, n, altID, str1 };

                            loggerForm.LogMessage(string.Format("\r\nLocation: X:{0}, Y:{1}, Z:{2} Hkey:{3}", groupID));
                            this.iLogger.LogMessage(exception5.ToString());

                            ProjectData.ClearProjectError();
                            return;
                        }
                    }

                    this.facetBuilder_panel_workbench_progressBar.Invoke(() => { this.facetBuilder_panel_workbench_progressBar.Value = m; });
                }
                this.iLogger.LogTimeStamp();
                this.iLogger.LogMessage("Second Pass.");
                this.iLogger.StartTask();
                short[] altID1 = new short[9];
                RoughEdge roughEdge = new RoughEdge();
                short num14 = checked((short)width);
                for (short o = 0; o <= num14; o = checked((short)(o + 1)))
                {
                    num1 = (o != 0 ? checked(o - 1) : width);
                    num2 = (o != width ? checked(o + 1) : 0);
                    short num15 = checked((short)height);
                    for (short p = 0; p <= num15; p = checked((short)(p + 1)))
                    {
                        num4 = (p != 0 ? checked(p - 1) : height);
                        num3 = (p != height ? checked(p + 1) : 0);
                        mapCell[o, p].ChangeAltID(roughEdge.CheckCorner(mapCell[num1, num4].TileID));
                        mapCell[o, p].ChangeAltID(roughEdge.CheckLeft(mapCell[num1, p].TileID));
                        mapCell[o, p].ChangeAltID(roughEdge.CheckTop(mapCell[o, num4].TileID));
                        if (mapCell[o, p].GroupID == 20)
                        {
                            altID1[0] = mapCell[num1, num4].AltID;
                            altID1[1] = mapCell[o, num4].AltID;
                            altID1[2] = mapCell[num2, num4].AltID;
                            altID1[3] = mapCell[num1, p].AltID;
                            altID1[4] = mapCell[o, p].AltID;
                            altID1[5] = mapCell[num2, p].AltID;
                            altID1[6] = mapCell[num1, num3].AltID;
                            altID1[7] = mapCell[o, num3].AltID;
                            altID1[8] = mapCell[num2, num3].AltID;
                            Array.Sort(altID1);
                            float single = 10f * VBMath.Rnd();
                            if (single == 0f)
                            {
                                mapCell[o, p].AltID = checked((short)(checked(altID1[8] - 4)));
                            }
                            else if (single >= 1f && single <= 2f)
                            {
                                mapCell[o, p].AltID = checked((short)(checked(altID1[8] - 2)));
                            }
                            else if (single >= 3f && single <= 7f)
                            {
                                mapCell[o, p].AltID = altID1[8];
                            }
                            else if (single >= 8f && single <= 9f)
                            {
                                mapCell[o, p].AltID = checked((short)(checked(altID1[8] + 2)));
                            }
                            else if (single == 10f)
                            {
                                mapCell[o, p].AltID = checked((short)(checked(altID1[8] + 4)));
                            }
                        }

                        if (clsTerrainTable.TerrianGroup(mapCell[o, p].GroupID).RandAlt)
                        {
                            float single1 = 10f * VBMath.Rnd();
                            if (single1 == 0f)
                            {
                                mapCell[o, p].ChangeAltID(-4);
                            }
                            else if (single1 >= 1f && single1 <= 2f)
                            {
                                mapCell[o, p].ChangeAltID(-2);
                            }
                            else if (single1 >= 8f && single1 <= 9f)
                            {
                                mapCell[o, p].ChangeAltID(2);
                            }
                            else if (single1 == 10f)
                            {
                                mapCell[o, p].ChangeAltID(4);
                            }
                        }
                    }
                    this.facetBuilder_panel_workbench_progressBar.Invoke(() => { this.facetBuilder_panel_workbench_progressBar.Value = o; });
                }
                this.iLogger.LogTimeStamp();
                int num16 = 1;
                int num17 = width;
                if (num17 == 6143)
                {
                    num = 0;
                }
                else if (num17 == 2303)
                {
                    num = 2;
                }
                else if (num17 == 2559)
                {
                    num = 3;
                }
                this.iLogger.LogMessage("\r\n");
                this.iLogger.LogMessage("Load . . . . . Import Tiles.");
                this.iLogger.StartTask();
                ImportTiles importTile = new ImportTiles(collections, this.facetBuilder_panel_workbench_groupBox_compileYourNewFacet_label_projectFolderLocation_textBox.Text);
                this.iLogger.LogTimeStamp();
                this.iLogger.LogMessage("\r\n");
                this.iLogger.LogMessage("Write Mul Files.");
                this.iLogger.StartTask();
                str = string.Format("{0}/Map{1}.mul", this.facetBuilder_panel_workbench_groupBox_compileYourNewFacet_label_projectFolderLocation_textBox.Text, num);
                this.iLogger.LogMessage(str);
                FileStream fileStream = new FileStream(str, FileMode.Create);
                BinaryWriter binaryWriter = new BinaryWriter(fileStream);
                int num18 = width;
                for (int q = 0; q <= num18; q = checked(q + 8))
                {
                    int num19 = height;
                    for (int r = 0; r <= num19; r = checked(r + 8))
                    {
                        binaryWriter.Write(num16);
                        int num20 = 0;
                        do
                        {
                            int num21 = 0;
                            do
                            {
                                mapCell[checked(q + num21), checked(r + num20)].WriteMapMul(binaryWriter);
                                num21++;
                            }
                            while (num21 <= 7);
                            num20++;
                        }
                        while (num20 <= 7);
                    }
                }
                binaryWriter.Close();
                fileStream.Close();
                str = string.Format("{0}/StaIdx{1}.mul", this.facetBuilder_panel_workbench_groupBox_compileYourNewFacet_label_projectFolderLocation_textBox.Text, num);
                FileStream fileStream1 = new FileStream(str, FileMode.Create);
                this.iLogger.LogMessage(str);
                str = string.Format("{0}/Statics{1}.mul", this.facetBuilder_panel_workbench_groupBox_compileYourNewFacet_label_projectFolderLocation_textBox.Text, num);
                FileStream fileStream2 = new FileStream(str, FileMode.Create);
                this.iLogger.LogMessage(str);
                BinaryWriter binaryWriter1 = new BinaryWriter(fileStream1);
                BinaryWriter binaryWriter2 = new BinaryWriter(fileStream2);
                int num22 = num8;
                for (int s = 0; s <= num22; s++)
                {
                    int num23 = num9;
                    for (int t = 0; t <= num23; t++)
                    {
                        int num24 = 0;
                        int position = checked((int)binaryWriter2.BaseStream.Position);
                        try
                        {
                            enumerator = collections[s, t].GetEnumerator();
                            while (enumerator.MoveNext())
                            {
                                ((StaticCell)enumerator.Current).Write(binaryWriter2);
                                num24 = checked(num24 + 7);
                            }
                        }
                        finally
                        {
                            if (enumerator is IDisposable)
                            {
                                ((IDisposable)enumerator).Dispose();
                            }
                        }
                        if (num24 == 0)
                        {
                            position = -1;
                        }
                        binaryWriter1.Write(position);
                        binaryWriter1.Write(num24);
                        binaryWriter1.Write(num16);
                    }
                }
                binaryWriter2.Close();
                binaryWriter1.Close();
                fileStream2.Close();
                fileStream1.Close();
                this.iLogger.LogTimeStamp();
                this.iLogger.LogMessage("Done.");
            }
            else
            {
                this.iLogger.LogMessage("Unable to find Transition Data files in the following path: ");
                this.iLogger.LogMessage(baseDirectory);
            }

        }

        #endregion

        private void facetBuilder_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}