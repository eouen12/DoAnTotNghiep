using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;

namespace QuanLyCuaHangNoiThat
{
    public class KetNoiCSDL
    {
        private string chuoiKetNoi = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Data.mdb";
        private OleDbConnection ketNoi;

        public KetNoiCSDL()
        {
            KetNoi();
        }

        private void KetNoi()
        {
            if (ketNoi == null)
                ketNoi = new OleDbConnection(chuoiKetNoi);
            if (ketNoi.State == ConnectionState.Closed)
                ketNoi.Open();
        }

        public DataTable TruyVan(string query, object[] parameter = null)
        {
            DataTable table = new DataTable();
            OleDbCommand cmd = new OleDbCommand(query, ketNoi);
            OleDbDataAdapter adapter = new OleDbDataAdapter(cmd);
            adapter.Fill(table);
            return table;
        }

        public int ThemXoaSua(string query)
        {
            OleDbCommand cmd = new OleDbCommand(query, ketNoi);
            return cmd.ExecuteNonQuery();
        }
    }
}

