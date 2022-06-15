namespace Ticari_Otomasyon.celalprojeDataSetTableAdapters
{
    /// <summary>
    ///TableAdapterManager is used to coordinate TableAdapters in the dataset to enable Hierarchical Update scenarios
    ///</summary>
    [System.ComponentModel.DesignerCategory("code")]
    [System.ComponentModel.ToolboxItem(true)]
    [System.ComponentModel.Designer("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerDesigner, Microsoft.VSD" +
        "esigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.Design.HelpKeyword("vs.data.TableAdapterManager")]
    public partial class TableAdapterManager : System.ComponentModel.Component
    {

        private UpdateOrderOption _updateOrder;

        private TBL_FIRMALARTableAdapter _tBL_FIRMALARTableAdapter;

        private bool _backupDataSetBeforeUpdate;

        private System.Data.IDbConnection _connection;

        [System.Diagnostics.DebuggerNonUserCode()]
        [System.CodeDom.Compiler.GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
        public UpdateOrderOption UpdateOrder
        {
            get
            {
                return _updateOrder;
            }
            set
            {
                _updateOrder = value;
            }
        }

        [System.Diagnostics.DebuggerNonUserCode()]
        [System.CodeDom.Compiler.GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
        [System.ComponentModel.Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microso" +
            "ft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3" +
            "a", "System.Drawing.Design.UITypeEditor")]
        public TBL_FIRMALARTableAdapter TBL_FIRMALARTableAdapter
        {
            get
            {
                return _tBL_FIRMALARTableAdapter;
            }
            set
            {
                _tBL_FIRMALARTableAdapter = value;
            }
        }

        [System.Diagnostics.DebuggerNonUserCode()]
        [System.CodeDom.Compiler.GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
        public bool BackupDataSetBeforeUpdate
        {
            get
            {
                return _backupDataSetBeforeUpdate;
            }
            set
            {
                _backupDataSetBeforeUpdate = value;
            }
        }

        [System.Diagnostics.DebuggerNonUserCode()]
        [System.CodeDom.Compiler.GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
        [System.ComponentModel.Browsable(false)]
        public System.Data.IDbConnection Connection
        {
            get
            {
                if (_connection != null)
                {
                    return _connection;
                }
                if (_tBL_FIRMALARTableAdapter != null
                            && _tBL_FIRMALARTableAdapter.Connection != null)
                {
                    return _tBL_FIRMALARTableAdapter.Connection;
                }
                return null;
            }
            set
            {
                _connection = value;
            }
        }

        [System.Diagnostics.DebuggerNonUserCode()]
        [System.CodeDom.Compiler.GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
        [System.ComponentModel.Browsable(false)]
        public int TableAdapterInstanceCount
        {
            get
            {
                int count = 0;
                if (_tBL_FIRMALARTableAdapter != null)
                {
                    count = count + 1;
                }
                return count;
            }
        }

        /// <summary>
        ///Update rows in top-down order.
        ///</summary>
        [System.Diagnostics.DebuggerNonUserCode()]
        [System.CodeDom.Compiler.GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
        private int UpdateUpdatedRows(celalprojeDataSet dataSet, System.Collections.Generic.List<System.Data.DataRow> allChangedRows, System.Collections.Generic.List<System.Data.DataRow> allAddedRows)
        {
            int result = 0;
            if (_tBL_FIRMALARTableAdapter != null)
            {
                System.Data.DataRow[] updatedRows = dataSet.TBL_FIRMALAR.Select(null, null, System.Data.DataViewRowState.ModifiedCurrent);
                updatedRows = GetRealUpdatedRows(updatedRows, allAddedRows);
                if (updatedRows != null
                            && 0 < updatedRows.Length)
                {
                    result = result + _tBL_FIRMALARTableAdapter.Update(updatedRows);
                    allChangedRows.AddRange(updatedRows);
                }
            }
            return result;
        }

        /// <summary>
        ///Insert rows in top-down order.
        ///</summary>
        [System.Diagnostics.DebuggerNonUserCode()]
        [System.CodeDom.Compiler.GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
        private int UpdateInsertedRows(celalprojeDataSet dataSet, System.Collections.Generic.List<System.Data.DataRow> allAddedRows)
        {
            int result = 0;
            if (_tBL_FIRMALARTableAdapter != null)
            {
                System.Data.DataRow[] addedRows = dataSet.TBL_FIRMALAR.Select(null, null, System.Data.DataViewRowState.Added);
                if (addedRows != null
                            && 0 < addedRows.Length)
                {
                    result = result + _tBL_FIRMALARTableAdapter.Update(addedRows);
                    allAddedRows.AddRange(addedRows);
                }
            }
            return result;
        }

        /// <summary>
        ///Delete rows in bottom-up order.
        ///</summary>
        [System.Diagnostics.DebuggerNonUserCode()]
        [System.CodeDom.Compiler.GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
        private int UpdateDeletedRows(celalprojeDataSet dataSet, System.Collections.Generic.List<System.Data.DataRow> allChangedRows)
        {
            int result = 0;
            if (_tBL_FIRMALARTableAdapter != null)
            {
                System.Data.DataRow[] deletedRows = dataSet.TBL_FIRMALAR.Select(null, null, System.Data.DataViewRowState.Deleted);
                if (deletedRows != null
                            && 0 < deletedRows.Length)
                {
                    result = result + _tBL_FIRMALARTableAdapter.Update(deletedRows);
                    allChangedRows.AddRange(deletedRows);
                }
            }
            return result;
        }

        /// <summary>
        ///Remove inserted rows that become updated rows after calling TableAdapter.Update(inserted rows) first
        ///</summary>
        [System.Diagnostics.DebuggerNonUserCode()]
        [System.CodeDom.Compiler.GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
        private System.Data.DataRow[] GetRealUpdatedRows(System.Data.DataRow[] updatedRows, System.Collections.Generic.List<System.Data.DataRow> allAddedRows)
        {
            if (updatedRows == null
                        || updatedRows.Length < 1)
            {
                return updatedRows;
            }
            if (allAddedRows == null
                        || allAddedRows.Count < 1)
            {
                return updatedRows;
            }
            System.Collections.Generic.List<System.Data.DataRow> realUpdatedRows = new System.Collections.Generic.List<System.Data.DataRow>();
            for (int i = 0; i < updatedRows.Length; i = i + 1)
            {
                System.Data.DataRow row = updatedRows[i];
                if (allAddedRows.Contains(row) == false)
                {
                    realUpdatedRows.Add(row);
                }
            }
            return realUpdatedRows.ToArray();
        }

        /// <summary>
        ///Update all changes to the dataset.
        ///</summary>
        [System.Diagnostics.DebuggerNonUserCode()]
        [System.CodeDom.Compiler.GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
        public virtual int UpdateAll(celalprojeDataSet dataSet)
        {
            if (dataSet == null)
            {
                throw new System.ArgumentNullException("dataSet");
            }
            if (dataSet.HasChanges() == false)
            {
                return 0;
            }
            if (_tBL_FIRMALARTableAdapter != null
                        && MatchTableAdapterConnection(_tBL_FIRMALARTableAdapter.Connection) == false)
            {
                throw new System.ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection s" +
                        "tring.");
            }
            System.Data.IDbConnection workConnection = Connection;
            if (workConnection == null)
            {
                throw new System.ApplicationException("TableAdapterManager contains no connection information. Set each TableAdapterMana" +
                        "ger TableAdapter property to a valid TableAdapter instance.");
            }
            bool workConnOpened = false;
            if ((workConnection.State & System.Data.ConnectionState.Broken)
                        == System.Data.ConnectionState.Broken)
            {
                workConnection.Close();
            }
            if (workConnection.State == System.Data.ConnectionState.Closed)
            {
                workConnection.Open();
                workConnOpened = true;
            }
            System.Data.IDbTransaction workTransaction = workConnection.BeginTransaction();
            if (workTransaction == null)
            {
                throw new System.ApplicationException("The transaction cannot begin. The current data connection does not support transa" +
                        "ctions or the current state is not allowing the transaction to begin.");
            }
            System.Collections.Generic.List<System.Data.DataRow> allChangedRows = new System.Collections.Generic.List<System.Data.DataRow>();
            System.Collections.Generic.List<System.Data.DataRow> allAddedRows = new System.Collections.Generic.List<System.Data.DataRow>();
            System.Collections.Generic.List<System.Data.Common.DataAdapter> adaptersWithAcceptChangesDuringUpdate = new System.Collections.Generic.List<System.Data.Common.DataAdapter>();
            System.Collections.Generic.Dictionary<object, System.Data.IDbConnection> revertConnections = new System.Collections.Generic.Dictionary<object, System.Data.IDbConnection>();
            int result = 0;
            System.Data.DataSet backupDataSet = null;
            if (BackupDataSetBeforeUpdate)
            {
                backupDataSet = new System.Data.DataSet();
                backupDataSet.Merge(dataSet);
            }
            try
            {
                // ---- Prepare for update -----------
                //
                if (_tBL_FIRMALARTableAdapter != null)
                {
                    revertConnections.Add(_tBL_FIRMALARTableAdapter, _tBL_FIRMALARTableAdapter.Connection);
                    _tBL_FIRMALARTableAdapter.Connection = (System.Data.SqlClient.SqlConnection)workConnection;
                    _tBL_FIRMALARTableAdapter.Transaction = (System.Data.SqlClient.SqlTransaction)workTransaction;
                    if (_tBL_FIRMALARTableAdapter.Adapter.AcceptChangesDuringUpdate)
                    {
                        _tBL_FIRMALARTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
                        adaptersWithAcceptChangesDuringUpdate.Add(_tBL_FIRMALARTableAdapter.Adapter);
                    }
                }
                // 
                //---- Perform updates -----------
                //
                if (UpdateOrder == UpdateOrderOption.UpdateInsertDelete)
                {
                    result = result + UpdateUpdatedRows(dataSet, allChangedRows, allAddedRows);
                    result = result + UpdateInsertedRows(dataSet, allAddedRows);
                }
                else
                {
                    result = result + UpdateInsertedRows(dataSet, allAddedRows);
                    result = result + UpdateUpdatedRows(dataSet, allChangedRows, allAddedRows);
                }
                result = result + UpdateDeletedRows(dataSet, allChangedRows);
                // 
                //---- Commit updates -----------
                //
                workTransaction.Commit();
                if (0 < allAddedRows.Count)
                {
                    System.Data.DataRow[] rows = new System.Data.DataRow[allAddedRows.Count];
                    allAddedRows.CopyTo(rows);
                    for (int i = 0; i < rows.Length; i = i + 1)
                    {
                        System.Data.DataRow row = rows[i];
                        row.AcceptChanges();
                    }
                }
                if (0 < allChangedRows.Count)
                {
                    System.Data.DataRow[] rows = new System.Data.DataRow[allChangedRows.Count];
                    allChangedRows.CopyTo(rows);
                    for (int i = 0; i < rows.Length; i = i + 1)
                    {
                        System.Data.DataRow row = rows[i];
                        row.AcceptChanges();
                    }
                }
            }
            catch (System.Exception ex)
            {
                workTransaction.Rollback();
                // ---- Restore the dataset -----------
                if (BackupDataSetBeforeUpdate)
                {
                    System.Diagnostics.Debug.Assert(backupDataSet != null);
                    dataSet.Clear();
                    dataSet.Merge(backupDataSet);
                }
                else
                {
                    if (0 < allAddedRows.Count)
                    {
                        System.Data.DataRow[] rows = new System.Data.DataRow[allAddedRows.Count];
                        allAddedRows.CopyTo(rows);
                        for (int i = 0; i < rows.Length; i = i + 1)
                        {
                            System.Data.DataRow row = rows[i];
                            row.AcceptChanges();
                            row.SetAdded();
                        }
                    }
                }
                throw ex;
            }
            finally
            {
                if (workConnOpened)
                {
                    workConnection.Close();
                }
                if (_tBL_FIRMALARTableAdapter != null)
                {
                    _tBL_FIRMALARTableAdapter.Connection = (System.Data.SqlClient.SqlConnection)revertConnections[_tBL_FIRMALARTableAdapter];
                    _tBL_FIRMALARTableAdapter.Transaction = null;
                }
                if (0 < adaptersWithAcceptChangesDuringUpdate.Count)
                {
                    System.Data.Common.DataAdapter[] adapters = new System.Data.Common.DataAdapter[adaptersWithAcceptChangesDuringUpdate.Count];
                    adaptersWithAcceptChangesDuringUpdate.CopyTo(adapters);
                    for (int i = 0; i < adapters.Length; i = i + 1)
                    {
                        System.Data.Common.DataAdapter adapter = adapters[i];
                        adapter.AcceptChangesDuringUpdate = true;
                    }
                }
            }
            return result;
        }

        [System.Diagnostics.DebuggerNonUserCode()]
        [System.CodeDom.Compiler.GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
        protected virtual void SortSelfReferenceRows(System.Data.DataRow[] rows, System.Data.DataRelation relation, bool childFirst)
        {
            System.Array.Sort(rows, new SelfReferenceComparer(relation, childFirst));
        }

        [System.Diagnostics.DebuggerNonUserCode()]
        [System.CodeDom.Compiler.GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
        protected virtual bool MatchTableAdapterConnection(System.Data.IDbConnection inputConnection)
        {
            if (_connection != null)
            {
                return true;
            }
            if (Connection == null
                        || inputConnection == null)
            {
                return true;
            }
            if (string.Equals(Connection.ConnectionString, inputConnection.ConnectionString, System.StringComparison.Ordinal))
            {
                return true;
            }
            return false;
        }

        /// <summary>
        ///Update Order Option
        ///</summary>
        [System.CodeDom.Compiler.GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
        public enum UpdateOrderOption
        {

            InsertUpdateDelete = 0,

            UpdateInsertDelete = 1,
        }

        /// <summary>
        ///Used to sort self-referenced table's rows
        ///</summary>
        [System.CodeDom.Compiler.GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
        private class SelfReferenceComparer : object, System.Collections.Generic.IComparer<System.Data.DataRow>
        {

            private System.Data.DataRelation _relation;

            private int _childFirst;

            [System.Diagnostics.DebuggerNonUserCode()]
            [System.CodeDom.Compiler.GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            internal SelfReferenceComparer(System.Data.DataRelation relation, bool childFirst)
            {
                _relation = relation;
                if (childFirst)
                {
                    _childFirst = -1;
                }
                else
                {
                    _childFirst = 1;
                }
            }

            [System.Diagnostics.DebuggerNonUserCode()]
            [System.CodeDom.Compiler.GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            private System.Data.DataRow GetRoot(System.Data.DataRow row, out int distance)
            {
                System.Diagnostics.Debug.Assert(row != null);
                System.Data.DataRow root = row;
                distance = 0;

                System.Collections.Generic.IDictionary<System.Data.DataRow, System.Data.DataRow> traversedRows = new System.Collections.Generic.Dictionary<System.Data.DataRow, System.Data.DataRow>();
                traversedRows[row] = row;

                System.Data.DataRow parent = row.GetParentRow(_relation, System.Data.DataRowVersion.Default);
                for (
                ; parent != null
                            && traversedRows.ContainsKey(parent) == false;
                )
                {
                    distance = distance + 1;
                    root = parent;
                    traversedRows[parent] = parent;
                    parent = parent.GetParentRow(_relation, System.Data.DataRowVersion.Default);
                }

                if (distance == 0)
                {
                    traversedRows.Clear();
                    traversedRows[row] = row;
                    parent = row.GetParentRow(_relation, System.Data.DataRowVersion.Original);
                    for (
                    ; parent != null
                                && traversedRows.ContainsKey(parent) == false;
                    )
                    {
                        distance = distance + 1;
                        root = parent;
                        traversedRows[parent] = parent;
                        parent = parent.GetParentRow(_relation, System.Data.DataRowVersion.Original);
                    }
                }

                return root;
            }

            [System.Diagnostics.DebuggerNonUserCode()]
            [System.CodeDom.Compiler.GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            public int Compare(System.Data.DataRow row1, System.Data.DataRow row2)
            {
                if (ReferenceEquals(row1, row2))
                {
                    return 0;
                }
                if (row1 == null)
                {
                    return -1;
                }
                if (row2 == null)
                {
                    return 1;
                }

                int distance1 = 0;
                System.Data.DataRow root1 = GetRoot(row1, out distance1);

                int distance2 = 0;
                System.Data.DataRow root2 = GetRoot(row2, out distance2);

                if (ReferenceEquals(root1, root2))
                {
                    return _childFirst * distance1.CompareTo(distance2);
                }
                else
                {
                    System.Diagnostics.Debug.Assert(root1.Table != null
                                    && root2.Table != null);
                    if (root1.Table.Rows.IndexOf(root1) < root2.Table.Rows.IndexOf(root2))
                    {
                        return -1;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}

#pragma warning restore 1591