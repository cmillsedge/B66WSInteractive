using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IO.Swagger.Api;
using IO.Swagger.Model;



namespace BR6WSInteractive
{
    public partial class frmQueries : Form
    {
        Session _session;
        string _url;
        public frmQueries(Session wsSession, string url)
        {

            InitializeComponent();
            _session = wsSession;
            _url = url;
            //GetTaskColumns();

        }

        private void btnGetQueries_Click(object sender, EventArgs e)
        {
            BRQueryWrapper queryOps = new BRQueryWrapper(_session, _url);
            string filterstring = txtFilter.Text;
            NamedArray queries = queryOps.GetQueriesByFilter(filterstring);
            foreach (Named query in queries)
            {
                //cmbQueries.Items.Add(query.Name + "-" + query.Id );
                cmbQueries.Items.Add(query);
            }
            cmbQueries.DisplayMember = "Name";
            cmbQueries.ValueMember = "Id";
            cmbQueries.SelectedIndex = 0;

        }

        private void btnRunQuery_Click(object sender, EventArgs e)
        {
            BRQueryWrapper queryOps = new BRQueryWrapper(_session, _url);
            Named query = (Named)cmbQueries.SelectedItem;
            int maxrows = Int32.Parse(cmbPage.Text.ToString());
            int offset = (Int32.Parse(lblPageNumVal.Text) - 1) * maxrows;
            QueryColumnArray columns = queryOps.GetQueryColumns(query.Id);
            SetQueryColumns(columns);
            QueryResults results = queryOps.GetQueryResults(query.Id,maxrows,offset);
            DataTable dt = DataTableConverter.ResultsToDataTable(results, columns);
            dgvResults.DataSource = dt;
        }

        private void SetQueryColumns(QueryColumnArray columns)
        {
            for (int i = 0; i < columns.Count; i++)
            {
                cmbCols1.Items.Add(columns[i].Name);
                cmbCols2.Items.Add(columns[i].Name);
            }
        }

        private void btnNextPage_Click(object sender, EventArgs e)
        {
            BRQueryWrapper queryOps = new BRQueryWrapper(_session, _url);
            Named query = (Named)cmbQueries.SelectedItem;
            int maxrows = Int32.Parse(cmbPage.Text.ToString());
            int offsetlabel = Int32.Parse(lblPageNumVal.Text);
            offsetlabel += 1;
            lblPageNumVal.Text = offsetlabel.ToString();
            int offset = (offsetlabel - 1) * maxrows;
            QueryColumnArray columns = queryOps.GetQueryColumns(query.Id);
            QueryResults results = queryOps.GetQueryResults(query.Id, maxrows, offset);
            DataTable dt = DataTableConverter.ResultsToDataTable(results, columns);
            dgvResults.DataSource = dt;
        }

        private void btnPrevPage_Click(object sender, EventArgs e)
        {
            BRQueryWrapper queryOps = new BRQueryWrapper(_session, _url);
            Named query = (Named)cmbQueries.SelectedItem;
            int maxrows = Int32.Parse(cmbPage.Text.ToString());
            int offsetlabel = Int32.Parse(lblPageNumVal.Text);
            if (offsetlabel >= 1)
            {
                offsetlabel -= 1;
                lblPageNumVal.Text = offsetlabel.ToString();
                int offset = (offsetlabel - 1) * maxrows;
                QueryColumnArray columns = queryOps.GetQueryColumns(query.Id);
                QueryResults results = queryOps.GetQueryResults(query.Id, maxrows, offset);
                DataTable dt = DataTableConverter.ResultsToDataTable(results, columns);
                dgvResults.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Cannot go back from page 1");
            }
            
        }

        private void btnFilterQuery_Click(object sender, EventArgs e)
        {

            FilterArray filters = GetFilterArray();
            BRQueryWrapper queryOps = new BRQueryWrapper(_session, _url);
            Named query = (Named)cmbQueries.SelectedItem;
            int maxrows = Int32.Parse(cmbPage.Text.ToString());
            int offset = (Int32.Parse(lblPageNumVal.Text) - 1) * maxrows;
            QueryColumnArray columns = queryOps.GetQueryColumns(query.Id);
            QueryResults results = queryOps.GetQueryResults(query.Id, maxrows, offset, filters);
            DataTable dt = DataTableConverter.ResultsToDataTable(results, columns);
            dgvResults.DataSource = dt;
        }

        private FilterArray GetFilterArray()
        {
            FilterArray filters = new FilterArray();
            //USE WITH > OPERATOR
            if(cmbCols1.Text != "")
            {
                Filter filter1 = new Filter(cmbCols1.Text, cmbOps1.Text.ToLower(), new List<string>() { rtbVals1.Text });
                filters.Add(filter1);
            }
            //USE WITH IN OPERATOR
            if (cmbCols2.Text != "")
            {
                List<string> vals = new List<string>();
                foreach(string s in rtbVals2.Lines)
                {
                    vals.Add(s);
                }
                Filter filter2 = new Filter(cmbCols2.Text, cmbOps2.Text.ToLower(),vals);
                filters.Add(filter2);
            }
            return filters;
        }
    }
}
