// <copyright file="DBConnection.cs" company="Ma Chung University">
// Copyright © 2017 All Rights Reserved
// Malang, East Java, Indonesia
// </copyright>
// <author> Augustine Sena aka Sena </author> 
// <summary>Example program of project campus
// Using softcomputing-fuzzy database fuzzyfy digital camera data
// Bad Recommendation for Big Data</summary>

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Controls;
using MetroFramework.Components;
using MetroFramework.Animation;
using MetroFramework.Forms;


namespace DigitalCameraSolutionDFuzzy
{
    public partial class Homepage : MetroForm
    {
        DBConnection executeDB;

        #region LISTING
        List<double> PRICE_CHEAP = new List<double>();
        List<double> PRICE_MEDIUM = new List<double>();
        List<double> PRICE_EXPENSIVE = new List<double>();
            List<double> PRICE;
        List<double> RELEASE_DATE_EARLIER = new List<double>();
        List<double> RELEASE_DATE_LATTER = new List<double>();
            List<double> RELEASE_DATE;
        List<double> DIMENSION_SMALL = new List<double>();
        List<double> DIMENSION_MEDIUM = new List<double>();
        List<double> DIMENSION_WIDE = new List<double>();
            List<double> DIMENSION;
        List<double> WEIGHT_LIGHT = new List<double>();
        List<double> WEIGHT_INTERMEDIATE = new List<double>();
        List<double> WEIGHT_HEAVY = new List<double>();
            List<double> WEIGHT;
        List<double> SCREEN_DOTS_LESS = new List<double>();
        List<double> SCREEN_DOTS_MORE = new List<double>();
            List<double> SCREEN_DOTS;
        List<double> MAX_RESOLUTION_LOW = new List<double>();
        List<double> MAX_RESOLUTION_MEDIUM = new List<double>();
        List<double> MAX_RESOLUTION_HIGH = new List<double>();
            List<double> MAX_RESOLUTION;
        List<double> EFFECTIVE_PIXEL_LOW = new List<double>();
        List<double> EFFECTIVE_PIXEL_MEDIUM = new List<double>();
        List<double> EFFECTIVE_PIXEL_HIGH = new List<double>();
            List<double> EFFECTIVE_PIXEL;
        List<double> PHOTO_DETECTORS_LOW = new List<double>();
        List<double> PHOTO_DETECTORS_MEDIUM = new List<double>();
        List<double> PHOTO_DETECTORS_HIGH = new List<double>();
            List<double> PHOTO_DETECTORS;
        List<double> SENSOR_SIZE_SMALL = new List<double>();
        List<double> SENSOR_SIZE_MEDIUM = new List<double>();
        List<double> SENSOR_SIZE_WIDE = new List<double>();
            List<double> SENSOR_SIZE;

        List<double> Initiator0 = new List<double>();
        List<double> Initiator1 = new List<double>();
        List<double> Fire_Strength;
        #endregion

        public Homepage()
        {
            InitializeComponent();
            
            #region BASIC STYLING and INITIATION 
            MetroStyleManager metroStyleManager = new MetroStyleManager();
            executeDB = new DBConnection();
            Fire_Strength = new List<double>();
            
            metroStyleManager.Theme = this.Theme;
            metroStyleManager.Style = this.Style;
            metroStyleManager.OwnerForm = this;
            //dataGridViewResult.ForeColor = Color.Black;
            //dataGridViewResult.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            //dataGridViewResult.ColumnHeadersDefaultCellStyle.BackColor = Color.Maroon;
            dataGridViewResult.GridColor = Color.White;
            int max_length = 27;//dataGridViewResult.Width;
            for (int i = 0; i <= max_length; i++) {
                dataGridViewResult.Columns[i].DefaultCellStyle.ForeColor = Color.White;
                dataGridViewResult.Columns[i].DefaultCellStyle.BackColor = Color.FromArgb(17, 17, 17);
            }
            dataGridViewResult.Columns[0].DefaultCellStyle.ForeColor = Color.Yellow;
            
            metroTextBoxSearch.Text = "Find";
            metroTextBoxSearch.GotFocus += RemoveText;
            metroTextBoxSearch.LostFocus += AddText;
            //metroButtonFuzzyfy.UseVisualStyleBackColor = true;
            //metroButtonFuzzyfy.BackColor = Color.Maroon;
            #endregion

            

            #region PRICE
            metroComboBoxPrice.DisplayMember = "Type";
            //metroComboBoxPrice.ValueMember = "Type";

            var price = new[] {
               /* new { Type = */"Cheap",// Value = "row[2]" },
               /* new { Type = */ "Medium", //Value = "row[3]" },
               /* new { Type =*/ "Expensive" //Value = "row[4]" }
            };

            metroComboBoxPrice.DataSource = price;
            metroComboBoxPrice.SelectedIndex = 0;
            metroComboBoxPrice.SelectedText = price[0];
            #endregion

            #region DATE RELEASE
            metroComboBoxDateRelease.DisplayMember = "Type";
            //metroComboBoxPrice.ValueMember = "Type";

            var date = new[] {
               /* new { Type = */"Earlier",// Value = "row[2]" },
               /* new { Type = */ "Latter" //Value = "row[3]" }
            };

            metroComboBoxDateRelease.DataSource = date;
            metroComboBoxDateRelease.SelectedIndex = 0;
            metroComboBoxDateRelease.SelectedText = date[0];
            #endregion

            #region DIMENSION
            metroComboBoxDimension.DisplayMember = "Type";
            //metroComboBoxPrice.ValueMember = "Type";

            var dimension = new[] {
               /* new { Type = */"Small",// Value = "row[2]" },
               /* new { Type = */ "Medium", //Value = "row[3]" },
               /* new { Type = */ "Wide" //Value = "row[3]" }
            };
            metroComboBoxDimension.DataSource = dimension;
            metroComboBoxDimension.SelectedIndex = 0;
            metroComboBoxDimension.SelectedText = dimension[0];
            #endregion

            #region WEIGHT
            metroComboBoxWeight.DisplayMember = "Type";
            //metroComboBoxPrice.ValueMember = "Type";

            var weight = new[] {
               /* new { Type = */"Light",// Value = "row[2]" },
               /* new { Type = */ "Intermediate", //Value = "row[3]" },
               /* new { Type = */ "Heavy" //Value = "row[3]" }
            };

            metroComboBoxWeight.DataSource = weight;
            metroComboBoxWeight.SelectedIndex = 0;
            metroComboBoxWeight.SelectedText = weight[0];
            #endregion

            #region SCREEN DOTS
            metroComboBoxScreenDots.DisplayMember = "Type";
            //metroComboBoxPrice.ValueMember = "Type";

            var screendots = new[] {
               /* new { Type = */"Less",// Value = "row[2]" },
               /* new { Type = */ "More" //Value = "row[3]" }
            };

            metroComboBoxScreenDots.DataSource = screendots;
            metroComboBoxScreenDots.SelectedIndex = 0;
            metroComboBoxScreenDots.SelectedText = screendots[0];
            #endregion

            #region MAX RESOLUTION
            metroComboBoxMaxResolution.DisplayMember = "Type";
            //metroComboBoxPrice.ValueMember = "Type";

            var maxres = new[] {
               /* new { Type = */"Low",// Value = "row[2]" },
               /* new { Type = */ "Medium", //Value = "row[3]" },
               /* new { Type = */ "High" //Value = "row[3]" }
            };

            metroComboBoxMaxResolution.DataSource = maxres;
            metroComboBoxMaxResolution.SelectedIndex = 0;
            metroComboBoxMaxResolution.SelectedText = maxres[0];
            #endregion

            #region EFFECTIVE PIXEL
            metroComboBoxEffectivePixel.DisplayMember = "Type";
            //metroComboBoxPrice.ValueMember = "Type";

            var pixel = new[] {
               /* new { Type = */"Low",// Value = "row[2]" },
               /* new { Type = */ "Medium", //Value = "row[3]" },
               /* new { Type = */ "High" //Value = "row[3]" }
            };

            metroComboBoxEffectivePixel.DataSource = pixel;
            metroComboBoxEffectivePixel.SelectedIndex = 0;
            metroComboBoxEffectivePixel.SelectedText = pixel[0];
            #endregion

            #region PHOTO DETECTORS
            metroComboBoxPhotoDetectors.DisplayMember = "Type";
            //metroComboBoxPrice.ValueMember = "Type";

            var photo = new[] {
               /* new { Type = */"Low",// Value = "row[2]" },
               /* new { Type = */ "Medium", //Value = "row[3]" },
               /* new { Type = */ "High" //Value = "row[3]" }
            };

            metroComboBoxPhotoDetectors.DataSource = photo;
            metroComboBoxPhotoDetectors.SelectedIndex = 0;
            metroComboBoxPhotoDetectors.SelectedText = photo[0];
            #endregion

            #region SENSOR SIZE
            metroComboBoxSensorSize.DisplayMember = "Type";
            //metroComboBoxPrice.ValueMember = "Type";

            var sensor = new[] {
               /* new { Type = */"Small",// Value = "row[2]" },
               /* new { Type = */ "Medium", //Value = "row[3]" },
               /* new { Type = */ "Wide" //Value = "row[3]" }
            };

            metroComboBoxSensorSize.DataSource = sensor;
            metroComboBoxSensorSize.SelectedIndex = 0;
            metroComboBoxSensorSize.SelectedText = sensor[0];
            #endregion

            INITIATE_FUZZY();
            BEGIN_FUZZY();
            Search();
        }
        #region FUZZYNESS
        public void INITIATE_FUZZY()
        {
            List<int> price = executeDB.GET_PRICE_LIST();
            List<int> release_date = executeDB.GET_RELEASE_DATE_LIST();
            List<int> dimension = executeDB.GET_DIMENSION_SQUARECUBIC_LIST();
            List<int> weight = executeDB.GET_WEIGHT_LIST();
            List<int> screen_dots = executeDB.GET_SCREEN_DOTS_LIST();
            List<int> max_resolution = executeDB.GET_MAX_RESOLUTION_LIST();
            List<double> effective_pixel = executeDB.GET_EFFECTIVE_PIXEL_LIST();
            List<double> photo_detectors = executeDB.GET_PHOTO_DETECTORS_LIST();
            List<double> sensor_size = executeDB.GET_SENSOR_SIZE_LIST();
            CLEAR_ALL();
            for (int i =0 ; i<executeDB.MAINDATA_LENGTH();i++)
            {
                Initiator0.Add(2);
                Initiator1.Add(1);

                PRICE_CHEAP.Add(DigitalCameraFuzzySets.PRICE.CHEAP.GetValue(price[i]));
                PRICE_MEDIUM.Add(DigitalCameraFuzzySets.PRICE.MEDIUM.GetValue(price[i]));
                PRICE_EXPENSIVE.Add(DigitalCameraFuzzySets.PRICE.EXPENSIVE.GetValue(price[i]));

                RELEASE_DATE_EARLIER.Add(DigitalCameraFuzzySets.DATE_RELEASE.EARLIER.GetValue(release_date[i]));
                RELEASE_DATE_LATTER.Add(DigitalCameraFuzzySets.DATE_RELEASE.LATTER.GetValue(release_date[i]));

                DIMENSION_SMALL.Add(DigitalCameraFuzzySets.DIMENSION.SMALL.GetValue(dimension[i]));
                DIMENSION_MEDIUM.Add(DigitalCameraFuzzySets.DIMENSION.MEDIUM.GetValue(dimension[i]));
                DIMENSION_WIDE.Add(DigitalCameraFuzzySets.DIMENSION.WIDE.GetValue(dimension[i]));

                WEIGHT_LIGHT.Add(DigitalCameraFuzzySets.WEIGHT.LIGHT.GetValue(weight[i]));
                WEIGHT_INTERMEDIATE.Add(DigitalCameraFuzzySets.WEIGHT.INTERMEDIATE.GetValue(weight[i]));
                WEIGHT_HEAVY.Add(DigitalCameraFuzzySets.WEIGHT.HEAVY.GetValue(weight[i]));

                SCREEN_DOTS_LESS.Add(DigitalCameraFuzzySets.SCREEN_DOTS.LESS.GetValue(screen_dots[i]));
                SCREEN_DOTS_MORE.Add(DigitalCameraFuzzySets.SCREEN_DOTS.MORE.GetValue(screen_dots[i]));

                MAX_RESOLUTION_LOW.Add(DigitalCameraFuzzySets.MAX_RESOLUTION.LOW.GetValue(max_resolution[i]));
                MAX_RESOLUTION_MEDIUM.Add(DigitalCameraFuzzySets.MAX_RESOLUTION.MEDIUM.GetValue(max_resolution[i]));
                MAX_RESOLUTION_HIGH.Add(DigitalCameraFuzzySets.MAX_RESOLUTION.HIGH.GetValue(max_resolution[i]));

                EFFECTIVE_PIXEL_LOW.Add(DigitalCameraFuzzySets.EFFECTIVE_PIXEL.LOW.GetValue(effective_pixel[i]));
                EFFECTIVE_PIXEL_MEDIUM.Add(DigitalCameraFuzzySets.EFFECTIVE_PIXEL.MEDIUM.GetValue(effective_pixel[i]));
                EFFECTIVE_PIXEL_HIGH.Add(DigitalCameraFuzzySets.EFFECTIVE_PIXEL.HIGH.GetValue(effective_pixel[i]));

                PHOTO_DETECTORS_LOW.Add(DigitalCameraFuzzySets.PHOTO_DETECTORS.LOW.GetValue(photo_detectors[i]));
                PHOTO_DETECTORS_MEDIUM.Add(DigitalCameraFuzzySets.PHOTO_DETECTORS.MEDIUM.GetValue(photo_detectors[i]));
                PHOTO_DETECTORS_HIGH.Add(DigitalCameraFuzzySets.PHOTO_DETECTORS.HIGH.GetValue(photo_detectors[i]));

                SENSOR_SIZE_SMALL.Add(DigitalCameraFuzzySets.SENSOR_SIZE.SMALL.GetValue(sensor_size[i]));
                SENSOR_SIZE_MEDIUM.Add(DigitalCameraFuzzySets.SENSOR_SIZE.MEDIUM.GetValue(sensor_size[i]));
                SENSOR_SIZE_WIDE.Add(DigitalCameraFuzzySets.SENSOR_SIZE.WIDE.GetValue(sensor_size[i]));
            }
        }
        public void CLEAR_ALL()
        {
            PRICE_CHEAP.Clear();
            PRICE_MEDIUM.Clear();
            PRICE_EXPENSIVE.Clear();

            RELEASE_DATE_EARLIER.Clear();
            RELEASE_DATE_LATTER.Clear();

            DIMENSION_SMALL.Clear();
            DIMENSION_MEDIUM.Clear();
            DIMENSION_WIDE.Clear();

            WEIGHT_LIGHT.Clear();
            WEIGHT_INTERMEDIATE.Clear();
            WEIGHT_HEAVY.Clear();

            SCREEN_DOTS_LESS.Clear();
            SCREEN_DOTS_MORE.Clear();

            MAX_RESOLUTION_LOW.Clear();
            MAX_RESOLUTION_MEDIUM.Clear();
            MAX_RESOLUTION_HIGH.Clear();

            EFFECTIVE_PIXEL_LOW.Clear();
            EFFECTIVE_PIXEL_MEDIUM.Clear();
            EFFECTIVE_PIXEL_HIGH.Clear();

            PHOTO_DETECTORS_LOW.Clear();
            PHOTO_DETECTORS_MEDIUM.Clear();
            PHOTO_DETECTORS_HIGH.Clear();

            SENSOR_SIZE_SMALL.Clear();
            SENSOR_SIZE_MEDIUM.Clear();
            SENSOR_SIZE_WIDE.Clear();


        } 
        public List<double> getValueMF_PRICE()
        {
            if (metroCheckBoxPrice.Checked)
            {
                switch (metroComboBoxPrice.SelectedIndex)
                {
                    case 0:
                        PRICE = PRICE_CHEAP;
                        break;
                    case 1:
                        PRICE = PRICE_MEDIUM;
                        break;
                    case 2:
                        PRICE = PRICE_EXPENSIVE;
                        break;
                    default:
                        PRICE = Initiator0;
                        break;
                }
            }
            else
            {
                 PRICE = Initiator0;
            }
            return PRICE;
        }
        public List<double> getValueMF_DATE_RELEASE()
        {
            if (metroCheckBoxDateRelease.Checked)
            {
                switch (metroComboBoxDateRelease.SelectedIndex)
                {
                    case 0:
                        RELEASE_DATE = RELEASE_DATE_EARLIER;
                        break;
                    case 1:
                        RELEASE_DATE = RELEASE_DATE_LATTER;
                        break;
                    default:
                        RELEASE_DATE = Initiator0;
                        break;
                }
            }
            else
            {
                RELEASE_DATE = Initiator0;
            }
            return RELEASE_DATE;
        }
        public List<double> getValueMF_DIMENSION()
        {
            if (metroCheckBoxDimension.Checked)
            {
                switch (metroComboBoxDimension.SelectedIndex)
                {
                    case 0:
                        DIMENSION = DIMENSION_SMALL;
                        break;
                    case 1:
                        DIMENSION = DIMENSION_MEDIUM;
                        break;
                    case 2:
                        DIMENSION = DIMENSION_WIDE;
                        break;
                    default:
                        DIMENSION = Initiator0;
                        break;
                }
            }
            else
            {
                DIMENSION = Initiator0;
            }
            return DIMENSION;
        }
        public List<double> getValueMF_WEIGHT()
        {
            if (metroCheckBoxWeight.Checked)
            {
                switch (metroComboBoxWeight.SelectedIndex)
                {
                    case 0:
                        WEIGHT = WEIGHT_LIGHT;
                        break;
                    case 1:
                        WEIGHT = WEIGHT_INTERMEDIATE;
                        break;
                    case 2:
                        WEIGHT = WEIGHT_HEAVY;
                        break;
                    default:
                        WEIGHT = Initiator0;
                        break;
                }
            }
            else
            {
                WEIGHT = Initiator0;
            }
            return WEIGHT;
        }
        public List<double> getValueMF_SCREEN_DOTS()
        {
            if (metroCheckBoxScreenDots.Checked)
            {
                switch (metroComboBoxScreenDots.SelectedIndex)
                {
                    case 0:
                        SCREEN_DOTS = SCREEN_DOTS_LESS;
                        break;
                    case 1:
                        SCREEN_DOTS = SCREEN_DOTS_MORE;
                        break;
                    default:
                        SCREEN_DOTS = Initiator0;
                        break;
                }
            }
            else
            {
                SCREEN_DOTS = Initiator0;
            }
            return SCREEN_DOTS;
        }
        public List<double> getValueMF_MAX_RESOLUTION()
        {
            if (metroCheckBoxMaxRes.Checked)
            {
                switch (metroComboBoxMaxResolution.SelectedIndex)
                {
                    case 0:
                        MAX_RESOLUTION = MAX_RESOLUTION_LOW;
                        break;
                    case 1:
                        MAX_RESOLUTION = MAX_RESOLUTION_MEDIUM;
                        break;
                    case 2:
                        MAX_RESOLUTION = MAX_RESOLUTION_HIGH;
                        break;
                    default:
                        MAX_RESOLUTION = Initiator0;
                        break;
                }
            }
            else
            {
                MAX_RESOLUTION = Initiator0;
            }
            return MAX_RESOLUTION;
        }
        public List<double> getValueMF_EFFECTIVE_PIXEL()
        {
            if (metroCheckBoxEffectivePixel.Checked)
            {
                switch (metroComboBoxEffectivePixel.SelectedIndex)
                {
                    case 0:
                        EFFECTIVE_PIXEL = EFFECTIVE_PIXEL_LOW;
                        break;
                    case 1:
                        EFFECTIVE_PIXEL = EFFECTIVE_PIXEL_MEDIUM;
                        break;
                    case 2:
                        EFFECTIVE_PIXEL = EFFECTIVE_PIXEL_HIGH;
                        break;
                    default:
                        EFFECTIVE_PIXEL = Initiator0;
                        break;
                }
            }
            else
            {
                EFFECTIVE_PIXEL = Initiator0;
            }
            return EFFECTIVE_PIXEL;
        }
        public List<double> getValueMF_PHOTO_DETECTORS()
        {
            if (metroCheckBoxPhotoDetectors.Checked)
            {
                switch (metroComboBoxPhotoDetectors.SelectedIndex)
                {
                    case 0:
                        PHOTO_DETECTORS = PHOTO_DETECTORS_LOW;
                        break;
                    case 1:
                        PHOTO_DETECTORS = PHOTO_DETECTORS_MEDIUM;
                        break;
                    case 2:
                        PHOTO_DETECTORS = PHOTO_DETECTORS_HIGH;
                        break;
                    default:
                        PHOTO_DETECTORS = Initiator0;
                        break;
                }
            }
            else
            {
                PHOTO_DETECTORS = Initiator0;
            }
            return PHOTO_DETECTORS;
        }
        public List<double> getValueMF_SENSOR_SIZE()
        {
            if (metroCheckBoxSensorSize.Checked)
            {
                switch (metroComboBoxSensorSize.SelectedIndex)
                {
                    case 0:
                        SENSOR_SIZE = SENSOR_SIZE_SMALL;
                        break;
                    case 1:
                        SENSOR_SIZE = SENSOR_SIZE_MEDIUM;
                        break;
                    case 2:
                        SENSOR_SIZE = SENSOR_SIZE_WIDE;
                        break;
                    default:
                        SENSOR_SIZE = Initiator0;
                        break;
                }
            }
            else
            {
                SENSOR_SIZE = Initiator0;
            }
            return SENSOR_SIZE;
        }

        public void BEGIN_FUZZY()
        {
            List<double> price = getValueMF_PRICE();
            List<double> release_date = getValueMF_DATE_RELEASE();
            List<double> dimension = getValueMF_DIMENSION();
            List<double> weight = getValueMF_WEIGHT();
            List<double> screen_dots = getValueMF_SCREEN_DOTS();
            List<double> max_resolution = getValueMF_MAX_RESOLUTION();
            List<double> effective_pixel = getValueMF_EFFECTIVE_PIXEL();
            List<double> photo_detectors = getValueMF_PHOTO_DETECTORS();
            List<double> sensor_size = getValueMF_SENSOR_SIZE();
            Fire_Strength.Clear();
            for (int i = 0; i < executeDB.MAINDATA_LENGTH(); i++)
            {
                double a = Math.Min(price[i],release_date[i]);
                double b = Math.Min(a, dimension[i]);
                double c = Math.Min(b, weight[i]);
                double d = Math.Min(c, screen_dots[i]);
                double e = Math.Min(d, max_resolution[i]);
                double f = Math.Min(e, effective_pixel[i]);
                double g = Math.Min(f, photo_detectors[i]);
                double h = Math.Min(g, sensor_size[i]);
                double k = h == 2.00 ? 0.00 : h * 100;
                Fire_Strength.Add(k);
                Console.Write("price       :" + "[" + i + "]" + string.Format("{0:0.00}", price[i]) + ", ");
                Console.Write("date_release:" + "[" + i + "]" + string.Format("{0:0.00}", release_date[i]) + ", ");
                Console.Write("dimension   :" + "[" + i + "]" + string.Format("{0:0.00}", dimension[i]) + ", ");
                Console.Write("weight      :" + "[" + i + "]" + string.Format("{0:0.00}", weight[i]) + ", ");
                Console.Write("screen_dots :" + "[" + i + "]" + string.Format("{0:0.00}", screen_dots[i]) + ", ");
                Console.Write("max_res     :" + "[" + i + "]" + string.Format("{0:0.00}", max_resolution[i]) + ", ");
                Console.Write("effective_p :" + "[" + i + "]" + string.Format("{0:0.00}", effective_pixel[i]) + ", ");
                Console.Write("photo_dtctr :" + "[" + i + "]" + string.Format("{0:0.00}", photo_detectors[i]) + ", ");
                Console.Write("sensor_size :" + "[" + i + "]" + string.Format("{0:0.00}", sensor_size[i]) + ", ");
                Console.Write("FIRE_STRENGTH:" + "[" + i + "]" + string.Format("{0:0.00}", Fire_Strength[i]));//(/*1-*/h)*100+" %"));
                Console.WriteLine();

            }
        }
        #endregion

        #region BASIC BEHAVIOUR
        private void Homepage_Resize(object sender, EventArgs e)
        {
            tableLayoutPanelHomepageHorizontal.Width = splitContainerHomepage.Width;
        }

        private void metroCheckBoxPrice_CheckedChanged(object sender, EventArgs e)
        {
            metroComboBoxPrice.Enabled = (metroCheckBoxPrice.CheckState==CheckState.Checked);
        }

        private void metroCheckBoxDateRelease_CheckedChanged(object sender, EventArgs e)
        {
            metroComboBoxDateRelease.Enabled = (metroCheckBoxDateRelease.CheckState == CheckState.Checked);
        }

        private void metroCheckBoxDimension_CheckedChanged(object sender, EventArgs e)
        {
            metroComboBoxDimension.Enabled = (metroCheckBoxDimension.CheckState == CheckState.Checked);
        }

        private void metroCheckBoxWeight_CheckedChanged(object sender, EventArgs e)
        {
            metroComboBoxWeight.Enabled = (metroCheckBoxWeight.CheckState == CheckState.Checked);
        }

        private void metroCheckBoxScreenDots_CheckedChanged(object sender, EventArgs e)
        {
            metroComboBoxScreenDots.Enabled = (metroCheckBoxScreenDots.CheckState == CheckState.Checked);
        }

        private void metroCheckBoxMaxRes_CheckedChanged(object sender, EventArgs e)
        {
            metroComboBoxMaxResolution.Enabled = (metroCheckBoxMaxRes.CheckState == CheckState.Checked);
        }

        private void metroCheckBoxEffectivePixel_CheckedChanged(object sender, EventArgs e)
        {
            metroComboBoxEffectivePixel.Enabled = (metroCheckBoxEffectivePixel.CheckState == CheckState.Checked);
        }

        private void metroCheckBoxPhotoDetectors_CheckedChanged(object sender, EventArgs e)
        {
            metroComboBoxPhotoDetectors.Enabled = (metroCheckBoxPhotoDetectors.CheckState == CheckState.Checked);
        }

        private void metroCheckBoxSensorSize_CheckedChanged(object sender, EventArgs e)
        {
            metroComboBoxSensorSize.Enabled = (metroCheckBoxSensorSize.CheckState == CheckState.Checked);
        }

        private void metroTextBoxSearch_TextChanged(object sender, EventArgs e)
        {
            if(metroTextBoxSearch.Focused)
            Search();
        }

        private void RemoveText(object sender, EventArgs e)
        {
            metroTextBoxSearch.Text = "";
        }

        private void AddText(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(metroTextBoxSearch.Text))
            { metroTextBoxSearch.Text = "Find"; }
            else { }
        }

        private void Search()
        {
            //string search = searchBox.Text;
            List<string>[] list;
            list = executeDB.ViewCameraCatalog();
            dataGridViewResult.Rows.Clear();
            for (int i = 0; i < list[0].Count; i++)
            {
                int number = dataGridViewResult.Rows.Add();
                //Fire_Strength.Add(0);
                dataGridViewResult.Rows[number].Cells[0].Value = /*string.Format("{0:0.00}",*/Math.Round(Fire_Strength[i],2);//)+" %";
                #region ROWS
                dataGridViewResult.Rows[number].Cells[1].Value = Convert.ToInt32(list[0][i].ToString()).ToString("000");
                dataGridViewResult.Rows[number].Cells[2].Value = list[1][i];
                dataGridViewResult.Rows[number].Cells[3].Value = Convert.ToInt32(list[2][i]).ToString("N0");
                dataGridViewResult.Rows[number].Cells[4].Value = list[3][i];
                dataGridViewResult.Rows[number].Cells[5].Value = list[4][i];
                dataGridViewResult.Rows[number].Cells[6].Value = list[5][i];
                dataGridViewResult.Rows[number].Cells[7].Value = Convert.ToDateTime(list[6][i].ToString()).ToString("dd/MM/yyyy");
                dataGridViewResult.Rows[number].Cells[8].Value = list[7][i];
                dataGridViewResult.Rows[number].Cells[9].Value = list[8][i];
                dataGridViewResult.Rows[number].Cells[10].Value = list[9][i];
                dataGridViewResult.Rows[number].Cells[11].Value = list[10][i];
                dataGridViewResult.Rows[number].Cells[12].Value = list[11][i];
                dataGridViewResult.Rows[number].Cells[13].Value = list[12][i];
                dataGridViewResult.Rows[number].Cells[14].Value = list[13][i];
                dataGridViewResult.Rows[number].Cells[15].Value = list[14][i];
                dataGridViewResult.Rows[number].Cells[16].Value = list[15][i];
                dataGridViewResult.Rows[number].Cells[17].Value = list[16][i];
                dataGridViewResult.Rows[number].Cells[18].Value = list[17][i];
                dataGridViewResult.Rows[number].Cells[19].Value = list[18][i];
                dataGridViewResult.Rows[number].Cells[20].Value = list[19][i];
                dataGridViewResult.Rows[number].Cells[21].Value = list[20][i];
                dataGridViewResult.Rows[number].Cells[22].Value = list[21][i];
                dataGridViewResult.Rows[number].Cells[23].Value = list[22][i];
                dataGridViewResult.Rows[number].Cells[24].Value = list[23][i];
                dataGridViewResult.Rows[number].Cells[25].Value = list[24][i];
                dataGridViewResult.Rows[number].Cells[26].Value = list[25][i];
                dataGridViewResult.Rows[number].Cells[27].Value = list[26][i];
                #endregion
            }
        }
        #endregion

        private void metroButtonFuzzyfy_Click(object sender, EventArgs e)
        {
            BEGIN_FUZZY();
            //dataGridViewResult.Rows.Clear();
            Search();
            dataGridViewResult.Sort(ColumnCF, ListSortDirection.Descending);
        }


    }
}
