using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_mobile_peristalsis.manager
{
    class Query
    {
        public string query = "";
        public Query select(string cols)
        {
            query += "SELECT " + cols + " ";
            return this;
        }
        public Query Select(string cols)
        {
            query += "SELECT " + cols + " ";
            return this;
        }
        public Query From(string table)
        {
            query += "FROM " + table + " ";
            return this;
        }

        public Query Where(string condition)
        {
            query += "WHERE " + condition + " ";
            return this;
        }

        public Query Insert(string ins_cols)
        {
            query += "INSERT INTO " + ins_cols + " "; //테이블명과 밸류값 입력
            return this;
        }
        public Query Update(string table)
        {
            query += "UPDATE " + table + " ";
            return this;
        }
        public Query Set(string values)
        {
            query += "SET " + values + " ";
            return this;
        }
        public Query Delete(string del_cols)
        {
            query += "DELETE FROM " + del_cols + " ";
            return this;
        }

        public Query Values(string val_cols)
        {
            query += "VALUES" + val_cols;
            return this;
        }

        public Query OrderBy(string order_cols)
        {
            query += " ORDER BY " + order_cols;
            return this;
        }
    }
}
