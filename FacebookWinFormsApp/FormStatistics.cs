using CefSharp.DevTools.IndexedDB;
using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace BasicFacebookFeatures
{
    public partial class FormStatistics : Form
    {
        internal FacebookWrapper.LoginResult m_LoggedInUser { get; set; }
        internal FormFeed m_Feed { get; set; }
        private const int k_FacebookLunchYear = 2004;
        private const int k_GraphInit = 1;
        private const int k_MonthNumber = 12;
        private const int k_Interval = 5;

        public FormStatistics()
        {
            InitializeComponent();
            chartPosts.Series.Clear();
            chartImages.Series.Clear();
            initializeComboBoxYear(comboBoxYearPosts);
            initializeComboBoxYear(comboBoxYearImages);
        }

        private void initializeComboBoxYear(ComboBox i_comboBoxYear)
        {
            for(int i = k_FacebookLunchYear; i <= DateTime.Now.Year; i++)
            {
                i_comboBoxYear.Items.Add(i.ToString());
            }
        }

        private void comboBoxYearPosts_SelectedIndexChanged(object sender, EventArgs e)
        {
            int v_ChosenYear = Int16.Parse(comboBoxYearPosts.SelectedItem.ToString());
            Dictionary<int, int> v_PostsMap = new Dictionary<int, int>();

            foreach(Post v_Post in m_LoggedInUser.LoggedInUser.Posts)
            {
                if(v_Post.CreatedTime.Value.Year == v_ChosenYear)
                {
                    if (v_PostsMap.ContainsKey(v_Post.CreatedTime.Value.Month))
                    {
                        v_PostsMap[v_Post.CreatedTime.Value.Month]++;
                    }
                    else
                    {
                        v_PostsMap.Add(v_Post.CreatedTime.Value.Month, k_GraphInit);
                    }
                }
            }

            initDiagram(chartPosts, v_PostsMap);
        }

        private void initDiagram(Chart i_Chart, Dictionary<int, int> i_Map)
        {
            i_Chart.Series.Clear();
            i_Chart.ChartAreas[0].AxisX.Interval = 1;
            i_Chart.ChartAreas[0].AxisY.Interval = calculateYInterval(i_Map);
            Series v_Series = i_Chart.Series.Add("MonthlyData");
            for (int v_Month = 1; v_Month <= k_MonthNumber; v_Month++)
            {
                if (i_Map.TryGetValue(v_Month, out int v_Count))
                {
                    v_Series.Points.AddXY(getMonthName(v_Month), v_Count);
                }
                else
                {
                    v_Series.Points.AddXY(getMonthName(v_Month), 0);
                }
            }

            i_Chart.ChartAreas[0].AxisY.Maximum = getMaximumValue(i_Map);
        }

        private int calculateYInterval(Dictionary<int, int> i_Map)
        {
            int v_MaxVal = getMaximumValue(i_Map);

            return (v_MaxVal / k_Interval) + 1;
        }

        private int getMaximumValue(Dictionary<int, int> i_Data)
        {
            int v_Max = 1;
            foreach (var v_Entry in i_Data)
            {
                if (v_Entry.Value > v_Max)
                {
                    v_Max = v_Entry.Value;
                }
            }

            return v_Max;
        }

        private string getMonthName(int month)
        {
            return System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(month);
        }

        private void comboBoxYearImages_SelectedIndexChanged(object sender, EventArgs e)
        {
            int v_ChosenYear = Int16.Parse(comboBoxYearImages.SelectedItem.ToString());
            Dictionary<int, int> v_ImagesMap = new Dictionary<int, int>();

            foreach (Album v_Album in m_LoggedInUser.LoggedInUser.Albums) 
            {
                foreach (Photo v_Photo in v_Album.Photos)
                {
                    if (v_Photo.CreatedTime.Value.Year == v_ChosenYear)
                    {
                        if (v_ImagesMap.ContainsKey(v_Photo.CreatedTime.Value.Month))
                        {
                            v_ImagesMap[v_Photo.CreatedTime.Value.Month]++;
                        }
                        else
                        {
                            v_ImagesMap.Add(v_Photo.CreatedTime.Value.Month, k_GraphInit);
                        }
                    }
                }
            }

            initDiagram(chartImages, v_ImagesMap);
        }

        private void buttonReturn_Click(object sender, EventArgs e)
        {
            if (m_Feed != null)
            {
                m_Feed.Visible = true;
            }

            this.Close();
        }
    }
}
