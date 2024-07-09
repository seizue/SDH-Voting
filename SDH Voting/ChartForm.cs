using LiveCharts;
using LiveCharts.Defaults;
using LiveCharts.Wpf;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace SDH_Voting
{
    public partial class ChartForm : Form
    {
        public ChartForm()
        {
            InitializeComponent();
            LoadChartData();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoadChartData()
        {
            string folderPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "SDH Voting");
            string filePath = Path.Combine(folderPath, "SDHRep.json");

            try
            {
                if (File.Exists(filePath))
                {
                    var representatives = new List<Representative>();
                    var lines = File.ReadAllLines(filePath);

                    foreach (var line in lines)
                    {
                        if (!string.IsNullOrWhiteSpace(line))
                        {
                            var representative = JsonConvert.DeserializeObject<Representative>(line);
                            representatives.Add(representative);
                        }
                    }

                    if (representatives.Any())
                    {
                        var seriesCollection = new SeriesCollection();

                        foreach (var rep in representatives)
                        {
                            var values = new ChartValues<ObservablePoint>();
                            values.Add(new ObservablePoint(0, 0)); // Start from origin (0, 0)
                            values.Add(new ObservablePoint(values.Count, rep.Votes));

                            seriesCollection.Add(new LineSeries
                            {
                                Title = rep.Name,
                                Values = values,
                                LineSmoothness = 0 // Disable line smoothing to see zigzag effect
                            });
                        }

                        cartesianChart1.Series = seriesCollection;

                        cartesianChart1.AxisX.Add(new Axis
                        {
                            Title = "Representatives",
                            Labels = representatives.Select(r => r.Name).ToArray()
                        });

                        cartesianChart1.AxisY.Add(new Axis
                        {
                            Title = "Votes",
                            LabelFormatter = value => value.ToString("N")
                        });
                    }
                    else
                    {
                        MessageBox.Show("SDHRep.json file is empty.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("SDHRep.json file not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (JsonSerializationException ex)
            {
                MessageBox.Show($"Error deserializing JSON data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An unexpected error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        public class Representative
        {
            public string Name { get; set; }
            public long Votes { get; set; }
         
        }

       
    }
}
