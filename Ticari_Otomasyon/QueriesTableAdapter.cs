namespace Ticari_Otomasyon.celalprojeDataSetTableAdapters
{
    /// <summary>
    ///Represents the connection and commands used to retrieve and save data.
    ///</summary>
    [System.ComponentModel.DesignerCategory("code")]
    [System.ComponentModel.ToolboxItem(true)]
    [System.ComponentModel.DataObject(true)]
    [System.ComponentModel.Designer("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner" +
        ", Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.Design.HelpKeyword("vs.data.TableAdapter")]
    public partial class QueriesTableAdapter : System.ComponentModel.Component
    {

        private System.Data.IDbCommand[] _commandCollection;

        [System.Diagnostics.DebuggerNonUserCode()]
        [System.CodeDom.Compiler.GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
        protected System.Data.IDbCommand[] CommandCollection
        {
            get
            {
                if (_commandCollection == null)
                {
                    InitCommandCollection();
                }
                return _commandCollection;
            }
        }

        [System.Diagnostics.DebuggerNonUserCode()]
        [System.CodeDom.Compiler.GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
        private void InitCommandCollection()
        {
            _commandCollection = new System.Data.IDbCommand[1];
            _commandCollection[0] = new System.Data.SqlClient.SqlCommand();
            ((System.Data.SqlClient.SqlCommand)_commandCollection[0]).Connection = new System.Data.SqlClient.SqlConnection(Properties.Settings.Default.celalprojeConnectionString);
            ((System.Data.SqlClient.SqlCommand)_commandCollection[0]).CommandText = "TBL_FIRMALAR";
            ((System.Data.SqlClient.SqlCommand)_commandCollection[0]).CommandType = System.Data.CommandType.Text;
        }

        [System.Diagnostics.DebuggerNonUserCode()]
        [System.CodeDom.Compiler.GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
        [System.ComponentModel.Design.HelpKeyword("vs.data.TableAdapter")]
        public virtual object ScalarQuery()
        {
            System.Data.SqlClient.SqlCommand command = (System.Data.SqlClient.SqlCommand)CommandCollection[0];
            System.Data.ConnectionState previousConnectionState = command.Connection.State;
            if ((command.Connection.State & System.Data.ConnectionState.Open)
                        != System.Data.ConnectionState.Open)
            {
                command.Connection.Open();
            }
            object returnValue;
            try
            {
                returnValue = command.ExecuteScalar();
            }
            finally
            {
                if (previousConnectionState == System.Data.ConnectionState.Closed)
                {
                    command.Connection.Close();
                }
            }
            if (returnValue == null
                        || returnValue.GetType() == typeof(System.DBNull))
            {
                return null;
            }
            else
            {
                return returnValue;
            }
        }
    }
}

#pragma warning restore 1591