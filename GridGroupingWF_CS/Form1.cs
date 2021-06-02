using Syncfusion.Windows.Forms.Grid;
using Syncfusion.Windows.Forms.Grid.Grouping;
using System;
using System.Data;
using System.Windows.Forms;


namespace DataGrid
{
    public partial class Form1 : Form
    {
        #region "Create DataTable"
        public Form1()
        {
            InitializeComponent();

            this.gridGroupingControl1.DataSource = CreateTable();
            GridSettings();
        }
        #endregion

        #region "GridSettings"
        void GridSettings()
        {
            //To set PushButton.
            this.gridGroupingControl1.TableDescriptor.Columns[2].Appearance.AddNewRecordFieldCell.CellType = GridCellTypeName.PushButton;
            this.gridGroupingControl1.TableDescriptor.Columns[2].Appearance.AddNewRecordFieldCell.Description = "PushButton";
            //Event subscription
            this.gridGroupingControl1.TableControlPushButtonClick += new GridTableControlCellPushButtonClickEventHandler(gridGroupingControl1_TableControlPushButtonClick);
        }
        #endregion

        #region "Event Hanlders"
        //Event Customization
        void gridGroupingControl1_TableControlPushButtonClick(object sender, GridTableControlCellPushButtonClickEventArgs e)
        {
            string s = string.Format("You clicked ({0},{1}).", e.Inner.RowIndex, e.Inner.ColIndex);
            MessageBox.Show(s);
        }
        #endregion

        #region "Create DataTable"
        string[] name1 = new string[] { "John", "Peter", "Smith", "Jay", "Krish", "Mike" };
        string[] country = new string[] { "UK", "USA", "Pune", "India", "China", "England" };
        string[] city = new string[] { "Graz", "Resende", "Bruxelles", "Aires", "Rio de janeiro", "Campinas" };
        string[] scountry = new string[] { "Brazil", "Belgium", "Austria", "Argentina", "France", "Beiging" };
        DataTable dt = new DataTable();
        DataRow dr;
        Random r = new Random();

        private DataTable CreateTable()
        {
            dt.Columns.Add("Name");
            dt.Columns.Add("Id");
            dt.Columns.Add("Date");
            dt.Columns.Add("Country");
            dt.Columns.Add("Ship City");
            dt.Columns.Add("Ship Country");
            dt.Columns.Add("Freight");
            dt.Columns.Add("Postal code");
            dt.Columns.Add("Password");

            for (int l = 0; l < 20; l++)
            {
                dr = dt.NewRow();
                dr[0] = name1[r.Next(0, 5)];
                dr[1] = "E" + r.Next(30);
                dr[2] = new DateTime(2012, 5, 23);
                dr[3] = country[r.Next(0, 5)];
                dr[4] = city[r.Next(0, 5)];
                dr[5] = scountry[r.Next(0, 5)];
                dr[6] = r.Next(1000, 2000);
                dr[7] = r.Next(10 + (r.Next(600000, 600100)));
                dr[8] = r.Next(14000, 20000);

                dt.Rows.Add(dr);
            }
            return dt;
        }
        #endregion
    }
}
